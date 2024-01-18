using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachHangDTO
    {
        //MAKHACHHANG, HOTEN,EMAIL,DIACHI, SDT,GIOITINH
        public KhachHangDTO(int MAKHACHHANG, string HOTEN, string SDT)
        {
            this.MAKHACHHANG= MAKHACHHANG;
            this.HOTEN= HOTEN;
            this.SDT = SDT;
            

        }

        public KhachHangDTO(DataRow row)
        {
            this.MAKHACHHANG = (int)row["MAKHACHHANG"];
            this.HOTEN = row["HOTEN"].ToString();
            this.SDT = row["SDT"].ToString();
            
        }

       public KhachHangDTO() { }
       public int MAKHACHHANG { get; set; }

       public string HOTEN { get; set; }
       public string SDT { get; set; }









    }
}
