using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUSS
{
    public class DanhMucSanPhamBUS
    {
        public List<DanhMuc> TimKiemTheoDanhMuc(string keywork)
        {
            return DanhMucSanPhamDAO.Instance.TimKiemTheoDanhMuc(keywork);
        }

        public bool KiemtraDanhMucSua(DanhMucSanPhamDTO newdm)
        {
            return DanhMucSanPhamDAO.Instance.KiemtraDanhMucSua(newdm);
        }

        public bool KiemtraDanhMucThem(DanhMucSanPhamDTO newdm)
        {
            return DanhMucSanPhamDAO.Instance.KiemtraDanhMucThem(newdm);
        }

        public bool KiemtraDanhMucTontaitrongSanPham(DanhMucSanPhamDTO newdm)
        {
            return DanhMucSanPhamDAO.Instance.KiemtraDanhMucTontaitrongSanPham(newdm);
        }

        public bool SetMaDMKoDcXoa(DanhMucSanPhamDTO newdm)
        {
            return DanhMucSanPhamDAO.Instance.SetMaDanhMucKhongDcXoa(newdm);
        }

    }
}
