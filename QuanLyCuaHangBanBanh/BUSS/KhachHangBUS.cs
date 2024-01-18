using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUSS
{
    public class KhachHangBUS
    {
        public bool ThemKH(KhachHangDTO newkh)
        {
           
            return KhachHangDAO.Instance.THemKH(newkh);
        }

        public List<KhachHangDTO> load()
        {
            return KhachHangDAO.Instance.loadKhachhang();
        }

        public bool SuaKh(KhachHangDTO newkh)
        {
            //if (KhachHangDAO.Instance.KiemTraTonTaiKhachHang(newkh) == false) { return false; }
            return KhachHangDAO.Instance.SuaKH(newkh);
        }

        public bool XoaKh(KhachHangDTO newkh)
        {
            return KhachHangDAO.Instance.XoaKH(newkh);
        }

        // Tìm kiếm 
        public List<KhachHang> TimKiemKhachHang(string keywork)
        {
            return KhachHangDAO.Instance.TimKiemKhachHang(keywork);
        }

        public bool KiemtraSDTSua(KhachHangDTO newkh)
        {
            return KhachHangDAO.Instance.KiemtraSDTSua(newkh);
        }
        public bool KiemtraSDTThem(KhachHangDTO newkh)
        {
            return KhachHangDAO.Instance.KiemtraSDTThem(newkh);
        }

        public bool KiemtraDodaisdt(string sdt)
        {
            return KhachHangDAO.Instance.KiemTraDoDaiSDT(sdt);
        }    
    }
}
