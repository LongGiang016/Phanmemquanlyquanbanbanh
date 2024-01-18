using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    //MAHOADON,DATECHECK, DATEOUT, MANHANVIEN, MAKHACHHANG,MABAN,TRANGTHAI
    public class HoaDonDTO
    {
        public HoaDonDTO() { }
        public HoaDonDTO(int MAHOADON , DateTime? DATECHECK , DateTime? DATEOUT, int MANHANVIEN, int MAKHACHHANG,int MABAN,bool? TRANGTHAI,int GIAMGIA = 0)
        {
            this.MAHOADON = MAHOADON;
            this.DATECHECK = DATECHECK;
            this.DATEOUT = DATEOUT;
            this.MANHANVIEN= MANHANVIEN;
            this.MAKHACHHANG= MAKHACHHANG;
            this.MABAN= MABAN;
            this.TRANGTHAI= TRANGTHAI;
            this.GIAMGIA = GIAMGIA;
        }
        public HoaDonDTO(DataRow row) 
        {
            this.MAHOADON = (int)row["MAHOADON"];

            var DateCheckTemp = row["DATECHECK"];
            if (DateCheckTemp .ToString() != "")
            {
                this.DATECHECK = (DateTime?)DateCheckTemp;
            }

            //this.DATECHECK = (DateTime?)row["DATECHECK"];

            var DateOutTemp = row["DATEOUT"];
            if(DateOutTemp.ToString() != "")
            {
                this.DATEOUT = (DateTime?)DateOutTemp;
            }
          

            var MaNhanVienTemp = row["MANHANVIEN"];
            if (MaNhanVienTemp.ToString() != "")
            {
                this.MANHANVIEN = (int)MaNhanVienTemp;
            }
            //this.MABAN = (int)row["MABAN"];

            var MabanTemp = row["MABAN"];
            if(MabanTemp.ToString() != "")
            {
                this.MABAN = (int)MabanTemp;
            }    
            var MaKhachHangTemp = row["MAKHACHHANG"];
            if (MaKhachHangTemp.ToString() != "")
            {
                this.MAKHACHHANG = (int)MaKhachHangTemp;
            }
            var TrangThaiTemp = row["TRANGTHAI"];
            if (TrangThaiTemp != null && bool.TryParse(TrangThaiTemp.ToString(), out bool trangThai))
            {
                this.TRANGTHAI = trangThai;
            }
            else
            {
                this.TRANGTHAI = true; // hoặc giá trị mặc định khác tùy vào mục đích sử dụng của bạn
            }
            this.GIAMGIA = (int)row["GIAMGIA"];

        }
        public int MAHOADON { get; set; }

        public DateTime? DATECHECK { get; set; }

        public DateTime? DATEOUT { get; set; }

        public int MANHANVIEN { get; set; }

        public string TENNHANVIEN { get; set; }

        public int MAKHACHHANG { get; set; }

        public string TENKHACHHANG { get; set; }

        public int MABAN { get; set; }

        public string TENBAN { get; set; }

        public bool? TRANGTHAI { get; set; }

        public int GIAMGIA { get; set; }

        public decimal? TONGHOADON { get; set; }

        public decimal? TONGHOADONTHEOMA { get; set; }


    }
}
