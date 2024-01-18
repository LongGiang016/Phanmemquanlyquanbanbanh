namespace QuanLyCuaHangBanBanh
{
    partial class frmBan
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
            this.dgvBan = new System.Windows.Forms.DataGridView();
            this.colMaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnReSet = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSuaBan = new System.Windows.Forms.Button();
            this.btnThemBan = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radCoKhach = new System.Windows.Forms.RadioButton();
            this.radTrong = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaBan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenBan = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBan)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBan
            // 
            this.dgvBan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBan.BackgroundColor = System.Drawing.Color.White;
            this.dgvBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaBan,
            this.colTenBan,
            this.colTrangThai});
            this.dgvBan.Location = new System.Drawing.Point(4, 445);
            this.dgvBan.Name = "dgvBan";
            this.dgvBan.RowHeadersWidth = 62;
            this.dgvBan.RowTemplate.Height = 28;
            this.dgvBan.Size = new System.Drawing.Size(1574, 434);
            this.dgvBan.TabIndex = 0;
            this.dgvBan.SelectionChanged += new System.EventHandler(this.dgvBan_SelectionChanged);
            // 
            // colMaBan
            // 
            this.colMaBan.DataPropertyName = "MABAN";
            this.colMaBan.HeaderText = "Mã bàn";
            this.colMaBan.MinimumWidth = 8;
            this.colMaBan.Name = "colMaBan";
            // 
            // colTenBan
            // 
            this.colTenBan.DataPropertyName = "TENBAN";
            this.colTenBan.HeaderText = "Tên bàn";
            this.colTenBan.MinimumWidth = 8;
            this.colTenBan.Name = "colTenBan";
            // 
            // colTrangThai
            // 
            this.colTrangThai.DataPropertyName = "TRANGTHAI";
            this.colTrangThai.HeaderText = "Trạng thái";
            this.colTrangThai.MinimumWidth = 8;
            this.colTrangThai.Name = "colTrangThai";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.btnTimKiem);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMaBan);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtTenBan);
            this.groupBox1.Location = new System.Drawing.Point(4, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1574, 358);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnReSet);
            this.groupBox3.Controls.Add(this.btnXoa);
            this.groupBox3.Controls.Add(this.btnSuaBan);
            this.groupBox3.Controls.Add(this.btnThemBan);
            this.groupBox3.Location = new System.Drawing.Point(689, 38);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(767, 167);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // btnReSet
            // 
            this.btnReSet.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnReSet.BackgroundImage = global::QuanLyCuaHangBanBanh.Properties.Resources.reset;
            this.btnReSet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnReSet.Location = new System.Drawing.Point(657, 40);
            this.btnReSet.Name = "btnReSet";
            this.btnReSet.Size = new System.Drawing.Size(95, 88);
            this.btnReSet.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnReSet, "Làm mới");
            this.btnReSet.UseVisualStyleBackColor = false;
            this.btnReSet.Click += new System.EventHandler(this.btnReSet_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnXoa.BackgroundImage = global::QuanLyCuaHangBanBanh.Properties.Resources.delete2;
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnXoa.Location = new System.Drawing.Point(457, 40);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(95, 88);
            this.btnXoa.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnXoa, "Xóa bàn");
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSuaBan
            // 
            this.btnSuaBan.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSuaBan.BackgroundImage = global::QuanLyCuaHangBanBanh.Properties.Resources.writing;
            this.btnSuaBan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSuaBan.Location = new System.Drawing.Point(252, 40);
            this.btnSuaBan.Name = "btnSuaBan";
            this.btnSuaBan.Size = new System.Drawing.Size(95, 88);
            this.btnSuaBan.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btnSuaBan, "Sửa bàn");
            this.btnSuaBan.UseVisualStyleBackColor = false;
            this.btnSuaBan.Click += new System.EventHandler(this.btnSuaBan_Click);
            // 
            // btnThemBan
            // 
            this.btnThemBan.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnThemBan.BackgroundImage = global::QuanLyCuaHangBanBanh.Properties.Resources.addtable;
            this.btnThemBan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnThemBan.Location = new System.Drawing.Point(28, 40);
            this.btnThemBan.Name = "btnThemBan";
            this.btnThemBan.Size = new System.Drawing.Size(95, 88);
            this.btnThemBan.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnThemBan, "Thêm bàn");
            this.btnThemBan.UseVisualStyleBackColor = false;
            this.btnThemBan.Click += new System.EventHandler(this.btnThemBan_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTimKiem.BackgroundImage = global::QuanLyCuaHangBanBanh.Properties.Resources.search;
            this.btnTimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTimKiem.Location = new System.Drawing.Point(561, 114);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(53, 37);
            this.btnTimKiem.TabIndex = 1;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radCoKhach);
            this.groupBox2.Controls.Add(this.radTrong);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(38, 217);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(320, 100);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Trạng thái";
            // 
            // radCoKhach
            // 
            this.radCoKhach.AutoSize = true;
            this.radCoKhach.Enabled = false;
            this.radCoKhach.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.radCoKhach.Location = new System.Drawing.Point(170, 40);
            this.radCoKhach.Name = "radCoKhach";
            this.radCoKhach.Size = new System.Drawing.Size(122, 26);
            this.radCoKhach.TabIndex = 18;
            this.radCoKhach.Text = "Có khách";
            this.radCoKhach.UseVisualStyleBackColor = true;
            // 
            // radTrong
            // 
            this.radTrong.AutoSize = true;
            this.radTrong.Checked = true;
            this.radTrong.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.radTrong.Location = new System.Drawing.Point(16, 40);
            this.radTrong.Name = "radTrong";
            this.radTrong.Size = new System.Drawing.Size(83, 26);
            this.radTrong.TabIndex = 17;
            this.radTrong.TabStop = true;
            this.radTrong.Text = "Trống";
            this.radTrong.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(50, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 22);
            this.label2.TabIndex = 13;
            this.label2.Text = "Mã bàn:";
            // 
            // txtMaBan
            // 
            this.txtMaBan.BackColor = System.Drawing.Color.White;
            this.txtMaBan.Enabled = false;
            this.txtMaBan.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtMaBan.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtMaBan.Location = new System.Drawing.Point(140, 47);
            this.txtMaBan.Name = "txtMaBan";
            this.txtMaBan.Size = new System.Drawing.Size(415, 37);
            this.txtMaBan.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(50, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 22);
            this.label1.TabIndex = 11;
            this.label1.Text = "Tên bàn:";
            // 
            // txtTenBan
            // 
            this.txtTenBan.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtTenBan.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtTenBan.Location = new System.Drawing.Point(140, 114);
            this.txtTenBan.Name = "txtTenBan";
            this.txtTenBan.Size = new System.Drawing.Size(415, 37);
            this.txtTenBan.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Location = new System.Drawing.Point(4, -1);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(342, 67);
            this.groupBox4.TabIndex = 23;
            this.groupBox4.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(119)))), ((int)(((byte)(18)))));
            this.label3.Location = new System.Drawing.Point(38, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(247, 33);
            this.label3.TabIndex = 1;
            this.label3.Text = "SWEET AND HAPPY ";
            // 
            // frmBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1602, 909);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvBan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frmBan";
            this.Text = "frmBan";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmBan_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBan)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaBan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenBan;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radCoKhach;
        private System.Windows.Forms.RadioButton radTrong;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnReSet;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSuaBan;
        private System.Windows.Forms.Button btnThemBan;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}