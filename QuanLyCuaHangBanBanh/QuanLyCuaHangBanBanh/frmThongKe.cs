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
    public partial class frmThongKe : Form
    {
        public frmThongKe()
        {
            InitializeComponent();
            colorr();
            
            
        }

        private void frmThongKe_Load(object sender, EventArgs e)
        {

        }
        private void colorr()
        {
            dateTimePicker1.BackColor = ColorTranslator.FromHtml("#EF7712");
            dateTimePicker1.ForeColor = ColorTranslator.FromHtml("#EF7712");
        }
    }
}
