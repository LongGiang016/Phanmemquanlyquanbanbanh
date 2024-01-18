using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAO
{
    public class DangNhapDAO
    {
        quanlycuahangbanhSHBEntities qlda = new quanlycuahangbanhSHBEntities();
        private static DangNhapDAO instance;

        public static DangNhapDAO Instance
        {
            get { if (instance == null) instance = new DangNhapDAO(); return DangNhapDAO.instance; }

            private set { DangNhapDAO.instance = value; }
        }
      
        public DangNhapDAO() { }
       


        
        
    }
}
