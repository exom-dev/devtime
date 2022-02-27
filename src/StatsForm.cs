using System;
using System.Globalization;
using System.Windows.Forms;

namespace devtime
{
    public partial class StatsForm : Form
    {
        private string context;

        public StatsForm(string context)
        {
            InitializeComponent();

            this.context = context;

            ExportFormat.DataSource = Enum.GetValues(typeof(Exporter.ExportFormat));
            LoggedTimeFormat.DataSource = Enum.GetValues(typeof(Exporter.TimeFormat));
            LoggedTimeApproximation.DataSource = Enum.GetValues(typeof(Exporter.TimeApproximation));

            string oldest = DB.SelectOldestDate(context);
            string newest = DB.SelectNewestDate(context);

            if(oldest == null || newest == null)
            {
                oldest = DateTime.Now.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
                newest = oldest;
            }

            From.Value = DateTime.ParseExact(oldest, "yyyy-MM-dd", CultureInfo.InvariantCulture);
            To.Value = DateTime.ParseExact(newest, "yyyy-MM-dd", CultureInfo.InvariantCulture);

            OnRangeChanged();
            OnFormatChanged();
        }

        private void Export_Click(object sender, EventArgs e)
        {
            if(!ExportDate.Checked && !ExportLoggedTime.Checked && !ExportLog.Checked)
            {
                MessageBox.Show("At least one field needs to be exported (date, logged time, log).", "devtime error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(ExportFileDialog.ShowDialog() == DialogResult.OK)
            {
                ExportForm form = new ExportForm(
                    ExportFileDialog.FileName,
                    context,
                    From.Value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture),
                    To.Value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture),
                    (Exporter.ExportFormat)ExportFormat.SelectedItem,
                    ExportDate.Checked,
                    ExportLoggedTime.Checked,
                    ExportLog.Checked,
                    (Exporter.TimeFormat)LoggedTimeFormat.SelectedItem,
                    (Exporter.TimeApproximation)LoggedTimeApproximation.SelectedItem);

                form.StartPosition = FormStartPosition.Manual;
                form.Left = Location.X + Size.Width / 2 - form.Size.Width / 2;
                form.Top = Location.Y + Size.Height / 2 - form.Size.Height / 2;

                DialogResult result = form.ShowDialog();

                switch(result)
                {
                    case DialogResult.OK:
                        MessageBox.Show("Export completed successfully.", "devtime", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case DialogResult.Retry: // No data found in the specified range
                        MessageBox.Show("Export completed successfully.\nHowever, there are no entries in the specified time range. Therefore, the exported file is empty.", "devtime", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                }
            }

            ExportFileDialog.FileName = "devtime_export";
        }

        private void OnRangeChanged()
        {
            long time = 0;

            try
            {
                time = DB.SelectTotalLoggedTime(context, From.Value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture), To.Value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture));
            }
            catch(Exception) { }


            long value = time / 3600000;
            Hours.Text = string.Format("{0} hour{1}", value, value != 1 ? "s" : "");
            Hours.Refresh();
            time %= 3600000;

            value = time / 60000;
            Minutes.Text = string.Format("{0} minute{1}", value, value != 1 ? "s" : "");
            Minutes.Refresh();
            time %= 60000;

            value = time / 1000;
            Seconds.Text = string.Format("{0} second{1}", value, value != 1 ? "s" : "");
            Seconds.Refresh();
            time %= 1000;

            value = time;
            Milliseconds.Text = string.Format("{0} millisecond{1}", value, value != 1 ? "s" : "");
            Milliseconds.Refresh();
        }

        private void OnFormatChanged()
        {
            switch ((Exporter.ExportFormat) ExportFormat.SelectedItem)
            {
                case Exporter.ExportFormat.CSV:
                    ExportFileDialog.DefaultExt = "csv";
                    ExportFileDialog.Filter = "CSV Files | *.csv";
                    break;
                case Exporter.ExportFormat.JSON:
                    ExportFileDialog.DefaultExt = "json";
                    ExportFileDialog.Filter = "JSON Files | *.json";
                    break;
            }
        }

        private void From_ValueChanged(object sender, EventArgs e)
        {
            OnRangeChanged();
        }

        private void To_ValueChanged(object sender, EventArgs e)
        {
            OnRangeChanged();
        }

        private void ExportFormat_SelectedIndexChanged(object sender, EventArgs e)
        {
            OnFormatChanged();
        }

        private void ExportLoggedTime_CheckedChanged(object sender, EventArgs e)
        {
            LoggedTimeFormat.Enabled = ExportLoggedTime.Checked;
            LoggedTimeApproximation.Enabled = ExportLoggedTime.Checked;

            LoggedTimeFormat.Refresh();
            LoggedTimeApproximation.Refresh();
        }
    }
}
