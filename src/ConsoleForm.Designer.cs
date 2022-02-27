
namespace devtime
{
    partial class ConsoleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsoleForm));
            this.CommandInput = new System.Windows.Forms.TextBox();
            this.InputButton = new System.Windows.Forms.Button();
            this.CommandOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CommandInput
            // 
            this.CommandInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CommandInput.BackColor = System.Drawing.Color.Black;
            this.CommandInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CommandInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CommandInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CommandInput.Location = new System.Drawing.Point(1, 207);
            this.CommandInput.Name = "CommandInput";
            this.CommandInput.Size = new System.Drawing.Size(460, 21);
            this.CommandInput.TabIndex = 0;
            this.CommandInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CommandInput_KeyDown);
            // 
            // InputButton
            // 
            this.InputButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.InputButton.Location = new System.Drawing.Point(462, 207);
            this.InputButton.Name = "InputButton";
            this.InputButton.Size = new System.Drawing.Size(48, 21);
            this.InputButton.TabIndex = 1;
            this.InputButton.Text = ">>";
            this.InputButton.UseVisualStyleBackColor = true;
            this.InputButton.Click += new System.EventHandler(this.InputButton_Click);
            // 
            // CommandOutput
            // 
            this.CommandOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CommandOutput.BackColor = System.Drawing.Color.Black;
            this.CommandOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CommandOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CommandOutput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CommandOutput.Location = new System.Drawing.Point(0, 0);
            this.CommandOutput.Multiline = true;
            this.CommandOutput.Name = "CommandOutput";
            this.CommandOutput.ReadOnly = true;
            this.CommandOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.CommandOutput.Size = new System.Drawing.Size(511, 206);
            this.CommandOutput.TabIndex = 2;
            this.CommandOutput.Text = "SQLite 3 Console\r\n\r\nEnter a valid SQLite 3 query to execute it.\r\nType \'tables\' to" +
    " list all tables.\r\n\r\n";
            // 
            // ConsoleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(511, 229);
            this.Controls.Add(this.CommandOutput);
            this.Controls.Add(this.InputButton);
            this.Controls.Add(this.CommandInput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(350, 178);
            this.Name = "ConsoleForm";
            this.Text = "SQLite3 Console - devtime";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CommandInput;
        private System.Windows.Forms.Button InputButton;
        private System.Windows.Forms.TextBox CommandOutput;
    }
}