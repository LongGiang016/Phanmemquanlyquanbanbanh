using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BanDTO
    {
        public BanDTO(int MABAN, string TENNBAN, string TRANGTHAI)
        {
            this.MABAN = MABAN;
            this.TENBAN = TENBAN;
            this.TRANGTHAI = TRANGTHAI;
        }
        public BanDTO() { }
        public BanDTO(DataRow row)
        {
            this.MABAN = (int)row["MABAN"];
            this.TENBAN = row["TENBAN"].ToString();
            this.TRANGTHAI = row["TRANGTHAI"].ToString();
        }
        public int MABAN { get; set; }
        public string TENBAN { get; set; }

        public string TRANGTHAI { get; set; }
    }
}
