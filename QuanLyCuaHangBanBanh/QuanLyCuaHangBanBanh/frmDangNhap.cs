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


namespace QuanLyCuaHangBanBanh
{
    public partial class frmDangNhap : Form
    {
        
        public frmDangNhap()
        {
            InitializeComponent();
            
            
        }


        private void btnDangNhap_Click(object sender, EventArgs e)
        {

            if((string.IsNullOrEmpty(txtTaiKhoan.Text))  || string.IsNullOrEmpty(txtMatKhau.Text))
            {
                MessageBox.Show(CONST.CanhBaoDeTrongtkmk, CONST.TB);
                return;
            }    
            string tendangnhap = txtTaiKhoan.Text;
            string matkhau = txtMatKhau.Text;
            int manhanvien;
            string chucvu = "";
            string tennhanvien = "";
            NhanVienDAO dangNhapDAO = new NhanVienDAO();
            NhanVienDTO dangNhap = dangNhapDAO.KiemtraDangNhap(tendangnhap, matkhau);
            if (dangNhap != null)
            {
               
                tennhanvien = dangNhap.HOTEN;
                chucvu = dangNhap.CHUCVU;
                manhanvien = dangNhap.MANHANVIEN;
                frmNhanVien frmnhanvien = new frmNhanVien(manhanvien);
                frmTaiKhoan frmtaikhoan = new frmTaiKhoan(manhanvien, matkhau);
                frmDatHang frmdathang = new frmDatHang(manhanvien);
                frmChinh frmchinh = new frmChinh(tennhanvien, chucvu,manhanvien, matkhau);
                
                this.Hide();
                frmchinh.Show();

            }
            else
            {
                MessageBox.Show(CONST.TBNhapTenVaMK, CONST.TB);
            }

          

        }

        private void btnDongApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            if (txtMatKhau.PasswordChar == '*')
            {
                txtMatKhau.PasswordChar = '\0'; // Hiển thị văn bản gốc (không ẩn mật khẩu)
                
            }
            else
            {
                txtMatKhau.PasswordChar = '*'; // Ẩn mật khẩu
                
            }

        }

        private void frmDangNhap_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void frmDangNhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {               
                btnDangNhap.PerformClick();
            }
        }



        //private bool KiemtraDangNhap(string tendangnhap , string matkhau)
        //{

        //    if(DangNhapDAO.Instance.LayThongTinDangNhap(tendangnhap, matkhau));
        //}

    }
}
