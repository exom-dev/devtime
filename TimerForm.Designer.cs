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
            this.TimerMainLabel = new System.Windows.Forms.Label();
            this.TimerSecondaryLabel = new System.Windows.Forms.Label();
            this.TimerGroup = new System.Windows.Forms.GroupBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.TodayButton = new System.Windows.Forms.Button();
            this.StatsButton = new System.Windows.Forms.Button();
            this.DaysList = new System.Windows.Forms.ListBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.MarkButton = new System.Windows.Forms.Button();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.ContextComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.LogExpandButton = new System.Windows.Forms.Button();
            this.TimerGroup.SuspendLayout();
            this.MenuStrip.SuspendLayout();
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
            this.TimerGroup.Location = new System.Drawing.Point(12, 34);
            this.TimerGroup.Name = "TimerGroup";
            this.TimerGroup.Size = new System.Drawing.Size(278, 101);
            this.TimerGroup.TabIndex = 5;
            this.TimerGroup.TabStop = false;
            this.TimerGroup.Text = "Timer";
            // 
            // StartButton
            // 
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.Location = new System.Drawing.Point(144, 141);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(146, 54);
            this.StartButton.TabIndex = 6;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            // 
            // TodayButton
            // 
            this.TodayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TodayButton.Location = new System.Drawing.Point(12, 141);
            this.TodayButton.Name = "TodayButton";
            this.TodayButton.Size = new System.Drawing.Size(126, 26);
            this.TodayButton.TabIndex = 7;
            this.TodayButton.Text = "Today\'s work";
            this.TodayButton.UseVisualStyleBackColor = true;
            // 
            // StatsButton
            // 
            this.StatsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatsButton.Location = new System.Drawing.Point(12, 169);
            this.StatsButton.Name = "StatsButton";
            this.StatsButton.Size = new System.Drawing.Size(126, 26);
            this.StatsButton.TabIndex = 8;
            this.StatsButton.Text = "Total stats";
            this.StatsButton.UseVisualStyleBackColor = true;
            // 
            // DaysList
            // 
            this.DaysList.FormattingEnabled = true;
            this.DaysList.IntegralHeight = false;
            this.DaysList.Location = new System.Drawing.Point(307, 34);
            this.DaysList.Name = "DaysList";
            this.DaysList.Size = new System.Drawing.Size(127, 133);
            this.DaysList.TabIndex = 9;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(408, 173);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(26, 23);
            this.AddButton.TabIndex = 10;
            this.AddButton.Text = "+";
            this.AddButton.UseVisualStyleBackColor = true;
            // 
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(307, 173);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(22, 23);
            this.RefreshButton.TabIndex = 11;
            this.RefreshButton.Text = "R";
            this.RefreshButton.UseVisualStyleBackColor = true;
            // 
            // MarkButton
            // 
            this.MarkButton.Location = new System.Drawing.Point(376, 173);
            this.MarkButton.Name = "MarkButton";
            this.MarkButton.Size = new System.Drawing.Size(26, 23);
            this.MarkButton.TabIndex = 12;
            this.MarkButton.Text = "M";
            this.MarkButton.UseVisualStyleBackColor = true;
            // 
            // MenuStrip
            // 
            this.MenuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ContextComboBox});
            this.MenuStrip.Location = new System.Drawing.Point(5, 2);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(131, 27);
            this.MenuStrip.TabIndex = 13;
            // 
            // ContextComboBox
            // 
            this.ContextComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.ContextComboBox.Name = "ContextComboBox";
            this.ContextComboBox.Size = new System.Drawing.Size(121, 23);
            // 
            // LogExpandButton
            // 
            this.LogExpandButton.Location = new System.Drawing.Point(396, 3);
            this.LogExpandButton.Name = "LogExpandButton";
            this.LogExpandButton.Size = new System.Drawing.Size(38, 25);
            this.LogExpandButton.TabIndex = 14;
            this.LogExpandButton.Text = ">>";
            this.LogExpandButton.UseVisualStyleBackColor = true;
            // 
            // TimerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 214);
            this.Controls.Add(this.LogExpandButton);
            this.Controls.Add(this.MenuStrip);
            this.Controls.Add(this.MarkButton);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.DaysList);
            this.Controls.Add(this.StatsButton);
            this.Controls.Add(this.TodayButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.TimerGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "TimerForm";
            this.Text = "devtime";
            this.TimerGroup.ResumeLayout(false);
            this.TimerGroup.PerformLayout();
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label TimerMainLabel;
        private System.Windows.Forms.Label TimerSecondaryLabel;
        private System.Windows.Forms.GroupBox TimerGroup;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button TodayButton;
        private System.Windows.Forms.Button StatsButton;
        private System.Windows.Forms.ListBox DaysList;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Button MarkButton;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripComboBox ContextComboBox;
        private System.Windows.Forms.Button LogExpandButton;
    }
}

