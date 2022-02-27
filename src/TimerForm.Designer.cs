using System.Drawing;

namespace devtime
{
    partial class TimerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimerForm));
            this.TimerMainLabel = new System.Windows.Forms.Label();
            this.TimerSecondaryLabel = new System.Windows.Forms.Label();
            this.TimerGroup = new System.Windows.Forms.GroupBox();
            this.DaysList = new System.Windows.Forms.ListBox();
            this.MonthLabel = new System.Windows.Forms.Label();
            this.MenuContainer = new System.Windows.Forms.Panel();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.ConsoleButton = new System.Windows.Forms.ToolStripMenuItem();
            this.LogWorkButton = new System.Windows.Forms.ToolStripMenuItem();
            this.StatsExportButton = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsButton = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextComboBox = new System.Windows.Forms.ComboBox();
            this.ProjectGroup = new System.Windows.Forms.GroupBox();
            this.EditProjectButton = new System.Windows.Forms.Button();
            this.NotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.RemoveButton = new System.Windows.Forms.Button();
            this.PreviousMonthButton = new System.Windows.Forms.Button();
            this.NextMonthButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.TimerGroup.SuspendLayout();
            this.MenuContainer.SuspendLayout();
            this.Menu.SuspendLayout();
            this.ProjectGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // TimerMainLabel
            // 
            this.TimerMainLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TimerMainLabel.AutoSize = true;
            this.TimerMainLabel.Font = new System.Drawing.Font("Consolas", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimerMainLabel.Location = new System.Drawing.Point(3, 20);
            this.TimerMainLabel.Margin = new System.Windows.Forms.Padding(0);
            this.TimerMainLabel.Name = "TimerMainLabel";
            this.TimerMainLabel.Size = new System.Drawing.Size(207, 75);
            this.TimerMainLabel.TabIndex = 1;
            this.TimerMainLabel.Text = "00:00";
            // 
            // TimerSecondaryLabel
            // 
            this.TimerSecondaryLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TimerSecondaryLabel.AutoSize = true;
            this.TimerSecondaryLabel.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimerSecondaryLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TimerSecondaryLabel.Location = new System.Drawing.Point(191, 20);
            this.TimerSecondaryLabel.Margin = new System.Windows.Forms.Padding(0);
            this.TimerSecondaryLabel.Name = "TimerSecondaryLabel";
            this.TimerSecondaryLabel.Size = new System.Drawing.Size(77, 28);
            this.TimerSecondaryLabel.TabIndex = 4;
            this.TimerSecondaryLabel.Text = "00.00";
            // 
            // TimerGroup
            // 
            this.TimerGroup.Controls.Add(this.TimerSecondaryLabel);
            this.TimerGroup.Controls.Add(this.TimerMainLabel);
            this.TimerGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimerGroup.Location = new System.Drawing.Point(12, 93);
            this.TimerGroup.Name = "TimerGroup";
            this.TimerGroup.Size = new System.Drawing.Size(278, 101);
            this.TimerGroup.TabIndex = 5;
            this.TimerGroup.TabStop = false;
            this.TimerGroup.Text = "Timer";
            // 
            // DaysList
            // 
            this.DaysList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DaysList.FormattingEnabled = true;
            this.DaysList.IntegralHeight = false;
            this.DaysList.ItemHeight = 16;
            this.DaysList.Location = new System.Drawing.Point(307, 61);
            this.DaysList.Name = "DaysList";
            this.DaysList.Size = new System.Drawing.Size(127, 169);
            this.DaysList.TabIndex = 9;
            this.DaysList.SelectedIndexChanged += new System.EventHandler(this.DaysList_SelectedIndexChanged);
            // 
            // MonthLabel
            // 
            this.MonthLabel.AutoSize = true;
            this.MonthLabel.Location = new System.Drawing.Point(345, 41);
            this.MonthLabel.Name = "MonthLabel";
            this.MonthLabel.Size = new System.Drawing.Size(51, 13);
            this.MonthLabel.TabIndex = 16;
            this.MonthLabel.Text = "Jan 2022";
            // 
            // MenuContainer
            // 
            this.MenuContainer.BackColor = System.Drawing.SystemColors.ControlDark;
            this.MenuContainer.Controls.Add(this.Menu);
            this.MenuContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuContainer.Location = new System.Drawing.Point(0, 0);
            this.MenuContainer.Name = "MenuContainer";
            this.MenuContainer.Size = new System.Drawing.Size(447, 25);
            this.MenuContainer.TabIndex = 18;
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ConsoleButton,
            this.LogWorkButton,
            this.StatsExportButton,
            this.SettingsButton});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.ShowItemToolTips = true;
            this.Menu.Size = new System.Drawing.Size(447, 24);
            this.Menu.TabIndex = 0;
            // 
            // ConsoleButton
            // 
            this.ConsoleButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ConsoleButton.Image = global::devtime.Properties.Resources.terminal;
            this.ConsoleButton.Name = "ConsoleButton";
            this.ConsoleButton.Size = new System.Drawing.Size(80, 20);
            this.ConsoleButton.Text = "Terminal";
            this.ConsoleButton.ToolTipText = "Database terminal";
            this.ConsoleButton.Click += new System.EventHandler(this.ConsoleButton_Click);
            // 
            // LogWorkButton
            // 
            this.LogWorkButton.Image = global::devtime.Properties.Resources.log;
            this.LogWorkButton.Name = "LogWorkButton";
            this.LogWorkButton.Size = new System.Drawing.Size(84, 20);
            this.LogWorkButton.Text = "Log work";
            this.LogWorkButton.ToolTipText = "Describe what you did on this day";
            this.LogWorkButton.Click += new System.EventHandler(this.LogWorkButton_Click);
            // 
            // StatsExportButton
            // 
            this.StatsExportButton.Image = global::devtime.Properties.Resources.export;
            this.StatsExportButton.Name = "StatsExportButton";
            this.StatsExportButton.Size = new System.Drawing.Size(99, 20);
            this.StatsExportButton.Text = "Stats/Export";
            this.StatsExportButton.ToolTipText = "See stats or export to CSV/JSON";
            this.StatsExportButton.Click += new System.EventHandler(this.StatsExportButton_Click);
            // 
            // SettingsButton
            // 
            this.SettingsButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.SettingsButton.Image = global::devtime.Properties.Resources.settings;
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(77, 20);
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.ToolTipText = "Change various options";
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // ContextComboBox
            // 
            this.ContextComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ContextComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContextComboBox.FormattingEnabled = true;
            this.ContextComboBox.Location = new System.Drawing.Point(6, 20);
            this.ContextComboBox.Name = "ContextComboBox";
            this.ContextComboBox.Size = new System.Drawing.Size(234, 23);
            this.ContextComboBox.TabIndex = 5;
            this.ToolTip.SetToolTip(this.ContextComboBox, "Select a project");
            this.ContextComboBox.SelectedIndexChanged += new System.EventHandler(this.ContextComboBox_SelectedIndexChanged);
            // 
            // ProjectGroup
            // 
            this.ProjectGroup.Controls.Add(this.ContextComboBox);
            this.ProjectGroup.Controls.Add(this.EditProjectButton);
            this.ProjectGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectGroup.Location = new System.Drawing.Point(12, 38);
            this.ProjectGroup.Name = "ProjectGroup";
            this.ProjectGroup.Size = new System.Drawing.Size(278, 52);
            this.ProjectGroup.TabIndex = 21;
            this.ProjectGroup.TabStop = false;
            this.ProjectGroup.Text = "Project";
            // 
            // EditProjectButton
            // 
            this.EditProjectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditProjectButton.ForeColor = System.Drawing.SystemColors.Control;
            this.EditProjectButton.Image = global::devtime.Properties.Resources.edit;
            this.EditProjectButton.Location = new System.Drawing.Point(246, 19);
            this.EditProjectButton.Name = "EditProjectButton";
            this.EditProjectButton.Size = new System.Drawing.Size(26, 25);
            this.EditProjectButton.TabIndex = 20;
            this.ToolTip.SetToolTip(this.EditProjectButton, "Edit project");
            this.EditProjectButton.UseVisualStyleBackColor = true;
            this.EditProjectButton.Click += new System.EventHandler(this.EditProjectButton_Click);
            // 
            // NotifyIcon
            // 
            this.NotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("NotifyIcon.Icon")));
            this.NotifyIcon.Text = "devtime";
            this.NotifyIcon.DoubleClick += new System.EventHandler(this.NotifyIcon_DoubleClick);
            // 
            // RemoveButton
            // 
            this.RemoveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveButton.ForeColor = System.Drawing.SystemColors.Control;
            this.RemoveButton.Image = global::devtime.Properties.Resources.remove;
            this.RemoveButton.Location = new System.Drawing.Point(383, 230);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(26, 24);
            this.RemoveButton.TabIndex = 22;
            this.ToolTip.SetToolTip(this.RemoveButton, "Delete entry");
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // PreviousMonthButton
            // 
            this.PreviousMonthButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PreviousMonthButton.ForeColor = System.Drawing.SystemColors.Control;
            this.PreviousMonthButton.Image = ((System.Drawing.Image)(resources.GetObject("PreviousMonthButton.Image")));
            this.PreviousMonthButton.Location = new System.Drawing.Point(306, 38);
            this.PreviousMonthButton.Name = "PreviousMonthButton";
            this.PreviousMonthButton.Size = new System.Drawing.Size(33, 19);
            this.PreviousMonthButton.TabIndex = 17;
            this.ToolTip.SetToolTip(this.PreviousMonthButton, "Previous month");
            this.PreviousMonthButton.UseVisualStyleBackColor = true;
            this.PreviousMonthButton.Click += new System.EventHandler(this.PreviousMonthButton_Click);
            // 
            // NextMonthButton
            // 
            this.NextMonthButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextMonthButton.ForeColor = System.Drawing.SystemColors.Control;
            this.NextMonthButton.Image = ((System.Drawing.Image)(resources.GetObject("NextMonthButton.Image")));
            this.NextMonthButton.Location = new System.Drawing.Point(400, 38);
            this.NextMonthButton.Name = "NextMonthButton";
            this.NextMonthButton.Size = new System.Drawing.Size(35, 19);
            this.NextMonthButton.TabIndex = 14;
            this.ToolTip.SetToolTip(this.NextMonthButton, "Next month");
            this.NextMonthButton.UseVisualStyleBackColor = true;
            this.NextMonthButton.Click += new System.EventHandler(this.NextMonthButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditButton.ForeColor = System.Drawing.SystemColors.Control;
            this.EditButton.Image = global::devtime.Properties.Resources.edit_time;
            this.EditButton.Location = new System.Drawing.Point(357, 230);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(26, 24);
            this.EditButton.TabIndex = 12;
            this.ToolTip.SetToolTip(this.EditButton, "Edit logged time");
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshButton.ForeColor = System.Drawing.SystemColors.Control;
            this.RefreshButton.Image = global::devtime.Properties.Resources.refresh;
            this.RefreshButton.Location = new System.Drawing.Point(306, 230);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(26, 24);
            this.RefreshButton.TabIndex = 11;
            this.ToolTip.SetToolTip(this.RefreshButton, "Refresh");
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.ForeColor = System.Drawing.SystemColors.Control;
            this.AddButton.Image = ((System.Drawing.Image)(resources.GetObject("AddButton.Image")));
            this.AddButton.Location = new System.Drawing.Point(409, 230);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(26, 24);
            this.AddButton.TabIndex = 10;
            this.ToolTip.SetToolTip(this.AddButton, "Add entry");
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // StartButton
            // 
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.Image = global::devtime.Properties.Resources.start;
            this.StartButton.Location = new System.Drawing.Point(11, 200);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(280, 54);
            this.StartButton.TabIndex = 6;
            this.StartButton.Text = "Start";
            this.StartButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.StartButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // ToolTip
            // 
            this.ToolTip.AutomaticDelay = 250;
            this.ToolTip.AutoPopDelay = 10000;
            this.ToolTip.InitialDelay = 250;
            this.ToolTip.ReshowDelay = 50;
            // 
            // TimerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 259);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.ProjectGroup);
            this.Controls.Add(this.MenuContainer);
            this.Controls.Add(this.PreviousMonthButton);
            this.Controls.Add(this.MonthLabel);
            this.Controls.Add(this.NextMonthButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.DaysList);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.TimerGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "TimerForm";
            this.Text = "devtime";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TimerForm_FormClosing);
            this.Shown += new System.EventHandler(this.TimerForm_Shown);
            this.Resize += new System.EventHandler(this.TimerForm_Resize);
            this.TimerGroup.ResumeLayout(false);
            this.TimerGroup.PerformLayout();
            this.MenuContainer.ResumeLayout(false);
            this.MenuContainer.PerformLayout();
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ProjectGroup.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label TimerMainLabel;
        private System.Windows.Forms.Label TimerSecondaryLabel;
        private System.Windows.Forms.GroupBox TimerGroup;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.ListBox DaysList;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button NextMonthButton;
        private System.Windows.Forms.Label MonthLabel;
        private System.Windows.Forms.Button PreviousMonthButton;
        private System.Windows.Forms.Panel MenuContainer;
        new private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem ConsoleButton;
        private System.Windows.Forms.ToolStripMenuItem LogWorkButton;
        private System.Windows.Forms.ComboBox ContextComboBox;
        private System.Windows.Forms.ToolStripMenuItem StatsExportButton;
        private System.Windows.Forms.Button EditProjectButton;
        private System.Windows.Forms.GroupBox ProjectGroup;
        private System.Windows.Forms.ToolStripMenuItem SettingsButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.NotifyIcon NotifyIcon;
        private System.Windows.Forms.ToolTip ToolTip;
    }
}

