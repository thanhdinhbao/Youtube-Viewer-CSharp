namespace Comment
{
    partial class CommentVideo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CommentVideo));
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCmt = new System.Windows.Forms.TextBox();
            this.txtLink = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnBatDau = new System.Windows.Forms.Button();
            this.txtMail1 = new System.Windows.Forms.TextBox();
            this.txtPass1 = new System.Windows.Forms.TextBox();
            this.txtRecovery1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCheckVideo = new System.Windows.Forms.Button();
            this.lblChannelName = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CbLike = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.CbSub = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numMaxTime = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numMinTime = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numThread = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtTotalSub = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtView = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.CbMute = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.pbRun = new System.Windows.Forms.ToolStripProgressBar();
            this.timeView = new System.Windows.Forms.ToolStripStatusLabel();
            this.tmRun = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinTime)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numThread)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(218, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Link video";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(218, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Comment";
            // 
            // txtCmt
            // 
            this.txtCmt.ForeColor = System.Drawing.Color.Brown;
            this.txtCmt.Location = new System.Drawing.Point(280, 90);
            this.txtCmt.MaxLength = 120;
            this.txtCmt.Name = "txtCmt";
            this.txtCmt.Size = new System.Drawing.Size(237, 20);
            this.txtCmt.TabIndex = 3;
            // 
            // txtLink
            // 
            this.txtLink.ForeColor = System.Drawing.Color.Brown;
            this.txtLink.Location = new System.Drawing.Point(280, 50);
            this.txtLink.MaxLength = 20;
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(237, 20);
            this.txtLink.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(262, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Thêm video để comment";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancel.Location = new System.Drawing.Point(417, 301);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 37);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnBatDau
            // 
            this.btnBatDau.BackColor = System.Drawing.Color.YellowGreen;
            this.btnBatDau.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBatDau.Location = new System.Drawing.Point(248, 301);
            this.btnBatDau.Name = "btnBatDau";
            this.btnBatDau.Size = new System.Drawing.Size(100, 37);
            this.btnBatDau.TabIndex = 7;
            this.btnBatDau.Text = "Chạy";
            this.btnBatDau.UseVisualStyleBackColor = false;
            this.btnBatDau.Click += new System.EventHandler(this.btnBatDau_Click);
            // 
            // txtMail1
            // 
            this.txtMail1.Location = new System.Drawing.Point(599, 46);
            this.txtMail1.Name = "txtMail1";
            this.txtMail1.Size = new System.Drawing.Size(100, 20);
            this.txtMail1.TabIndex = 18;
            // 
            // txtPass1
            // 
            this.txtPass1.Location = new System.Drawing.Point(599, 89);
            this.txtPass1.Name = "txtPass1";
            this.txtPass1.Size = new System.Drawing.Size(100, 20);
            this.txtPass1.TabIndex = 19;
            // 
            // txtRecovery1
            // 
            this.txtRecovery1.Location = new System.Drawing.Point(599, 135);
            this.txtRecovery1.Name = "txtRecovery1";
            this.txtRecovery1.Size = new System.Drawing.Size(100, 20);
            this.txtRecovery1.TabIndex = 20;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 166);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // btnCheckVideo
            // 
            this.btnCheckVideo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCheckVideo.Location = new System.Drawing.Point(61, 301);
            this.btnCheckVideo.Name = "btnCheckVideo";
            this.btnCheckVideo.Size = new System.Drawing.Size(107, 37);
            this.btnCheckVideo.TabIndex = 2;
            this.btnCheckVideo.Text = "Check video";
            this.btnCheckVideo.UseVisualStyleBackColor = false;
            this.btnCheckVideo.Click += new System.EventHandler(this.btnCheckVideo_Click);
            // 
            // lblChannelName
            // 
            this.lblChannelName.AutoSize = true;
            this.lblChannelName.ForeColor = System.Drawing.Color.Maroon;
            this.lblChannelName.Location = new System.Drawing.Point(94, 192);
            this.lblChannelName.Name = "lblChannelName";
            this.lblChannelName.Size = new System.Drawing.Size(0, 13);
            this.lblChannelName.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Location = new System.Drawing.Point(35, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 37;
            this.label7.Text = "Tên kênh:";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(208, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 97);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Link video";
            // 
            // CbLike
            // 
            this.CbLike.AutoSize = true;
            this.CbLike.ForeColor = System.Drawing.Color.Red;
            this.CbLike.Location = new System.Drawing.Point(268, 44);
            this.CbLike.Name = "CbLike";
            this.CbLike.Size = new System.Drawing.Size(15, 14);
            this.CbLike.TabIndex = 62;
            this.CbLike.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label10.Location = new System.Drawing.Point(232, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 63;
            this.label10.Text = "Like:";
            // 
            // CbSub
            // 
            this.CbSub.AutoSize = true;
            this.CbSub.ForeColor = System.Drawing.Color.Red;
            this.CbSub.Location = new System.Drawing.Point(281, 188);
            this.CbSub.Name = "CbSub";
            this.CbSub.Size = new System.Drawing.Size(15, 14);
            this.CbSub.TabIndex = 52;
            this.CbSub.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(219, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 57;
            this.label6.Text = "Đăng kí: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(171, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 20);
            this.label2.TabIndex = 56;
            this.label2.Text = "-";
            // 
            // numMaxTime
            // 
            this.numMaxTime.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numMaxTime.Location = new System.Drawing.Point(201, 65);
            this.numMaxTime.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numMaxTime.Name = "numMaxTime";
            this.numMaxTime.Size = new System.Drawing.Size(82, 20);
            this.numMaxTime.TabIndex = 54;
            this.numMaxTime.Value = new decimal(new int[] {
            120,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(217, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 55;
            this.label4.Text = "Delay";
            // 
            // numMinTime
            // 
            this.numMinTime.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numMinTime.Location = new System.Drawing.Point(73, 64);
            this.numMinTime.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.numMinTime.Name = "numMinTime";
            this.numMinTime.Size = new System.Drawing.Size(82, 20);
            this.numMinTime.TabIndex = 53;
            this.numMinTime.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numThread);
            this.groupBox2.Controls.Add(this.numMinTime);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.numMaxTime);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.CbLike);
            this.groupBox2.Location = new System.Drawing.Point(208, 144);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(327, 151);
            this.groupBox2.TabIndex = 64;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // numThread
            // 
            this.numThread.Location = new System.Drawing.Point(73, 14);
            this.numThread.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numThread.Name = "numThread";
            this.numThread.Size = new System.Drawing.Size(36, 20);
            this.numThread.TabIndex = 49;
            this.numThread.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtTotalSub);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Location = new System.Drawing.Point(12, 172);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(182, 123);
            this.groupBox3.TabIndex = 65;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin";
            // 
            // txtTotalSub
            // 
            this.txtTotalSub.ForeColor = System.Drawing.Color.Brown;
            this.txtTotalSub.Location = new System.Drawing.Point(88, 94);
            this.txtTotalSub.Name = "txtTotalSub";
            this.txtTotalSub.ReadOnly = true;
            this.txtTotalSub.Size = new System.Drawing.Size(49, 20);
            this.txtTotalSub.TabIndex = 71;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label13.Location = new System.Drawing.Point(46, 98);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 13);
            this.label13.TabIndex = 71;
            this.label13.Text = "Sub:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label11.Location = new System.Drawing.Point(222, 160);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 50;
            this.label11.Text = "Số tab:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label8.Location = new System.Drawing.Point(58, 216);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 58;
            this.label8.Text = "View:";
            // 
            // txtView
            // 
            this.txtView.ForeColor = System.Drawing.Color.Brown;
            this.txtView.Location = new System.Drawing.Point(100, 213);
            this.txtView.Name = "txtView";
            this.txtView.ReadOnly = true;
            this.txtView.Size = new System.Drawing.Size(49, 20);
            this.txtView.TabIndex = 59;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label9.Location = new System.Drawing.Point(58, 243);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 60;
            this.label9.Text = "Time:";
            // 
            // txtTime
            // 
            this.txtTime.ForeColor = System.Drawing.Color.Brown;
            this.txtTime.Location = new System.Drawing.Point(100, 240);
            this.txtTime.Name = "txtTime";
            this.txtTime.ReadOnly = true;
            this.txtTime.Size = new System.Drawing.Size(49, 20);
            this.txtTime.TabIndex = 61;
            // 
            // CbMute
            // 
            this.CbMute.AutoSize = true;
            this.CbMute.ForeColor = System.Drawing.Color.Red;
            this.CbMute.Location = new System.Drawing.Point(281, 247);
            this.CbMute.Name = "CbMute";
            this.CbMute.Size = new System.Drawing.Size(15, 14);
            this.CbMute.TabIndex = 66;
            this.CbMute.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label12.Location = new System.Drawing.Point(219, 247);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 13);
            this.label12.TabIndex = 67;
            this.label12.Text = "Mute:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus,
            this.pbRun,
            this.timeView});
            this.statusStrip1.Location = new System.Drawing.Point(0, 345);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(578, 22);
            this.statusStrip1.TabIndex = 70;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(66, 17);
            this.lblStatus.Text = "Trạng thái";
            // 
            // pbRun
            // 
            this.pbRun.Name = "pbRun";
            this.pbRun.Size = new System.Drawing.Size(100, 16);
            this.pbRun.Step = 1;
            // 
            // timeView
            // 
            this.timeView.Name = "timeView";
            this.timeView.Size = new System.Drawing.Size(13, 17);
            this.timeView.Text = "0";
            // 
            // tmRun
            // 
            this.tmRun.Interval = 1000;
            this.tmRun.Tick += new System.EventHandler(this.tmRun_Tick);
            // 
            // CommentVideo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 367);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.CbMute);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtView);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CbSub);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblChannelName);
            this.Controls.Add(this.btnCheckVideo);
            this.Controls.Add(this.txtRecovery1);
            this.Controls.Add(this.txtPass1);
            this.Controls.Add(this.txtMail1);
            this.Controls.Add(this.btnBatDau);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtLink);
            this.Controls.Add(this.txtCmt);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CommentVideo";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Comment video";
            this.Load += new System.EventHandler(this.AddVideo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinTime)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numThread)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtCmt;
        public System.Windows.Forms.TextBox txtLink;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnBatDau;
        public System.Windows.Forms.TextBox txtMail1;
        public System.Windows.Forms.TextBox txtPass1;
        public System.Windows.Forms.TextBox txtRecovery1;
        private System.Windows.Forms.Button btnCheckVideo;
        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblChannelName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox CbLike;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox CbSub;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.NumericUpDown numMaxTime;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.NumericUpDown numMinTime;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtView;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTime;
        public System.Windows.Forms.NumericUpDown numThread;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox CbMute;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ToolStripProgressBar pbRun;
        public System.Windows.Forms.ToolStripStatusLabel timeView;
        private System.Windows.Forms.Timer tmRun;
        private System.Windows.Forms.TextBox txtTotalSub;
        private System.Windows.Forms.Label label13;
    }
}