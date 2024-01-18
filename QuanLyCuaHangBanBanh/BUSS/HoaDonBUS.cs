using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUSS
{
    public class HoaDonBUS
    {
        public List<HoaDonDTO> LoadDSHD()
        {
            return HoaDonDAO.Instance.LayDSHoaDon();
        }

        public List<HoaDonDTO> LoadDSHDTheoMaNhanVien(int id)
        {
            return HoaDonDAO.Instance.LayDSHoaDonTheoMaNhanVien(id);
        }
        public List<HoaDonDTO> LoadDSHDTheoMaBan(int id)
        {
            return HoaDonDAO.Instance.LayDSHoaDonTheoMaBan(id);
        }
        public List<HoaDonDTO> LoadDSHDTheoMaKhach(int id)
        {
            return HoaDonDAO.Instance.LayDSHoaDonTheoMaKhach(id);
        }

        public List<HoaDonDTO> LoadDSHDTheoMaHoaDon(int id)
        {
            return HoaDonDAO.Instance.LayDSHoaDonTheoMaHoaDon(id);
        }

        public List<HoaDonDTO> LoadDSHDTheoNgay(DateTime ngaybatdau )
        {
            return HoaDonDAO.Instance.LayDSHoaDonTheoNgay(ngaybatdau);
        }
    }
}
