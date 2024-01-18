using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangBanBanh
{
    public partial class frmChinh : Form
    {
        private string tennhanvien;
        private string chucvu;
        private int manhanvien;
        private string matkhau;
        public frmChinh(string tennhanvien, string chucvu, int manhanvien ,string matkhau)
        {
            InitializeComponent();

            // Gán giá trị cho dangNhapDTO từ cơ sở dữ liệu

            this.tennhanvien = tennhanvien;

            this.chucvu = chucvu;
            this.manhanvien = manhanvien;
            this.matkhau = matkhau;

            lblTenNhanVien.Text = tennhanvien;

            lblchucvu.Text = chucvu;

            PhanQuyen();


            
        }

        public void LoadForm(Object Form)
        {
            if (this.panelMain.Controls.Count > 0)
                this.panelMain.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock= DockStyle.Fill;
            this.panelMain.Controls.Add(f);
            this.panelMain.Tag= f;
            f.Show();

            

        }
        private void LoadForma(Form frm)
        {
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            this.panelMain.Controls.Clear();
            this.panelMain.Controls.Add(frm);
            this.panelMain.Tag = frm;
            frm.Show();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

      

       

      



        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            
            DialogResult result = MessageBox.Show(CONST.TBDangXuat, CONST.TB, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                lblTenNhanVien.Text = string.Empty;
                lblchucvu.Text = string.Empty;
                frmDangNhap frmdangnhap = new frmDangNhap();
                this.Close(); // đóng form chính
                frmdangnhap.Show();
            }
        }

        private void PhanQuyen()
        {
            if(lblchucvu.Text == "Nhân viên")
            {
                btnSanPham.Visible = false;
                btnThongKe.Visible = false;
                btnNhanVien.Visible = false;
                btnBanAn.Visible = false;
                btnKhachHang.Visible = false;
                btnDanhMuc.Visible = false;
                btnThongKe.Visible = false;
                
            }    
        }
        private void lblTenNhanVien_Click(object sender, EventArgs e)
        {

        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            string hexColor = CONST.MaMauChung; // Mã màu sắc, ví dụ "#00FFFF" là màu xanh lam đậm
            Color color = ColorTranslator.FromHtml(hexColor);
            btnTaiKhoan.BackColor = color;
            btnBanAn.BackColor = Color.White;
            btnThongKe.BackColor = Color.White;
            btnNhanVien.BackColor = Color.White;
            btnKhachHang.BackColor = Color.White;
            btnSanPham.BackColor = Color.White;
            btnDanhMuc.BackColor = Color.White;
            btnDatHang.BackColor = Color.White;

            LoadForm(new frmTaiKhoan(manhanvien,matkhau));
        }

       

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            string hexColor = CONST.MaMauChung; // Mã màu sắc, ví dụ "#00FFFF" là màu xanh lam đậm
            Color color = ColorTranslator.FromHtml(hexColor);
            btnKhachHang.BackColor = color;
            btnBanAn.BackColor = Color.White;
            btnThongKe.BackColor = Color.White;
            btnNhanVien.BackColor = Color.White;
            btnTaiKhoan.BackColor = Color.White;
            btnSanPham.BackColor = Color.White;
            btnDanhMuc.BackColor = Color.White;

            LoadForm(new frmKhachHang());
        }

        private void btnDanhMuc_Click(object sender, EventArgs e)
        {

            string hexColor = CONST.MaMauChung; // Mã màu sắc, ví dụ "#00FFFF" là màu xanh lam đậm
            Color color = ColorTranslator.FromHtml(hexColor);
            btnDanhMuc.BackColor = color;
            btnBanAn.BackColor = Color.White;
            btnThongKe.BackColor = Color.White;
            btnNhanVien.BackColor = Color.White;
            btnKhachHang.BackColor = Color.White;
            btnTaiKhoan.BackColor = Color.White;
            btnSanPham.BackColor = Color.White;

            LoadForm(new frmDanhMucSanPham());
        }

        private void btnDatHang_Click(object sender, EventArgs e)
        {
            string hexColor = CONST.MaMauChung; // Mã màu sắc, ví dụ "#00FFFF" là màu xanh lam đậm
            Color color = ColorTranslator.FromHtml(hexColor);
            btnDatHang.BackColor = color;
            btnBanAn.BackColor = Color.White;
            btnThongKe.BackColor = Color.White;
            btnNhanVien.BackColor = Color.White;
            btnKhachHang.BackColor= Color.White;
            btnTaiKhoan.BackColor = Color.White;
            btnSanPham.BackColor = Color.White;
            btnDanhMuc.BackColor = Color.White;
            LoadForma(new frmDatHang(manhanvien));
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            string hexColor = CONST.MaMauChung; // Mã màu sắc, ví dụ "#00FFFF" là màu xanh lam đậm
            Color color = ColorTranslator.FromHtml(hexColor);
            btnSanPham.BackColor = color;
            btnBanAn.BackColor = Color.White;
            btnThongKe.BackColor = Color.White;
            btnNhanVien.BackColor = Color.White;
            btnKhachHang.BackColor = Color.White;
            btnTaiKhoan.BackColor = Color.White;
            btnDanhMuc.BackColor = Color.White;
            btnDatHang.BackColor = Color.White;

            LoadForm(new frmSanPham());
        }

        private void btnBanAn_Click(object sender, EventArgs e)
        {
            string hexColor = CONST.MaMauChung; // Mã màu sắc, ví dụ "#00FFFF" là màu xanh lam đậm
            Color color = ColorTranslator.FromHtml(hexColor);
            btnBanAn.BackColor = color;
            btnThongKe.BackColor = Color.White;
            btnNhanVien.BackColor = Color.White;
            btnKhachHang.BackColor = Color.White;
            btnTaiKhoan.BackColor = Color.White;
            btnSanPham.BackColor = Color.White;
            btnDanhMuc.BackColor = Color.White;
            LoadForm(new frmBan());
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            string hexColor = CONST.MaMauChung; // Mã màu sắc, ví dụ "#00FFFF" là màu xanh lam đậm
            Color color = ColorTranslator.FromHtml(hexColor);
            btnNhanVien.BackColor = color;
            btnBanAn.BackColor = Color.White;
            btnThongKe.BackColor = Color.White;
            btnKhachHang.BackColor = Color.White;
            btnTaiKhoan.BackColor = Color.White;
            btnDanhMuc.BackColor = Color.White;
            btnSanPham.BackColor = Color.White;

            LoadForm(new frmNhanVien(manhanvien));
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            string hexColor = CONST.MaMauChung; // Mã màu sắc, ví dụ "#00FFFF" là màu xanh lam đậm
            Color color = ColorTranslator.FromHtml(hexColor);
            btnThongKe.BackColor = color;
            btnBanAn.BackColor = Color.White;
            btnNhanVien.BackColor = Color.White;
            btnKhachHang.BackColor = Color.White;
            btnTaiKhoan.BackColor = Color.White;
            btnSanPham.BackColor = Color.White;
            btnDanhMuc.BackColor = Color.White;
            LoadForm(new frmHoaDon());
        }

        private void frmChinh_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D1 || e.KeyCode == Keys.NumPad1)
            {
                btnDatHang.PerformClick();
            }
            else if (e.KeyCode == Keys.D2 || e.KeyCode == Keys.NumPad2)
            {
                btnTaiKhoan.PerformClick();
            }
            else if (e.KeyCode == Keys.D3 || e.KeyCode == Keys.NumPad3)
            {
                btnSanPham.PerformClick();
            }
            else if (e.KeyCode == Keys.D4 || e.KeyCode == Keys.NumPad4)
            {
                 btnThongKe.PerformClick();
            }
            else if (e.KeyCode == Keys.D5 || e.KeyCode == Keys.NumPad5)
            {
                btnNhanVien.PerformClick();
            }
            else if (e.KeyCode == Keys.D6 || e.KeyCode == Keys.NumPad6)
            {
                btnBanAn.PerformClick();

            }
            else if (e.KeyCode == Keys.D7 || e.KeyCode == Keys.NumPad7)
            {
                btnKhachHang.PerformClick();
            }
            else if (e.KeyCode == Keys.D8 || e.KeyCode == Keys.NumPad8)
            {
                btnDanhMuc.PerformClick();
            }
            else if (e.KeyCode == Keys.F12)
            {
                btnDangXuat.PerformClick();
            }
        }

        private void frmChinh_KeyPress(object sender, KeyPressEventArgs e)
        {
        }
    }
}
