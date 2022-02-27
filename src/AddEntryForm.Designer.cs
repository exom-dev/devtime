namespace devtime
{
    partial class AddEntryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEntryForm));
            this.DateGroup = new System.Windows.Forms.GroupBox();
            this.Day = new System.Windows.Forms.DateTimePicker();
            this.LoggedTimeGroup = new System.Windows.Forms.GroupBox();
            this.TimeMillisecondLabel = new System.Windows.Forms.Label();
            this.TimeSecondLabel = new System.Windows.Forms.Label();
            this.TimeMinuteLabel = new System.Windows.Forms.Label();
            this.TimeHourLabel = new System.Windows.Forms.Label();
            this.TimeMillisecond = new System.Windows.Forms.NumericUpDown();
            this.TimeSecond = new System.Windows.Forms.NumericUpDown();
            this.TimeMinute = new System.Windows.Forms.NumericUpDown();
            this.TimeHour = new System.Windows.Forms.NumericUpDown();
            this.OkDialogButton = new System.Windows.Forms.Button();
            this.CancelDialogButton = new System.Windows.Forms.Button();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.DateGroup.SuspendLayout();
            this.LoggedTimeGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TimeMillisecond)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeSecond)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeHour)).BeginInit();
            this.SuspendLayout();
            // 
            // DateGroup
            // 
            this.DateGroup.Controls.Add(this.Day);
            this.DateGroup.Location = new System.Drawing.Point(55, 12);
            this.DateGroup.Name = "DateGroup";
            this.DateGroup.Size = new System.Drawing.Size(121, 50);
            this.DateGroup.TabIndex = 0;
            this.DateGroup.TabStop = false;
            this.DateGroup.Text = "Entry day";
            // 
            // Day
            // 
            this.Day.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Day.Location = new System.Drawing.Point(6, 19);
            this.Day.Name = "Day";
            this.Day.Size = new System.Drawing.Size(109, 20);
            this.Day.TabIndex = 0;
            this.ToolTip.SetToolTip(this.Day, "The day of the entry");
            // 
            // LoggedTimeGroup
            // 
            this.LoggedTimeGroup.Controls.Add(this.TimeMillisecondLabel);
            this.LoggedTimeGroup.Controls.Add(this.TimeSecondLabel);
            this.LoggedTimeGroup.Controls.Add(this.TimeMinuteLabel);
            this.LoggedTimeGroup.Controls.Add(this.TimeHourLabel);
            this.LoggedTimeGroup.Controls.Add(this.TimeMillisecond);
            this.LoggedTimeGroup.Controls.Add(this.TimeSecond);
            this.LoggedTimeGroup.Controls.Add(this.TimeMinute);
            this.LoggedTimeGroup.Controls.Add(this.TimeHour);
            this.LoggedTimeGroup.Location = new System.Drawing.Point(12, 68);
            this.LoggedTimeGroup.Name = "LoggedTimeGroup";
            this.LoggedTimeGroup.Size = new System.Drawing.Size(206, 65);
            this.LoggedTimeGroup.TabIndex = 1;
            this.LoggedTimeGroup.TabStop = false;
            this.LoggedTimeGroup.Text = "Logged time";
            // 
            // TimeMillisecondLabel
            // 
            this.TimeMillisecondLabel.AutoSize = true;
            this.TimeMillisecondLabel.Location = new System.Drawing.Point(158, 42);
            this.TimeMillisecondLabel.Name = "TimeMillisecondLabel";
            this.TimeMillisecondLabel.Size = new System.Drawing.Size(20, 13);
            this.TimeMillisecondLabel.TabIndex = 7;
            this.TimeMillisecondLabel.Text = "ms";
            // 
            // TimeSecondLabel
            // 
            this.TimeSecondLabel.AutoSize = true;
            this.TimeSecondLabel.Location = new System.Drawing.Point(105, 42);
            this.TimeSecondLabel.Name = "TimeSecondLabel";
            this.TimeSecondLabel.Size = new System.Drawing.Size(47, 13);
            this.TimeSecondLabel.TabIndex = 6;
            this.TimeSecondLabel.Text = "seconds";
            // 
            // TimeMinuteLabel
            // 
            this.TimeMinuteLabel.AutoSize = true;
            this.TimeMinuteLabel.Location = new System.Drawing.Point(56, 42);
            this.TimeMinuteLabel.Name = "TimeMinuteLabel";
            this.TimeMinuteLabel.Size = new System.Drawing.Size(28, 13);
            this.TimeMinuteLabel.TabIndex = 5;
            this.TimeMinuteLabel.Text = "mins";
            // 
            // TimeHourLabel
            // 
            this.TimeHourLabel.AutoSize = true;
            this.TimeHourLabel.Location = new System.Drawing.Point(6, 42);
            this.TimeHourLabel.Name = "TimeHourLabel";
            this.TimeHourLabel.Size = new System.Drawing.Size(33, 13);
            this.TimeHourLabel.TabIndex = 4;
            this.TimeHourLabel.Text = "hours";
            // 
            // TimeMillisecond
            // 
            this.TimeMillisecond.Location = new System.Drawing.Point(156, 19);
            this.TimeMillisecond.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.TimeMillisecond.Name = "TimeMillisecond";
            this.TimeMillisecond.Size = new System.Drawing.Size(44, 20);
            this.TimeMillisecond.TabIndex = 3;
            this.ToolTip.SetToolTip(this.TimeMillisecond, "The milliseconds logged for the day");
            // 
            // TimeSecond
            // 
            this.TimeSecond.Location = new System.Drawing.Point(106, 19);
            this.TimeSecond.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.TimeSecond.Name = "TimeSecond";
            this.TimeSecond.Size = new System.Drawing.Size(44, 20);
            this.TimeSecond.TabIndex = 2;
            this.ToolTip.SetToolTip(this.TimeSecond, "The seconds logged for the day");
            // 
            // TimeMinute
            // 
            this.TimeMinute.Location = new System.Drawing.Point(56, 19);
            this.TimeMinute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.TimeMinute.Name = "TimeMinute";
            this.TimeMinute.Size = new System.Drawing.Size(44, 20);
            this.TimeMinute.TabIndex = 1;
            this.ToolTip.SetToolTip(this.TimeMinute, "The minutes logged for the day");
            // 
            // TimeHour
            // 
            this.TimeHour.Location = new System.Drawing.Point(6, 19);
            this.TimeHour.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.TimeHour.Name = "TimeHour";
            this.TimeHour.Size = new System.Drawing.Size(44, 20);
            this.TimeHour.TabIndex = 0;
            this.ToolTip.SetToolTip(this.TimeHour, "The hours logged for the day");
            // 
            // OkDialogButton
            // 
            this.OkDialogButton.Location = new System.Drawing.Point(144, 139);
            this.OkDialogButton.Name = "OkDialogButton";
            this.OkDialogButton.Size = new System.Drawing.Size(75, 23);
            this.OkDialogButton.TabIndex = 2;
            this.OkDialogButton.Text = "OK";
            this.OkDialogButton.UseVisualStyleBackColor = true;
            this.OkDialogButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // CancelDialogButton
            // 
            this.CancelDialogButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelDialogButton.Location = new System.Drawing.Point(63, 139);
            this.CancelDialogButton.Name = "CancelDialogButton";
            this.CancelDialogButton.Size = new System.Drawing.Size(75, 23);
            this.CancelDialogButton.TabIndex = 3;
            this.CancelDialogButton.Text = "Cancel";
            this.CancelDialogButton.UseVisualStyleBackColor = true;
            this.CancelDialogButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ToolTip
            // 
            this.ToolTip.AutomaticDelay = 250;
            this.ToolTip.AutoPopDelay = 10000;
            this.ToolTip.InitialDelay = 250;
            this.ToolTip.ReshowDelay = 50;
            // 
            // AddEntryForm
            // 
            this.AcceptButton = this.OkDialogButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelDialogButton;
            this.ClientSize = new System.Drawing.Size(230, 171);
            this.Controls.Add(this.CancelDialogButton);
            this.Controls.Add(this.OkDialogButton);
            this.Controls.Add(this.LoggedTimeGroup);
            this.Controls.Add(this.DateGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddEntryForm";
            this.Text = "Add entry";
            this.DateGroup.ResumeLayout(false);
            this.LoggedTimeGroup.ResumeLayout(false);
            this.LoggedTimeGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TimeMillisecond)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeSecond)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeHour)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox DateGroup;
        private System.Windows.Forms.DateTimePicker Day;
        private System.Windows.Forms.GroupBox LoggedTimeGroup;
        private System.Windows.Forms.Label TimeMillisecondLabel;
        private System.Windows.Forms.Label TimeSecondLabel;
        private System.Windows.Forms.Label TimeMinuteLabel;
        private System.Windows.Forms.Label TimeHourLabel;
        private System.Windows.Forms.NumericUpDown TimeMillisecond;
        private System.Windows.Forms.NumericUpDown TimeSecond;
        private System.Windows.Forms.NumericUpDown TimeMinute;
        private System.Windows.Forms.NumericUpDown TimeHour;
        private System.Windows.Forms.Button OkDialogButton;
        private System.Windows.Forms.Button CancelDialogButton;
        private System.Windows.Forms.ToolTip ToolTip;
    }
}