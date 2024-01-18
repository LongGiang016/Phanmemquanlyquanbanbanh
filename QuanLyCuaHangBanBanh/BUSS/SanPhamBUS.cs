using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUSS
{
    public class SanPhamBUS
    {
        //public List<SanPhamDTO> loadSP()
        //{
        //    return SanPhamDAO.Instance.loadsanpham();
        //}

        //public bool ThemSP(SanPhamDTO newsp)
        //{
        //    return SanPhamDAO.Instance.ThemSP(newsp);
        //}
        public bool Suasp(SanPhamDTO suasp)
        {
            return SanPhamDAO.Instance.SuaSP(suasp);
        }

        public bool Xoasp(SanPhamDTO suasp)
        {
            return SanPhamDAO.Instance.XoaSP(suasp);
        }
        public List<SanPham> TimKiemSanPham(string keywork)
        {
            return SanPhamDAO.Instance.TimKiemSanPham(keywork);
        }
        public List<SanPhamDTO> TimKiemTENDanhMuc(int tenDM)
        {
            return SanPhamDAO.Instance.TimKiemTENDanhMuc(tenDM);
        }

        public List<SanPhamDTO> TimKiemTheoMa(int ma)
        {
            return SanPhamDAO.Instance.TimKiemTheoMa(ma);
        }

        public List<SanPhamDTO> LayDanhSachTheoTenDtpr(string name)
        {
            List<SanPhamDTO> list =  SanPhamDAO.Instance.LayDanhSachTheoTenDtpro(name);
            return list;
        }

        public bool KiemtraSanPhamSua(SanPhamDTO newsp)
        {
            return SanPhamDAO.Instance.KiemtraSanPhamSua(newsp);
        }

        public bool KiemtraSanPhamTTtongHoaDon(SanPhamDTO newsp)
        {
            return SanPhamDAO.Instance.KiemtraSanPhamTTtongHoaDon(newsp);
        }
    }
}
