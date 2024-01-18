using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DTO
{
    public class SanPhamDTO
    {
        //SELECT MASANPHAM,MADANHMUC,TENSANPHAM,SOLUONG,MOTA,DONGIA from SanPham
        public SanPhamDTO() { }

        public SanPhamDTO(int MASANPHAM, int MADANHMUC, string TENDANHMUC, string TENSANPHAM, int SOLUONG, string MOTA, Decimal? DONGIA , Byte[] HINHANH )
        {
            this.MASANPHAM = MASANPHAM;
            this.MADANHMUC = MADANHMUC;
            this.TENDANHMUC = TENDANHMUC;
            this.TENSANPHAM = TENSANPHAM;
            this.SOLUONG = SOLUONG;
            this.MOTA = MOTA;
            this.DONGIA = DONGIA;
            this.HINHANH = HINHANH;
        }

        public SanPhamDTO(DataRow row)
        {
            this.MASANPHAM = (int)row["MASANPHAM"];
            this.MADANHMUC = (int)row["MADANHMUC"];
            this.TENSANPHAM = row["TENSANPHAM"].ToString();
            this.SOLUONG = (int)row["SOLUONG"];
            this.MOTA = row["MOTA"].ToString();
            this.DONGIA = (Decimal?)row["DONGIA"];
            this.HINHANH = (byte[])row["HINHANH"];
        }
        public int MASANPHAM { get; set; }

        public string TENDANHMUC { get; set; }

        public int MADANHMUC { get; set; }

        public string TENSANPHAM { get; set; }

        public int SOLUONG { get; set; }

        public string MOTA { get; set; }

        public Decimal? DONGIA { get; set; }

        public byte[] HINHANH { get; set; }
    }
}
