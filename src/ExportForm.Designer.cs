namespace devtime
{
    partial class ExportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExportForm));
            this.ProgressGroup = new System.Windows.Forms.GroupBox();
            this.Progress = new System.Windows.Forms.ProgressBar();
            this.ProgressGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProgressGroup
            // 
            this.ProgressGroup.Controls.Add(this.Progress);
            this.ProgressGroup.Location = new System.Drawing.Point(12, 12);
            this.ProgressGroup.Name = "ProgressGroup";
            this.ProgressGroup.Size = new System.Drawing.Size(219, 51);
            this.ProgressGroup.TabIndex = 0;
            this.ProgressGroup.TabStop = false;
            this.ProgressGroup.Text = "Exporting data";
            // 
            // Progress
            // 
            this.Progress.Location = new System.Drawing.Point(6, 19);
            this.Progress.Name = "Progress";
            this.Progress.Size = new System.Drawing.Size(207, 23);
            this.Progress.TabIndex = 0;
            // 
            // ExportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 71);
            this.Controls.Add(this.ProgressGroup);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ExportForm";
            this.Text = "Exporting...";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ExportForm_FormClosing);
            this.Shown += new System.EventHandler(this.ExportForm_Shown);
            this.ProgressGroup.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ProgressGroup;
        private System.Windows.Forms.ProgressBar Progress;
    }
}