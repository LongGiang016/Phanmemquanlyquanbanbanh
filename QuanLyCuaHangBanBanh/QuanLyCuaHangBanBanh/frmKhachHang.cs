using BUSS;
using DTO;
using DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.CompilerServices;

namespace QuanLyCuaHangBanBanh
{
    public partial class frmKhachHang : Form
    {
        KhachHangBUS _khb = new KhachHangBUS();
        public frmKhachHang()
        {
            InitializeComponent();
            load();
            dgvKhachHang.AutoGenerateColumns = false;

        }

        private void load()
        {
            dgvKhachHang.DataSource = _khb.load();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtTenKhach.Text))
            {
                MessageBox.Show(CONST.CanhBaoDeTrong, CONST.TB);
                return;
            }
            if (NhanVienDAO.Instance.KiemTraDoDaiSDT(txtSDT.Text) == false)
            {

                MessageBox.Show(CONST.CanhBaoDoDaiSDT, CONST.TB);
                return;
            }
            KhachHangDTO newkh = new KhachHangDTO
            {
                HOTEN = txtTenKhach.Text,
                SDT = txtSDT.Text,
            };

            if (_khb.KiemtraSDTThem(newkh) == false)
            {
                MessageBox.Show(CONST.CanhBaoSĐTTrung, CONST.TB);
                return;
            }    
            if(_khb.ThemKH(newkh))
            {
                MessageBox.Show(CONST.themTC, CONST.TB);
            }
            else
            {
                MessageBox.Show(CONST.themTB, CONST.TB);
            }
            ResetText();
            load();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtTenKhach.Text) || string.IsNullOrEmpty(txtSDT.Text))
            {
                MessageBox.Show(CONST.CanhBaoDeTrong, CONST.TB);
                return;
            }

            if (_khb.KiemtraDodaisdt(txtSDT.Text) == false)
            {
                MessageBox.Show(CONST.CanhBaoDoDaiSDT, CONST.TB);
                return;
            }

            KhachHangDTO newkh = new KhachHangDTO
            {
                MAKHACHHANG = Convert.ToInt32(txtMaKhach.Text),
                HOTEN = txtTenKhach.Text,
                SDT = txtSDT.Text
            };


            if(_khb.KiemtraSDTSua(newkh) == false)
            {
                MessageBox.Show(CONST.CanhBaoSĐTTrung, CONST.TB);
                return;
            }    
            if (_khb.SuaKh(newkh))
            {
                MessageBox.Show(CONST.suaTC, CONST.TB);
            }
            else
            {
                MessageBox.Show(CONST.suaTB, CONST.TB);
            }
            ResetText();
            load();

        }
          private void btnRest_Click(object sender, EventArgs e)
        {
            txtMaKhach.Text = string.Empty;
            txtSDT.Text = string.Empty;
            txtTenKhach.Text = string.Empty;
            load();
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtMaKhach.Text))
            {
                MessageBox.Show(CONST.CanhBaoChuaNhapMaXoa, CONST.TB, MessageBoxButtons.OKCancel);
                return;
            }
            KhachHangDTO delDM = new KhachHangDTO()
            {
                MAKHACHHANG = Convert.ToInt32(txtMaKhach.Text)
            };
            DialogResult result = MessageBox.Show(CONST.xacnhanxoaKH, CONST.TB, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {

            
                if (_khb.XoaKh(delDM))
                {
                    MessageBox.Show(CONST.xoaTC,CONST.TB);

                }
                else
                {
                    MessageBox.Show(CONST.xoaTB,CONST.TB);
                }
            }
            ResetText();
            load();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dgvKhachHang.DataSource = _khb.TimKiemKhachHang(txtTimKiem.Text);
        }

        private void dgvKhachHang_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvKhachHang.SelectedRows.Count > 0)
            {
                DataGridViewRow select = dgvKhachHang.SelectedRows[0];
                txtMaKhach.Text = select.Cells["colMaKhachHang"].Value.ToString();
                txtTenKhach.Text = select.Cells["colTenKhachHang"].Value.ToString();
                txtSDT.Text = select.Cells["colSDT"].Value.ToString();

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

        private void frmKhachHang_KeyDown(object sender, KeyEventArgs e)
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
                btnRest.PerformClick();
            }
        }
    }
}
