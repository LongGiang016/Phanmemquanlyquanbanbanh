using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class KhachHangDAO
    {
        quanlycuahangbanhSHBEntities _QLCHBEnti = new quanlycuahangbanhSHBEntities();

        private static KhachHangDAO instance;

        public static KhachHangDAO Instance
        {
            get { if (instance == null) instance = new KhachHangDAO(); return KhachHangDAO.instance; }

            private set { KhachHangDAO.instance = value; }
        }

        private KhachHangDAO() { }

        public List<KhachHangDTO> loadKhachhang()
        {
            var lst = _QLCHBEnti.KhachHangs.ToList();

            var result = from c in _QLCHBEnti.KhachHangs
                         where c.XOA == true
                         select new KhachHangDTO
                         {
                             MAKHACHHANG = c.MAKHACHHANG,
                             HOTEN = c.HOTEN,                           
                             SDT = c.SDT,
                            
                             


                         }; 
            return result.ToList();
        }

        public bool THemKH(KhachHangDTO newkh)
        {
            try
            {
                KhachHang EFkh = new KhachHang
                {
                    MAKHACHHANG = newkh.MAKHACHHANG,  
                    HOTEN = newkh.HOTEN,
                    SDT = newkh.SDT,                       
                    XOA = true
                    
                };
                _QLCHBEnti.KhachHangs.Add(EFkh);
                _QLCHBEnti.SaveChanges();
                return true;

            }catch(Exception ex) 
            {
                return false;
            }
        }

        public bool ThemKHDataProvider(string Hoten ,  int sdt)
        {
            try
            {
                DataProvider.Instance.ExecuNonQuery("USP_ThemVaoKhachHang @HOTEN , @SDT", new object[] { Hoten, sdt });
                return true;
                
            }catch(Exception e) { return false; }
        }

        public bool SuaKH(KhachHangDTO EDKh)
        {
            int Makhach  = EDKh.MAKHACHHANG;
            try
            {
                KhachHang EFKh = _QLCHBEnti.KhachHangs.SingleOrDefault(c => c.MAKHACHHANG == Makhach);

                EFKh.HOTEN = EDKh.HOTEN;
                EFKh.SDT = EDKh.SDT;

                _QLCHBEnti.SaveChanges();
                return true;

            }
            catch(Exception ex) 
            {
                return false;
            }
        }
        public bool XoaKH(KhachHangDTO EDKh)
        {
            try
            {
                KhachHang dmEF = _QLCHBEnti.KhachHangs.SingleOrDefault(u => u.MAKHACHHANG== EDKh.MAKHACHHANG);
                if (dmEF == null)
                {
                    return false;
                };
                dmEF.XOA = false;
                _QLCHBEnti.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool KiemtraSDTThem(KhachHangDTO newkh)
        {
            KhachHang efkh = _QLCHBEnti.KhachHangs.SingleOrDefault(c => c.SDT == newkh.SDT && c.XOA == true);
            if (efkh != null)
            {
                return false;
            }
            return true;
        }

        public bool KiemtraSDTSua(KhachHangDTO newkh)
        {
            KhachHang efkh = _QLCHBEnti.KhachHangs.SingleOrDefault(c => c.SDT == newkh.SDT && c.MAKHACHHANG != newkh.MAKHACHHANG && c.XOA == true);
            if(efkh != null)
            {
                return false;
            }
            return true;
        }

        public bool KiemTraDoDaiSDT(string sdt)
        {
            if (sdt.ToString().Length > 10)
            {
                return false;
            }

            return true;
        }

        public bool KiemTraTonTaiKhachHang(KhachHangDTO newkh)
        {
            KhachHang efkh = _QLCHBEnti.KhachHangs.SingleOrDefault(c => c.SDT == newkh.SDT);
            if(efkh != null ) 
            {
                return false;
            }
            return true;
        }


        // Tìm kiếm 
        public List<KhachHang> TimKiemKhachHang(string keywork)
        {
            using (var context = new quanlycuahangbanhSHBEntities())
            {
                return context.KhachHangs.Where(v =>
                        v.HOTEN.Contains(keywork) ||
                        v.SDT.Contains(keywork))
                    .Where(f => f.XOA == true).ToList();
            }
        }
    }
}
