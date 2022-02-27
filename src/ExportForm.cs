using System;
using System.IO;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;

namespace devtime
{
    public partial class ExportForm : Form
    {
        private string outputFile;
        private string context;
        private string from;
        private string to;
        private Exporter.ExportFormat exportFormat;
        private bool exportDate;
        private bool exportTime;
        private bool exportLog;
        private Exporter.TimeFormat timeFormat;
        private Exporter.TimeApproximation timeApproximation;

        private Thread exporterThread;
        private bool exporterShouldRun;

        public ExportForm(string outputFile, string context, string from, string to, Exporter.ExportFormat exportFormat, bool exportDate, bool exportTime, bool exportLog, Exporter.TimeFormat timeFormat, Exporter.TimeApproximation timeApproximation)
        {
            InitializeComponent();

            this.outputFile = outputFile;
            this.context = context;
            this.from = from;
            this.to = to;
            this.exportFormat = exportFormat;
            this.exportDate = exportDate;
            this.exportTime = exportTime;
            this.exportLog = exportLog;
            this.timeFormat = timeFormat;
            this.timeApproximation = timeApproximation;

            exporterShouldRun = true;

            DialogResult = DialogResult.Cancel;
        }

        private void ExportForm_Shown(object sender, EventArgs e)
        {
            exporterThread = new Thread(Export);
            exporterThread.Start();
        }

        private void Export()
        {
            try
            {
                using(StreamWriter output = new StreamWriter(outputFile))
                {
                    Exporter exporter = null;

                    switch(exportFormat)
                    {
                        case Exporter.ExportFormat.CSV:
                            exporter = new CsvExporter(output, exportDate, exportTime, exportLog, timeFormat, timeApproximation);
                            break;
                        case Exporter.ExportFormat.JSON:
                            exporter = new JsonExporter(output, exportDate, exportTime, exportLog, timeFormat, timeApproximation);
                            break;
                    }

                    long totalEntries = DB.SelectTotalEntryCount(context, from, to);
                    long iterations = totalEntries / Config.databaseExportBufferSize + (totalEntries % Config.databaseExportBufferSize > 0 ? 1 : 0);

                    Invoke(new Action(() =>
                    {
                        Progress.Maximum = (int) iterations;
                    }));

                    exporter.ExportStart();

                    for(long i = 0; i < iterations && exporterShouldRun; ++i)
                    {
                        if(i > 0)
                        {
                            exporter.ExportMid();
                        }

                        SQLite.Column[] columns = DB.SelectEntries(context, from, to, i * Config.databaseExportBufferSize, Config.databaseExportBufferSize);

                        for(int j = 0; j < columns[0].values.Count && exporterShouldRun; ++j)
                        {
                            if (j > 0)
                            {
                                exporter.ExportMid();
                            }

                            string log = columns[2].values.Count == 0 || (string)columns[2].values[j] == null ? "" : (string)columns[2].values[j];

                            exporter.ExportEntry((string)columns[0].values[j], (long)columns[1].values[j], log);
                        }

                        Invoke(new Action(() =>
                        {
                            Progress.Value = (int)i + 1;
                            Progress.Refresh();
                        }));
                    }

                    exporter.ExportEnd();

                    if (exporterShouldRun)
                    {
                        if (totalEntries > 0)
                        {
                            Invoke(new Action(() =>
                            {
                                DialogResult = DialogResult.OK;
                            }));
                        }
                        else
                        {
                            Invoke(new Action(() =>
                            {
                                DialogResult = DialogResult.Retry;
                            }));
                        }
                    }
                }
            }
            catch(SQLite.StatementException ex)
            {
                Invoke(new Action(() =>
                {
                    Error(string.Format("Failed to export data (database statement error; maybe the database can't be read).\n\n{0}", ex.ToString()));
                }));
            }
            catch (SQLite.QueryException ex)
            {
                Invoke(new Action(() =>
                {
                    Error(string.Format("Failed to export data (database query error; maybe the database can't be read).\n\n{0}", ex.ToString()));
                }));
            }
            catch (SQLite.DBException ex)
            {
                Invoke(new Action(() =>
                {
                    Error(string.Format("Failed to export data (database error; maybe the database can't be read).\n\n{0}", ex.ToString()));
                }));
            }
            catch (Exception ex)
            {
                Invoke(new Action(() =>
                {
                    Error(string.Format("Failed to export data.\n\n{0}", ex.Message));
                }));
            }

            BeginInvoke(new Action(() =>
            {
                Close();
            }));
        }

        private void Error(string msg)
        {
            MessageBox.Show(msg, "devtime error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ExportForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (exporterThread.IsAlive)
            {
                exporterShouldRun = false;

                while (exporterThread.IsAlive)
                {
                    Thread.Sleep(1);
                }
            }
        }
    }
}
