using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
namespace DAO
{
    public class CT_HoaDonDAO
    {
        quanlycuahangbanhSHBEntities db = new quanlycuahangbanhSHBEntities();
        private static CT_HoaDonDAO instance;

        public static CT_HoaDonDAO Instance
        {
            get { if (instance == null) instance = new CT_HoaDonDAO(); return CT_HoaDonDAO.instance; }
            private set { CT_HoaDonDAO.instance = value; }
        }
        private CT_HoaDonDAO() { }

        public List<CT_HoaDonDTO> GetList(int id)
        {
            var lst = db.CT_Hoadon.ToList();
            return lst.Where(v => v.MAHOADON == id).Select(u => new CT_HoaDonDTO
            {
                MACTHOADON = u.MACTHOADON,
                MAHOADON = u.MAHOADON,
                MASANPHAM = u.MASANPHAM,
                TENSANPHAM = u.SanPham.TENSANPHAM,
                SOLUONG = u.SOLUONG.Value,
                DONGIA = u.SanPham.DONGIA,              
            }).ToList();
        }

        public void ThemVaoCT_HoaDon(int mahoadon, int masanpham, int soluiong)
        {
            DataProvider.Instance.ExecuNonQuery("exec USP_ThemCTHoaDonsua @MAHOADON , @MASANPHAM , @SOLUONG", new object[] { mahoadon, masanpham, soluiong });
        }

        public void XoaCTHD(int mahoadon , int masanpham)
        {
            DataProvider.Instance.ExecuNonQuery("exec USP_XoaCTHoaDon @MAHOADON , @MASANPHAM", new object[] { mahoadon, masanpham });
        }
    }
}
