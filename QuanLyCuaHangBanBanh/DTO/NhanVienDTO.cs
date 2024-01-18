using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVienDTO
    {
        public NhanVienDTO() { }

        public NhanVienDTO(int MANHANVIEN, string HOTEN, string DIACHI, string EMAIL, string SDT, string CALAMVIEC, bool? GIOITINH, decimal? LUONG, string CHUCVU, byte[] HINHANH, string TENDANGNHAP, string MATKHAU = "1")
        {
            this.MANHANVIEN = MANHANVIEN;
            this.HOTEN = HOTEN;
            this.DIACHI = DIACHI;
            this.EMAIL = EMAIL;
            this.SDT = SDT;
            this.CALAMVIEC = CALAMVIEC;
            this.GIOITINH = GIOITINH;
            this.LUONG = LUONG;
            this.CHUCVU = CHUCVU;
            this.HINHANH = HINHANH;
            this.TENDANGNHAP = TENDANGNHAP;
            this.MATKHAU = MATKHAU;
        }

        public int MANHANVIEN { get; set; }
        public string HOTEN { get; set; }
        public string DIACHI { get; set; }
        public string EMAIL { get; set; }
        public string SDT { get; set; }
        public string CALAMVIEC { get; set; }
        public bool? GIOITINH { get; set; }
        public decimal? LUONG { get; set; }
        public string CHUCVU { get; set; }
        public byte[] HINHANH { get; set; }
        public string TENDANGNHAP { get; set; }
        public string MATKHAU { get; set; }
       
    }
}
