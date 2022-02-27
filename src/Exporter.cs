using System;
using System.IO;
using System.Text;

namespace devtime
{
    public abstract class Exporter
    {
        public enum ExportFormat
        {
            CSV,
            JSON
        }

        public enum TimeFormat
        {
            Milliseconds,
            Seconds,
            Minutes,
            Hours
        }

        public enum TimeApproximation
        {
            None,
            Round,
            Ceiling
        }

        protected bool exportDate;
        protected bool exportTime;
        protected bool exportLog;

        protected TimeFormat timeFormat;
        protected TimeApproximation timeApproximation;

        protected StreamWriter output;

        public Exporter(StreamWriter output, bool exportDate, bool exportTime, bool exportLog, TimeFormat timeFormat, TimeApproximation timeApproximation)
        {
            this.output = output;
            this.exportDate = exportDate;
            this.exportTime = exportTime;
            this.exportLog = exportLog;
            this.timeFormat = timeFormat;
            this.timeApproximation = timeApproximation;
        }

        public abstract void ExportStart(); // At the start of the file
        public abstract void ExportMid(); // Between entries
        public abstract void ExportEnd(); // At the end of the file
        public abstract void ExportEntry(string date, long time, string log);

        public static double FormatTime(long time, TimeFormat format, TimeApproximation approximation)
        {
            double loggedTime = time;

            switch (format)
            {
                case TimeFormat.Hours:
                    loggedTime /= 3600000.0;
                    break;
                case TimeFormat.Minutes:
                    loggedTime /= 60000.0;
                    break;
                case TimeFormat.Seconds:
                    loggedTime /= 1000.0;
                    break;
                case TimeFormat.Milliseconds:
                    break;
            }

            switch (approximation)
            {
                case TimeApproximation.Round:
                    loggedTime = Math.Round(loggedTime);
                    break;
                case TimeApproximation.Ceiling:
                    loggedTime = Math.Ceiling(loggedTime);
                    break;
                case TimeApproximation.None:
                    break;

            }

            return loggedTime;
        }
    }

    public class JsonExporter : Exporter
    {
        public JsonExporter(StreamWriter output, bool exportDate, bool exportTime, bool exportLog, TimeFormat timeFormat, TimeApproximation timeApproximation)
            : base(output, exportDate, exportTime, exportLog, timeFormat, timeApproximation) { }

        public override void ExportStart()
        {
            output.Write("[");
        }

        public override void ExportMid()
        {
            output.Write(",");
        }

        public override void ExportEnd()
        {
            output.Write("]");
        }

        public override void ExportEntry(string date, long time, string log)
        {
            StringBuilder sb = new StringBuilder("{");

            if(exportDate)
            {
                sb.AppendFormat("\"date\": \"{0}\"", date);
            }

            if (exportTime)
            {
                if(exportDate)
                {
                    sb.Append(",");
                }

                double loggedTime = FormatTime(time, timeFormat, timeApproximation);

                sb.AppendFormat("\"logged_time\": \"{0}\"", loggedTime);
            }

            if(exportLog)
            {
                if(exportDate || exportTime)
                {
                    sb.Append(",");
                }

                log = log
                    .Replace("\"", "\\\"")
                    .Replace("\n", "\\n")
                    .Replace("\r", "\\r")
                    .Replace("\t", "\\t")
                    .Replace("\b", "\\b")
                    .Replace("\f", "\\f");

                sb.AppendFormat("\"log\": \"{0}\"", log);
            }

            sb.Append("}");

            output.Write(sb.ToString());
        }
    }

    public class CsvExporter : Exporter
    {
        public CsvExporter(StreamWriter output, bool exportDate, bool exportTime, bool exportLog, TimeFormat timeFormat, TimeApproximation timeApproximation)
            : base(output, exportDate, exportTime, exportLog, timeFormat, timeApproximation) { }

        public override void ExportStart()
        {
            StringBuilder sb = new StringBuilder();
            
            if(exportDate)
            {
                sb.Append("date");
            }

            if(exportTime)
            {
                if(exportDate)
                {
                    sb.Append(",");
                }

                sb.Append("logged_time");
            }

            if(exportLog)
            {
                if (exportDate || exportTime)
                {
                    sb.Append(",");
                }

                sb.Append("log");
            }

            output.WriteLine(sb.ToString());
        }

        public override void ExportMid()
        {
            // Nothing
        }

        public override void ExportEnd()
        {
            // Nothing
        }

        public override void ExportEntry(string date, long time, string log)
        {
            StringBuilder sb = new StringBuilder();

            if (exportDate)
            {
                sb.AppendFormat("\"{0}\"", date);
            }

            if (exportTime)
            {
                if (exportDate)
                {
                    sb.Append(",");
                }

                double loggedTime = FormatTime(time, timeFormat, timeApproximation);

                sb.AppendFormat("{0}", loggedTime);
            }

            if (exportLog)
            {
                if (exportDate || exportTime)
                {
                    sb.Append(",");
                }

                log = log.Replace("\"", "\"\"");

                sb.AppendFormat("\"{0}\"", log);
            }

            output.WriteLine(sb.ToString());
        }
    }
}
