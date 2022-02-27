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
    public partial class ConsoleForm : Form
    {
        public ConsoleForm()
        {
            InitializeComponent();

            CommandInput.Font = new Font(FontFamily.GenericMonospace, CommandInput.Font.Size);
            CommandOutput.Font = new Font(FontFamily.GenericMonospace, CommandOutput.Font.Size);
        }

        private void Execute()
        {
            string input = CommandInput.Text.Trim();

            if(input.Length == 0)
            {
                return;
            }

            CommandInput.Text = "";
            CommandInput.ReadOnly = true;
            CommandInput.Refresh();

            InputButton.Enabled = false;
            InputButton.Refresh();

            WriteLine2("> " + input);

            CommandOutput.Refresh();

            HandleQuery(input);

            CommandOutput.Refresh();

            CommandInput.ReadOnly = false;
            CommandInput.Refresh();

            InputButton.Enabled = true;
            InputButton.Refresh();
        }

        private void WriteLine(string text = "")
        {
            CommandOutput.AppendText(text + Environment.NewLine);
        }

        private void WriteLine2(string text = "")
        {
            CommandOutput.AppendText(string.Format("{0}{1}{1}", text, Environment.NewLine));
        }

        private void Write(string text)
        {
            CommandOutput.AppendText(text);
        }

        private void HandleQuery(string query)
        {
            string cmd = query.ToLowerInvariant();

            if (cmd.Equals("tables"))
            {
                List<string> tables = DB.GetTables();

                if(tables == null || tables.Count == 0)
                {
                    WriteLine2("No tables found");
                    return;
                }

                for(int i = 0; i < tables.Count; ++i)
                {
                    WriteLine(tables[i]);
                }

                WriteLine();
            }
            else if(cmd.Equals("clear") || cmd.Equals("cls"))
            {
                CommandOutput.Text = "";
            }
            else
            {
                SQLite.Column[] result = null;

                try
                {
                    result = DB.Exec(query);
                }
                catch (Exception ex)
                {
                    WriteLine2(ex.ToString());
                    return;
                }

                if(result == null)
                {
                    WriteLine2("Success!");
                    return;
                }

                for (int i = 0; i < result.Length; ++i)
                {
                    Write(string.Format("{0, -20} |", result[i].name));
                }

                WriteLine();

                for (int i = 0; i < result.Length; ++i)
                {
                    Write("=====================|");
                }

                WriteLine();

                for (int i = 0; i < result[0].values.Count; ++i)
                {
                    for (int j = 0; j < result.Length; ++j)
                    {
                        string str;

                        if(result[j].type == SQLite.Column.Type.NULL || result[j].values[i] == null)
                        {
                            str = "NULL";
                        }
                        else
                        {
                            str = result[j].values[i].ToString();
                        }

                        Write(string.Format("{0, -20} |", str));
                    }

                    WriteLine();

                    for (int j = 0; j < result.Length; ++j)
                    {
                        Write("---------------------|");
                    }

                    WriteLine();
                }

                WriteLine();
                WriteLine2("Success!");
            }
        }

        private void InputButton_Click(object sender, EventArgs e)
        {
            Execute();
        }

        private void CommandInput_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Execute();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }
}
