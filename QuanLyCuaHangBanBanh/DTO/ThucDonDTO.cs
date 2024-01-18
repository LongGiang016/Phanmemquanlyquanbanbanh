using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ThucDonDTO
    {
        //MASANPHAM,TENSANPHAM,SOLUONG,MOTA,DONGIA
        public ThucDonDTO(int MASANPHAM,string TENSANPHAM , int SOLUONG , Decimal? DONGIA, Decimal? TONGDONGIA = 0) 
        {
            this.MASANPHAM= MASANPHAM;
            this.TENSANPHAM = TENSANPHAM;
            this.DONGIA = DONGIA;
            this.SOLUONG= SOLUONG;
            this.TONGDONGIA= TONGDONGIA;
        }

        public ThucDonDTO(DataRow row)
        {
            this.MASANPHAM = (int)row["MASANPHAM"];
            this.TENSANPHAM = row["TENSANPHAM"].ToString();
            this.DONGIA = (Decimal?)row["DONGIA"];
            this.SOLUONG = (int)row["SOLUONG"];
            this.TONGDONGIA = (Decimal?)row["TONGDONGIA"];
            //this.HINHANH = (byte[])row["HINHANH"];
        }

        public int MASANPHAM { get; set; }
        public string TENSANPHAM { get; set; }

        public int SOLUONG { get; set; }

        public Decimal? DONGIA { get; set; }

        public Decimal? TONGDONGIA { get; set; }

       

    }
}
