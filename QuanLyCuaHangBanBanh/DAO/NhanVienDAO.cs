using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class NhanVienDAO
    {
        quanlycuahangbanhSHBEntities _qlch = new quanlycuahangbanhSHBEntities();
        private static NhanVienDAO instance;

        public static NhanVienDAO Instance
        {
            get { if (instance == null) instance = new NhanVienDAO(); return NhanVienDAO.instance; }

            private set { NhanVienDAO.instance = value; }
        }

        public NhanVienDAO() { }

        public List<NhanVienDTO> LoadNhanVien()
        {
            var lst = from v in _qlch.NhanViens
                      where v.XOA == true
                      select new NhanVienDTO
                      {
                          MANHANVIEN = v.MANHANVIEN,
                          HOTEN = v.HOTEN,
                          DIACHI = v.DIACHI,
                          EMAIL = v.EMAIL,
                          SDT = v.SDT,
                          CALAMVIEC = v.CALAMVIEC,
                          GIOITINH = v.GIOITINH == true ? true : v.GIOITINH.Value,
                          LUONG = v.LUONG,
                          CHUCVU = v.CHUCVU,
                          HINHANH = v.HINHANH,
                          TENDANGNHAP = v.TENDANGNHAP,
                          
                      };
            return lst.ToList();
        }

        public List<NhanVienDTO> loadnvtheoma(int manhanvien)
        {
            var lst = from v in _qlch.NhanViens
                      where v.XOA == true && v.MANHANVIEN == manhanvien
                      select new NhanVienDTO
                      {
                          MANHANVIEN = v.MANHANVIEN,
                          HOTEN = v.HOTEN,
                          DIACHI = v.DIACHI,
                          EMAIL = v.EMAIL,
                          SDT = v.SDT,
                          CALAMVIEC = v.CALAMVIEC,
                          GIOITINH = v.GIOITINH == true ? true : v.GIOITINH.Value,
                          LUONG = v.LUONG,
                          CHUCVU = v.CHUCVU,
                          HINHANH = v.HINHANH,
                          TENDANGNHAP = v.TENDANGNHAP,
                      };
            return lst.ToList();
        }
        public bool ThemNhanVien(NhanVienDTO newUser)
        {
            try
            {
                NhanVien f = new NhanVien
                {
                    MANHANVIEN = newUser.MANHANVIEN,
                    HOTEN = newUser.HOTEN,
                    DIACHI = newUser.DIACHI,
                    EMAIL = newUser.EMAIL,
                    LUONG = newUser.LUONG,
                    SDT = newUser.SDT,
                    CALAMVIEC = newUser.CALAMVIEC,
                    GIOITINH = newUser.GIOITINH,
                    CHUCVU = newUser.CHUCVU,
                    HINHANH = newUser.HINHANH,
                    TENDANGNHAP = newUser.TENDANGNHAP,
                    XOA = true,
                    MATKHAU = "1",                   
                };

                _qlch.NhanViens.Add(f);
                _qlch.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public bool SuaNhanVien(NhanVienDTO suaUser)
        {
            try
            {
                NhanVien f = _qlch.NhanViens.SingleOrDefault(u => u.MANHANVIEN == suaUser.MANHANVIEN);
                if (f == null)
                {
                    return false;
                }

                f.MANHANVIEN = suaUser.MANHANVIEN;
                f.DIACHI = suaUser.DIACHI;
                f.TENDANGNHAP = suaUser.TENDANGNHAP;
                f.SDT = suaUser.SDT;
                f.GIOITINH = suaUser.GIOITINH;
                f.HOTEN = suaUser.HOTEN;
                f.EMAIL = suaUser.EMAIL;
                f.CALAMVIEC = suaUser.CALAMVIEC;
                f.LUONG = suaUser.LUONG;
                f.CHUCVU = suaUser.CHUCVU;
                f.HINHANH = suaUser.HINHANH;


                _qlch.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public bool SuaTenDangNhap(NhanVienDTO suaUser)
        {
            try
            {
                NhanVien f = _qlch.NhanViens.SingleOrDefault(u => u.MANHANVIEN == suaUser.MANHANVIEN);
                if (f == null)
                {
                    return false;
                }

                f.MANHANVIEN = suaUser.MANHANVIEN;            
                f.TENDANGNHAP = suaUser.TENDANGNHAP;
               

                _qlch.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public bool SuaMatKhau(NhanVienDTO suaUser)
        {
            try
            {
                NhanVien f = _qlch.NhanViens.SingleOrDefault(u => u.MANHANVIEN == suaUser.MANHANVIEN);
                if (f == null)
                {
                    return false;
                }

                f.MANHANVIEN = suaUser.MANHANVIEN;
                f.MATKHAU= suaUser.MATKHAU;


                _qlch.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public bool KieMtraSuaNhanVien(NhanVienDTO Suanv)
        {
            NhanVien efkh = _qlch.NhanViens.SingleOrDefault(c => c.SDT == Suanv.SDT && c.MANHANVIEN != Suanv.MANHANVIEN && c.XOA == true);
            if (efkh != null)
            {
                return false;
            }
            return true;
        }

        public bool XoaNhanVien(NhanVienDTO xoaUser)
        {
            try
            {
                NhanVien a = _qlch.NhanViens.SingleOrDefault(u => u.MANHANVIEN == xoaUser.MANHANVIEN);
                if(a == null)
                {
                    return false;
                }
                
                a.XOA = false;

                _qlch.SaveChanges();

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public bool ResetMatKhau(NhanVienDTO NhanVien)
        {
            try
            {
                NhanVien a = _qlch.NhanViens.SingleOrDefault(u => u.MANHANVIEN == NhanVien.MANHANVIEN);
                if (a == null)
                {
                    return false;
                }

                a.MATKHAU = "1";

                _qlch.SaveChanges();

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }



        public NhanVienDTO KiemtraDangNhap(string tendangnhap, string matkhau)
        {
                using (var qlda = new quanlycuahangbanhSHBEntities())
                {
                    var dangNhap = (from c in qlda.NhanViens
                                    where c.TENDANGNHAP == tendangnhap && c.MATKHAU == matkhau && c.XOA == true
                                    select new NhanVienDTO
                                    {
                                        MANHANVIEN = c.MANHANVIEN,
                                        TENDANGNHAP = c.TENDANGNHAP,
                                        MATKHAU = c.MATKHAU,
                                        HOTEN = c.HOTEN,
                                        CHUCVU = c.CHUCVU,

                                    }).FirstOrDefault();

                    return dangNhap;
                }
                //select * from nhanvien wherer tendangnhap = tendangnhap and xoa == true
        }

        public bool KiemtraTontaiNhanVien(NhanVienDTO nv)
        {
            NhanVien efnv = _qlch.NhanViens.SingleOrDefault(c => c.SDT == nv.SDT);
            if(efnv != null)
            {
                return false;
            }
            return true;
        }
        // Tìm kiếm 
        public List<NhanVien> TimKiemNhanVien(string keywork)
        {
            using (var context = new quanlycuahangbanhSHBEntities())
            {
                return context.NhanViens.Where(v =>
                        v.DIACHI.Contains(keywork) ||
                        v.HOTEN.Contains(keywork) ||
                        v.EMAIL.Contains(keywork) ||
                        v.CHUCVU.Contains(keywork) ||
                        v.SDT.Contains(keywork) ||
                        v.GIOITINH.ToString() == (keywork) )
                    .Where(f => f.XOA == true).ToList();
            }
        }

        public bool KiemTraDoDaiSDT(string matKhau)
        {
            if (matKhau.Length > 10) 
            {
                return false;
            }
            return true;
        }

    }
}

