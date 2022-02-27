namespace devtime
{
    partial class LogWorkForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogWorkForm));
            this.LogGroup = new System.Windows.Forms.GroupBox();
            this.LogTextBox = new System.Windows.Forms.TextBox();
            this.OkDialogButton = new System.Windows.Forms.Button();
            this.CancelDialogButton = new System.Windows.Forms.Button();
            this.LogGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // LogGroup
            // 
            this.LogGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogGroup.Controls.Add(this.LogTextBox);
            this.LogGroup.Location = new System.Drawing.Point(12, 12);
            this.LogGroup.Name = "LogGroup";
            this.LogGroup.Size = new System.Drawing.Size(244, 140);
            this.LogGroup.TabIndex = 0;
            this.LogGroup.TabStop = false;
            this.LogGroup.Text = "What did you do today?";
            // 
            // LogTextBox
            // 
            this.LogTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogTextBox.Location = new System.Drawing.Point(6, 19);
            this.LogTextBox.Multiline = true;
            this.LogTextBox.Name = "LogTextBox";
            this.LogTextBox.Size = new System.Drawing.Size(232, 115);
            this.LogTextBox.TabIndex = 0;
            // 
            // OkDialogButton
            // 
            this.OkDialogButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OkDialogButton.Location = new System.Drawing.Point(182, 155);
            this.OkDialogButton.Name = "OkDialogButton";
            this.OkDialogButton.Size = new System.Drawing.Size(75, 23);
            this.OkDialogButton.TabIndex = 1;
            this.OkDialogButton.Text = "OK";
            this.OkDialogButton.UseVisualStyleBackColor = true;
            this.OkDialogButton.Click += new System.EventHandler(this.OkDialogButton_Click);
            // 
            // CancelDialogButton
            // 
            this.CancelDialogButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelDialogButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelDialogButton.Location = new System.Drawing.Point(101, 155);
            this.CancelDialogButton.Name = "CancelDialogButton";
            this.CancelDialogButton.Size = new System.Drawing.Size(75, 23);
            this.CancelDialogButton.TabIndex = 2;
            this.CancelDialogButton.Text = "Cancel";
            this.CancelDialogButton.UseVisualStyleBackColor = true;
            this.CancelDialogButton.Click += new System.EventHandler(this.CancelDialogButton_Click);
            // 
            // LogWorkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 190);
            this.Controls.Add(this.CancelDialogButton);
            this.Controls.Add(this.OkDialogButton);
            this.Controls.Add(this.LogGroup);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(284, 229);
            this.Name = "LogWorkForm";
            this.Text = "Log work";
            this.LogGroup.ResumeLayout(false);
            this.LogGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox LogGroup;
        private System.Windows.Forms.Button OkDialogButton;
        private System.Windows.Forms.Button CancelDialogButton;
        private System.Windows.Forms.TextBox LogTextBox;
    }
}