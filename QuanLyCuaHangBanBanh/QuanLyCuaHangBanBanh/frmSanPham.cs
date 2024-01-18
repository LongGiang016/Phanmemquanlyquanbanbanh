
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
using BUSS;
using System.Windows.Navigation;

namespace QuanLyCuaHangBanBanh
{
    public partial class frmSanPham : Form
    {
        SanPhamBUS _spbus = new SanPhamBUS();

        quanlycuahangbanhSHBEntities _qlch = new quanlycuahangbanhSHBEntities();
        private Image defaultImage;
        public frmSanPham()
        {
            InitializeComponent();
            LoadSP();
            dgvSanPham.AutoGenerateColumns = false;
            LoadDanhMucSanPham();
            defaultImage = ptrSanPham.Image;
            //Image image = Image.FromFile("../../../HinhAnhBanhLamDoAn/default_img.png");


        }

        private void LoadDanhMucSanPham()
        {
            List<DanhMucSanPhamDTO> listDanhMuc = DanhMucSanPhamDAO.Instance.LayDanhSach();
            cbbDanhMucSanPham.DataSource = listDanhMuc;
            cbbDanhMucSanPham.DisplayMember = "TENDANHMUC";
        }

        private void LoadSP()
        {
            //dgvSanPham.DataSource = _spbus.loadSP();
            dgvSanPham.DataSource = SanPhamDAO.Instance.loadsanpham();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenSanPham.Text) || string.IsNullOrEmpty(txtMoTa.Text) || string.IsNullOrEmpty(txtDonGia.Text))
            {
                MessageBox.Show(CONST.CanhBaoDeTrong,CONST.TB);
                return;
            }
            Image hinhAnh = ptrSanPham.Image;
            byte[] bytes;
            using (MemoryStream ms = new MemoryStream())
            {
                hinhAnh.Save(ms, hinhAnh.RawFormat);
                bytes = ms.ToArray();
            }

            SanPhamDTO newwsp = new SanPhamDTO
            {
                
                TENSANPHAM = txtTenSanPham.Text,
                MADANHMUC = ((DanhMucSanPhamDTO)cbbDanhMucSanPham.SelectedItem).MADANHMUC,
                DONGIA = Convert.ToDecimal(txtDonGia.Text),
                SOLUONG = int.Parse(nmSoLuong.Text),
                MOTA = txtMoTa.Text,
                HINHANH = bytes


            };
            if (SanPhamDAO.Instance.KiemtraTen(newwsp) == false)
            {
                MessageBox.Show(CONST.TBSpTonTai);
                return;
            }    
            if (SanPhamDAO.Instance.ThemSP(newwsp))
            {
                MessageBox.Show(CONST.themTC);
            }
            else
            {
                MessageBox.Show(CONST.themTB);
            }
            btnLamMoi_Click(sender, e);
            LoadSP();
        }

        private void ptrSanPham_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                ptrSanPham.Image = Image.FromFile(open.FileName);
                this.Text = open.FileName;
            }
        }

        private void dgvSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //int i = e.RowIndex;
            //if (i == -1) return;
            //txtMaSanPham.Text = dgvSanPham.Rows[i].Cells["colMaSanPham"].Value.ToString();
            //cbbDanhMucSanPham.SelectedValue = dgvSanPham.Rows[i].Cells["colTenDanhMuc"].Value;
            //txtDonGia.Text = dgvSanPham.Rows[i].Cells["colDonGia"].Value.ToString();
            //txtMoTa.Text = dgvSanPham.Rows[i].Cells["colMoTa"].Value.ToString();
            //nmSoLuong.Text = dgvSanPham.Rows[i].Cells["colSoLuong"].Value.ToString();
            //txtTenSanPham.Text = dgvSanPham.Rows[i].Cells["colTenSanPham"].Value.ToString();
            //byte[] HinhAnh = (byte[])dgvSanPham.Rows[i].Cells["colHinhAnh"].Value;
            //Image img = byteArrayToImage(HinhAnh);
            //ptrSanPham.Image = img;
        }

        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            ImageConverter _imageConverter = new ImageConverter();
            Image img = (Image)_imageConverter.ConvertFrom(byteArrayIn);
            return img;
        }

        private void dgvSanPham_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSanPham.SelectedRows.Count > 0)
            {
                DataGridViewRow selected = dgvSanPham.SelectedRows[0];
                txtTenSanPham.Text = selected.Cells["colTenSanPham"].Value.ToString();
                txtDonGia.Text = selected.Cells["colDonGia"].Value.ToString();
                txtMaSanPham.Text = selected.Cells["colMaSanPham"].Value.ToString();
                txtMoTa.Text = selected.Cells["colMoTa"].Value.ToString();
                object soLuongValue = selected.Cells["colSoLuong"].Value;
                // Kiểm tra xem giá trị có tồn tại và có phải là số nguyên không
                if (soLuongValue != null && int.TryParse(soLuongValue.ToString(), out int soLuong))
                {
                    nmSoLuong.Value = soLuong; // Gán giá trị vào NumericUpDown
                }
                byte[] HinhAnh = (byte[])selected.Cells["colHinhAnh"].Value;
                Image img = byteArrayToImage(HinhAnh);
                ptrSanPham.Image = img;
            }
        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ptrSanPham.Image = defaultImage;
            txtMaSanPham.Text = string.Empty;
            txtDonGia.Text = string.Empty;
            nmSoLuong.Value = 1;
            txtTenSanPham.Text = string.Empty;
            txtMoTa.Text = string.Empty;
            LoadSP();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenSanPham.Text) || string.IsNullOrEmpty(txtMoTa.Text) || string.IsNullOrEmpty(txtDonGia.Text) || string.IsNullOrEmpty(txtMaSanPham.Text))
            {
                MessageBox.Show(CONST.CanhBaoChuaChonSpSua, CONST.TB);
                return;
            }

            Image hinhAnh = ptrSanPham.Image;
            byte[] bytes;
            using (MemoryStream ms = new MemoryStream())
            {
                hinhAnh.Save(ms, hinhAnh.RawFormat);
                bytes = ms.ToArray();
            }
            SanPhamDTO newwsp = new SanPhamDTO
            {
                MASANPHAM = Convert.ToInt32(txtMaSanPham.Text),
                TENSANPHAM = txtTenSanPham.Text,
                MADANHMUC = ((DanhMucSanPhamDTO)cbbDanhMucSanPham.SelectedItem).MADANHMUC,
                DONGIA = Convert.ToDecimal(txtDonGia.Text),
                SOLUONG = int.Parse(nmSoLuong.Text),
                MOTA = txtMoTa.Text,
                HINHANH = bytes
            };

            if(_spbus.KiemtraSanPhamSua(newwsp) == false)
            {
                MessageBox.Show(CONST.CanhBaoTenSanPhamTrung);
                return;
            }
            
            if (_spbus.Suasp(newwsp))
            {
                MessageBox.Show(CONST.suaTC);
            }
            else
            {
                MessageBox.Show(CONST.suaTB);
            }
            btnLamMoi_Click(sender, e);
            LoadSP();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtMaSanPham.Text))
            {
                MessageBox.Show(CONST.CanhBaoChuaNhapMaXoa,CONST.TB);
            }
            DialogResult result = MessageBox.Show(CONST.xacnhanxoaSP, CONST.TB, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {


                SanPhamDTO newwsp = new SanPhamDTO
                {
                    MASANPHAM = Convert.ToInt32(txtMaSanPham.Text),
                };

                if(_spbus.KiemtraSanPhamTTtongHoaDon(newwsp) == true)
                {
                    MessageBox.Show(CONST.xoaTBTonTaiTrongHoaDon);
                    return;
                }    
                if (_spbus.Xoasp(newwsp))
                {
                    MessageBox.Show(CONST.xoaTC);
                }
                else
                {
                    MessageBox.Show(CONST.xoaTB);
                }
                btnLamMoi_Click(sender, e);
                LoadSP();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DanhMucSanPhamDTO selectedNhanVien = (DanhMucSanPhamDTO)cbbDanhMucSanPham.SelectedItem;
            int makhach = selectedNhanVien.MADANHMUC;
            dgvSanPham.DataSource = _spbus.TimKiemTENDanhMuc(makhach);
        }

        private void btnTimKiemTenSP_Click(object sender, EventArgs e)
        {
            dgvSanPham.DataSource = _spbus.TimKiemSanPham(txtTenSanPham.Text);
        }

        private void btnTKMaSP_Click(object sender, EventArgs e)
        {
            dgvSanPham.DataSource = _spbus.TimKiemTheoMa(Convert.ToInt32(txtMaSanPham.Text));
        }

        private void txtMaSanPham_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void frmSanPham_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D1 || e.KeyCode == Keys.NumPad1)
            {
                btnThem.PerformClick();
            }
            else if (e.KeyCode == Keys.D2 || e.KeyCode == Keys.NumPad2)
            {
                btnSua.PerformClick();
            }
            else if (e.KeyCode == Keys.D3 || e.KeyCode == Keys.NumPad3)
            {
                btnXoa.PerformClick();
            }
            else if (e.KeyCode == Keys.D4 || e.KeyCode == Keys.NumPad4)
            {
                btnLamMoi.PerformClick();
            }
        }

    }
}
