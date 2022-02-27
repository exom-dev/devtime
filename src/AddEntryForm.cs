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
    public partial class AddEntryForm : Form
    {
        public DateTime date;
        public int loggedTime;

        string context;

        public AddEntryForm(string context)
        {
            InitializeComponent();
            this.context = context;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if(TimeHour.Value == 24 && (TimeMinute.Value > 0 || TimeSecond.Value > 0 || TimeMillisecond.Value > 0))
            {
                Error("Logged time is invalid (24 hours are logged; all other inputs must be 0).");
                return;
            }

            date = Day.Value;
            string dateStr = date.ToString("yyyy-MM-dd");

            if (DB.DateExists(context, dateStr))
            {
                Error("An entry for this day already exists.");
                return;
            }

            // Devtime now supports working with dates from the future :)
            //if(0 > DateTime.Now.ToString("yyy-MM-dd", CultureInfo.InvariantCulture).CompareTo(dateStr))
            //{
            //    Error("Cannot add a day from the future. Devtime does not (and shouldn't) support working with dates from the future.\n\nEven if you forcefully add the date from the terminal, stuff WILL break!");
            //    return;
            //}

            loggedTime = ((int) TimeMillisecond.Value) + ((int) TimeSecond.Value * 1000) + ((int) TimeMinute.Value * 60000) + ((int) TimeHour.Value * 3600000);

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
