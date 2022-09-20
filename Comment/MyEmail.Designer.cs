namespace Comment
{
    partial class MyEmail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyEmail));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recoveryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mailToolDataSet = new Comment.MailToolDataSet();
            this.mailTableAdapter = new Comment.MailToolDataSetTableAdapters.MailTableAdapter();
            this.btnAddMail = new System.Windows.Forms.Button();
            this.btnCheckMail = new System.Windows.Forms.Button();
            this.btnDelMail = new System.Windows.Forms.Button();
            this.mailBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnEditMail = new System.Windows.Forms.Button();
            this.btnDeXuat = new System.Windows.Forms.Button();
            this.btnSearchVideo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mailToolDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mailBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.mailDataGridViewTextBoxColumn,
            this.passDataGridViewTextBoxColumn,
            this.recoveryDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.mailBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(896, 372);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.FillWeight = 200F;
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.iDDataGridViewTextBoxColumn.Width = 165;
            // 
            // mailDataGridViewTextBoxColumn
            // 
            this.mailDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mailDataGridViewTextBoxColumn.DataPropertyName = "Mail";
            this.mailDataGridViewTextBoxColumn.HeaderText = "Mail";
            this.mailDataGridViewTextBoxColumn.Name = "mailDataGridViewTextBoxColumn";
            this.mailDataGridViewTextBoxColumn.ReadOnly = true;
            this.mailDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // passDataGridViewTextBoxColumn
            // 
            this.passDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.passDataGridViewTextBoxColumn.DataPropertyName = "Pass";
            this.passDataGridViewTextBoxColumn.HeaderText = "Mật khẩu";
            this.passDataGridViewTextBoxColumn.Name = "passDataGridViewTextBoxColumn";
            this.passDataGridViewTextBoxColumn.ReadOnly = true;
            this.passDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // recoveryDataGridViewTextBoxColumn
            // 
            this.recoveryDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.recoveryDataGridViewTextBoxColumn.DataPropertyName = "Recovery";
            this.recoveryDataGridViewTextBoxColumn.HeaderText = "Mail khôi phục";
            this.recoveryDataGridViewTextBoxColumn.Name = "recoveryDataGridViewTextBoxColumn";
            this.recoveryDataGridViewTextBoxColumn.ReadOnly = true;
            this.recoveryDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // mailBindingSource
            // 
            this.mailBindingSource.DataMember = "Mail";
            this.mailBindingSource.DataSource = this.mailToolDataSet;
            // 
            // mailToolDataSet
            // 
            this.mailToolDataSet.DataSetName = "MailToolDataSet";
            this.mailToolDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mailTableAdapter
            // 
            this.mailTableAdapter.ClearBeforeFill = true;
            // 
            // btnAddMail
            // 
            this.btnAddMail.BackColor = System.Drawing.Color.Violet;
            this.btnAddMail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddMail.Location = new System.Drawing.Point(20, 379);
            this.btnAddMail.Name = "btnAddMail";
            this.btnAddMail.Size = new System.Drawing.Size(105, 49);
            this.btnAddMail.TabIndex = 1;
            this.btnAddMail.Text = "Thêm Mail";
            this.btnAddMail.UseVisualStyleBackColor = false;
            this.btnAddMail.Click += new System.EventHandler(this.btnAddMail_Click);
            // 
            // btnCheckMail
            // 
            this.btnCheckMail.BackColor = System.Drawing.Color.YellowGreen;
            this.btnCheckMail.Location = new System.Drawing.Point(662, 379);
            this.btnCheckMail.Name = "btnCheckMail";
            this.btnCheckMail.Size = new System.Drawing.Size(105, 49);
            this.btnCheckMail.TabIndex = 5;
            this.btnCheckMail.Text = "Ktra đăng nhập";
            this.btnCheckMail.UseVisualStyleBackColor = false;
            this.btnCheckMail.Click += new System.EventHandler(this.btnCheckMail_Click);
            // 
            // btnDelMail
            // 
            this.btnDelMail.BackColor = System.Drawing.Color.Coral;
            this.btnDelMail.Location = new System.Drawing.Point(787, 379);
            this.btnDelMail.Name = "btnDelMail";
            this.btnDelMail.Size = new System.Drawing.Size(105, 49);
            this.btnDelMail.TabIndex = 6;
            this.btnDelMail.Text = "Xóa Mail";
            this.btnDelMail.UseVisualStyleBackColor = false;
            this.btnDelMail.Click += new System.EventHandler(this.btnDelMail_Click);
            // 
            // mailBindingSource1
            // 
            this.mailBindingSource1.DataMember = "Mail";
            this.mailBindingSource1.DataSource = this.mailToolDataSet;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogin.Location = new System.Drawing.Point(289, 379);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(105, 49);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Comment video";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnEditMail
            // 
            this.btnEditMail.BackColor = System.Drawing.Color.Gold;
            this.btnEditMail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditMail.Enabled = false;
            this.btnEditMail.Location = new System.Drawing.Point(150, 379);
            this.btnEditMail.Name = "btnEditMail";
            this.btnEditMail.Size = new System.Drawing.Size(105, 49);
            this.btnEditMail.TabIndex = 2;
            this.btnEditMail.Text = "Sửa Mail";
            this.btnEditMail.UseVisualStyleBackColor = false;
            this.btnEditMail.Click += new System.EventHandler(this.btnEditMail_Click);
            // 
            // btnDeXuat
            // 
            this.btnDeXuat.BackColor = System.Drawing.Color.Silver;
            this.btnDeXuat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeXuat.Location = new System.Drawing.Point(421, 379);
            this.btnDeXuat.Name = "btnDeXuat";
            this.btnDeXuat.Size = new System.Drawing.Size(105, 49);
            this.btnDeXuat.TabIndex = 4;
            this.btnDeXuat.Text = "Tăng click vào hình thu nhỏ";
            this.btnDeXuat.UseVisualStyleBackColor = false;
            this.btnDeXuat.Click += new System.EventHandler(this.btnDeXuat_Click);
            // 
            // btnSearchVideo
            // 
            this.btnSearchVideo.BackColor = System.Drawing.Color.Chocolate;
            this.btnSearchVideo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchVideo.Location = new System.Drawing.Point(542, 379);
            this.btnSearchVideo.Name = "btnSearchVideo";
            this.btnSearchVideo.Size = new System.Drawing.Size(105, 49);
            this.btnSearchVideo.TabIndex = 7;
            this.btnSearchVideo.Text = "Tìm kiếm video";
            this.btnSearchVideo.UseVisualStyleBackColor = false;
            this.btnSearchVideo.Click += new System.EventHandler(this.btnSearchVideo_Click);
            // 
            // MyEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(899, 432);
            this.Controls.Add(this.btnSearchVideo);
            this.Controls.Add(this.btnDeXuat);
            this.Controls.Add(this.btnEditMail);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnDelMail);
            this.Controls.Add(this.btnCheckMail);
            this.Controls.Add(this.btnAddMail);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MyEmail";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "My Email";
            this.Load += new System.EventHandler(this.AddMail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mailToolDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mailBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MailToolDataSet mailToolDataSet;
        private System.Windows.Forms.BindingSource mailBindingSource;
        private MailToolDataSetTableAdapters.MailTableAdapter mailTableAdapter;
        private System.Windows.Forms.Button btnAddMail;
        private System.Windows.Forms.Button btnCheckMail;
        private System.Windows.Forms.Button btnDelMail;
        private System.Windows.Forms.BindingSource mailBindingSource1;
        private System.Windows.Forms.Button btnLogin;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnEditMail;
        private System.Windows.Forms.Button btnDeXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recoveryDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnSearchVideo;
    }
}