using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace devtime
{
    public partial class AddContextForm : Form
    {
        public string contextName;

        public AddContextForm()
        {
            InitializeComponent();
            contextName = null;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            string text = ContextTextBox.Text.Trim();

            if(string.IsNullOrWhiteSpace(text))
            {
                Error("The project name cannot be empty.");
                return;
            }

            if (!IsAlphascore(text))
            {
                Error("Invalid project name (must only contain a-z, A-Z, 0-9 and underscores, with the first character not being a digit, and max 255 characters).\nPlease try another name.");
                return;
            }

            List<string> contexts = DB.GetTables();

            if(contexts.IndexOf(text) != -1)
            {
                Error(string.Format("A project named '{0}' already exists.\nPlease try another name.", text));
                return;
            }

            contextName = text;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        bool IsAlphascore(string str)
        {
            for(int i = 0; i < str.Length; ++i)
            {
                // a-zA-Z0-9_ and first character not a digit
                if ((str[i] < 'a' || str[i] > 'z') && (str[i] < 'A' || str[i] > 'Z') && (str[i] < '0' || str[i] > '9' || i == 0) && (str[i] != '_'))
                {
                    return false;
                }
            }

            return true;
        }

        void Error(string msg)
        {
            MessageBox.Show(msg, "devtime error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
