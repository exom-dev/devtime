namespace devtime
{
    partial class StatsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatsForm));
            this.WorkedGroup = new System.Windows.Forms.GroupBox();
            this.Milliseconds = new System.Windows.Forms.Label();
            this.Seconds = new System.Windows.Forms.Label();
            this.Minutes = new System.Windows.Forms.Label();
            this.Hours = new System.Windows.Forms.Label();
            this.FromGroup = new System.Windows.Forms.GroupBox();
            this.From = new System.Windows.Forms.DateTimePicker();
            this.ToGroup = new System.Windows.Forms.GroupBox();
            this.To = new System.Windows.Forms.DateTimePicker();
            this.ExportGroup = new System.Windows.Forms.GroupBox();
            this.LoggedTimeApproximation = new System.Windows.Forms.ComboBox();
            this.LoggedTimeApproximationLabel = new System.Windows.Forms.Label();
            this.LoggedTimeFormat = new System.Windows.Forms.ComboBox();
            this.LoggedTimeFormatLabel = new System.Windows.Forms.Label();
            this.ExportLog = new System.Windows.Forms.CheckBox();
            this.ExportLoggedTime = new System.Windows.Forms.CheckBox();
            this.ExportDate = new System.Windows.Forms.CheckBox();
            this.Export = new System.Windows.Forms.Button();
            this.ExportFormat = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ExportFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.WorkedGroup.SuspendLayout();
            this.FromGroup.SuspendLayout();
            this.ToGroup.SuspendLayout();
            this.ExportGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // WorkedGroup
            // 
            this.WorkedGroup.Controls.Add(this.Milliseconds);
            this.WorkedGroup.Controls.Add(this.Seconds);
            this.WorkedGroup.Controls.Add(this.Minutes);
            this.WorkedGroup.Controls.Add(this.Hours);
            this.WorkedGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorkedGroup.Location = new System.Drawing.Point(12, 12);
            this.WorkedGroup.Name = "WorkedGroup";
            this.WorkedGroup.Size = new System.Drawing.Size(132, 99);
            this.WorkedGroup.TabIndex = 0;
            this.WorkedGroup.TabStop = false;
            this.WorkedGroup.Text = "You have worked";
            // 
            // Milliseconds
            // 
            this.Milliseconds.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Milliseconds.AutoSize = true;
            this.Milliseconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Milliseconds.Location = new System.Drawing.Point(6, 77);
            this.Milliseconds.Margin = new System.Windows.Forms.Padding(0);
            this.Milliseconds.Name = "Milliseconds";
            this.Milliseconds.Size = new System.Drawing.Size(72, 13);
            this.Milliseconds.TabIndex = 5;
            this.Milliseconds.Text = "0 milliseconds";
            // 
            // Seconds
            // 
            this.Seconds.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Seconds.AutoSize = true;
            this.Seconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Seconds.Location = new System.Drawing.Point(6, 61);
            this.Seconds.Margin = new System.Windows.Forms.Padding(0);
            this.Seconds.Name = "Seconds";
            this.Seconds.Size = new System.Drawing.Size(56, 13);
            this.Seconds.TabIndex = 4;
            this.Seconds.Text = "0 seconds";
            // 
            // Minutes
            // 
            this.Minutes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Minutes.AutoSize = true;
            this.Minutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minutes.Location = new System.Drawing.Point(6, 43);
            this.Minutes.Margin = new System.Windows.Forms.Padding(0);
            this.Minutes.Name = "Minutes";
            this.Minutes.Size = new System.Drawing.Size(63, 16);
            this.Minutes.TabIndex = 3;
            this.Minutes.Text = "0 minutes";
            // 
            // Hours
            // 
            this.Hours.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Hours.AutoSize = true;
            this.Hours.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hours.Location = new System.Drawing.Point(4, 22);
            this.Hours.Margin = new System.Windows.Forms.Padding(0);
            this.Hours.Name = "Hours";
            this.Hours.Size = new System.Drawing.Size(62, 20);
            this.Hours.TabIndex = 2;
            this.Hours.Text = "0 hours";
            // 
            // FromGroup
            // 
            this.FromGroup.Controls.Add(this.From);
            this.FromGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromGroup.Location = new System.Drawing.Point(150, 13);
            this.FromGroup.Name = "FromGroup";
            this.FromGroup.Size = new System.Drawing.Size(132, 46);
            this.FromGroup.TabIndex = 1;
            this.FromGroup.TabStop = false;
            this.FromGroup.Text = "From (inclusive)";
            // 
            // From
            // 
            this.From.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.From.Location = new System.Drawing.Point(9, 19);
            this.From.Name = "From";
            this.From.Size = new System.Drawing.Size(117, 20);
            this.From.TabIndex = 0;
            this.ToolTip.SetToolTip(this.From, "The first date to consider");
            this.From.ValueChanged += new System.EventHandler(this.From_ValueChanged);
            // 
            // ToGroup
            // 
            this.ToGroup.Controls.Add(this.To);
            this.ToGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToGroup.Location = new System.Drawing.Point(150, 65);
            this.ToGroup.Name = "ToGroup";
            this.ToGroup.Size = new System.Drawing.Size(132, 46);
            this.ToGroup.TabIndex = 2;
            this.ToGroup.TabStop = false;
            this.ToGroup.Text = "To (inclusive)";
            // 
            // To
            // 
            this.To.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.To.Location = new System.Drawing.Point(9, 19);
            this.To.Name = "To";
            this.To.Size = new System.Drawing.Size(117, 20);
            this.To.TabIndex = 0;
            this.ToolTip.SetToolTip(this.To, "The last date to consider");
            this.To.ValueChanged += new System.EventHandler(this.To_ValueChanged);
            // 
            // ExportGroup
            // 
            this.ExportGroup.Controls.Add(this.LoggedTimeApproximation);
            this.ExportGroup.Controls.Add(this.LoggedTimeApproximationLabel);
            this.ExportGroup.Controls.Add(this.LoggedTimeFormat);
            this.ExportGroup.Controls.Add(this.LoggedTimeFormatLabel);
            this.ExportGroup.Controls.Add(this.ExportLog);
            this.ExportGroup.Controls.Add(this.ExportLoggedTime);
            this.ExportGroup.Controls.Add(this.ExportDate);
            this.ExportGroup.Controls.Add(this.Export);
            this.ExportGroup.Controls.Add(this.ExportFormat);
            this.ExportGroup.Controls.Add(this.label4);
            this.ExportGroup.Location = new System.Drawing.Point(12, 117);
            this.ExportGroup.Name = "ExportGroup";
            this.ExportGroup.Size = new System.Drawing.Size(270, 144);
            this.ExportGroup.TabIndex = 3;
            this.ExportGroup.TabStop = false;
            this.ExportGroup.Text = "Export";
            // 
            // LoggedTimeApproximation
            // 
            this.LoggedTimeApproximation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LoggedTimeApproximation.FormattingEnabled = true;
            this.LoggedTimeApproximation.Location = new System.Drawing.Point(77, 110);
            this.LoggedTimeApproximation.Name = "LoggedTimeApproximation";
            this.LoggedTimeApproximation.Size = new System.Drawing.Size(81, 21);
            this.LoggedTimeApproximation.TabIndex = 9;
            this.ToolTip.SetToolTip(this.LoggedTimeApproximation, "Logged time approximation function");
            // 
            // LoggedTimeApproximationLabel
            // 
            this.LoggedTimeApproximationLabel.AutoSize = true;
            this.LoggedTimeApproximationLabel.Location = new System.Drawing.Point(6, 113);
            this.LoggedTimeApproximationLabel.Name = "LoggedTimeApproximationLabel";
            this.LoggedTimeApproximationLabel.Size = new System.Drawing.Size(68, 13);
            this.LoggedTimeApproximationLabel.TabIndex = 8;
            this.LoggedTimeApproximationLabel.Text = "Time approx:";
            // 
            // LoggedTimeFormat
            // 
            this.LoggedTimeFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LoggedTimeFormat.FormattingEnabled = true;
            this.LoggedTimeFormat.Location = new System.Drawing.Point(77, 76);
            this.LoggedTimeFormat.Name = "LoggedTimeFormat";
            this.LoggedTimeFormat.Size = new System.Drawing.Size(81, 21);
            this.LoggedTimeFormat.TabIndex = 7;
            this.ToolTip.SetToolTip(this.LoggedTimeFormat, "Logged time format");
            // 
            // LoggedTimeFormatLabel
            // 
            this.LoggedTimeFormatLabel.AutoSize = true;
            this.LoggedTimeFormatLabel.Location = new System.Drawing.Point(6, 79);
            this.LoggedTimeFormatLabel.Name = "LoggedTimeFormatLabel";
            this.LoggedTimeFormatLabel.Size = new System.Drawing.Size(65, 13);
            this.LoggedTimeFormatLabel.TabIndex = 6;
            this.LoggedTimeFormatLabel.Text = "Time format:";
            // 
            // ExportLog
            // 
            this.ExportLog.AutoSize = true;
            this.ExportLog.Checked = true;
            this.ExportLog.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ExportLog.Location = new System.Drawing.Point(141, 45);
            this.ExportLog.Name = "ExportLog";
            this.ExportLog.Size = new System.Drawing.Size(44, 17);
            this.ExportLog.TabIndex = 5;
            this.ExportLog.Text = "Log";
            this.ToolTip.SetToolTip(this.ExportLog, "Include the log field in the export");
            this.ExportLog.UseVisualStyleBackColor = true;
            // 
            // ExportLoggedTime
            // 
            this.ExportLoggedTime.AutoSize = true;
            this.ExportLoggedTime.Checked = true;
            this.ExportLoggedTime.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ExportLoggedTime.Location = new System.Drawing.Point(57, 45);
            this.ExportLoggedTime.Name = "ExportLoggedTime";
            this.ExportLoggedTime.Size = new System.Drawing.Size(84, 17);
            this.ExportLoggedTime.TabIndex = 4;
            this.ExportLoggedTime.Text = "Logged time";
            this.ToolTip.SetToolTip(this.ExportLoggedTime, "Include the logged time field in the export");
            this.ExportLoggedTime.UseVisualStyleBackColor = true;
            this.ExportLoggedTime.CheckedChanged += new System.EventHandler(this.ExportLoggedTime_CheckedChanged);
            // 
            // ExportDate
            // 
            this.ExportDate.AutoSize = true;
            this.ExportDate.Checked = true;
            this.ExportDate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ExportDate.Location = new System.Drawing.Point(9, 45);
            this.ExportDate.Name = "ExportDate";
            this.ExportDate.Size = new System.Drawing.Size(49, 17);
            this.ExportDate.TabIndex = 3;
            this.ExportDate.Text = "Date";
            this.ToolTip.SetToolTip(this.ExportDate, "Include the date field in the export");
            this.ExportDate.UseVisualStyleBackColor = true;
            // 
            // Export
            // 
            this.Export.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Export.Image = global::devtime.Properties.Resources.export;
            this.Export.Location = new System.Drawing.Point(164, 75);
            this.Export.Name = "Export";
            this.Export.Size = new System.Drawing.Size(100, 57);
            this.Export.TabIndex = 2;
            this.Export.Text = "Export";
            this.Export.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Export.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Export.UseVisualStyleBackColor = true;
            this.Export.Click += new System.EventHandler(this.Export_Click);
            // 
            // ExportFormat
            // 
            this.ExportFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ExportFormat.FormattingEnabled = true;
            this.ExportFormat.Location = new System.Drawing.Point(54, 14);
            this.ExportFormat.Name = "ExportFormat";
            this.ExportFormat.Size = new System.Drawing.Size(125, 21);
            this.ExportFormat.TabIndex = 1;
            this.ToolTip.SetToolTip(this.ExportFormat, "Export format");
            this.ExportFormat.SelectedIndexChanged += new System.EventHandler(this.ExportFormat_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Format:";
            // 
            // ExportFileDialog
            // 
            this.ExportFileDialog.FileName = "devtime_export";
            this.ExportFileDialog.Title = "Export devtime data";
            // 
            // ToolTip
            // 
            this.ToolTip.AutomaticDelay = 250;
            this.ToolTip.AutoPopDelay = 10000;
            this.ToolTip.InitialDelay = 250;
            this.ToolTip.ReshowDelay = 50;
            // 
            // StatsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 271);
            this.Controls.Add(this.ExportGroup);
            this.Controls.Add(this.ToGroup);
            this.Controls.Add(this.FromGroup);
            this.Controls.Add(this.WorkedGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StatsForm";
            this.Text = "Stats";
            this.WorkedGroup.ResumeLayout(false);
            this.WorkedGroup.PerformLayout();
            this.FromGroup.ResumeLayout(false);
            this.ToGroup.ResumeLayout(false);
            this.ExportGroup.ResumeLayout(false);
            this.ExportGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox WorkedGroup;
        private System.Windows.Forms.GroupBox FromGroup;
        private System.Windows.Forms.DateTimePicker From;
        private System.Windows.Forms.GroupBox ToGroup;
        private System.Windows.Forms.DateTimePicker To;
        private System.Windows.Forms.GroupBox ExportGroup;
        private System.Windows.Forms.ComboBox ExportFormat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Export;
        private System.Windows.Forms.CheckBox ExportLog;
        private System.Windows.Forms.CheckBox ExportLoggedTime;
        private System.Windows.Forms.CheckBox ExportDate;
        private System.Windows.Forms.Label Hours;
        private System.Windows.Forms.Label Milliseconds;
        private System.Windows.Forms.Label Seconds;
        private System.Windows.Forms.Label Minutes;
        private System.Windows.Forms.ComboBox LoggedTimeFormat;
        private System.Windows.Forms.Label LoggedTimeFormatLabel;
        private System.Windows.Forms.ComboBox LoggedTimeApproximation;
        private System.Windows.Forms.Label LoggedTimeApproximationLabel;
        private System.Windows.Forms.SaveFileDialog ExportFileDialog;
        private System.Windows.Forms.ToolTip ToolTip;
    }
}