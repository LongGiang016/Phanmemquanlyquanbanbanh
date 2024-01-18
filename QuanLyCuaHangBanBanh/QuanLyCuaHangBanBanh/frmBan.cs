using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUSS;
using DAO;
using DTO;

namespace QuanLyCuaHangBanBanh
{
    public partial class frmBan : Form
    {
        /*frmDangNhap dn = new frmDangNhap();
        DanhNhapDTO d = new DanhNhapDTO();
        BanBUS _bb = new BanBUS();*/
        public frmBan()
        {
            InitializeComponent();           
            LoadBan();
            radTrong.Checked = true;
            dgvBan.AutoGenerateColumns = false;
            
           
        }
        private void HienThiTenDangNhap(string tenDangNhap)
        {
           
        }


        private void LoadBan()
        {
            dgvBan.DataSource = BanDAO.Instance.LoadBanEntiti();
        }

        private void btnThemBan_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtTenBan.Text))
            {
                MessageBox.Show(CONST.CanhBaoDeTrong,CONST.TB);
                return;
            }
            BanDTO newban = new BanDTO()
            {
                TENBAN = txtTenBan.Text,
                TRANGTHAI = radTrong.Checked ? CONST.TBTrong : CONST.TBCoNguoi,

            };

            if(_bb.Kiemtraban(newban) == false)
            {
                MessageBox.Show(CONST.TBBanTonTai,CONST.TB);
                return;
            }    
            if(_bb.Themban(newban))
            {
                MessageBox.Show(CONST.themTC,CONST.TB);
            }
            else
            {
                MessageBox.Show(CONST.themTB,CONST.TB);
            }
            btnReSet_Click(sender, e);
        }

        private void btnSuaBan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenBan.Text) || string.IsNullOrWhiteSpace(txtTenBan.Text) || string.IsNullOrEmpty(txtMaBan.Text))
            {
                MessageBox.Show(CONST.TBBanCanSua,CONST.TB);
                return;
            }
            BanDTO newban = new BanDTO()
            {
                MABAN = Convert.ToInt32(txtMaBan.Text),
                TENBAN = txtTenBan.Text,
                TRANGTHAI = radTrong.Checked ? CONST.TBTrong : CONST.TBCoNguoi,

            };
            if(_bb.KieMtraSuaBan(newban) == false)
            {
                MessageBox.Show(CONST.TBTrungBan);
                return;
            }    

            if (_bb.Suaban(newban))
            {
                MessageBox.Show(CONST.suaTC,CONST.TB);
            }
            else
            {
                MessageBox.Show(CONST.suaTB,CONST.suaTB);
            }
            btnReSet_Click(sender, e);


        }

        private void dgvBan_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvBan.SelectedRows.Count > 0) 
            {
                DataGridViewRow select = dgvBan.SelectedRows[0];
                txtMaBan.Text = select.Cells["colMaBan"].Value.ToString();
                txtTenBan.Text = select.Cells["colTenBan"].Value.ToString();
                if (select.Cells["colTrangThai"].Value.ToString() == "Trống")
                {
                    radTrong.Checked= true;
                }
                else
                {
                    radCoKhach.Checked= true;
                }    
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaBan.Text))
            {
                MessageBox.Show(CONST.TBBanCanXoa,CONST.TB);
                return;
            }
            BanDTO newban = new BanDTO()
            {
                MABAN = Convert.ToInt32(txtMaBan.Text),
               

            };
            DialogResult result = MessageBox.Show(CONST.xacnhanxoaBan, CONST.TB, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                if (BanDAO.Instance.KiemtrabantrongHd(newban) == false)
                {
                    MessageBox.Show(CONST.TBBanCoNguoi, CONST.TB);
                    return;
                }

                if (_bb.Xoaban(newban))
                {
                    MessageBox.Show(CONST.xoaTC, CONST.TB);
                }
                else
                {
                    MessageBox.Show(CONST.xoaTB, CONST.TB);
                }
                btnReSet_Click(sender, e);
            }

          
        }

        private void btnReSet_Click(object sender, EventArgs e)
        {
            txtMaBan.Text = string.Empty;
            txtTenBan.Text = string.Empty;
            LoadBan();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dgvBan.DataSource = BanDAO.Instance.TimKiemBab(txtTenBan.Text);
        }

        private void frmBan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D1 || e.KeyCode == Keys.NumPad1)
            {
                btnThemBan.PerformClick();
            }
            else if (e.KeyCode == Keys.D2 || e.KeyCode == Keys.NumPad2)
            {
                btnSuaBan.PerformClick();
            }
            else if (e.KeyCode == Keys.D3 || e.KeyCode == Keys.NumPad3)
            {
                btnXoa.PerformClick();
            }
            else if (e.KeyCode == Keys.D4 || e.KeyCode == Keys.NumPad4)
            {
                btnReSet.PerformClick();
            }
        }
    }
}
