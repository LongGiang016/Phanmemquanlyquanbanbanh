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
    public partial class frmInHoaDon : Form
    {
        public frmInHoaDon()
        {
            InitializeComponent();
           
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        public void frmInHoaDon_Load(object sender, EventArgs e)
        {
            this.crpHoaDon.RefreshReport();
        }
    }
}
