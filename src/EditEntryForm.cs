using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace devtime
{
    public partial class EditEntryForm : Form
    {
        public int loggedTime;

        public EditEntryForm(int currentLoggedTime)
        {
            InitializeComponent();

            TimeHour.Value = currentLoggedTime / 3600000;
            currentLoggedTime %= 3600000;

            TimeMinute.Value = currentLoggedTime / 60000;
            currentLoggedTime %= 60000;

            TimeSecond.Value = currentLoggedTime / 1000;
            currentLoggedTime %= 1000;

            TimeMillisecond.Value = currentLoggedTime;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (TimeHour.Value == 24 && (TimeMinute.Value > 0 || TimeSecond.Value > 0 || TimeMillisecond.Value > 0))
            {
                Error("Logged time is invalid (24 hours are logged; all other inputs must be 0).");
                return;
            }

            loggedTime = ((int)TimeMillisecond.Value) + ((int)TimeSecond.Value * 1000) + ((int)TimeMinute.Value * 60000) + ((int)TimeHour.Value * 3600000);

            DialogResult = DialogResult.OK;
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }


        void Error(string msg)
        {
            MessageBox.Show(msg, "devtime error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
