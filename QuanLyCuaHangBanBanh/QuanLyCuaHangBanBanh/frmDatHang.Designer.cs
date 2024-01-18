namespace QuanLyCuaHangBanBanh
{
    partial class frmDatHang
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
            this.cbbDanhMucSanPham = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.lblGIamGia = new System.Windows.Forms.Label();
            this.nbGiamGia = new System.Windows.Forms.NumericUpDown();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.flpMangVe = new System.Windows.Forms.FlowLayoutPanel();
            this.cbbBan = new System.Windows.Forms.ComboBox();
            this.flpBan = new System.Windows.Forms.FlowLayoutPanel();
            this.btnChuyenBan = new System.Windows.Forms.Button();
            this.grbSanPham = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.colMaSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenSPdgvSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDonGiadgvSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMoTadgvSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHinhAnh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTimKiemSP = new System.Windows.Forms.TextBox();
            this.grbThonTinSanPham = new System.Windows.Forms.GroupBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.nmSoLuong = new System.Windows.Forms.NumericUpDown();
            this.btnThem = new System.Windows.Forms.Button();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTenSanPham = new System.Windows.Forms.TextBox();
            this.ptrSanPham = new System.Windows.Forms.PictureBox();
            this.lblSoBan = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnThemKhach = new System.Windows.Forms.Button();
            this.txtTenKhachHang = new System.Windows.Forms.TextBox();
            this.lblSDT = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.lblTenKhachHang = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnTimKiemMDM = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvMenu = new System.Windows.Forms.DataGridView();
            this.colMSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTongDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.nbGiamGia)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.grbSanPham.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            this.grbThonTinSanPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptrSanPham)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbDanhMucSanPham
            // 
            this.cbbDanhMucSanPham.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cbbDanhMucSanPham.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cbbDanhMucSanPham.FormattingEnabled = true;
            this.cbbDanhMucSanPham.Location = new System.Drawing.Point(699, 32);
            this.cbbDanhMucSanPham.Name = "cbbDanhMucSanPham";
            this.cbbDanhMucSanPham.Size = new System.Drawing.Size(226, 38);
            this.cbbDanhMucSanPham.TabIndex = 7;
            this.cbbDanhMucSanPham.SelectedIndexChanged += new System.EventHandler(this.cbbDanhMucSanPham_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tổng tiền:";
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(119)))), ((int)(((byte)(18)))));
            this.btnThanhToan.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(119)))), ((int)(((byte)(18)))));
            this.btnThanhToan.FlatAppearance.BorderSize = 0;
            this.btnThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThanhToan.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.ForeColor = System.Drawing.Color.White;
            this.btnThanhToan.Location = new System.Drawing.Point(21, 273);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(553, 77);
            this.btnThanhToan.TabIndex = 1;
            this.btnThanhToan.Text = "THANH TOÁN";
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // lblGIamGia
            // 
            this.lblGIamGia.AutoSize = true;
            this.lblGIamGia.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGIamGia.Location = new System.Drawing.Point(17, 208);
            this.lblGIamGia.Name = "lblGIamGia";
            this.lblGIamGia.Size = new System.Drawing.Size(118, 22);
            this.lblGIamGia.TabIndex = 8;
            this.lblGIamGia.Text = "Khuyến mãi:";
            // 
            // nbGiamGia
            // 
            this.nbGiamGia.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.nbGiamGia.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.nbGiamGia.Location = new System.Drawing.Point(181, 199);
            this.nbGiamGia.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nbGiamGia.Name = "nbGiamGia";
            this.nbGiamGia.Size = new System.Drawing.Size(393, 37);
            this.nbGiamGia.TabIndex = 0;
            this.nbGiamGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTongTien
            // 
            this.txtTongTien.BackColor = System.Drawing.Color.White;
            this.txtTongTien.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtTongTien.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtTongTien.Location = new System.Drawing.Point(181, 157);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(393, 37);
            this.txtTongTien.TabIndex = 11;
            this.txtTongTien.Text = "0";
            this.txtTongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(0, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(342, 67);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(119)))), ((int)(((byte)(18)))));
            this.label2.Location = new System.Drawing.Point(27, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 33);
            this.label2.TabIndex = 0;
            this.label2.Text = "SWEET AND HAPPY ";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.flpMangVe);
            this.groupBox4.Controls.Add(this.cbbBan);
            this.groupBox4.Controls.Add(this.flpBan);
            this.groupBox4.Controls.Add(this.btnChuyenBan);
            this.groupBox4.Location = new System.Drawing.Point(0, 85);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(342, 796);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            // 
            // flpMangVe
            // 
            this.flpMangVe.Location = new System.Drawing.Point(6, 17);
            this.flpMangVe.Name = "flpMangVe";
            this.flpMangVe.Size = new System.Drawing.Size(328, 114);
            this.flpMangVe.TabIndex = 1;
            // 
            // cbbBan
            // 
            this.cbbBan.FormattingEnabled = true;
            this.cbbBan.Location = new System.Drawing.Point(12, 749);
            this.cbbBan.Name = "cbbBan";
            this.cbbBan.Size = new System.Drawing.Size(167, 28);
            this.cbbBan.TabIndex = 3;
            this.cbbBan.Visible = false;
            // 
            // flpBan
            // 
            this.flpBan.Location = new System.Drawing.Point(6, 137);
            this.flpBan.Name = "flpBan";
            this.flpBan.Size = new System.Drawing.Size(328, 597);
            this.flpBan.TabIndex = 2;
            // 
            // btnChuyenBan
            // 
            this.btnChuyenBan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(119)))), ((int)(((byte)(18)))));
            this.btnChuyenBan.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(119)))), ((int)(((byte)(18)))));
            this.btnChuyenBan.FlatAppearance.BorderSize = 0;
            this.btnChuyenBan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChuyenBan.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChuyenBan.ForeColor = System.Drawing.Color.White;
            this.btnChuyenBan.Location = new System.Drawing.Point(200, 740);
            this.btnChuyenBan.Name = "btnChuyenBan";
            this.btnChuyenBan.Size = new System.Drawing.Size(134, 43);
            this.btnChuyenBan.TabIndex = 4;
            this.btnChuyenBan.Text = "Chuyển bàn";
            this.btnChuyenBan.UseVisualStyleBackColor = false;
            this.btnChuyenBan.Visible = false;
            // 
            // grbSanPham
            // 
            this.grbSanPham.Controls.Add(this.flowLayoutPanel1);
            this.grbSanPham.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbSanPham.Location = new System.Drawing.Point(348, 85);
            this.grbSanPham.Name = "grbSanPham";
            this.grbSanPham.Size = new System.Drawing.Size(641, 432);
            this.grbSanPham.TabIndex = 9;
            this.grbSanPham.TabStop = false;
            this.grbSanPham.Text = "Sản phẩm";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.dgvSanPham);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 25);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(629, 401);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSanPham.BackgroundColor = System.Drawing.Color.White;
            this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaSanPham,
            this.colTenSPdgvSP,
            this.colDonGiadgvSP,
            this.colMoTadgvSP,
            this.colHinhAnh});
            this.dgvSanPham.Location = new System.Drawing.Point(3, 3);
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.ReadOnly = true;
            this.dgvSanPham.RowHeadersWidth = 62;
            this.dgvSanPham.RowTemplate.Height = 28;
            this.dgvSanPham.Size = new System.Drawing.Size(626, 398);
            this.dgvSanPham.TabIndex = 10;
            this.dgvSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSanPham_CellClick);
            this.dgvSanPham.SelectionChanged += new System.EventHandler(this.dgvSanPham_SelectionChanged);
            // 
            // colMaSanPham
            // 
            this.colMaSanPham.DataPropertyName = "MASANPHAM";
            this.colMaSanPham.HeaderText = "Mã sản phẩm";
            this.colMaSanPham.MinimumWidth = 8;
            this.colMaSanPham.Name = "colMaSanPham";
            this.colMaSanPham.ReadOnly = true;
            this.colMaSanPham.Visible = false;
            // 
            // colTenSPdgvSP
            // 
            this.colTenSPdgvSP.DataPropertyName = "TENSANPHAM";
            this.colTenSPdgvSP.HeaderText = "Tên sản phẩm";
            this.colTenSPdgvSP.MinimumWidth = 8;
            this.colTenSPdgvSP.Name = "colTenSPdgvSP";
            this.colTenSPdgvSP.ReadOnly = true;
            // 
            // colDonGiadgvSP
            // 
            this.colDonGiadgvSP.DataPropertyName = "DONGIA";
            this.colDonGiadgvSP.HeaderText = "Đơn giá";
            this.colDonGiadgvSP.MinimumWidth = 8;
            this.colDonGiadgvSP.Name = "colDonGiadgvSP";
            this.colDonGiadgvSP.ReadOnly = true;
            // 
            // colMoTadgvSP
            // 
            this.colMoTadgvSP.DataPropertyName = "MOTA";
            this.colMoTadgvSP.HeaderText = "Mô tả";
            this.colMoTadgvSP.MinimumWidth = 8;
            this.colMoTadgvSP.Name = "colMoTadgvSP";
            this.colMoTadgvSP.ReadOnly = true;
            // 
            // colHinhAnh
            // 
            this.colHinhAnh.DataPropertyName = "HINHANH";
            this.colHinhAnh.HeaderText = "Hình ảnh";
            this.colHinhAnh.MinimumWidth = 8;
            this.colHinhAnh.Name = "colHinhAnh";
            this.colHinhAnh.ReadOnly = true;
            this.colHinhAnh.Visible = false;
            // 
            // txtTimKiemSP
            // 
            this.txtTimKiemSP.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtTimKiemSP.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtTimKiemSP.Location = new System.Drawing.Point(348, 32);
            this.txtTimKiemSP.Name = "txtTimKiemSP";
            this.txtTimKiemSP.Size = new System.Drawing.Size(267, 37);
            this.txtTimKiemSP.TabIndex = 5;
            // 
            // grbThonTinSanPham
            // 
            this.grbThonTinSanPham.Controls.Add(this.btnXoa);
            this.grbThonTinSanPham.Controls.Add(this.nmSoLuong);
            this.grbThonTinSanPham.Controls.Add(this.btnThem);
            this.grbThonTinSanPham.Controls.Add(this.lblSoLuong);
            this.grbThonTinSanPham.Controls.Add(this.lblDonGia);
            this.grbThonTinSanPham.Controls.Add(this.txtDonGia);
            this.grbThonTinSanPham.Controls.Add(this.label8);
            this.grbThonTinSanPham.Controls.Add(this.txtTenSanPham);
            this.grbThonTinSanPham.Controls.Add(this.ptrSanPham);
            this.grbThonTinSanPham.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbThonTinSanPham.Location = new System.Drawing.Point(348, 517);
            this.grbThonTinSanPham.Name = "grbThonTinSanPham";
            this.grbThonTinSanPham.Size = new System.Drawing.Size(646, 364);
            this.grbThonTinSanPham.TabIndex = 11;
            this.grbThonTinSanPham.TabStop = false;
            this.grbThonTinSanPham.Text = "Thông tin sản phẩm";
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(119)))), ((int)(((byte)(18)))));
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXoa.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(324, 273);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(295, 77);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "XÓA";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // nmSoLuong
            // 
            this.nmSoLuong.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.nmSoLuong.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.nmSoLuong.Location = new System.Drawing.Point(342, 186);
            this.nmSoLuong.Name = "nmSoLuong";
            this.nmSoLuong.Size = new System.Drawing.Size(277, 37);
            this.nmSoLuong.TabIndex = 5;
            this.nmSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(119)))), ((int)(((byte)(18)))));
            this.btnThem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(119)))), ((int)(((byte)(18)))));
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThem.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(13, 273);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(295, 77);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "THÊM | SỬA";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuong.Location = new System.Drawing.Point(189, 193);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(89, 22);
            this.lblSoLuong.TabIndex = 12;
            this.lblSoLuong.Text = "Số lượng:";
            // 
            // lblDonGia
            // 
            this.lblDonGia.AutoSize = true;
            this.lblDonGia.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonGia.Location = new System.Drawing.Point(189, 114);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(83, 22);
            this.lblDonGia.TabIndex = 14;
            this.lblDonGia.Text = "Đơn giá:";
            // 
            // txtDonGia
            // 
            this.txtDonGia.BackColor = System.Drawing.Color.White;
            this.txtDonGia.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtDonGia.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtDonGia.Location = new System.Drawing.Point(342, 114);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.ReadOnly = true;
            this.txtDonGia.Size = new System.Drawing.Size(277, 37);
            this.txtDonGia.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(189, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 22);
            this.label8.TabIndex = 12;
            this.label8.Text = "Tên sản phẩm:";
            // 
            // txtTenSanPham
            // 
            this.txtTenSanPham.BackColor = System.Drawing.Color.White;
            this.txtTenSanPham.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtTenSanPham.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtTenSanPham.Location = new System.Drawing.Point(342, 42);
            this.txtTenSanPham.Name = "txtTenSanPham";
            this.txtTenSanPham.ReadOnly = true;
            this.txtTenSanPham.Size = new System.Drawing.Size(277, 37);
            this.txtTenSanPham.TabIndex = 13;
            // 
            // ptrSanPham
            // 
            this.ptrSanPham.Image = global::QuanLyCuaHangBanBanh.Properties.Resources.save;
            this.ptrSanPham.Location = new System.Drawing.Point(13, 42);
            this.ptrSanPham.Name = "ptrSanPham";
            this.ptrSanPham.Size = new System.Drawing.Size(144, 156);
            this.ptrSanPham.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptrSanPham.TabIndex = 0;
            this.ptrSanPham.TabStop = false;
            // 
            // lblSoBan
            // 
            this.lblSoBan.AutoSize = true;
            this.lblSoBan.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoBan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(119)))), ((int)(((byte)(18)))));
            this.lblSoBan.Location = new System.Drawing.Point(1007, 60);
            this.lblSoBan.Name = "lblSoBan";
            this.lblSoBan.Size = new System.Drawing.Size(15, 22);
            this.lblSoBan.TabIndex = 25;
            this.lblSoBan.Text = ".";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.nbGiamGia);
            this.groupBox1.Controls.Add(this.txtTongTien);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnThanhToan);
            this.groupBox1.Controls.Add(this.lblGIamGia);
            this.groupBox1.Location = new System.Drawing.Point(1000, 517);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(598, 364);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnThemKhach);
            this.groupBox6.Controls.Add(this.txtTenKhachHang);
            this.groupBox6.Controls.Add(this.lblSDT);
            this.groupBox6.Controls.Add(this.txtSDT);
            this.groupBox6.Controls.Add(this.lblTenKhachHang);
            this.groupBox6.Location = new System.Drawing.Point(11, 20);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(579, 127);
            this.groupBox6.TabIndex = 24;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Thông tin khách hàng";
            // 
            // btnThemKhach
            // 
            this.btnThemKhach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(119)))), ((int)(((byte)(18)))));
            this.btnThemKhach.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(119)))), ((int)(((byte)(18)))));
            this.btnThemKhach.FlatAppearance.BorderSize = 0;
            this.btnThemKhach.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThemKhach.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemKhach.ForeColor = System.Drawing.Color.White;
            this.btnThemKhach.Location = new System.Drawing.Point(439, 30);
            this.btnThemKhach.Name = "btnThemKhach";
            this.btnThemKhach.Size = new System.Drawing.Size(134, 81);
            this.btnThemKhach.TabIndex = 2;
            this.btnThemKhach.Text = "THÊM";
            this.btnThemKhach.UseVisualStyleBackColor = false;
            this.btnThemKhach.Click += new System.EventHandler(this.btnThemKhach_Click);
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtTenKhachHang.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtTenKhachHang.Location = new System.Drawing.Point(170, 27);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.Size = new System.Drawing.Size(242, 37);
            this.txtTenKhachHang.TabIndex = 0;
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSDT.Location = new System.Drawing.Point(6, 86);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(126, 22);
            this.lblSDT.TabIndex = 25;
            this.lblSDT.Text = "Số điện thoại:";
            // 
            // txtSDT
            // 
            this.txtSDT.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtSDT.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtSDT.Location = new System.Drawing.Point(170, 78);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(242, 37);
            this.txtSDT.TabIndex = 1;
            this.txtSDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSDT_KeyPress);
            // 
            // lblTenKhachHang
            // 
            this.lblTenKhachHang.AutoSize = true;
            this.lblTenKhachHang.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenKhachHang.Location = new System.Drawing.Point(6, 30);
            this.lblTenKhachHang.Name = "lblTenKhachHang";
            this.lblTenKhachHang.Size = new System.Drawing.Size(158, 22);
            this.lblTenKhachHang.TabIndex = 23;
            this.lblTenKhachHang.Text = "Tên khách hàng:";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackgroundImage = global::QuanLyCuaHangBanBanh.Properties.Resources.search;
            this.btnTimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTimKiem.Location = new System.Drawing.Point(621, 30);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(53, 40);
            this.btnTimKiem.TabIndex = 6;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnTimKiemMDM
            // 
            this.btnTimKiemMDM.BackgroundImage = global::QuanLyCuaHangBanBanh.Properties.Resources.search;
            this.btnTimKiemMDM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTimKiemMDM.Location = new System.Drawing.Point(936, 31);
            this.btnTimKiemMDM.Name = "btnTimKiemMDM";
            this.btnTimKiemMDM.Size = new System.Drawing.Size(53, 40);
            this.btnTimKiemMDM.TabIndex = 8;
            this.btnTimKiemMDM.UseVisualStyleBackColor = true;
            this.btnTimKiemMDM.Click += new System.EventHandler(this.btnTimKiemMDM_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvMenu);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(1000, 85);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(598, 432);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sản phẩm theo bàn";
            // 
            // dgvMenu
            // 
            this.dgvMenu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMenu.BackgroundColor = System.Drawing.Color.White;
            this.dgvMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMSP,
            this.colTenSanPham,
            this.colSoLuong,
            this.colDonGia,
            this.colTongDonGia});
            this.dgvMenu.Location = new System.Drawing.Point(11, 28);
            this.dgvMenu.Name = "dgvMenu";
            this.dgvMenu.ReadOnly = true;
            this.dgvMenu.RowHeadersWidth = 62;
            this.dgvMenu.RowTemplate.Height = 28;
            this.dgvMenu.Size = new System.Drawing.Size(579, 398);
            this.dgvMenu.TabIndex = 26;
            this.dgvMenu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMenu_CellClick);
            this.dgvMenu.SelectionChanged += new System.EventHandler(this.dgvMenu_SelectionChanged);
            // 
            // colMSP
            // 
            this.colMSP.HeaderText = "Mã sản phẩm";
            this.colMSP.MinimumWidth = 8;
            this.colMSP.Name = "colMSP";
            this.colMSP.ReadOnly = true;
            this.colMSP.Visible = false;
            // 
            // colTenSanPham
            // 
            this.colTenSanPham.HeaderText = "Tên sản phẩm";
            this.colTenSanPham.MinimumWidth = 8;
            this.colTenSanPham.Name = "colTenSanPham";
            this.colTenSanPham.ReadOnly = true;
            // 
            // colSoLuong
            // 
            this.colSoLuong.HeaderText = "Số lượng";
            this.colSoLuong.MinimumWidth = 8;
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.ReadOnly = true;
            // 
            // colDonGia
            // 
            this.colDonGia.HeaderText = "Đơn giá";
            this.colDonGia.MinimumWidth = 8;
            this.colDonGia.Name = "colDonGia";
            this.colDonGia.ReadOnly = true;
            // 
            // colTongDonGia
            // 
            this.colTongDonGia.HeaderText = "Tổng đơn giá";
            this.colTongDonGia.MinimumWidth = 8;
            this.colTongDonGia.Name = "colTongDonGia";
            this.colTongDonGia.ReadOnly = true;
            // 
            // frmDatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1602, 909);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnTimKiemMDM);
            this.Controls.Add(this.lblSoBan);
            this.Controls.Add(this.grbThonTinSanPham);
            this.Controls.Add(this.txtTimKiemSP);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.cbbDanhMucSanPham);
            this.Controls.Add(this.grbSanPham);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frmDatHang";
            this.Text = "frmDatHang";
            this.Load += new System.EventHandler(this.frmDatHang_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmDatHang_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.nbGiamGia)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.grbSanPham.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            this.grbThonTinSanPham.ResumeLayout(false);
            this.grbThonTinSanPham.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptrSanPham)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbbDanhMucSanPham;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label lblGIamGia;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox grbSanPham;
        private System.Windows.Forms.Button btnChuyenBan;
        private System.Windows.Forms.TextBox txtTimKiemSP;
        private System.Windows.Forms.GroupBox grbThonTinSanPham;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTenSanPham;
        private System.Windows.Forms.PictureBox ptrSanPham;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.FlowLayoutPanel flpBan;
        private System.Windows.Forms.Label lblSoBan;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.NumericUpDown nmSoLuong;
        private System.Windows.Forms.NumericUpDown nbGiamGia;
        private System.Windows.Forms.ComboBox cbbBan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label lblTenKhachHang;
        private System.Windows.Forms.TextBox txtTenKhachHang;
        private System.Windows.Forms.FlowLayoutPanel flpMangVe;
        private System.Windows.Forms.Button btnThemKhach;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenSPdgvSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDonGiadgvSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMoTadgvSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHinhAnh;
        private System.Windows.Forms.Button btnTimKiemMDM;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTongDonGia;
    }
}