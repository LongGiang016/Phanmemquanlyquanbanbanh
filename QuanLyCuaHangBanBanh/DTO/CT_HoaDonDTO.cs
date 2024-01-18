using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CT_HoaDonDTO
    {
        //MACTHOADON , MAHOADON, MASANPHAM, SOLUONG

        public CT_HoaDonDTO() { }
        public CT_HoaDonDTO(DataRow row)
        {
            this.MACTHOADON =(int)row["MACTHOADON"];
            this.MAHOADON = (int)row["MAHOADON"];
            this.MASANPHAM = (int)row["MASANPHAM"];
            this.SOLUONG = (int)row["SOLUONG"];
        }

        public CT_HoaDonDTO(int MACTHOADON , int MAHOADON, int MASANPHAM , int SOLUONG )
        {
            this.MACTHOADON = MACTHOADON;
            this.MAHOADON = MAHOADON;
            this.MASANPHAM= MASANPHAM;
            this.SOLUONG = SOLUONG;
        }

        public int MACTHOADON { get; set; }

        public int MAHOADON { get; set; }

        public int MASANPHAM { get; set; }

        public int SOLUONG { get; set; }

        public string TENSANPHAM { get; set; }

        public decimal? DONGIA { get; set; }
       
        
    }
}
