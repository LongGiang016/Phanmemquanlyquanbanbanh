using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
                            

namespace DAO
{
    public class HoaDonDAO
    {
        private static HoaDonDAO instance;
        quanlycuahangbanhSHBEntities db = new quanlycuahangbanhSHBEntities();
        public static HoaDonDAO Instance
        {
            get { if (instance == null) instance = new HoaDonDAO(); return HoaDonDAO.instance; }

            private set { HoaDonDAO.instance = value; }
        }

        private HoaDonDAO() { }
        //Thành công : MAHOADON / Thất bại : -1;

        public List<HoaDonDTO> LayDSHoaDon()
        {
            var lst = from u in db.HoaDons
                      where u.TRANGTHAI == true
                      select new HoaDonDTO
                      {
                          MAHOADON = u.MAHOADON,
                          MANHANVIEN = u.MANHANVIEN != null ? u.MANHANVIEN.Value : 0,
                          MAKHACHHANG = u.MAKHACHHANG != null ? u.MAKHACHHANG.Value : 0,
                          MABAN = u.MABAN != null ? u.MABAN.Value : 0,
                          TONGHOADON = u.TONGHOADON,
                          DATECHECK = u.DATECHECK,
                          DATEOUT = u.DATEOUT,
                          TRANGTHAI = u.TRANGTHAI,
                          TENNHANVIEN = u.NhanVien.HOTEN,
                          TENKHACHHANG = u.KhachHang.HOTEN,
                          TENBAN = u.Ban.TENBAN,
                      };
            return lst.ToList();
        }
        public List<HoaDonDTO> LayDSHoaDonTheoMaNhanVien(int id)
        {
            var lst = from u in db.HoaDons
                      where u.TRANGTHAI == true && u.MANHANVIEN == id
                      select new HoaDonDTO
                      {
                          MAHOADON = u.MAHOADON,
                          MANHANVIEN = u.MANHANVIEN ?? 0,
                          MAKHACHHANG = u.MAKHACHHANG ?? 0,
                          MABAN = u.MABAN ?? 0,
                          TONGHOADON = u.TONGHOADON,
                          DATECHECK = u.DATECHECK,
                          DATEOUT = u.DATEOUT,
                          TRANGTHAI = u.TRANGTHAI,
                          TENNHANVIEN = u.NhanVien.HOTEN,
                          TENKHACHHANG = u.KhachHang.HOTEN,
                          TENBAN = u.Ban.TENBAN,
                      };
            return lst.ToList();
        }
        public List<HoaDonDTO> LayDSHoaDonTheoMaBan(int id)
        {
            var lst = from u in db.HoaDons
                      where u.TRANGTHAI == true && u.MABAN == id
                      select new HoaDonDTO
                      {
                          MAHOADON = u.MAHOADON,
                          MANHANVIEN = u.MANHANVIEN != null ? u.MANHANVIEN.Value : 0,
                          MAKHACHHANG = u.MAKHACHHANG != null ? u.MAKHACHHANG.Value : 0,
                          MABAN = u.MABAN != null ? u.MABAN.Value : 0,
                          TONGHOADON = u.TONGHOADON,
                          DATECHECK = u.DATECHECK,
                          DATEOUT = u.DATEOUT,
                          TRANGTHAI = u.TRANGTHAI,
                          TENNHANVIEN = u.NhanVien.HOTEN,
                          TENKHACHHANG = u.KhachHang.HOTEN,
                          TENBAN = u.Ban.TENBAN,
                          TONGHOADONTHEOMA = db.HoaDons.Where(h => h.MABAN == id).Sum(h => h.TONGHOADON)
                      };
            return lst.ToList();
        }
        public List<HoaDonDTO> LayDSHoaDonTheoMaKhach(int id)
        {
            var lst = from u in db.HoaDons
                       join ct in db.CT_Hoadon on u.MAHOADON equals ct.MAHOADON
                      join sp in db.SanPhams on ct.MASANPHAM equals sp.MASANPHAM
                      where u.TRANGTHAI == true && ct.MASANPHAM == id
                      select new HoaDonDTO
                      {
                          MAHOADON = u.MAHOADON,
                          MANHANVIEN = u.MANHANVIEN != null ? u.MANHANVIEN.Value : 0,
                          MAKHACHHANG = u.MAKHACHHANG != null ? u.MAKHACHHANG.Value : 0,
                          MABAN = u.MABAN != null ? u.MABAN.Value : 0,
                          TONGHOADON = u.TONGHOADON,
                          DATECHECK = u.DATECHECK,
                          DATEOUT = u.DATEOUT,
                          TRANGTHAI = u.TRANGTHAI,
                          TENNHANVIEN = u.NhanVien.HOTEN,
                          TENKHACHHANG = u.KhachHang.HOTEN,
                          TENBAN = u.Ban.TENBAN,
                      };
            return lst.ToList();
        }

        public List<HoaDonDTO> LayDSHoaDonTheoMaHoaDon(int id)
        {
            var lst = from u in db.HoaDons
                      where u.TRANGTHAI == true && u.MAHOADON == id
                      select new HoaDonDTO
                      {
                          MAHOADON = u.MAHOADON,
                          MANHANVIEN = u.MANHANVIEN != null ? u.MANHANVIEN.Value : 0,
                          MAKHACHHANG = u.MAKHACHHANG != null ? u.MAKHACHHANG.Value : 0,
                          MABAN = u.MABAN != null ? u.MABAN.Value : 0,
                          TONGHOADON = u.TONGHOADON,
                          DATECHECK = u.DATECHECK,
                          DATEOUT = u.DATEOUT,
                          TRANGTHAI = u.TRANGTHAI,
                          TENNHANVIEN = u.NhanVien.HOTEN,
                          TENKHACHHANG = u.KhachHang.HOTEN,
                          TENBAN = u.Ban.TENBAN,

                      };
            return lst.ToList();
        }
        public List<HoaDonDTO> LayDSHoaDonTheoNgay(DateTime ngaybatdau )
        {
            var lst = from u in db.HoaDons
                      where u.TRANGTHAI == true && DbFunctions.TruncateTime(u.DATECHECK) == ngaybatdau.Date 
                      select new HoaDonDTO
                      {
                          MAHOADON = u.MAHOADON,
                          MANHANVIEN = u.MANHANVIEN != null ? u.MANHANVIEN.Value : 0,
                          MAKHACHHANG = u.MAKHACHHANG != null ? u.MAKHACHHANG.Value : 0,
                          MABAN = u.MABAN != null ? u.MABAN.Value : 0,
                          TONGHOADON = u.TONGHOADON,
                          DATECHECK = u.DATECHECK,
                          DATEOUT = u.DATEOUT,
                          TRANGTHAI = u.TRANGTHAI,
                          TENNHANVIEN = u.NhanVien.HOTEN,
                          TENKHACHHANG = u.KhachHang.HOTEN,
                          TENBAN = u.Ban.TENBAN,
                      };
            return lst.ToList();
        }

        public int GetUncheckBillIDTableID(int id)
        {
            DataTable data = DataProvider.Instance.ExecuQuery("select * from HoaDon where MABAN = " + id +" and TRANGTHAI = 0");
            if(data.Rows.Count > 0)
            {
                HoaDonDTO hoadon = new HoaDonDTO(data.Rows[0]);
                return hoadon.MAHOADON;
            }
            return -1;
        }

        public void CheckOut(int id, int giamgia, string sdt, decimal tongTien, int manhanvien)
        {
            string query = "update HoaDon set  TRANGTHAI = 1, DATEOUT = GETDATE(), " + " GIAMGIA = " + giamgia + ", TONGHOADON = " + tongTien + " , MANHANVIEN = " +  manhanvien + "  ,MAKHACHHANG = (select MAKHACHHANG from KhachHang where SDT = '" + sdt + "') where MAHOADON = " + id ;

           // "UPDATE HoaDon SET dateCheckOut = GETDATE(), TRANGTHAI = 1, " + " GIAMGIA = " + giamgia + ", totalPrice = " + totalPrice + " WHERE id = " + id;
            DataProvider.Instance.ExecuNonQuery(query);
        }

        public void CheckOutNotKhH(int id , int giamgia, decimal tongtien, int manhanvien)
        {

            string query = "update HoaDon set  TRANGTHAI = 1, DATEOUT = GETDATE(), " + " GIAMGIA = " + giamgia + ", TONGHOADON = " + tongtien + ", MANHANVIEN = " +  manhanvien + "  where MAHOADON = " + id;

            // "UPDATE HoaDon SET dateCheckOut = GETDATE(), TRANGTHAI = 1, " + " GIAMGIA = " + giamgia + ", totalPrice = " + totalPrice + " WHERE id = " + id;
            DataProvider.Instance.ExecuNonQuery(query);
        }

        public void ThemVaoHoaDon(int id)
        {
            DataProvider.Instance.ExecuNonQuery("exec USP_ThemVaoHoaDon @MABAN", new object[] { id });
        }

        public int LayHoaDonLonNhat()
        {
            try
            {
                string query = "select MAX(MAHOADON) from HoaDon";
                return (int)DataProvider.Instance.ExecuteScalar(query); 
            }
            catch (Exception ex)
            {
                return 1;
            }
        }

        public DataTable LayDLXuatHD(int MaHD)
        {
            
            string query = "Select hd.MAHOADON, sp.MASANPHAM, cthd.SOLUONG, sp.TENSANPHAM,sp.DONGIA,DATECHECK,DATEOUT,hd.MANHANVIEN,hd.MABAN,hd.MAKHACHHANG,hd.TONGHOADON \r\nFrom SanPham sp ,HoaDon hd, CT_HoaDon cthd \r\nWhere cthd.MAHOADON = " + MaHD + " AND hd.MAHOADON = cthd.MAHOADON AND cthd.MASANPHAM = sp.MASANPHAM";

            return DataProvider.Instance.ExecuQuery(query);
        }

        public DataTable LayDLXuatHDtheonv(int Manv)
        {

            string query = "Select (SELECT SUM(TONGHOADON) FROM HoaDon where MANHANVIEN = " +  Manv + ") AS TONGHOADONTHEOMA,  nv.HOTEN, hd.MABAN, MAHOADON ,hd.MANHANVIEN,hd.MAKHACHHANG,hd.DATECHECK,hd.DATEOUT ,TONGHOADON  \r\nFrom HoaDon hd, NhanVien nv , BAN ban \r\nWhere hd.MANHANVIEN = " + Manv + " AND nv.MANHANVIEN = hd.MANHANVIEN AND hd.MABAN = ban.MABAN";

            return DataProvider.Instance.ExecuQuery(query);
        }

        public DataTable LayDLXuatHDtheomasp(int Masp)
        {

            //string query = "select (SELECT SUM(TONGHOADON) FROM HoaDon hd , CT_Hoadon ct , SanPham sp where hd.MAHOADON = ct.MAHOADON  and ct.MASANPHAM = sp.MASANPHAM and ct.MASANPHAM = " + Masp + ") AS TONGHOADONTHEOMA,  \r\n  hd.MAHOADON, \r\n  sp.TENSANPHAM , \r\n  hd.TONGHOADON ,\r\n  b.TENBAN,\r\n  nv.HOTEN,\r\n  sp.TENSANPHAM\r\n  from HoaDon hd, CT_Hoadon ct , SanPham sp , Ban b , NhanVien nv\r\n  where hd.MAHOADON = ct.MAHOADON and ct.MASANPHAM = sp.MASANPHAM and ct.MASANPHAM = " +  Masp  +" and hd.MABAN = b.MABAN and hd.MANHANVIEN = nv.MANHANVIEN";
            string query = "SELECT (SELECT SUM(TONGHOADON) FROM HoaDon hd , CT_Hoadon ct , SanPham sp where hd.MAHOADON = ct.MAHOADON  and ct.MASANPHAM = sp.MASANPHAM and ct.MASANPHAM = " + Masp + ") AS TONGHOADONTHEOMA, hd.MAHOADON , hd.MAKHACHHANG , hd.DATECHECK , hd.DATEOUT , ct.MASANPHAM , b.TENBAN ,hd.TONGHOADON FROM Ban b,  HoaDon hd , CT_Hoadon ct  where ct.MASANPHAM = " + Masp + " and hd.MAHOADON = ct.MAHOADON and b.MABAN = hd.MABAN";
            return DataProvider.Instance.ExecuQuery(query);


        }

        public DataTable LayDLXuatHDtheongay(DateTime ngaybatdau)
        {

            //string query = "SELECT (SELECT SUM(TONGHOADON) FROM HoaDon hd  where CAST(hd.DATECHECK AS DATE) <= '" + ngaybatdau.ToString("yyyy-MM-dd") + " ' and CAST(hd.DATECHECK AS DATE) <= '" + ngayketthuc.ToString("yyyy-MM-dd") + "') AS TONGHOADONTHEOMA, hd.MANHANVIEN, hd.TONGHOADON , hd.MAHOADON, hd.MAKHACHHANG, hd.DATECHECK, hd.DATEOUT, ct.MASANPHAM, b.TENBAN FROM Ban b, HoaDon hd, CT_Hoadon ct WHERE hd.MAHOADON = ct.MAHOADON AND b.MABAN = hd.MABAN AND hd.TRANGTHAI = 1 AND CAST(hd.DATECHECK AS DATE) >= '" + ngaybatdau.ToString("yyyy-MM-dd") + "' AND CAST(hd.DATECHECK AS DATE) <= '" + ngayketthuc.ToString("yyyy-MM-dd") + "'";
            string querysua = "SELECT (SELECT SUM(TONGHOADON) FROM HoaDon hd  where CAST(hd.DATECHECK AS DATE) <= '" + ngaybatdau.ToString("yyyy-MM-dd") + "') AS TONGHOADONTHEOMA, hd.MANHANVIEN, hd.TONGHOADON , hd.MAHOADON, hd.MAKHACHHANG, hd.DATECHECK, hd.DATEOUT , b.TENBAN FROM Ban b, HoaDon hd WHERE  b.MABAN = hd.MABAN AND hd.TRANGTHAI = 1 AND CAST(hd.DATECHECK AS DATE) >= '" + ngaybatdau.ToString("yyyy-MM-dd") +"' ";
            return DataProvider.Instance.ExecuQuery(querysua);

        }
    }
}
