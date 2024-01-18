using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUSS
{
    public class NhanVienBUS
    {
        public List<NhanVienDTO> loadNV()
        {
            return NhanVienDAO.Instance.LoadNhanVien();
        }

        public List<NhanVienDTO> loadnvtheoma(int manhanvien)
        {
            return NhanVienDAO.Instance.loadnvtheoma(manhanvien);
        }

        public bool ThemNhanVien(NhanVienDTO nhanVien)
        {
            if (NhanVienDAO.Instance.KiemtraTontaiNhanVien(nhanVien) == false) { return false; }

            return NhanVienDAO.Instance.ThemNhanVien(nhanVien);
        }

        public bool SuaNhanVien(NhanVienDTO nhanVien)
        {
            //if (NhanVienDAO.Instance.KiemtraTontaiNhanVien(nhanVien) == false) { return false; }

            return NhanVienDAO.Instance.SuaNhanVien(nhanVien);
        }
        public bool XoaNhanVien(NhanVienDTO nhanVien)
        {

            return NhanVienDAO.Instance.XoaNhanVien(nhanVien);
        }

        public bool SuaTenDangNhap(NhanVienDTO nhanVien)
        {
            return NhanVienDAO.Instance.SuaTenDangNhap(nhanVien);
        }

        public bool SuaMatKhau(NhanVienDTO nhanVien)
        {
            return NhanVienDAO.Instance.SuaMatKhau(nhanVien);
        }
        // Tìm kiếm 
        public List<NhanVien> TimKiemNhanVien(string keywork)
        {
            return NhanVienDAO.Instance.TimKiemNhanVien(keywork);
        }
        public bool KieMtraSuaNhanVien(NhanVienDTO Suanv)
        {
            return NhanVienDAO.Instance.KieMtraSuaNhanVien(Suanv);
        }
        public bool ResetMatKhau(NhanVienDTO NhanVien)
        {
            return NhanVienDAO.Instance.ResetMatKhau(NhanVien);
        }

    }
}
