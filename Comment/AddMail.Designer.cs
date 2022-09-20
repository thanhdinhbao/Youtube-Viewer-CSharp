namespace Comment
{
    partial class AddMail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddMail));
            this.btnMail1 = new System.Windows.Forms.Button();
            this.btnCheck1 = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMail1 = new System.Windows.Forms.TextBox();
            this.txtPass1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRecovery1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMail1
            // 
            this.btnMail1.BackColor = System.Drawing.Color.GreenYellow;
            this.btnMail1.Location = new System.Drawing.Point(17, 129);
            this.btnMail1.Name = "btnMail1";
            this.btnMail1.Size = new System.Drawing.Size(92, 39);
            this.btnMail1.TabIndex = 4;
            this.btnMail1.Text = "Thêm Mail";
            this.btnMail1.UseVisualStyleBackColor = false;
            this.btnMail1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCheck1
            // 
            this.btnCheck1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCheck1.Location = new System.Drawing.Point(133, 129);
            this.btnCheck1.Name = "btnCheck1";
            this.btnCheck1.Size = new System.Drawing.Size(92, 39);
            this.btnCheck1.TabIndex = 5;
            this.btnCheck1.Text = "Ktra đăng nhập";
            this.btnCheck1.UseVisualStyleBackColor = false;
            this.btnCheck1.Click += new System.EventHandler(this.btnCheck1_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancel.Location = new System.Drawing.Point(245, 129);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 39);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Hủy bỏ";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mail";
            // 
            // txtMail1
            // 
            this.txtMail1.Location = new System.Drawing.Point(115, 12);
            this.txtMail1.Name = "txtMail1";
            this.txtMail1.Size = new System.Drawing.Size(222, 20);
            this.txtMail1.TabIndex = 1;
            // 
            // txtPass1
            // 
            this.txtPass1.Location = new System.Drawing.Point(115, 49);
            this.txtPass1.Name = "txtPass1";
            this.txtPass1.PasswordChar = '*';
            this.txtPass1.Size = new System.Drawing.Size(222, 20);
            this.txtPass1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mật khẩu";
            // 
            // txtRecovery1
            // 
            this.txtRecovery1.Location = new System.Drawing.Point(115, 84);
            this.txtRecovery1.Name = "txtRecovery1";
            this.txtRecovery1.Size = new System.Drawing.Size(222, 20);
            this.txtRecovery1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mail kh.phục";
            // 
            // AddMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 179);
            this.Controls.Add(this.txtRecovery1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPass1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMail1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCheck1);
            this.Controls.Add(this.btnMail1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddMail";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thêm Gmail";
            this.Load += new System.EventHandler(this.AddMail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMail1;
        private System.Windows.Forms.Button btnCheck1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMail1;
        private System.Windows.Forms.TextBox txtPass1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRecovery1;
        private System.Windows.Forms.Label label3;
    }
}