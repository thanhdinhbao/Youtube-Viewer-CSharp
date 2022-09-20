namespace Comment
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btnExit = new System.Windows.Forms.Button();
            this.btnInputEmail = new System.Windows.Forms.Button();
            this.btnCoder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.Info;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(14, 159);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(241, 45);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnInputEmail
            // 
            this.btnInputEmail.BackColor = System.Drawing.SystemColors.Info;
            this.btnInputEmail.Location = new System.Drawing.Point(12, 27);
            this.btnInputEmail.Name = "btnInputEmail";
            this.btnInputEmail.Size = new System.Drawing.Size(241, 45);
            this.btnInputEmail.TabIndex = 1;
            this.btnInputEmail.Text = "Chạy";
            this.btnInputEmail.UseVisualStyleBackColor = false;
            this.btnInputEmail.Click += new System.EventHandler(this.btnInputEmail_Click);
            // 
            // btnCoder
            // 
            this.btnCoder.BackColor = System.Drawing.SystemColors.Info;
            this.btnCoder.Location = new System.Drawing.Point(12, 91);
            this.btnCoder.Name = "btnCoder";
            this.btnCoder.Size = new System.Drawing.Size(241, 45);
            this.btnCoder.TabIndex = 2;
            this.btnCoder.Text = "Tác giả";
            this.btnCoder.UseVisualStyleBackColor = false;
            this.btnCoder.Click += new System.EventHandler(this.btnCoder_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(267, 228);
            this.Controls.Add(this.btnCoder);
            this.Controls.Add(this.btnInputEmail);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TGT Tool v1.0";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnInputEmail;
        private System.Windows.Forms.Button btnCoder;
    }
}

