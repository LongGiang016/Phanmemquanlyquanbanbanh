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
using DTO;
using BUSS;
using System.IO;
using System.Runtime.CompilerServices;
using System.Web.Services.Description;
using DAO;

namespace QuanLyCuaHangBanBanh
{
    
    public partial class frmTaiKhoan : Form
    {
        NhanVienBUS _nvbus = new NhanVienBUS();
        private int manhanvien;
        private string matkhau;
        public frmTaiKhoan(int manhanvien, string matkhau)
        {
            InitializeComponent();
            this.manhanvien = manhanvien;
            load();
            this.matkhau = matkhau; 
        }

        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            ImageConverter _imageConverter = new ImageConverter();
            Image img = (Image)_imageConverter.ConvertFrom(byteArrayIn);
            return img;
        }

        public void load()
        {
            List<NhanVienDTO> lstNhanVien = _nvbus.loadnvtheoma(manhanvien);
            {
                if (lstNhanVien.Count > 0)
                {
                    NhanVienDTO firstNhanVien = lstNhanVien[0];
                    cbbChucVu.Text = firstNhanVien.CHUCVU;
                    txtHoTen.Text = firstNhanVien.HOTEN;
                    txtDiaChi.Text = firstNhanVien.DIACHI;
                    txtEmail.Text = firstNhanVien.EMAIL;
                    txtCaLamViec.Text = firstNhanVien.CALAMVIEC;
                    txtLuong.Text = Convert.ToString(firstNhanVien.LUONG);
                    txtTendangNhap.Text = firstNhanVien.TENDANGNHAP;
                    txtSDT.Text = firstNhanVien.SDT;
                    if (firstNhanVien.GIOITINH == true)
                    {
                        radNam.Checked = true;
                    }
                    else
                    {
                        radNu.Checked = true;
                    }
                    byte[] HinhAnh = (byte[])firstNhanVien.HINHANH;
                    Image img = byteArrayToImage(HinhAnh);
                    ptrTaiKhoan.Image = img;                   
                    // Gán các giá trị khác tương tự cho các textbox khác
                }
                
            }
        }

        
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnCapNhatTenDangNhap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenDangNhapMoi.Text) || string.IsNullOrEmpty(txtTenDangNhapMoi2.Text))
            {
                MessageBox.Show(CONST.CanhBaoDeTrongtkm, CONST.TB);
                return;
            }

            if (txtTenDangNhapMoi.Text != txtTenDangNhapMoi2.Text)
            {
                MessageBox.Show(CONST.TBTKSaiTkNhapLai,CONST.TB);
                return;
            }


            NhanVienDTO newnv = new NhanVienDTO
            {
                MANHANVIEN = manhanvien,             
                TENDANGNHAP = txtTenDangNhapMoi2.Text,
                
            };
            if (_nvbus.SuaTenDangNhap(newnv))
            {
                MessageBox.Show(CONST.TBCapNhatTKTC);
            }
            else
            {
                MessageBox.Show(CONST.TBCapNhatTKTB);
            }
            resetTenDangNhap();
            load();
        }

        private void resetTenDangNhap()
        {
            txtTenDangNhapMoi.Text = string.Empty;
            txtTenDangNhapMoi2.Text = string.Empty;
        }



        private void btnCapNhatTT_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtHoTen.Text)  || string.IsNullOrEmpty(txtDiaChi.Text) || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtSDT.Text) || string.IsNullOrEmpty(txtCaLamViec.Text) || string.IsNullOrEmpty(txtLuong.Text) || string.IsNullOrEmpty(txtTendangNhap.Text))
            {
                MessageBox.Show(CONST.CanhBaoDeTrong,CONST.TB);
                return;
            }

            if(NhanVienDAO.Instance.KiemTraDoDaiSDT(txtSDT.Text) == false)
            {

                MessageBox.Show(CONST.CanhBaokytusdt, CONST.TB);
                return;
            }    

            Image hinhAnh = ptrTaiKhoan.Image;
            byte[] bytes;
            using (MemoryStream ms = new MemoryStream())
            {
                hinhAnh.Save(ms, hinhAnh.RawFormat);
                bytes = ms.ToArray();
            }

            NhanVienDTO newnv = new NhanVienDTO
            {
                MANHANVIEN = Convert.ToInt32(manhanvien),
                HOTEN = txtHoTen.Text,
                EMAIL = txtEmail.Text,
                LUONG = Convert.ToDecimal(txtLuong.Text),
                DIACHI = txtDiaChi.Text,
                CHUCVU = cbbChucVu.Text,
                TENDANGNHAP = txtTendangNhap.Text,
                SDT = txtSDT.Text,
                GIOITINH = radNam.Checked ? true : false,
                CALAMVIEC = txtCaLamViec.Text,
                HINHANH = bytes,

            };
            if(_nvbus.KieMtraSuaNhanVien(newnv) == false)
            {
                MessageBox.Show(CONST.TBTrungSDT);
                return;
            }    
            if (_nvbus.SuaNhanVien(newnv))
            {
                MessageBox.Show(CONST.CapNhatTC);
            }
            else
            {
                MessageBox.Show(CONST.CapNhatTB);
            }
            load();
        }

        private void ptrTaiKhoan_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                ptrTaiKhoan.Image = Image.FromFile(open.FileName);
                this.Text = open.FileName;
            }
        }

        private void CapNhatMatKhau_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtMatKhau.Text) || string.IsNullOrEmpty(txtMatKhauMoi.Text) || string.IsNullOrEmpty(txtMatKhauMoi2.Text))
            {
                MessageBox.Show(CONST.CanhBaoDeTrongmkm, CONST.TB);
                return;
            }

            if (txtMatKhau.Text != matkhau)
            {
                MessageBox.Show(CONST.TBSaiMkCu,CONST.TB);
                return;
            } 
            
            
            if (txtMatKhauMoi.Text != txtMatKhauMoi2.Text )
            {
                MessageBox.Show(CONST.TBSaiMkMoi,CONST.TB);
                return;
            }
            NhanVienDTO newnv = new NhanVienDTO
            {
                MANHANVIEN = manhanvien,
                MATKHAU = txtMatKhauMoi2.Text,

            };
            if (_nvbus.SuaMatKhau(newnv))
            {
                MessageBox.Show(CONST.CapNhatMKMTC);
            }
            else
            {
                MessageBox.Show(CONST.CapNhatMKMTB);
            }
            resetMatKhau();
            
            
        }
        private void resetMatKhau()
        {
            txtMatKhauMoi.Text = string.Empty;
            txtMatKhau.Text = string.Empty;
            txtMatKhauMoi2.Text = string.Empty;
        }

        private void btnXemMK_Click(object sender, EventArgs e)
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

        private void btnXemMKmoi_Click(object sender, EventArgs e)
        {
            if (txtMatKhauMoi.PasswordChar == '*')
            {
                txtMatKhauMoi.PasswordChar = '\0'; // Hiển thị văn bản gốc (không ẩn mật khẩu)

            }
            else
            {
                txtMatKhauMoi.PasswordChar = '*'; // Ẩn mật khẩu

            }
        }


        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back )
            {
                e.Handled = true;
            }
        }

        private void btnXemMatKhauMoi2_Click(object sender, EventArgs e)
        {
            if (txtMatKhauMoi2.PasswordChar == '*')
            {
                txtMatKhau.PasswordChar = '\0'; // Hiển thị văn bản gốc (không ẩn mật khẩu)

            }
            else
            {
                txtMatKhauMoi2.PasswordChar = '*'; // Ẩn mật khẩu

            }
        }
    }
    
}
