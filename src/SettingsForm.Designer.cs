namespace devtime
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.DatabaseGroup = new System.Windows.Forms.GroupBox();
            this.DatabaseExportBufferSize = new System.Windows.Forms.NumericUpDown();
            this.DatabaseExportBufferSizeLabel = new System.Windows.Forms.Label();
            this.DatabasePath = new System.Windows.Forms.TextBox();
            this.DatabasePathLabel = new System.Windows.Forms.Label();
            this.DatabaseUpdateFrequency = new System.Windows.Forms.NumericUpDown();
            this.DatabaseUpdateFrequencyLabel = new System.Windows.Forms.Label();
            this.AdvancedGroup = new System.Windows.Forms.GroupBox();
            this.FreeMemoryWhenStopping = new System.Windows.Forms.CheckBox();
            this.DisableDynamicGuiUpdates = new System.Windows.Forms.CheckBox();
            this.TaskbarColorsGroup = new System.Windows.Forms.GroupBox();
            this.MinimizeToTray = new System.Windows.Forms.CheckBox();
            this.RunningTimerColor = new System.Windows.Forms.ComboBox();
            this.StoppedTimerColor = new System.Windows.Forms.ComboBox();
            this.RunningTimerColorLabel = new System.Windows.Forms.Label();
            this.StoppedTimerColorLabel = new System.Windows.Forms.Label();
            this.OkDialogButton = new System.Windows.Forms.Button();
            this.CancelDialogButton = new System.Windows.Forms.Button();
            this.HotkeyGroup = new System.Windows.Forms.GroupBox();
            this.StopHotkey = new System.Windows.Forms.ComboBox();
            this.StartHotkey = new System.Windows.Forms.ComboBox();
            this.StopHotkeyLabel = new System.Windows.Forms.Label();
            this.StartHotkeyLabel = new System.Windows.Forms.Label();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.DatabaseGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatabaseExportBufferSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatabaseUpdateFrequency)).BeginInit();
            this.AdvancedGroup.SuspendLayout();
            this.TaskbarColorsGroup.SuspendLayout();
            this.HotkeyGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // DatabaseGroup
            // 
            this.DatabaseGroup.Controls.Add(this.DatabaseExportBufferSize);
            this.DatabaseGroup.Controls.Add(this.DatabaseExportBufferSizeLabel);
            this.DatabaseGroup.Controls.Add(this.DatabasePath);
            this.DatabaseGroup.Controls.Add(this.DatabasePathLabel);
            this.DatabaseGroup.Controls.Add(this.DatabaseUpdateFrequency);
            this.DatabaseGroup.Controls.Add(this.DatabaseUpdateFrequencyLabel);
            this.DatabaseGroup.Location = new System.Drawing.Point(12, 12);
            this.DatabaseGroup.Name = "DatabaseGroup";
            this.DatabaseGroup.Size = new System.Drawing.Size(200, 107);
            this.DatabaseGroup.TabIndex = 0;
            this.DatabaseGroup.TabStop = false;
            this.DatabaseGroup.Text = "Database";
            // 
            // DatabaseExportBufferSize
            // 
            this.DatabaseExportBufferSize.Location = new System.Drawing.Point(121, 79);
            this.DatabaseExportBufferSize.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.DatabaseExportBufferSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DatabaseExportBufferSize.Name = "DatabaseExportBufferSize";
            this.DatabaseExportBufferSize.Size = new System.Drawing.Size(73, 20);
            this.DatabaseExportBufferSize.TabIndex = 5;
            this.ToolTip.SetToolTip(this.DatabaseExportBufferSize, "How many entries to export at once. The larger this number is, the faster the exp" +
        "ort is, but the more memory it consumes");
            this.DatabaseExportBufferSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // DatabaseExportBufferSizeLabel
            // 
            this.DatabaseExportBufferSizeLabel.AutoSize = true;
            this.DatabaseExportBufferSizeLabel.Location = new System.Drawing.Point(6, 82);
            this.DatabaseExportBufferSizeLabel.Name = "DatabaseExportBufferSizeLabel";
            this.DatabaseExportBufferSizeLabel.Size = new System.Drawing.Size(91, 13);
            this.DatabaseExportBufferSizeLabel.TabIndex = 4;
            this.DatabaseExportBufferSizeLabel.Text = "Export buffer size:";
            this.ToolTip.SetToolTip(this.DatabaseExportBufferSizeLabel, "How many entries to export at once. The larger this number is, the faster the exp" +
        "ort is, but the more memory it consumes");
            // 
            // DatabasePath
            // 
            this.DatabasePath.Location = new System.Drawing.Point(59, 50);
            this.DatabasePath.Name = "DatabasePath";
            this.DatabasePath.Size = new System.Drawing.Size(135, 20);
            this.DatabasePath.TabIndex = 3;
            this.ToolTip.SetToolTip(this.DatabasePath, "The path to the database file");
            // 
            // DatabasePathLabel
            // 
            this.DatabasePathLabel.AutoSize = true;
            this.DatabasePathLabel.Location = new System.Drawing.Point(6, 52);
            this.DatabasePathLabel.Name = "DatabasePathLabel";
            this.DatabasePathLabel.Size = new System.Drawing.Size(50, 13);
            this.DatabasePathLabel.TabIndex = 2;
            this.DatabasePathLabel.Text = "File path:";
            this.ToolTip.SetToolTip(this.DatabasePathLabel, "The path to the database file");
            // 
            // DatabaseUpdateFrequency
            // 
            this.DatabaseUpdateFrequency.Location = new System.Drawing.Point(121, 19);
            this.DatabaseUpdateFrequency.Maximum = new decimal(new int[] {
            36000,
            0,
            0,
            0});
            this.DatabaseUpdateFrequency.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DatabaseUpdateFrequency.Name = "DatabaseUpdateFrequency";
            this.DatabaseUpdateFrequency.Size = new System.Drawing.Size(73, 20);
            this.DatabaseUpdateFrequency.TabIndex = 1;
            this.ToolTip.SetToolTip(this.DatabaseUpdateFrequency, "How often to save the current time in the database when the timer is running (in " +
        "seconds)");
            this.DatabaseUpdateFrequency.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // DatabaseUpdateFrequencyLabel
            // 
            this.DatabaseUpdateFrequencyLabel.AutoSize = true;
            this.DatabaseUpdateFrequencyLabel.Location = new System.Drawing.Point(6, 21);
            this.DatabaseUpdateFrequencyLabel.Name = "DatabaseUpdateFrequencyLabel";
            this.DatabaseUpdateFrequencyLabel.Size = new System.Drawing.Size(109, 13);
            this.DatabaseUpdateFrequencyLabel.TabIndex = 0;
            this.DatabaseUpdateFrequencyLabel.Text = "Update frequency (s):";
            this.ToolTip.SetToolTip(this.DatabaseUpdateFrequencyLabel, "How often to save the current time in the database when the timer is running (in " +
        "seconds)");
            // 
            // AdvancedGroup
            // 
            this.AdvancedGroup.Controls.Add(this.FreeMemoryWhenStopping);
            this.AdvancedGroup.Controls.Add(this.DisableDynamicGuiUpdates);
            this.AdvancedGroup.Location = new System.Drawing.Point(218, 125);
            this.AdvancedGroup.Name = "AdvancedGroup";
            this.AdvancedGroup.Size = new System.Drawing.Size(200, 78);
            this.AdvancedGroup.TabIndex = 1;
            this.AdvancedGroup.TabStop = false;
            this.AdvancedGroup.Text = "Avanced";
            // 
            // FreeMemoryWhenStopping
            // 
            this.FreeMemoryWhenStopping.AutoSize = true;
            this.FreeMemoryWhenStopping.Location = new System.Drawing.Point(6, 51);
            this.FreeMemoryWhenStopping.Name = "FreeMemoryWhenStopping";
            this.FreeMemoryWhenStopping.Size = new System.Drawing.Size(178, 17);
            this.FreeMemoryWhenStopping.TabIndex = 1;
            this.FreeMemoryWhenStopping.Text = "call the GC when the timer stops";
            this.ToolTip.SetToolTip(this.FreeMemoryWhenStopping, "Try to free additional memory every time the timer is stopped, by calling the GC");
            this.FreeMemoryWhenStopping.UseVisualStyleBackColor = true;
            // 
            // DisableDynamicGuiUpdates
            // 
            this.DisableDynamicGuiUpdates.AutoSize = true;
            this.DisableDynamicGuiUpdates.Location = new System.Drawing.Point(6, 22);
            this.DisableDynamicGuiUpdates.Name = "DisableDynamicGuiUpdates";
            this.DisableDynamicGuiUpdates.Size = new System.Drawing.Size(189, 17);
            this.DisableDynamicGuiUpdates.TabIndex = 0;
            this.DisableDynamicGuiUpdates.Text = "no GUI updates when not focused";
            this.ToolTip.SetToolTip(this.DisableDynamicGuiUpdates, "Lower CPU usage by not updating the GUI when the window is not in focus");
            this.DisableDynamicGuiUpdates.UseVisualStyleBackColor = true;
            // 
            // TaskbarColorsGroup
            // 
            this.TaskbarColorsGroup.Controls.Add(this.MinimizeToTray);
            this.TaskbarColorsGroup.Controls.Add(this.RunningTimerColor);
            this.TaskbarColorsGroup.Controls.Add(this.StoppedTimerColor);
            this.TaskbarColorsGroup.Controls.Add(this.RunningTimerColorLabel);
            this.TaskbarColorsGroup.Controls.Add(this.StoppedTimerColorLabel);
            this.TaskbarColorsGroup.Location = new System.Drawing.Point(218, 12);
            this.TaskbarColorsGroup.Name = "TaskbarColorsGroup";
            this.TaskbarColorsGroup.Size = new System.Drawing.Size(193, 107);
            this.TaskbarColorsGroup.TabIndex = 2;
            this.TaskbarColorsGroup.TabStop = false;
            this.TaskbarColorsGroup.Text = "Taskbar / tray";
            // 
            // MinimizeToTray
            // 
            this.MinimizeToTray.AutoSize = true;
            this.MinimizeToTray.Location = new System.Drawing.Point(6, 81);
            this.MinimizeToTray.Name = "MinimizeToTray";
            this.MinimizeToTray.Size = new System.Drawing.Size(133, 17);
            this.MinimizeToTray.TabIndex = 2;
            this.MinimizeToTray.Text = "Minimize to system tray";
            this.ToolTip.SetToolTip(this.MinimizeToTray, "Hide the window when minimizing and spawn a tray icon");
            this.MinimizeToTray.UseVisualStyleBackColor = true;
            // 
            // RunningTimerColor
            // 
            this.RunningTimerColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RunningTimerColor.FormattingEnabled = true;
            this.RunningTimerColor.Location = new System.Drawing.Point(87, 49);
            this.RunningTimerColor.Name = "RunningTimerColor";
            this.RunningTimerColor.Size = new System.Drawing.Size(100, 21);
            this.RunningTimerColor.TabIndex = 3;
            this.ToolTip.SetToolTip(this.RunningTimerColor, "The taskbar/tray color to show when the timer is running");
            // 
            // StoppedTimerColor
            // 
            this.StoppedTimerColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StoppedTimerColor.FormattingEnabled = true;
            this.StoppedTimerColor.Location = new System.Drawing.Point(87, 19);
            this.StoppedTimerColor.Name = "StoppedTimerColor";
            this.StoppedTimerColor.Size = new System.Drawing.Size(100, 21);
            this.StoppedTimerColor.TabIndex = 2;
            this.ToolTip.SetToolTip(this.StoppedTimerColor, "The taskbar/tray color to show when the timer is not running");
            // 
            // RunningTimerColorLabel
            // 
            this.RunningTimerColorLabel.AutoSize = true;
            this.RunningTimerColorLabel.Location = new System.Drawing.Point(6, 52);
            this.RunningTimerColorLabel.Name = "RunningTimerColorLabel";
            this.RunningTimerColorLabel.Size = new System.Drawing.Size(76, 13);
            this.RunningTimerColorLabel.TabIndex = 1;
            this.RunningTimerColorLabel.Text = "Running color:";
            this.ToolTip.SetToolTip(this.RunningTimerColorLabel, "The taskbar/tray color to show when the timer is running");
            // 
            // StoppedTimerColorLabel
            // 
            this.StoppedTimerColorLabel.AutoSize = true;
            this.StoppedTimerColorLabel.Location = new System.Drawing.Point(6, 22);
            this.StoppedTimerColorLabel.Name = "StoppedTimerColorLabel";
            this.StoppedTimerColorLabel.Size = new System.Drawing.Size(69, 13);
            this.StoppedTimerColorLabel.TabIndex = 0;
            this.StoppedTimerColorLabel.Text = "Normal color:";
            this.ToolTip.SetToolTip(this.StoppedTimerColorLabel, "The taskbar/tray color to show when the timer is not running");
            // 
            // OkDialogButton
            // 
            this.OkDialogButton.Location = new System.Drawing.Point(344, 209);
            this.OkDialogButton.Name = "OkDialogButton";
            this.OkDialogButton.Size = new System.Drawing.Size(75, 23);
            this.OkDialogButton.TabIndex = 3;
            this.OkDialogButton.Text = "OK";
            this.OkDialogButton.UseVisualStyleBackColor = true;
            this.OkDialogButton.Click += new System.EventHandler(this.OkDialogButton_Click);
            // 
            // CancelDialogButton
            // 
            this.CancelDialogButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelDialogButton.Location = new System.Drawing.Point(263, 209);
            this.CancelDialogButton.Name = "CancelDialogButton";
            this.CancelDialogButton.Size = new System.Drawing.Size(75, 23);
            this.CancelDialogButton.TabIndex = 4;
            this.CancelDialogButton.Text = "Cancel";
            this.CancelDialogButton.UseVisualStyleBackColor = true;
            this.CancelDialogButton.Click += new System.EventHandler(this.CancelDialogButton_Click);
            // 
            // HotkeyGroup
            // 
            this.HotkeyGroup.Controls.Add(this.StopHotkey);
            this.HotkeyGroup.Controls.Add(this.StartHotkey);
            this.HotkeyGroup.Controls.Add(this.StopHotkeyLabel);
            this.HotkeyGroup.Controls.Add(this.StartHotkeyLabel);
            this.HotkeyGroup.Location = new System.Drawing.Point(12, 125);
            this.HotkeyGroup.Name = "HotkeyGroup";
            this.HotkeyGroup.Size = new System.Drawing.Size(200, 78);
            this.HotkeyGroup.TabIndex = 5;
            this.HotkeyGroup.TabStop = false;
            this.HotkeyGroup.Text = "Hotkeys";
            // 
            // StopHotkey
            // 
            this.StopHotkey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StopHotkey.FormattingEnabled = true;
            this.StopHotkey.Location = new System.Drawing.Point(69, 49);
            this.StopHotkey.Name = "StopHotkey";
            this.StopHotkey.Size = new System.Drawing.Size(118, 21);
            this.StopHotkey.TabIndex = 7;
            this.ToolTip.SetToolTip(this.StopHotkey, "The hotkey to stop the timer");
            // 
            // StartHotkey
            // 
            this.StartHotkey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StartHotkey.FormattingEnabled = true;
            this.StartHotkey.Location = new System.Drawing.Point(69, 19);
            this.StartHotkey.Name = "StartHotkey";
            this.StartHotkey.Size = new System.Drawing.Size(118, 21);
            this.StartHotkey.TabIndex = 6;
            this.ToolTip.SetToolTip(this.StartHotkey, "The hotkey to start the timer");
            // 
            // StopHotkeyLabel
            // 
            this.StopHotkeyLabel.AutoSize = true;
            this.StopHotkeyLabel.Location = new System.Drawing.Point(6, 52);
            this.StopHotkeyLabel.Name = "StopHotkeyLabel";
            this.StopHotkeyLabel.Size = new System.Drawing.Size(57, 13);
            this.StopHotkeyLabel.TabIndex = 5;
            this.StopHotkeyLabel.Text = "Stop timer:";
            this.ToolTip.SetToolTip(this.StopHotkeyLabel, "The hotkey to stop the timer");
            // 
            // StartHotkeyLabel
            // 
            this.StartHotkeyLabel.AutoSize = true;
            this.StartHotkeyLabel.Location = new System.Drawing.Point(6, 22);
            this.StartHotkeyLabel.Name = "StartHotkeyLabel";
            this.StartHotkeyLabel.Size = new System.Drawing.Size(57, 13);
            this.StartHotkeyLabel.TabIndex = 4;
            this.StartHotkeyLabel.Text = "Start timer:";
            this.ToolTip.SetToolTip(this.StartHotkeyLabel, "The hotkey to start the timer");
            // 
            // ToolTip
            // 
            this.ToolTip.AutomaticDelay = 250;
            this.ToolTip.AutoPopDelay = 10000;
            this.ToolTip.InitialDelay = 250;
            this.ToolTip.ReshowDelay = 50;
            // 
            // SettingsForm
            // 
            this.AcceptButton = this.OkDialogButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelDialogButton;
            this.ClientSize = new System.Drawing.Size(423, 240);
            this.Controls.Add(this.HotkeyGroup);
            this.Controls.Add(this.CancelDialogButton);
            this.Controls.Add(this.OkDialogButton);
            this.Controls.Add(this.TaskbarColorsGroup);
            this.Controls.Add(this.AdvancedGroup);
            this.Controls.Add(this.DatabaseGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.DatabaseGroup.ResumeLayout(false);
            this.DatabaseGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatabaseExportBufferSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatabaseUpdateFrequency)).EndInit();
            this.AdvancedGroup.ResumeLayout(false);
            this.AdvancedGroup.PerformLayout();
            this.TaskbarColorsGroup.ResumeLayout(false);
            this.TaskbarColorsGroup.PerformLayout();
            this.HotkeyGroup.ResumeLayout(false);
            this.HotkeyGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox DatabaseGroup;
        private System.Windows.Forms.NumericUpDown DatabaseUpdateFrequency;
        private System.Windows.Forms.Label DatabaseUpdateFrequencyLabel;
        private System.Windows.Forms.TextBox DatabasePath;
        private System.Windows.Forms.Label DatabasePathLabel;
        private System.Windows.Forms.GroupBox AdvancedGroup;
        private System.Windows.Forms.CheckBox DisableDynamicGuiUpdates;
        private System.Windows.Forms.CheckBox FreeMemoryWhenStopping;
        private System.Windows.Forms.GroupBox TaskbarColorsGroup;
        private System.Windows.Forms.ComboBox RunningTimerColor;
        private System.Windows.Forms.ComboBox StoppedTimerColor;
        private System.Windows.Forms.Label RunningTimerColorLabel;
        private System.Windows.Forms.Label StoppedTimerColorLabel;
        private System.Windows.Forms.Button OkDialogButton;
        private System.Windows.Forms.Button CancelDialogButton;
        private System.Windows.Forms.CheckBox MinimizeToTray;
        private System.Windows.Forms.NumericUpDown DatabaseExportBufferSize;
        private System.Windows.Forms.Label DatabaseExportBufferSizeLabel;
        private System.Windows.Forms.GroupBox HotkeyGroup;
        private System.Windows.Forms.ComboBox StopHotkey;
        private System.Windows.Forms.ComboBox StartHotkey;
        private System.Windows.Forms.Label StopHotkeyLabel;
        private System.Windows.Forms.Label StartHotkeyLabel;
        private System.Windows.Forms.ToolTip ToolTip;
    }
}