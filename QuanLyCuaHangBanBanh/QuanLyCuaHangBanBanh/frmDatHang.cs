using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using DTO;
using BUSS;
using System.Globalization;
using System.Xml;
using System.Windows.Documents;
using System.Windows.Baml2006;
using System.Data.Linq;
using System.Diagnostics.PerformanceData;
using System.Security.Cryptography;
using System.Runtime.InteropServices;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;


namespace QuanLyCuaHangBanBanh
{
    public partial class frmDatHang : Form
    {
        private Image defaultImage;
        KhachHangBUS KhachHangBus = new KhachHangBUS();
        SanPhamBUS SanphamBus = new SanPhamBUS();
        CultureInfo cultureinfo = new CultureInfo("vi-VN");
        BanBUS banBUS = new BanBUS();
        string hexColor = "#dcdcdc";
        string hexAllColore = "#EF7712";// Mã màu sắc, ví dụ "#00FFFF" là màu xanh lam đậm
        private int manhanvien;


        public frmDatHang(int manhanvien)
        {
            //    nmSoLuong.Minimum = -100;
            //    nmSoLuong.Maximum = 100;
            //    nmSoLuong.DecimalPlaces = 0;
            this.manhanvien = manhanvien;
            InitializeComponent();
            dgvSanPham.AutoGenerateColumns = false;
            LoadBan();
            LoadDanhMucSanPham();
            LoadDanhMucBan();
            LoadSP();
            defaultImage = ptrSanPham.Image;

        }

        private void frmDatHang_Load(object sender, EventArgs e)
        {

        }

        private void LoadSP()
        {
            //dgvSanPham.DataSource = _spbus.loadSP();
            dgvSanPham.DataSource = SanPhamDAO.Instance.loadsanpham();
        }

        private void ResetTextThemSP()
        {
            txtDonGia.Text = string.Empty;
            txtTenSanPham.Text = string.Empty;
            txtTenKhachHang.Text = string.Empty;
            txtSDT.Text = string.Empty;
            nmSoLuong.Value = 1;
            ptrSanPham.Image = defaultImage;
            nbGiamGia.Value = 0;
        }


        private void LoadBan()
        {
            Color color = ColorTranslator.FromHtml(hexColor);
            Color colorall = ColorTranslator.FromHtml(hexAllColore);
            flpBan.Controls.Clear();
            flpMangVe.Controls.Clear();
            //List<BanDTO> ListBan =  BanDAO.Instance.LoadBan();
            List<BanDTO> listBan = banBUS.LoadBan();

            foreach (BanDTO item in listBan)
            {
                Button btnBan = new Button() { Width = BanDAO.RongBan, Height = BanDAO.DaiBan };
                btnBan.Text = item.TENBAN + Environment.NewLine + item.TRANGTHAI;
                btnBan.Click += btn_click;
                btnBan.Tag = item;

                if (item.MABAN == 1)
                {
                    Button btnBanMangVe = new Button() { Width = BanDAO.RongMangVe, Height = BanDAO.DaiMangVe };
                    btnBanMangVe.Text = item.TENBAN;
                    btnBanMangVe.Click += btn_click;
                    btnBanMangVe.Tag = item;
                    btnBanMangVe.BackColor = colorall;
                    btnBanMangVe.FlatAppearance.BorderColor = colorall;
                    btnBanMangVe.FlatAppearance.BorderSize = 0;
                    btnBanMangVe.FlatStyle = FlatStyle.Flat;
                    btnBanMangVe.Font = new Font("Century Gothic", 10, FontStyle.Bold);
                    btnBanMangVe.ForeColor = Color.White;



                    flpMangVe.Controls.Add(btnBanMangVe);


                }
                else
                {

                    if (item.TRANGTHAI == CONST.TBTrong)
                    {


                        btnBan.BackColor = color;


                    }
                    else if (item.TRANGTHAI == CONST.TBCoNguoi)
                    {
                        btnBan.BackColor = Color.Pink;
                    }



                    flpBan.Controls.Add(btnBan);

                }
            }

        }

       

        private void btn_click(object sender, EventArgs e)
        {
            ResetText();
            string TenBan = ((sender as Button).Tag as BanDTO).TENBAN;
            int MaBan = ((sender as Button).Tag as BanDTO).MABAN;
            dgvMenu.Tag = (sender as Button).Tag;
            ShowBill(MaBan);
            lblSoBan.Text = TenBan;
        }

        void ShowBill(int id)
        {
            dgvMenu.Rows.Clear();
            List<ThucDonDTO> listcthd = ThucDonDAO.Instance.LayDanhSachThucDonTheoBan(id);
            float TongDonGia = 0;
            foreach (ThucDonDTO item in listcthd)
            {
                int rowIndex = dgvMenu.Rows.Add();
                DataGridViewRow row = dgvMenu.Rows[rowIndex];
                row.Cells["colMSP"].Value = item.MASANPHAM;
                row.Cells["colTenSanPham"].Value = item.TENSANPHAM;
                row.Cells["colSoLuong"].Value = item.SOLUONG;
                row.Cells["colDonGia"].Value = item.DONGIA;
                row.Cells["colTongDonGia"].Value = item.TONGDONGIA;
                TongDonGia += (float)item.TONGDONGIA;

            }


            txtTongTien.Text = TongDonGia.ToString("c", cultureinfo);

            LoadBan();




        }

        
        public void LoadDanhMucSanPham()
        {
            List<DanhMucSanPhamDTO> listDanhMuc = DanhMucSanPhamDAO.Instance.LayDanhSach();
            cbbDanhMucSanPham.DataSource = listDanhMuc;
            cbbDanhMucSanPham.DisplayMember = "TENDANHMUC";
        }

        public void LoadDanhMucBan()
        {
            List<BanDTO> listban = BanDAO.Instance.LoadBan();
            cbbBan.DataSource = listban;
            cbbBan.DisplayMember = "TENBAN";
        }
        public void LoadSanPhamTheoDanhMuc(int id)
        {
            List<SanPhamDTO> ListSP = SanPhamDAO.Instance.LayDanhSachTheoMaDanhMuc(id);
            foreach (SanPhamDTO item in ListSP)
            {
                int rowIndex = dgvSanPham.Rows.Add();
                DataGridViewRow row = dgvSanPham.Rows[rowIndex];
                row.Cells["colMaSanPham"].Value = item.MASANPHAM;
                row.Cells["colTenSPdgvSP"].Value = item.TENSANPHAM;
                row.Cells["colDonGiadgvSP"].Value = item.DONGIA;
                row.Cells["colMoTadgvSP"].Value = item.MOTA;
                row.Cells["colHinhAnh"].Value = item.HINHANH;

            }           

        }



        private void cbbDanhMucSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int id = 0;
            //ComboBox cb = sender as ComboBox;
            //if (cb.SelectedItem == null)
            //{
            //    return;
            //}
            //DanhMucSanPhamDTO selected = cb.SelectedItem as DanhMucSanPhamDTO;
            //id = selected.MADANHMUC;

            //dgvSanPham.Rows.Clear();

            //// Load danh sách sản phẩm theo mã danh mục
            //LoadSanPhamTheoDanhMuc(id);



        }

        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            ImageConverter _imageConverter = new ImageConverter();
            Image img = (Image)_imageConverter.ConvertFrom(byteArrayIn);
            return img;
        }

        private void dgvSanPham_SelectionChanged(object sender, EventArgs e)
        {
            CultureInfo acultureinfo = new CultureInfo("vi-VN");
            if (dgvSanPham.SelectedRows.Count > 0)
            {
                DataGridViewRow Selection = dgvSanPham.SelectedRows[0];

                if (Selection.Cells["colTenSPdgvSP"].Value != null && Selection.Cells["colDonGiadgvSP"].Value != null && Selection.Cells["colMoTadgvSP"].Value != null)
                {
                    txtTenSanPham.Text = Selection.Cells["colTenSPdgvSP"].Value.ToString();
                    txtDonGia.Text = Selection.Cells["colDonGiadgvSP"].Value.ToString();
                    byte[] HinhAnh = (byte[])Selection.Cells["colHinhAnh"].Value;

                    Image img = byteArrayToImage(HinhAnh);
                    ptrSanPham.Image = img;

                    if (decimal.TryParse(txtDonGia.Text, out decimal donGia))
                    {
                        txtDonGia.Text = donGia.ToString("c", acultureinfo);
                    }
                }

            }




        }

        private void btnThem_Click(object sender, EventArgs e)
        {



            BanDTO ban = dgvMenu.Tag as BanDTO;

            if (ban == null) 
            {

                MessageBox.Show(CONST.TBChuaChonBan);
                return;
            }
            else // Nếu có bàn được chọn
            {
                if (string.IsNullOrEmpty(txtTenSanPham.Text) || string.IsNullOrEmpty(txtDonGia.Text))
                {
                    MessageBox.Show(CONST.TBChuaChonMon, CONST.TB);
                    return;
                }

                int idBill = HoaDonDAO.Instance.GetUncheckBillIDTableID(ban.MABAN);
                int foodID = (int)btnThem.Tag;
                int count = (int)nmSoLuong.Value;

              
                if (SanPhamDAO.Instance.KiemTraSanPhamTonTaiTrongHD(idBill, foodID) == false) // Kiểm tra sản phẩm đã có trong hóa đơn
                {
                    if (count < 0) // Nếu số lượng sản phẩm âm và sản phẩm đã có trong hóa đơn, thông báo lỗi
                    {
                        MessageBox.Show(CONST.TBNhapSoDuong, CONST.TB);
                        nmSoLuong.Value = 0;
                        return;
                    }
                }

                if (idBill == -1)
                {
                    HoaDonDAO.Instance.ThemVaoHoaDon(ban.MABAN);
                    CT_HoaDonDAO.Instance.ThemVaoCT_HoaDon(HoaDonDAO.Instance.LayHoaDonLonNhat(), foodID, count);
                }
                else
                {
                    CT_HoaDonDAO.Instance.ThemVaoCT_HoaDon(idBill, foodID, count);
                }



                ShowBill(ban.MABAN);

                ResetTextThemSP();
            }



        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            BanDTO ban = dgvMenu.Tag as BanDTO;

            if (ban == null)
            {

                MessageBox.Show(CONST.TBChuaChonBan, CONST.TB);
                return;
            }
            if (string.IsNullOrEmpty(txtTenSanPham.Text) || string.IsNullOrEmpty(txtDonGia.Text))
            {
                MessageBox.Show(CONST.TBChuaChonMonXoa, CONST.TB);
                return;
            }

            int idBill = HoaDonDAO.Instance.GetUncheckBillIDTableID(ban.MABAN);
            int foodID = (int)btnThem.Tag;
            DialogResult result = MessageBox.Show(CONST.xacnhanxoaSPHD, CONST.TB, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                CT_HoaDonDAO.Instance.XoaCTHD(idBill, foodID);

                ShowBill(ban.MABAN);
            }
        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSanPham.Rows[e.RowIndex];

                // Lưu thông tin sản phẩm vào tag của nút "Thêm"
                if (row.Cells["colMaSanPham"].Value != null && int.TryParse(row.Cells["colMaSanPham"].Value.ToString(), out int foodID))
                {

                    btnThem.Tag = foodID;
                }
            }
        }

        private void dgvMenu_SelectionChanged(object sender, EventArgs e)
        {
            ptrSanPham.Image = defaultImage;
            CultureInfo acultureinfo = new CultureInfo("vi-VN");

            SanPhamDTO sp = dgvMenu.Tag as SanPhamDTO;
            if (dgvMenu.SelectedRows.Count > 0)
            {
                DataGridViewRow Selection = dgvMenu.SelectedRows[0];
                //txtTenSanPham.Text = Selection.Cells["colTenSanPham"].Value.ToString();
                //txtDonGia.Text = Selection.Cells["colDonGia"].Value.ToString();

                //if (decimal.TryParse(txtDonGia.Text, out decimal donGia))
                //{
                //    txtDonGia.Text = donGia.ToString("c", acultureinfo);
                //}
                if (Selection.Cells["colTenSanPham"].Value != null && Selection.Cells["colDonGia"].Value != null)
                {
                    txtTenSanPham.Text = Selection.Cells["colTenSanPham"].Value.ToString();
                    txtDonGia.Text = Selection.Cells["colDonGia"].Value.ToString();

                    object soLuongValue = Selection.Cells["colSoLuong"].Value;

                    // Kiểm tra xem giá trị có tồn tại và có phải là số nguyên không
                    if (soLuongValue != null && int.TryParse(soLuongValue.ToString(), out int soLuong))
                    {
                        nmSoLuong.Value = soLuong; // Gán giá trị vào NumericUpDown
                    }

                    if (decimal.TryParse(txtDonGia.Text, out decimal donGia))
                    {
                        txtDonGia.Text = donGia.ToString("c", acultureinfo);
                    }
                }
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            BanDTO ban = dgvMenu.Tag as BanDTO;

            if (ban == null)
            {
                MessageBox.Show(CONST.TBChuaChonBan, CONST.TB);
                return;
            }

            int idBill = HoaDonDAO.Instance.GetUncheckBillIDTableID(ban.MABAN);
            //int foodID = (cbbTenSanPham.SelectedItem as SanPhamDTO).MASANPHAM;
            int foodID = (int)btnThem.Tag;
            int count = (int)nmSoLuong.Value;
            if (count <= 0)
            {
                MessageBox.Show(CONST.TBNhapSoDuong, CONST.TB);
                nmSoLuong.Value = 0;
                return;
            }

            if (idBill == -1)
            {
                HoaDonDAO.Instance.ThemVaoHoaDon(ban.MABAN);
                CT_HoaDonDAO.Instance.ThemVaoCT_HoaDon(HoaDonDAO.Instance.LayHoaDonLonNhat(), foodID, count);
            }
            else
            {
                CT_HoaDonDAO.Instance.ThemVaoCT_HoaDon(idBill, foodID, count);
            }

        }

        private void dgvMenu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvMenu.Rows[e.RowIndex];
                //int foodID = (int)row.Cells["colMSP"].Value;
                //// Lưu thông tin sản phẩm vào tag của nút "Thêm"
                //btnThem.Tag = foodID;
                if (row.Cells["colMSP"].Value != null && int.TryParse(row.Cells["colMSP"].Value.ToString(), out int foodID))
                {
                    // Lưu thông tin sản phẩm vào tag của nút "Thêm"
                    btnThem.Tag = foodID;
                }
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            BanDTO ban = dgvMenu.Tag as BanDTO;

            if (ban == null)
            {
                MessageBox.Show(CONST.TBChuaHD, CONST.TB);
                return;
            }

            int MaHoaDon = HoaDonDAO.Instance.GetUncheckBillIDTableID(ban.MABAN);

            if (MaHoaDon != -1)
            {

                int GiamGia = (int)nbGiamGia.Value;



                decimal TongTien = decimal.Parse(txtTongTien.Text.Split(',')[0].Replace(".", ""));

                decimal TongTienTT = TongTien - (TongTien / 100) * GiamGia;

                if (txtSDT.Text == string.Empty)
                {


                    DialogResult result = MessageBox.Show(string.Format(CONST.TBXacNhapThanhToan, ban.TENBAN, TongTien, GiamGia, TongTienTT), CONST.XN, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        HoaDonDAO.Instance.CheckOutNotKhH(MaHoaDon, GiamGia,TongTienTT,manhanvien);
                        DialogResult inhdkkh = MessageBox.Show(CONST.TBXNInHD, CONST.XN, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (inhdkkh == DialogResult.Yes)
                        {

                            DataTable dt = HoaDonDAO.Instance.LayDLXuatHD(MaHoaDon);
                            //Gán dữ liệu cho Crystal Report
                            crHoaDon XuatHD = new crHoaDon();
                            XuatHD.SetDataSource(dt);
                            //hiển thị báo cáo
                            frmInHoaDon GUI = new frmInHoaDon();
                            GUI.crpHoaDon.ReportSource = XuatHD;
                            GUI.ShowDialog();
                        }
                    }

                }
                else
                {
                    string sdt = txtSDT.Text;

                    DialogResult result = MessageBox.Show(string.Format(CONST.TBXacNhapThanhToan, ban.TENBAN, TongTien, GiamGia, TongTienTT), CONST.XN, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        HoaDonDAO.Instance.CheckOut(MaHoaDon, GiamGia, sdt, TongTienTT,manhanvien);

                        DialogResult inhdkkh = MessageBox.Show(CONST.TBXNInHD, CONST.XN, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (inhdkkh == DialogResult.Yes)
                        {

                            DataTable dt = HoaDonDAO.Instance.LayDLXuatHD(MaHoaDon);
                            //Gán dữ liệu cho Crystal Report
                            crHoaDon XuatHD = new crHoaDon();
                            XuatHD.SetDataSource(dt);
                            //hiển thị báo cáo
                            frmInHoaDon GUI = new frmInHoaDon();
                            GUI.crpHoaDon.ReportSource = XuatHD;
                            GUI.ShowDialog();
                        }
                    }
                }
                ShowBill(ban.MABAN);
                LoadBan();

            }
            else
            {
                MessageBox.Show(CONST.TBKhongHD, CONST.TB);

            }
            ResetTextThemSP();
        }

        private void btnThemKhach_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtTenKhachHang.Text) || string.IsNullOrEmpty(txtSDT.Text))
            {
                MessageBox.Show(CONST.CanhBaoDeTrong,CONST.TB);
                return;
            }

            if (NhanVienDAO.Instance.KiemTraDoDaiSDT(txtSDT.Text) == false)
            {

                MessageBox.Show(CONST.CanhBaokytusdt, CONST.TB);
                return;
            }

            KhachHangDTO newkh = new KhachHangDTO
            {
                HOTEN = txtTenKhachHang.Text,
                SDT = txtSDT.Text,
            };

            if(KhachHangBus.KiemtraSDTThem(newkh) == false)
            {
                MessageBox.Show("Khách hàng" + txtTenKhachHang.Text + "đã được thêm trước");
                txtTenKhachHang.Text = string.Empty;
                return;
            }    
            if(KhachHangBus.ThemKH(newkh))
            {
                MessageBox.Show(CONST.themTC, CONST.TB);
            }
            else
            {
                MessageBox.Show(CONST.themTB,CONST.TB);
            }
            txtTenKhachHang.Text = string.Empty;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dgvSanPham.DataSource = SanphamBus.TimKiemSanPham(txtTimKiemSP.Text);
        }

        private void btnTimKiemMDM_Click(object sender, EventArgs e)
        {
            DanhMucSanPhamDTO selectedNhanVien = (DanhMucSanPhamDTO)cbbDanhMucSanPham.SelectedItem;
            int makhach = selectedNhanVien.MADANHMUC;
            dgvSanPham.DataSource = SanphamBus.TimKiemTENDanhMuc(makhach);
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void frmDatHang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1 )
            {
                btnThem.PerformClick();
            }
            else if (e.KeyCode == Keys.F2)
            {
                btnXoa.PerformClick();
            }
            else if (e.KeyCode == Keys.F3)
            {
                btnThemKhach.PerformClick();
            }
            else if (e.KeyCode == Keys.F4)
            {
                btnThanhToan.PerformClick();
            }
        }
    }
}