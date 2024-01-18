using BUSS;
using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangBanBanh
{
    public partial class frmNhanVien : Form
    {
        NhanVienBUS _nvbus = new NhanVienBUS();
        public int manhanvien;
        public frmNhanVien(int manhanvien)
        {
            this.manhanvien = manhanvien;
            InitializeComponent();
            dgvNhanVien.AutoGenerateColumns = false;
            loadnv();
        }

        private void loadnv()
        {
            dgvNhanVien.DataSource = _nvbus.loadNV();
        }



        private void btnThemNV_Click(object sender, EventArgs e)
        {

            if(string.IsNullOrEmpty(txtHoTen.Text)|| string.IsNullOrEmpty(txtDiaChi.Text) || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtSDT.Text) || string.IsNullOrEmpty(txtCaLamViec.Text) || string.IsNullOrEmpty(txtLuong.Text) || string.IsNullOrEmpty(txtTendangNhap.Text))
            {
                MessageBox.Show(CONST.CanhBaoDeTrong,CONST.TB);
                return;
            }

            if (NhanVienDAO.Instance.KiemTraDoDaiSDT(txtSDT.Text) == false)
            {

                MessageBox.Show(CONST.CanhBaoDoDaiSDT, CONST.TB);
                return;
            }

            Image hinhAnh = ptrNhanVien.Image;
            byte[] bytes;
            using (MemoryStream ms = new MemoryStream())
            {
                hinhAnh.Save(ms, hinhAnh.RawFormat);
                bytes = ms.ToArray();
            }

            NhanVienDTO newnv = new NhanVienDTO
            {               
                HOTEN = txtHoTen.Text,
                EMAIL = txtEmail.Text,
                LUONG = Convert.ToDecimal(txtLuong.Text),
                DIACHI = txtDiaChi.Text,
                CHUCVU = cbbChucVu.SelectedItem.ToString(),
                TENDANGNHAP = txtTendangNhap.Text,
                SDT = txtSDT.Text,
                GIOITINH = radNam.Checked ? true : false,
                CALAMVIEC = txtCaLamViec.Text,
                HINHANH = bytes,
                MATKHAU = "1",



            };
            if(_nvbus.ThemNhanVien(newnv))
            {
                MessageBox.Show(CONST.themTC, CONST.TB);
                btnReset_Click(sender, e);
            }
            else
            {
                MessageBox.Show(CONST.themTB ,CONST.TB);
            }
         
            loadnv();
        }

        private void ptrNhanVien_Click(object sender, EventArgs e)
        {

            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                ptrNhanVien.Image = Image.FromFile(open.FileName);
                this.Text = open.FileName;
            }
        }
        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            ImageConverter _imageConverter = new ImageConverter();
            Image img = (Image)_imageConverter.ConvertFrom(byteArrayIn);
            return img;
        }

        private void dgvNhanVien_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvNhanVien.SelectedRows.Count > 0)
            {
                DataGridViewRow select = dgvNhanVien.SelectedRows[0];
                txtMaNhanVien.Text = select.Cells["colMaNhanVien"].Value.ToString();
                txtHoTen.Text = select.Cells["colHoTen"].Value.ToString();
                txtEmail.Text = select.Cells["colEmail"].Value.ToString();
                txtLuong.Text = select.Cells["colLuong"].Value.ToString();
                cbbChucVu.Text = select.Cells["colChucVu"].Value.ToString();
                txtCaLamViec.Text = select.Cells["colCaLamViec"].Value.ToString();
                if (select.Cells["colGioiTinh"].Value.ToString() == "True")
                {
                    radNam.Checked = true;
                }
                else
                {
                    radNu.Checked = true;
                }
                txtSDT.Text = select.Cells["colSDT"].Value.ToString();
                txtTendangNhap.Text = select.Cells["colTenDangNhap"].Value.ToString();
                txtDiaChi.Text = select.Cells["colDiaChi"].Value.ToString();
                byte[] HinhAnh = (byte[])select.Cells["colHinhAnh"].Value;
                Image img = byteArrayToImage(HinhAnh);
                ptrNhanVien.Image = img;
            }    
        }

        private void btnSuaNV_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtHoTen.Text) || string.IsNullOrEmpty(txtMaNhanVien.Text) || string.IsNullOrEmpty(txtDiaChi.Text) || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtSDT.Text) || string.IsNullOrEmpty(txtCaLamViec.Text) || string.IsNullOrEmpty(txtLuong.Text) || string.IsNullOrEmpty(txtTendangNhap.Text))
            {
                MessageBox.Show(CONST.CanhBaoDeTrong, CONST.TB);
                return;
            }

            if (NhanVienDAO.Instance.KiemTraDoDaiSDT(txtSDT.Text) == false)
            {

                MessageBox.Show(CONST.CanhBaokytusdt, CONST.TB);
                return;
            }

            Image hinhAnh = ptrNhanVien.Image;
            byte[] bytes;
            using (MemoryStream ms = new MemoryStream())
            {
                hinhAnh.Save(ms, hinhAnh.RawFormat);
                bytes = ms.ToArray();
            }

            NhanVienDTO newnv = new NhanVienDTO
            {
                MANHANVIEN = Convert.ToInt32(txtMaNhanVien.Text),
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
                MessageBox.Show(CONST.TBTrungSDT, CONST.TB);
                return;
            }    
            if (_nvbus.SuaNhanVien(newnv))
            {
                MessageBox.Show(CONST.suaTC, CONST.TB);
                btnReset_Click(sender, e);
            }
            else
            {
                MessageBox.Show(CONST.suaTB);
            }
            loadnv();
        }

        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtMaNhanVien.Text))
            {
                MessageBox.Show(CONST.CanhBaoDeTrong, CONST.TB);
                return;
            }    
            int mnv = int.Parse(txtMaNhanVien.Text);

            NhanVienDTO efkh = new NhanVienDTO
            {
                MANHANVIEN = mnv,
            };
            if(efkh.MANHANVIEN == manhanvien)
            {
                MessageBox.Show(CONST.CanhBaoNV,CONST.TB);
                return;
            }    
            if(_nvbus.XoaNhanVien(efkh))
            {
                MessageBox.Show(CONST.xoaTC, CONST.TB);
            }
            else
            {
                MessageBox.Show(CONST.xoaTB, CONST.TB);
            }
            loadnv();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMaNhanVien.Text = string.Empty;
            txtHoTen.Text = string.Empty;
            txtCaLamViec.Text = string.Empty;
            txtEmail.Text= string.Empty;
            txtLuong.Text= string.Empty;
            txtSDT.Text= string.Empty;
            txtCaLamViec.Text= string.Empty;
            txtTendangNhap.Text = string.Empty;
            txtDiaChi.Text = string.Empty;  
            radNam.Checked = true;
            txtTimKiem.Text= string.Empty;
            loadnv();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dgvNhanVien.DataSource = _nvbus.TimKiemNhanVien(txtTimKiem.Text);
        }

        private void dgvNhanVien_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvNhanVien.Columns[e.ColumnIndex].Name == "colGioiTinh")
            {
                if (e.Value != null)
                {
                    bool gioiTinh = Convert.ToBoolean(e.Value);
                    e.Value = gioiTinh ? "Nam" : "Nữ";
                }
            }
        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void ResetPass_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtMaNhanVien.Text))
            {
                MessageBox.Show(CONST.TBKhongcoNV, CONST
                    .TB);
                return;
            }
            DialogResult result = MessageBox.Show(CONST.xacnhanRSMatKhau, CONST.TB, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                int mnv = int.Parse(txtMaNhanVien.Text);

                NhanVienDTO efkh = new NhanVienDTO
                {
                    MANHANVIEN = mnv,
                };
                if (_nvbus.ResetMatKhau(efkh))
                {

                    MessageBox.Show(CONST.suaTC, CONST.TB);
                }
                else
                {
                    MessageBox.Show(CONST.suaTB, CONST.TB);
                }
            }
        }

        private void txtLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void frmNhanVien_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D1 || e.KeyCode == Keys.NumPad1)
            {
                btnThemNV.PerformClick();
            }
            else if (e.KeyCode == Keys.D2 || e.KeyCode == Keys.NumPad2)
            {
                btnSuaNV.PerformClick();
            }
            else if (e.KeyCode == Keys.D3 || e.KeyCode == Keys.NumPad3)
            {
                btnXoaNV.PerformClick();
            }
            else if (e.KeyCode == Keys.D4 || e.KeyCode == Keys.NumPad4)
            {
                btnReset.PerformClick();
            }
        }
    }
}

