namespace devtime
{
    partial class AddContextForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddContextForm));
            this.ContextGroup = new System.Windows.Forms.GroupBox();
            this.ContextTextBox = new System.Windows.Forms.TextBox();
            this.OkDialogButton = new System.Windows.Forms.Button();
            this.CancelDialogButton = new System.Windows.Forms.Button();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ContextGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // ContextGroup
            // 
            this.ContextGroup.Controls.Add(this.ContextTextBox);
            this.ContextGroup.Location = new System.Drawing.Point(12, 12);
            this.ContextGroup.Name = "ContextGroup";
            this.ContextGroup.Size = new System.Drawing.Size(241, 47);
            this.ContextGroup.TabIndex = 0;
            this.ContextGroup.TabStop = false;
            this.ContextGroup.Text = "Project name";
            this.ToolTip.SetToolTip(this.ContextGroup, "Name must only include a-z, A-Z, 0-9, _ , and cannot start with a digit");
            // 
            // ContextTextBox
            // 
            this.ContextTextBox.Location = new System.Drawing.Point(6, 19);
            this.ContextTextBox.MaxLength = 255;
            this.ContextTextBox.Name = "ContextTextBox";
            this.ContextTextBox.Size = new System.Drawing.Size(229, 20);
            this.ContextTextBox.TabIndex = 0;
            this.ToolTip.SetToolTip(this.ContextTextBox, "Name must only include a-z, A-Z, 0-9, _ , and cannot start with a digit");
            // 
            // OkDialogButton
            // 
            this.OkDialogButton.Location = new System.Drawing.Point(179, 65);
            this.OkDialogButton.Name = "OkDialogButton";
            this.OkDialogButton.Size = new System.Drawing.Size(75, 23);
            this.OkDialogButton.TabIndex = 1;
            this.OkDialogButton.Text = "OK";
            this.OkDialogButton.UseVisualStyleBackColor = true;
            this.OkDialogButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // CancelDialogButton
            // 
            this.CancelDialogButton.Location = new System.Drawing.Point(98, 65);
            this.CancelDialogButton.Name = "CancelDialogButton";
            this.CancelDialogButton.Size = new System.Drawing.Size(75, 23);
            this.CancelDialogButton.TabIndex = 2;
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
            // AddContextForm
            // 
            this.AcceptButton = this.OkDialogButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 98);
            this.Controls.Add(this.CancelDialogButton);
            this.Controls.Add(this.OkDialogButton);
            this.Controls.Add(this.ContextGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddContextForm";
            this.Text = "Add project";
            this.ContextGroup.ResumeLayout(false);
            this.ContextGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ContextGroup;
        private System.Windows.Forms.Button OkDialogButton;
        private System.Windows.Forms.Button CancelDialogButton;
        private System.Windows.Forms.TextBox ContextTextBox;
        private System.Windows.Forms.ToolTip ToolTip;
    }
}