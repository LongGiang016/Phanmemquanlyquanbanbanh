using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class BanDAO
    {
        quanlycuahangbanhSHBEntities qlch = new quanlycuahangbanhSHBEntities();
        
        private static BanDAO instance;
        public static BanDAO Instance
        {
            get { if (instance == null) instance = new BanDAO(); return BanDAO.instance; }
            private set { instance = value; }
        }

        public static int RongBan = 100;
        public static int DaiBan = 100;

        public static int RongMangVe = 326;
        public static int DaiMangVe = 80;
        private BanDAO() { }

        public List<BanDTO> LoadBan()
        {
            List<BanDTO> listBan = new List<BanDTO>();

            DataTable data = DataProvider.Instance.ExecuQuery("SELECT MABAN , TENBAN , TRANGTHAI FROM Ban where XOA = 1");
            foreach(DataRow item in data.Rows)
            {
                BanDTO bandto = new BanDTO(item);


                listBan.Add(bandto);

            }    

            return listBan;
        }

        public List<BanDTO> LoadBanEntiti()
        {
            var lst = from c in qlch.Bans
                      where c.XOA == true && c.TENBAN != "Mang về"
                      select new BanDTO
                      {
                          MABAN = c.MABAN, TENBAN = c.TENBAN  , TRANGTHAI = c.TRANGTHAI

                      };
            return lst.ToList();
        }

        public bool ThemBan(BanDTO newban)
        {
            try
            {

                Ban efb = new Ban
                {
                    MABAN = newban.MABAN,
                    TENBAN = newban.TENBAN,
                    TRANGTHAI = newban.TRANGTHAI,
                    XOA = true,
                };
                qlch.Bans.Add(efb);
                qlch.SaveChanges();
                return true;

            }
            catch(Exception e) { return false; }

        }

        public bool SuaBan(BanDTO newban)
        {
            try
            {
                Ban efb = qlch.Bans.SingleOrDefault(c => c.MABAN == newban.MABAN);
                if(efb == null)
                {
                    return false;
                }
                efb.TENBAN = newban.TENBAN;
                efb.TRANGTHAI = newban.TRANGTHAI;
                
                qlch.SaveChanges();
                return true;

            }
            catch (Exception e) { return false; }

        }

        public bool XoaBan(BanDTO newban)
        {
            try
            {
                Ban efb = qlch.Bans.SingleOrDefault(c => c.MABAN == newban.MABAN);
                if (efb == null)
                {
                    return false;
                }
                efb.XOA = false;

                qlch.SaveChanges();
                return true;

            }
            catch (Exception e) { return false; }

        }

        public bool Kiemtraban(BanDTO newban)
        {
            Ban efb = qlch.Bans.SingleOrDefault(c => c.TENBAN == newban.TENBAN && c.XOA == true);
            if(efb != null)
            {
                return false;
            }
            return true;
        }
        public bool KiemtrabantrongHd(BanDTO newban)
        {
    
            HoaDon efb = qlch.HoaDons.SingleOrDefault(c => c.MABAN == newban.MABAN && c.TRANGTHAI == false);
            if (efb != null)
            {
                return false;
            }
            return true;
        }


        public List<Ban> TimKiemBab(string keywork)
        {
            using (var context = new quanlycuahangbanhSHBEntities())
            {
                return context.Bans.Where(v =>
                        v.TENBAN.Contains(keywork))
                    .Where(f => f.XOA == true).ToList();
            }
        }


        public void Chuyenban(int id1 , int id2)
        {
            DataProvider.Instance.ExecuQuery("USP_ChuyenBan @idTable1 , @idTable2", new object[]{id1,id2});
        }

        public bool KieMtraSuaBan(BanDTO Suanv)
        {
            Ban efkh = qlch.Bans.SingleOrDefault(c => c.TENBAN == Suanv.TENBAN && c.MABAN != Suanv.MABAN && c.XOA == true);
            if (efkh != null)
            {
                return false;
            }
            return true;
        }


    }
}
