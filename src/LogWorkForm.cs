using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows.Forms;

namespace devtime
{
    public partial class LogWorkForm : Form
    {
        public string log;

        public LogWorkForm(string initialLog, string when)
        {
            InitializeComponent();
            LogTextBox.Text = initialLog;

            DateTime date = DateTime.ParseExact(when, "yyyy-MM-dd", CultureInfo.InvariantCulture);

            string suffix;

            if(date == DateTime.Now.Date)
            {
                suffix = "today";
            }
            else if (date.Date == DateTime.Now.AddDays(-1).Date)
            {
                suffix = "yesterday";
            }
            else if (date.Date == DateTime.Now.AddDays(1).Date)
            {
                suffix = "tomorrow";
            }
            else
            {
                suffix = "on " + when;
            }

            LogGroup.Text = string.Format("What did you do {0}?", suffix);
        }

        private void OkDialogButton_Click(object sender, EventArgs e)
        {
            log = LogTextBox.Text;

            if (string.IsNullOrWhiteSpace(log))
            {
                log = "";
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void CancelDialogButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
