using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUSS
{
    public class BanBUS
    {
        private BanDAO ban = BanDAO.Instance;
        public List<BanDTO> LoadBan()
        {
            return ban.LoadBan();
        }

        public List<BanDTO> LoadBanEntiti()
        {
            return ban.LoadBanEntiti();
        }

        public bool Themban(BanDTO newb)
        {
            return BanDAO.Instance.ThemBan(newb);
        }

        public bool Suaban(BanDTO newb)
        {
            return BanDAO.Instance.SuaBan(newb);
        }

        public bool Xoaban(BanDTO newb)
        {
            return BanDAO.Instance.XoaBan(newb);
        }

        public bool Kiemtraban(BanDTO newb)
        {
            return BanDAO.Instance.Kiemtraban(newb);
        }

        public bool KieMtraSuaBan(BanDTO Suanv)
        {
            return BanDAO.Instance.KieMtraSuaBan(Suanv);
        }

    }
}
