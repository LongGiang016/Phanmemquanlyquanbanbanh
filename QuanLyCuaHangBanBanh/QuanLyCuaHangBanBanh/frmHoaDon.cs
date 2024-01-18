using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUSS;
using DAO;
using System.Data.Entity.Infrastructure;
using System.Globalization;

namespace QuanLyCuaHangBanBanh
{
    public partial class frmHoaDon : Form
    {
        HoaDonBUS _hdb = new HoaDonBUS();
        CT_HoaDonBUS _cthd = new CT_HoaDonBUS();
        public frmHoaDon()
        {
            InitializeComponent();
            loaddshd();
            loadcbbnhanvien();
            loadcbbKhachHang();
        }

        private void loaddshd()
        {
            dgvDSHD.DataSource = _hdb.LoadDSHD();
        }

        public void loadcbbKhachHang()
        {

            cbbTenKhachHang.DataSource = SanPhamDAO.Instance.loadsanpham();
            cbbTenKhachHang.DisplayMember = "TENSANPHAM";
            cbbTenKhachHang.DisplayMember = "MASANPHAM";
            cbbTenKhachHang.Format += (s, e) => e.Value = $"{((SanPhamDTO)e.ListItem).MASANPHAM} - {((SanPhamDTO)e.ListItem).TENSANPHAM}";
           
        }

        public void loadcbbnhanvien()
        {
            cbbNhanVien.DataSource = NhanVienDAO.Instance.LoadNhanVien();
            cbbNhanVien.DisplayMember= "HOTEN";
            cbbNhanVien.DisplayMember = "MANHANVIEN";
            cbbNhanVien.Format += (s, e) => e.Value = $"{((NhanVienDTO)e.ListItem).MANHANVIEN} - {((NhanVienDTO)e.ListItem).HOTEN}";
        }

        private void HienThiChiTietHoaDon(int mahoadon)
        {
            dgvCTHD.DataSource = _cthd.Load(mahoadon);
        }
        public void dgvDSHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDSHD.Rows[e.RowIndex];
                // Lấy mã hóa đơn từ cột "MAHOADON" trong hàng được chọn
                int maHoaDon = Convert.ToInt32(row.Cells["MAHOADON"].Value);
                HienThiChiTietHoaDon(maHoaDon);
                label8.Text = maHoaDon.ToString();
            }
        }

        private void btnTimKiemNhanVien_Click(object sender, EventArgs e)
        {
            //dgvCTHD.Rows.Clear();

            if (cbbNhanVien.SelectedItem != null)
            {
                NhanVienDTO selectedNhanVien = (NhanVienDTO)cbbNhanVien.SelectedItem;
                int maNhanVien = selectedNhanVien.MANHANVIEN;
                dgvDSHD.DataSource = _hdb.LoadDSHDTheoMaNhanVien(maNhanVien);
                decimal tongHoaDon = (decimal)_hdb.LoadDSHDTheoMaNhanVien(maNhanVien).Sum(h => h.TONGHOADON);
                txtTongHoaDon.Text = tongHoaDon.ToString();
               

            }
        }

        private void btnTimKiemKhach_Click(object sender, EventArgs e)
        {
            //dgvCTHD.Rows.Clear();
            if (cbbTenKhachHang.SelectedItem != null)
            {
                SanPhamDTO selectedNhanVien = (SanPhamDTO)cbbTenKhachHang.SelectedItem;
                int makhach = selectedNhanVien.MASANPHAM;
                dgvDSHD.DataSource = _hdb.LoadDSHDTheoMaKhach(makhach);
                decimal tongHoaDon = (decimal)_hdb.LoadDSHDTheoMaKhach(makhach).Sum(h => h.TONGHOADON);
                txtTongHoaDon.Text = tongHoaDon.ToString();
               
            }
        }

        private void btnTimKiemTheoMaHD_Click(object sender, EventArgs e)
        {
            //dgvCTHD.Rows.Clear();
            if (string.IsNullOrEmpty(txtMaHoaDon.Text))
            {
                MessageBox.Show(CONST.TBNhapMaHD,CONST.TB);
                return;
            }
            int mahoadon = int.Parse(txtMaHoaDon.Text);
            dgvDSHD.DataSource = _hdb.LoadDSHDTheoMaHoaDon(mahoadon);
            decimal tongHoaDon = (decimal)_hdb.LoadDSHDTheoMaHoaDon(mahoadon).Sum(h => h.TONGHOADON);
            txtTongHoaDon.Text = tongHoaDon.ToString();
            
        }

        private void btnTimKiemTheoTime_Click(object sender, EventArgs e)
        {
            ////dgvCTHD.Rows.Clear();
            //if (dtNgayKetThuc.Value < dtNgayBatDau.Value)
            //{
            //    MessageBox.Show(CONST.TBSaiNgay, CONST.TB);
            //    return;
            //}    
            dgvDSHD.DataSource = _hdb.LoadDSHDTheoNgay(dtNgayBatDau.Value);
            decimal tongHoaDon = (decimal)_hdb.LoadDSHDTheoNgay(dtNgayBatDau.Value).Sum(h => h.TONGHOADON);
            txtTongHoaDon.Text = tongHoaDon.ToString();
           
        }

        private void btnInThongKe_Click(object sender, EventArgs e)
        {

            if(radNhanVien.Checked)
            {
                BaoCaoThongKeTheoNhanVien BCTK = new BaoCaoThongKeTheoNhanVien();
                NhanVienDTO selectedNhanVien = (NhanVienDTO)cbbNhanVien.SelectedItem;
                int maNhanVien = selectedNhanVien.MANHANVIEN;
                BCTK.SetDataSource(HoaDonDAO.Instance.LayDLXuatHDtheonv(maNhanVien));
                frmInHoaDon GUI = new frmInHoaDon();
                GUI.crpHoaDon.ReportSource = BCTK;
                GUI.ShowDialog();
            }
            if(radMaKhach.Checked)
            {

                BaoCaoThongKeTheoSanPham BCTK = new BaoCaoThongKeTheoSanPham();
                SanPhamDTO selectedNhanVien = (SanPhamDTO)cbbTenKhachHang.SelectedItem;
                int masp = selectedNhanVien.MASANPHAM; ;
                BCTK.SetDataSource(HoaDonDAO.Instance.LayDLXuatHDtheomasp(masp));
                frmInHoaDon GUI = new frmInHoaDon();
                GUI.crpHoaDon.ReportSource = BCTK;
                GUI.ShowDialog();
            }
            if(radNgay.Checked)
            {

                BaoCaoThongKeTheoNgay BCTK = new BaoCaoThongKeTheoNgay();

                BCTK.SetDataSource(HoaDonDAO.Instance.LayDLXuatHDtheongay(dtNgayBatDau.Value));
                //BCTK.SetParameterValue("NGAYBATDAU", dtNgayBatDau.Value);
                //BCTK.SetParameterValue("NGAYKETTHUC", dtNgayKetThuc.Value);
                frmInHoaDon GUI = new frmInHoaDon();
                GUI.crpHoaDon.ReportSource = BCTK;
                GUI.ShowDialog();
            }

            if(radMaHoaDon.Checked)
            {
                if(string.IsNullOrEmpty(txtMaHoaDon.Text))
                {
                    MessageBox.Show(CONST.CanhBaoDeTrong,CONST.TB);
                    return;
                }    
                int mahd = int.Parse(txtMaHoaDon.Text);
                DataTable dt = HoaDonDAO.Instance.LayDLXuatHD(mahd);
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
}
