using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class DanhMucSanPhamDAO
    {
        quanlycuahangbanhSHBEntities db = new quanlycuahangbanhSHBEntities();
        private static DanhMucSanPhamDAO instance;

        public static DanhMucSanPhamDAO Instance
        {
            get { if (instance == null) instance = new DanhMucSanPhamDAO(); return DanhMucSanPhamDAO.instance; }

            private set { DanhMucSanPhamDAO.instance = value; }
        }
        private DanhMucSanPhamDAO() { }

        public List<DanhMucSanPhamDTO> LayDanhSach()
        {
            List<DanhMucSanPhamDTO> listdmsp = new List<DanhMucSanPhamDTO>();

            string query = "select * from DanhMuc where XOA = 1";

            DataTable data = DataProvider.Instance.ExecuQuery(query);

            foreach (DataRow row in data.Rows)
            {
                DanhMucSanPhamDTO danhmucsp = new DanhMucSanPhamDTO(row);
                listdmsp.Add(danhmucsp);
            }

            return listdmsp;
        }

        //Phương thức thêm danh mục
        public bool ThemDanhMuc(DanhMucSanPhamDTO newDM)
        {
            try
            {
                DanhMuc dmEF = new DanhMuc
                {
                    MADANHMUC = newDM.MADANHMUC,
                    TENDANHMUC = newDM.TENDANHMUC,
                    XOA = true
                };
                db.DanhMucs.Add(dmEF);
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool XoaDanhMuc(DanhMucSanPhamDTO delDM)
        {
            try
            {
                DanhMuc dmEF = db.DanhMucs.SingleOrDefault(u => u.MADANHMUC == delDM.MADANHMUC);
                if (dmEF == null)
                {
                    return false;
                };

                dmEF.XOA = false;

                SanPham Spef = db.SanPhams.SingleOrDefault(c => c.MADANHMUC == dmEF.MADANHMUC);
                if (Spef != null)
                {
                    return false;
                }
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool SuaDanhMuc(DanhMucSanPhamDTO upDM)
        {
            try
            {
                var dmEF = db.DanhMucs.SingleOrDefault(u => u.MADANHMUC == upDM.MADANHMUC);
                if (dmEF != null)
                {
                    dmEF.TENDANHMUC = upDM.TENDANHMUC;
                };
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        // Tìm kiếm 
        public List<DanhMuc> TimKiemTheoDanhMuc(string keywork)
        {
            using (var context = new quanlycuahangbanhSHBEntities())
            {
                return context.DanhMucs.Where(v =>
                v.TENDANHMUC.Contains(keywork))
                    .Where(f => f.XOA == true).ToList();
            }
        }

        public bool KiemtraDanhMucSua(DanhMucSanPhamDTO newdm)
        {
            DanhMuc efkh = db.DanhMucs.SingleOrDefault(c => c.TENDANHMUC == newdm.TENDANHMUC && c.MADANHMUC != newdm.MADANHMUC && c.XOA == true);
            if (efkh != null)
            {
                return false;
            }
            return true;
        }

        public bool KiemtraDanhMucThem(DanhMucSanPhamDTO newdm)
        {
            DanhMuc efkh = db.DanhMucs.SingleOrDefault(c => c.TENDANHMUC == newdm.TENDANHMUC &&  c.XOA == true);
            if (efkh != null)
            {
                return false;
            }
            return true;
        }

        public bool KiemtraDanhMucTontaitrongSanPham(DanhMucSanPhamDTO newdm)
        {
            SanPham efkh = db.SanPhams.SingleOrDefault(c => c.MADANHMUC == newdm.MADANHMUC && c.XOA == true );
            if (efkh != null)
            {
                return false;
            }
            return true;
        }

        public bool SetMaDanhMucKhongDcXoa(DanhMucSanPhamDTO newdm)
        {
            if(newdm.MADANHMUC == 1 || newdm.MADANHMUC == 2)
            {
                return true;
            }
            return false;
        }

    }
}
