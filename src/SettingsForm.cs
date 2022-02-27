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
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();

            StoppedTimerColor.DataSource = Enum.GetValues(typeof(Config.TaskbarColor));
            RunningTimerColor.DataSource = Enum.GetValues(typeof(Config.TaskbarColor));

            StartHotkey.DataSource = Enum.GetValues(typeof(Config.Hotkey));
            StopHotkey.DataSource = Enum.GetValues(typeof(Config.Hotkey));

            DatabaseUpdateFrequency.Value = Config.databaseUpdateFrequency;
            DatabasePath.Text = Config.databasePath;
            DatabaseExportBufferSize.Value = Config.databaseExportBufferSize;

            StoppedTimerColor.SelectedItem = Config.stoppedTimerColor;
            RunningTimerColor.SelectedItem = Config.runningTimerColor;
            MinimizeToTray.Checked = Config.minimizeToTray;

            StartHotkey.SelectedItem = Config.startHotkey;
            StopHotkey.SelectedItem = Config.stopHotkey;

            DisableDynamicGuiUpdates.Checked = Config.disableDynamicGuiUpdates;
            FreeMemoryWhenStopping.Checked = Config.freeMemoryWhenStopping;
        }

        private void OkDialogButton_Click(object sender, EventArgs e)
        {
            Config.databaseUpdateFrequency = (uint) DatabaseUpdateFrequency.Value;
            Config.databasePath = DatabasePath.Text;
            Config.databaseExportBufferSize = (uint) DatabaseExportBufferSize.Value;

            Config.stoppedTimerColor = (Config.TaskbarColor)StoppedTimerColor.SelectedItem;
            Config.runningTimerColor = (Config.TaskbarColor)RunningTimerColor.SelectedItem;
            Config.minimizeToTray = MinimizeToTray.Checked;

            Config.startHotkey = (Config.Hotkey)StartHotkey.SelectedItem;
            Config.stopHotkey = (Config.Hotkey)StopHotkey.SelectedItem;

            Config.disableDynamicGuiUpdates = DisableDynamicGuiUpdates.Checked;
            Config.freeMemoryWhenStopping = FreeMemoryWhenStopping.Checked;

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
