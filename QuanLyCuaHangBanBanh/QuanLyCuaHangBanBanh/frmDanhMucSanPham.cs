using BUSS;
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
    public partial class frmDanhMucSanPham : Form
    {

        DanhMucSanPhamBUS _dmbus = new DanhMucSanPhamBUS();
        public frmDanhMucSanPham()
        {
            InitializeComponent();
            loaddanhmucsanpham();
            dgvDanhMuc.AutoGenerateColumns = false;
        }

        private void loaddanhmucsanpham()
        {
            dgvDanhMuc.DataSource = DanhMucSanPhamDAO.Instance.LayDanhSach();
        }

        private void bntThem_Click(object sender, EventArgs e)
        {
            if (txtTenDanhMuc.Text == string.Empty)
            {
                MessageBox.Show(CONST.TBChonThemDM, CONST.TB, MessageBoxButtons.OKCancel);
                return;
            }
            DanhMucSanPhamDTO newDM = new DanhMucSanPhamDTO()
            {
                TENDANHMUC = txtTenDanhMuc.Text
            };
            if(DanhMucSanPhamDAO.Instance.KiemtraDanhMucThem(newDM) == false)
            {
                MessageBox.Show(CONST.TBTrungDanhMuc, CONST.TB);
                return;
            }    
            if (DanhMucSanPhamDAO.Instance.ThemDanhMuc(newDM))
            {
                MessageBox.Show(CONST.themTC ,CONST.TB);
            }
            else
            {
                MessageBox.Show(CONST.themTB, CONST.TB);
            }
            btnLamMoi_Click(sender, e);
        }

        private void dgvDanhMuc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        //    int i = e.RowIndex;
        //    if (i == -1) return;
        //    txtMaDanhMuc.Text = dgvDanhMuc.Rows[i].Cells["colMaDanhMuc"].Value.ToString();
        //    txtTenDanhMuc.Text = dgvDanhMuc.Rows[i].Cells["colTenDanhMuc"].Value.ToString();
        }

        private void dgvDanhMuc_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvDanhMuc.SelectedRows.Count > 0)
            {
                DataGridViewRow select = dgvDanhMuc.SelectedRows[0];
                txtMaDanhMuc.Text = select.Cells["colMaDanhMuc"].Value.ToString();
                txtTenDanhMuc.Text = select.Cells["colTenDanhMuc"].Value.ToString();

            }    
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaDanhMuc.Text) || string.IsNullOrEmpty(txtTenDanhMuc.Text))
            {
                MessageBox.Show(CONST.TBChonSuaDM, CONST.TB, MessageBoxButtons.OKCancel);
                return;
            } 
            DanhMucSanPhamDTO upDM = new DanhMucSanPhamDTO()
            {
                MADANHMUC = Convert.ToInt32(txtMaDanhMuc.Text),
                TENDANHMUC = txtTenDanhMuc.Text
            };
            if(_dmbus.KiemtraDanhMucSua(upDM) == false)
            {
                MessageBox.Show(CONST.TBTrungDanhMuc, CONST.TB);
                return;
            }    
            if (DanhMucSanPhamDAO.Instance.SuaDanhMuc(upDM))
            {
                MessageBox.Show(CONST.suaTC, CONST.TB);
            }
            else
            {
                MessageBox.Show(CONST.suaTB, CONST.TB);
            }
            btnLamMoi_Click(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaDanhMuc.Text))
            {
                MessageBox.Show(CONST.TBNhapMaDM, CONST.TB, MessageBoxButtons.OKCancel);
                return;
            }
            DanhMucSanPhamDTO delDM = new DanhMucSanPhamDTO()
            {
                MADANHMUC = Convert.ToInt32(txtMaDanhMuc.Text)
            };
            DialogResult result = MessageBox.Show(CONST.xacnhanxoaDM, CONST.TB, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                if (_dmbus.SetMaDMKoDcXoa(delDM) == true)
                {
                    MessageBox.Show(CONST.TBTrungDanhMucSP);
                    return;
                }
                if (DanhMucSanPhamDAO.Instance.XoaDanhMuc(delDM))
                {
                    MessageBox.Show(CONST.xoaTC, CONST.TB);

                }
                else
                {
                    MessageBox.Show(CONST.TBTrungDanhMucTrongDm);
                }
            }
            btnLamMoi_Click(sender, e);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaDanhMuc.Text = string.Empty;
            txtTenDanhMuc.Text = string.Empty;
            loaddanhmucsanpham();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dgvDanhMuc.DataSource = DanhMucSanPhamDAO.Instance.TimKiemTheoDanhMuc(txtTenDanhMuc.Text);
        }

        private void frmDanhMucSanPham_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.A)
            {
                bntThem .PerformClick();
            }
            else if (e.KeyCode == Keys.F2)
            {
                btnSua.PerformClick();
            }
            else if (e.KeyCode == Keys.F3)
            {
                btnXoa.PerformClick();
            }
            else if (e.KeyCode == Keys.F4)
            {
                btnLamMoi.PerformClick();
            }
        }
    }
}
