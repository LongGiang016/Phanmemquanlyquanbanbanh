using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class SanPhamDAO
    {
        private static SanPhamDAO instance;

        quanlycuahangbanhSHBEntities _qlch = new quanlycuahangbanhSHBEntities();

        public static SanPhamDAO Instance
        {
            get { if (instance == null) instance = new SanPhamDAO(); return SanPhamDAO.instance; }

            private set { SanPhamDAO.instance = value; }
        }
        private SanPhamDAO() { }

        public List<SanPhamDTO> loadsanpham()
        {
            var lst = from c in _qlch.SanPhams
                      where c.XOA == true
                      select new SanPhamDTO
                      {
                          MASANPHAM = c.MASANPHAM,
                          TENSANPHAM = c.TENSANPHAM,
                          MADANHMUC = c.MADANHMUC,
                          TENDANHMUC = c.DanhMuc.TENDANHMUC,
                          DONGIA = c.DONGIA,
                          SOLUONG = c.SOLUONG,
                          MOTA = c.MOTA,
                          HINHANH = c.HINHANH


                      };
            return lst.ToList();
        }

        public bool ThemSP(SanPhamDTO newsp)
        {
            try
            {
                SanPham efsp = new SanPham
                {
                    MASANPHAM = newsp.MASANPHAM,
                    TENSANPHAM = newsp.TENSANPHAM,
                    MADANHMUC = newsp.MADANHMUC,
                    DONGIA = newsp.DONGIA.Value,
                    MOTA = newsp.MOTA,
                    HINHANH = newsp.HINHANH,
                    SOLUONG = newsp.SOLUONG,
                    XOA = true,

                };
                _qlch.SanPhams.Add(efsp);
                _qlch.SaveChanges();
                return true;

            }
            catch (Exception e) { return false; }
        }

        public bool SuaSP(SanPhamDTO newsp)
        {
            try
            {
                SanPham efsp = _qlch.SanPhams.SingleOrDefault(v => v.MASANPHAM == newsp.MASANPHAM);
                if (efsp == null) { return false; }
                efsp.MASANPHAM = newsp.MASANPHAM;
                efsp.TENSANPHAM = newsp.TENSANPHAM;
                efsp.MADANHMUC = newsp.MADANHMUC;
                efsp.DONGIA = newsp.DONGIA.Value;
                efsp.MOTA = newsp.MOTA;
                efsp.HINHANH = newsp.HINHANH;
                efsp.SOLUONG = newsp.SOLUONG;

                _qlch.SaveChanges();
                return true;

            }
            catch (Exception e) { return false; }
        }

        public bool XoaSP(SanPhamDTO newsp)
        {
            try
            {
                SanPham efsp = _qlch.SanPhams.SingleOrDefault(v => v.MASANPHAM == newsp.MASANPHAM);
                if (efsp == null) { return false; }



                efsp.XOA = false;
                _qlch.SaveChanges();
                return true;

            }
            catch (Exception e) { return false; }
        }


        public List<SanPhamDTO> LayDanhSachTheoMaDanhMuc(int id)
        {
            List<SanPhamDTO> ListSanPham = new List<SanPhamDTO>();

            string query = "select * from SanPham where XOA = 1 and  MADANHMUC = " + id;

            DataTable data = DataProvider.Instance.ExecuQuery(query);

            foreach (DataRow row in data.Rows)
            {
                SanPhamDTO sanpham = new SanPhamDTO(row);
                ListSanPham.Add(sanpham);
            }

            return ListSanPham;
        }
        public List<SanPhamDTO> LayDanhSachTheoTenDtpro(string name)
        {
            List<SanPhamDTO> ListSanPham = new List<SanPhamDTO>();

            string query = string.Format("select * from SanPham where TENSANPHAM = N'{0}'") + name;

            DataTable data = DataProvider.Instance.ExecuQuery(query);

            foreach (DataRow row in data.Rows)
            {
                SanPhamDTO sanpham = new SanPhamDTO(row);
                ListSanPham.Add(sanpham);
            }
            return ListSanPham;
        }


        public bool KiemtraTen(SanPhamDTO sp)
        {
            SanPham efsp = _qlch.SanPhams.SingleOrDefault(v => v.TENSANPHAM == sp.TENSANPHAM && v.XOA == true);
            if (efsp != null) { return false; }
            return true;
        }
        //Nếu tôn tại thì nó trả về 1 , 0 là sai
        public bool KiemTraSanPhamTonTaiTrongHD(int MAHOADON, int MASANPHAM)
        {
            DataTable data = DataProvider.Instance.ExecuQuery("exec USP_KiemTraSanPhamTonTai @MAHOADON , @MASANPHAM", new object[] { MAHOADON, MASANPHAM });

            if (data.Rows.Count > 0)
            {
                int count = Convert.ToInt32(data.Rows[0][0]);
                if (count > 0)
                {
                    return true;
                }
            }
            return false;
        }

        //Phương thức tìm kiếm theo tên danh mục
        public List<SanPhamDTO> TimKiemTENDanhMuc(int tenDM)
        {
            var lst = _qlch.SanPhams.ToList();
            return lst.Where(v => v.DanhMuc.MADANHMUC == (tenDM)).Where(x => x.XOA == true).Select(u => new SanPhamDTO
            {
                MASANPHAM = u.MASANPHAM,
                TENSANPHAM = u.TENSANPHAM,
                TENDANHMUC = u.DanhMuc.TENDANHMUC,
                SOLUONG = u.SOLUONG,
                MOTA = u.MOTA,
                DONGIA = u.DONGIA,
                HINHANH = u.HINHANH
            }).ToList();
        }
        // Tìm kiếm 
        public List<SanPham> TimKiemSanPham(string keywork)
        {
            using (var context = new quanlycuahangbanhSHBEntities())
            {
                return context.SanPhams.Where(v =>
                        v.TENSANPHAM.Contains(keywork))
                    .Where(f => f.XOA == true).ToList();
            }
        }

        //Phương thức tìm kiếm theo tên Ma 
        public List<SanPhamDTO> TimKiemTheoMa(int ma)
        {
            var lst = _qlch.SanPhams.ToList();
            return lst.Where(v => v.MASANPHAM == (ma)).Where(x => x.XOA == true).Select(u => new SanPhamDTO
            {
                MASANPHAM = u.MASANPHAM,
                TENSANPHAM = u.TENSANPHAM,
                TENDANHMUC = u.DanhMuc.TENDANHMUC,
                SOLUONG = u.SOLUONG,
                MOTA = u.MOTA,
                DONGIA = u.DONGIA,
                HINHANH = u.HINHANH
            }).ToList();
        }

        public bool KiemtraSanPhamSua (SanPhamDTO newsp)
        {
            SanPham efkh = _qlch.SanPhams.SingleOrDefault(c => c.TENSANPHAM == newsp.TENSANPHAM && c.MASANPHAM != newsp.MASANPHAM && c.XOA == true);
            if (efkh != null)
            {
                return false;
            }
            return true;
        }

        public bool KiemtraSanPhamTTtongHoaDon(SanPhamDTO newsp)
        {

            //HoaDon hd = new HoaDon();

            //CT_Hoadon ct = _qlch.CT_Hoadon.SingleOrDefault(c => c.MASANPHAM == newsp.MASANPHAM && c.MAHOADON == hd.MAHOADON && hd.TRANGTHAI == false);
            //if (ct != null) { return false; }
            //return true;

            int maSanPham = newsp.MASANPHAM;
           
            //int maHoaDon = newsp.MAHOADON;

            // Truy vấn dữ liệu từ bảng CT_Hoadon và HoaDon
            var query = from ct in _qlch.CT_Hoadon
                        join hd in _qlch.HoaDons on ct.MAHOADON equals hd.MAHOADON
                        where ct.MASANPHAM == maSanPham && hd.MAHOADON == ct.MAHOADON && hd.TRANGTHAI == false
                        select ct;

            // Kiểm tra xem có bất kỳ bản ghi nào khớp với điều kiện
            bool exists = query.Any();

            return exists;
        }
    }
}
