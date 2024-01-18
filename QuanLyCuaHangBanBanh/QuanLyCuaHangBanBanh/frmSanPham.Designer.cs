namespace QuanLyCuaHangBanBanh
{
    partial class frmSanPham
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
            this.lblTenSanPham = new System.Windows.Forms.Label();
            this.txtTenSanPham = new System.Windows.Forms.TextBox();
            this.lblMaDanhMuc = new System.Windows.Forms.Label();
            this.lblMaSanPham = new System.Windows.Forms.Label();
            this.txtMaSanPham = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nmSoLuong = new System.Windows.Forms.NumericUpDown();
            this.btnTimKiemMaDanhMuc = new System.Windows.Forms.Button();
            this.btnTKMaSP = new System.Windows.Forms.Button();
            this.btnTimKiemTenSP = new System.Windows.Forms.Button();
            this.cbbDanhMucSanPham = new System.Windows.Forms.ComboBox();
            this.lblMoTa = new System.Windows.Forms.Label();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.ptrSanPham = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.colTenSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenDanhMuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHinhAnh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaDanhMuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptrSanPham)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTenSanPham
            // 
            this.lblTenSanPham.AutoSize = true;
            this.lblTenSanPham.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenSanPham.Location = new System.Drawing.Point(237, 128);
            this.lblTenSanPham.Name = "lblTenSanPham";
            this.lblTenSanPham.Size = new System.Drawing.Size(137, 22);
            this.lblTenSanPham.TabIndex = 10;
            this.lblTenSanPham.Text = "Tên sản phẩm:";
            // 
            // txtTenSanPham
            // 
            this.txtTenSanPham.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtTenSanPham.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtTenSanPham.Location = new System.Drawing.Point(377, 125);
            this.txtTenSanPham.Name = "txtTenSanPham";
            this.txtTenSanPham.Size = new System.Drawing.Size(294, 37);
            this.txtTenSanPham.TabIndex = 1;
            // 
            // lblMaDanhMuc
            // 
            this.lblMaDanhMuc.AutoSize = true;
            this.lblMaDanhMuc.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaDanhMuc.Location = new System.Drawing.Point(237, 213);
            this.lblMaDanhMuc.Name = "lblMaDanhMuc";
            this.lblMaDanhMuc.Size = new System.Drawing.Size(139, 22);
            this.lblMaDanhMuc.TabIndex = 12;
            this.lblMaDanhMuc.Text = "Mã danh mục:";
            // 
            // lblMaSanPham
            // 
            this.lblMaSanPham.AutoSize = true;
            this.lblMaSanPham.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaSanPham.Location = new System.Drawing.Point(237, 40);
            this.lblMaSanPham.Name = "lblMaSanPham";
            this.lblMaSanPham.Size = new System.Drawing.Size(134, 22);
            this.lblMaSanPham.TabIndex = 14;
            this.lblMaSanPham.Text = "Mã sản phẩm:";
            // 
            // txtMaSanPham
            // 
            this.txtMaSanPham.BackColor = System.Drawing.Color.White;
            this.txtMaSanPham.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtMaSanPham.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtMaSanPham.Location = new System.Drawing.Point(377, 37);
            this.txtMaSanPham.Name = "txtMaSanPham";
            this.txtMaSanPham.Size = new System.Drawing.Size(294, 37);
            this.txtMaSanPham.TabIndex = 0;
            this.txtMaSanPham.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaSanPham_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(342, 67);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(119)))), ((int)(((byte)(18)))));
            this.label2.Location = new System.Drawing.Point(38, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "SWEET AND HAPPY ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nmSoLuong);
            this.groupBox1.Controls.Add(this.btnTimKiemMaDanhMuc);
            this.groupBox1.Controls.Add(this.btnTKMaSP);
            this.groupBox1.Controls.Add(this.btnTimKiemTenSP);
            this.groupBox1.Controls.Add(this.cbbDanhMucSanPham);
            this.groupBox1.Controls.Add(this.lblMoTa);
            this.groupBox1.Controls.Add(this.txtMoTa);
            this.groupBox1.Controls.Add(this.lblSoLuong);
            this.groupBox1.Controls.Add(this.lblDonGia);
            this.groupBox1.Controls.Add(this.txtDonGia);
            this.groupBox1.Controls.Add(this.ptrSanPham);
            this.groupBox1.Controls.Add(this.lblMaSanPham);
            this.groupBox1.Controls.Add(this.txtMaSanPham);
            this.groupBox1.Controls.Add(this.lblMaDanhMuc);
            this.groupBox1.Controls.Add(this.lblTenSanPham);
            this.groupBox1.Controls.Add(this.txtTenSanPham);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(12, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1209, 377);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // nmSoLuong
            // 
            this.nmSoLuong.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.nmSoLuong.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.nmSoLuong.Location = new System.Drawing.Point(887, 128);
            this.nmSoLuong.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nmSoLuong.Name = "nmSoLuong";
            this.nmSoLuong.Size = new System.Drawing.Size(306, 37);
            this.nmSoLuong.TabIndex = 4;
            this.nmSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnTimKiemMaDanhMuc
            // 
            this.btnTimKiemMaDanhMuc.BackgroundImage = global::QuanLyCuaHangBanBanh.Properties.Resources.search;
            this.btnTimKiemMaDanhMuc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTimKiemMaDanhMuc.Location = new System.Drawing.Point(675, 207);
            this.btnTimKiemMaDanhMuc.Name = "btnTimKiemMaDanhMuc";
            this.btnTimKiemMaDanhMuc.Size = new System.Drawing.Size(53, 40);
            this.btnTimKiemMaDanhMuc.TabIndex = 8;
            this.btnTimKiemMaDanhMuc.UseVisualStyleBackColor = true;
            this.btnTimKiemMaDanhMuc.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnTKMaSP
            // 
            this.btnTKMaSP.BackgroundImage = global::QuanLyCuaHangBanBanh.Properties.Resources.search;
            this.btnTKMaSP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTKMaSP.Location = new System.Drawing.Point(677, 37);
            this.btnTKMaSP.Name = "btnTKMaSP";
            this.btnTKMaSP.Size = new System.Drawing.Size(53, 42);
            this.btnTKMaSP.TabIndex = 6;
            this.btnTKMaSP.UseVisualStyleBackColor = true;
            this.btnTKMaSP.Click += new System.EventHandler(this.btnTKMaSP_Click);
            // 
            // btnTimKiemTenSP
            // 
            this.btnTimKiemTenSP.BackgroundImage = global::QuanLyCuaHangBanBanh.Properties.Resources.search;
            this.btnTimKiemTenSP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTimKiemTenSP.Location = new System.Drawing.Point(677, 123);
            this.btnTimKiemTenSP.Name = "btnTimKiemTenSP";
            this.btnTimKiemTenSP.Size = new System.Drawing.Size(53, 42);
            this.btnTimKiemTenSP.TabIndex = 7;
            this.btnTimKiemTenSP.UseVisualStyleBackColor = true;
            this.btnTimKiemTenSP.Click += new System.EventHandler(this.btnTimKiemTenSP_Click);
            // 
            // cbbDanhMucSanPham
            // 
            this.cbbDanhMucSanPham.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cbbDanhMucSanPham.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cbbDanhMucSanPham.FormattingEnabled = true;
            this.cbbDanhMucSanPham.Location = new System.Drawing.Point(377, 209);
            this.cbbDanhMucSanPham.Name = "cbbDanhMucSanPham";
            this.cbbDanhMucSanPham.Size = new System.Drawing.Size(294, 38);
            this.cbbDanhMucSanPham.TabIndex = 2;
            // 
            // lblMoTa
            // 
            this.lblMoTa.AutoSize = true;
            this.lblMoTa.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoTa.Location = new System.Drawing.Point(787, 219);
            this.lblMoTa.Name = "lblMoTa";
            this.lblMoTa.Size = new System.Drawing.Size(64, 22);
            this.lblMoTa.TabIndex = 29;
            this.lblMoTa.Text = "Mô tả:";
            // 
            // txtMoTa
            // 
            this.txtMoTa.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtMoTa.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtMoTa.Location = new System.Drawing.Point(887, 213);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(314, 145);
            this.txtMoTa.TabIndex = 5;
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuong.Location = new System.Drawing.Point(787, 131);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(89, 22);
            this.lblSoLuong.TabIndex = 29;
            this.lblSoLuong.Text = "Số lượng:";
            // 
            // lblDonGia
            // 
            this.lblDonGia.AutoSize = true;
            this.lblDonGia.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonGia.Location = new System.Drawing.Point(787, 43);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(83, 22);
            this.lblDonGia.TabIndex = 17;
            this.lblDonGia.Text = "Đơn giá:";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtDonGia.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtDonGia.Location = new System.Drawing.Point(887, 37);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(306, 37);
            this.txtDonGia.TabIndex = 3;
            this.txtDonGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDonGia_KeyPress);
            // 
            // ptrSanPham
            // 
            this.ptrSanPham.Image = global::QuanLyCuaHangBanBanh.Properties.Resources.hide1;
            this.ptrSanPham.Location = new System.Drawing.Point(6, 37);
            this.ptrSanPham.Name = "ptrSanPham";
            this.ptrSanPham.Size = new System.Drawing.Size(215, 205);
            this.ptrSanPham.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptrSanPham.TabIndex = 16;
            this.ptrSanPham.TabStop = false;
            this.ptrSanPham.Click += new System.EventHandler(this.ptrSanPham_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnLamMoi);
            this.groupBox3.Controls.Add(this.btnSua);
            this.groupBox3.Controls.Add(this.btnXoa);
            this.groupBox3.Controls.Add(this.btnThem);
            this.groupBox3.Location = new System.Drawing.Point(1227, 85);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(341, 377);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chức năng";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLamMoi.BackgroundImage = global::QuanLyCuaHangBanBanh.Properties.Resources.reset;
            this.btnLamMoi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLamMoi.Location = new System.Drawing.Point(204, 235);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(120, 120);
            this.btnLamMoi.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnLamMoi, "Làm mới thông tin");
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSua.BackgroundImage = global::QuanLyCuaHangBanBanh.Properties.Resources.suabanh;
            this.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSua.Location = new System.Drawing.Point(204, 34);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(120, 120);
            this.btnSua.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btnSua, "Sửa sản phẩm");
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnXoa.BackgroundImage = global::QuanLyCuaHangBanBanh.Properties.Resources.delete;
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnXoa.Location = new System.Drawing.Point(18, 235);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(120, 120);
            this.btnXoa.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnXoa, "Xóa sản phẩm");
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnThem.BackgroundImage = global::QuanLyCuaHangBanBanh.Properties.Resources.lambanh;
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnThem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(119)))), ((int)(((byte)(18)))));
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(119)))), ((int)(((byte)(18)))));
            this.btnThem.Location = new System.Drawing.Point(18, 34);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(120, 120);
            this.btnThem.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnThem, "Thêm sản phẩm");
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSanPham.BackgroundColor = System.Drawing.Color.White;
            this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTenSanPham,
            this.colTenDanhMuc,
            this.colDonGia,
            this.colSoLuong,
            this.colMoTa,
            this.colHinhAnh,
            this.colMaSanPham,
            this.colMaDanhMuc});
            this.dgvSanPham.Location = new System.Drawing.Point(12, 468);
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.RowHeadersWidth = 62;
            this.dgvSanPham.RowTemplate.Height = 28;
            this.dgvSanPham.Size = new System.Drawing.Size(1556, 373);
            this.dgvSanPham.TabIndex = 23;
            this.dgvSanPham.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSanPham_CellContentClick);
            this.dgvSanPham.SelectionChanged += new System.EventHandler(this.dgvSanPham_SelectionChanged);
            // 
            // colTenSanPham
            // 
            this.colTenSanPham.DataPropertyName = "TENSANPHAM";
            this.colTenSanPham.HeaderText = "Tên sản phẩm";
            this.colTenSanPham.MinimumWidth = 8;
            this.colTenSanPham.Name = "colTenSanPham";
            // 
            // colTenDanhMuc
            // 
            this.colTenDanhMuc.DataPropertyName = "TENDANHMUC";
            this.colTenDanhMuc.HeaderText = "Tên danh mục";
            this.colTenDanhMuc.MinimumWidth = 8;
            this.colTenDanhMuc.Name = "colTenDanhMuc";
            // 
            // colDonGia
            // 
            this.colDonGia.DataPropertyName = "DONGIA";
            this.colDonGia.HeaderText = "Đơn giá";
            this.colDonGia.MinimumWidth = 8;
            this.colDonGia.Name = "colDonGia";
            // 
            // colSoLuong
            // 
            this.colSoLuong.DataPropertyName = "SOLUONG";
            this.colSoLuong.HeaderText = "Số lượng";
            this.colSoLuong.MinimumWidth = 8;
            this.colSoLuong.Name = "colSoLuong";
            // 
            // colMoTa
            // 
            this.colMoTa.DataPropertyName = "MOTA";
            this.colMoTa.HeaderText = "Mô tả";
            this.colMoTa.MinimumWidth = 8;
            this.colMoTa.Name = "colMoTa";
            // 
            // colHinhAnh
            // 
            this.colHinhAnh.DataPropertyName = "HINHANH";
            this.colHinhAnh.HeaderText = "Hình ảnh";
            this.colHinhAnh.MinimumWidth = 8;
            this.colHinhAnh.Name = "colHinhAnh";
            this.colHinhAnh.Visible = false;
            // 
            // colMaSanPham
            // 
            this.colMaSanPham.DataPropertyName = "MASANPHAM";
            this.colMaSanPham.HeaderText = "Mã sản phẩm";
            this.colMaSanPham.MinimumWidth = 8;
            this.colMaSanPham.Name = "colMaSanPham";
            this.colMaSanPham.Visible = false;
            // 
            // colMaDanhMuc
            // 
            this.colMaDanhMuc.DataPropertyName = "MADANHMUC";
            this.colMaDanhMuc.HeaderText = "Mã danh mục";
            this.colMaDanhMuc.MinimumWidth = 8;
            this.colMaDanhMuc.Name = "colMaDanhMuc";
            this.colMaDanhMuc.Visible = false;
            // 
            // frmSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1580, 853);
            this.Controls.Add(this.dgvSanPham);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frmSanPham";
            this.Text = "frmSanPham";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmSanPham_KeyDown);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptrSanPham)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTenSanPham;
        private System.Windows.Forms.TextBox txtTenSanPham;
        private System.Windows.Forms.Label lblMaDanhMuc;
        private System.Windows.Forms.Label lblMaSanPham;
        private System.Windows.Forms.TextBox txtMaSanPham;
        private System.Windows.Forms.PictureBox ptrSanPham;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblMoTa;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.Button btnTimKiemMaDanhMuc;
        private System.Windows.Forms.Button btnTimKiemTenSP;
        private System.Windows.Forms.ComboBox cbbDanhMucSanPham;
        private System.Windows.Forms.NumericUpDown nmSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenDanhMuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMoTa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHinhAnh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaDanhMuc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTKMaSP;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}