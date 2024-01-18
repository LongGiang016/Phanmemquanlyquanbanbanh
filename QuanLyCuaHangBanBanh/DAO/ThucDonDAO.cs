using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class ThucDonDAO
    {
        private static ThucDonDAO instance;

        public static ThucDonDAO Instance
        {
            get { if(instance == null) instance = new ThucDonDAO(); return ThucDonDAO.instance;}

            private set { ThucDonDAO.instance= value; }
        }
        
        private ThucDonDAO() { }

        public List<ThucDonDTO> LayDanhSachThucDonTheoBan(int id)
        {
            List<ThucDonDTO> listThucDon = new List<ThucDonDTO>();

            string query = "select sp.HINHANH, sp.MASANPHAM, TENSANPHAM ,cthd.SOLUONG, DONGIA, cthd.SOLUONG * DONGIA as TONGDONGIA,hd.MABAN from HoaDon hd, CT_Hoadon cthd, SanPham sp where hd.MAHOADON = cthd.MAHOADON and sp.MASANPHAM = cthd.MASANPHAM and hd.TRANGTHAI = 0  and hd.MABAN = " + id;

            DataTable data = DataProvider.Instance.ExecuQuery(query);

            foreach (DataRow item in data.Rows)
            {
                ThucDonDTO thucdon = new ThucDonDTO(item);
                listThucDon.Add(thucdon);
            }

            return listThucDon;
        }

        public List<ThucDonDTO> LayDanhSachThucDonkotheoBan()
        {
            List<ThucDonDTO> listThucDon = new List<ThucDonDTO>();

            string query = "select sp.MASANPHAM, TENSANPHAM ,cthd.SOLUONG, DONGIA, cthd.SOLUONG * DONGIA as TONGDONGIA,hd.MABAN from HoaDon hd, CT_Hoadon cthd, SanPham sp where hd.MAHOADON = cthd.MAHOADON and sp.MASANPHAM = cthd.MASANPHAM and hd.TRANGTHAI = 0 ";

            DataTable data = DataProvider.Instance.ExecuQuery(query);

            foreach (DataRow item in data.Rows)
            {
                ThucDonDTO thucdon = new ThucDonDTO(item);
                listThucDon.Add(thucdon);
            }

            return listThucDon;
        }



    }
}
