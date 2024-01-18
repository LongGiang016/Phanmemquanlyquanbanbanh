using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DanhMucSanPhamDTO
    {
        //MADANHMUC,TENDANHMUC
        public DanhMucSanPhamDTO() { }
        public DanhMucSanPhamDTO(int MADANHMUC, string TENDANHMUC)
        {
            this.MADANHMUC = MADANHMUC;
            this.TENDANHMUC = TENDANHMUC;
        }

        public DanhMucSanPhamDTO(DataRow row)
        {
            this.MADANHMUC = (int)row["MADANHMUC"];
            this.TENDANHMUC = row["TENDANHMUC"].ToString();
        }
        public int MADANHMUC { get; set; }

        public string TENDANHMUC { get; set; }


    }
}
