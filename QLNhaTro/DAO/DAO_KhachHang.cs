using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNhaTro.DAO
{
    class DAO_KhachHang
    {
        DBQLNhaTroEntities db;
        public DAO_KhachHang()
        {
            db = new DBQLNhaTroEntities();
        }
        public dynamic LayDSKH()
        {
            var ds = db.KhachHangs.Select(s => new { 
                s.ID,
                s.HoTen,
                s.GioiTinh,
                s.SDT,
                s.CMND,
                s.QueQuan,
                s.TrangThaiThuePhong,
                s.NgaySinh
            }).ToList();
            return ds;
        }
        public dynamic LayDSKHTrong()
        {
            var ds = db.KhachHangs.Where(s => s.TrangThaiThuePhong == false)
                                    .Select(s => new {
                                        s.ID,
                                        s.HoTen,
                                        s.GioiTinh,
                                        s.SDT,
                                        s.CMND,
                                        s.QueQuan,
                                        s.TrangThaiThuePhong,
                                        s.NgaySinh
                                    }).ToList();
            return ds;
        }

        public void ThemKH(KhachHang kh)
        {
            db.sp_ThemKH(kh.HoTen, kh.CMND, kh.QueQuan, kh.GioiTinh, kh.NgaySinh, kh.SDT, kh.ID);
            db.SaveChanges();
        }
        public void ThuePhong(ThuePhong tp)
        {
            db.sp_ThuePhong(tp.TienCoc, tp.NgayNhanCoc, tp.PhongID, tp.KhachHangID);
            db.SaveChanges();
        }
        public dynamic LayDSKhachThue()
        {
            var ds = db.KhachHangs.Select(s => new
            {
                s.ID,
                s.HoTen,
                s.GioiTinh,
                s.NgaySinh,
                s.QueQuan,
                s.CMND,
                s.SDT,
                
            }).ToList();
            return ds;
        }
        public dynamic LayDSPTheoPhongNho()
        {
            var ds = db.Phongs.Where(s => s.TrangThai == false && s.LoaiPhongID == 1)
                .Select(s => new {
                    s.ID,
                    TenLoaiPhong = s.LoaiPhong.Ten,
                    s.SoPhong,
                    s.LoaiPhong.Gia
                }).ToList();
            return ds;
        }
        public dynamic LayDSPTheoPhongVua()
        {
            var ds = db.Phongs.Where(s => s.TrangThai == false && s.LoaiPhongID == 2)
                .Select(s => new {
                    s.ID,
                    TenLoaiPhong = s.LoaiPhong.Ten,
                    s.SoPhong,
                    s.LoaiPhong.Gia,
                }).ToList();
            return ds;
        }
        public dynamic LayDSPTheoPhongLon()
        {
            var ds = db.Phongs.Where(s => s.TrangThai == false && s.LoaiPhongID == 3)
                .Select(s => new {
                    s.ID,
                    TenLoaiPhong = s.LoaiPhong.Ten,
                    s.SoPhong,
                    s.LoaiPhong.Gia,
                }).ToList();
            return ds;
        }
        public dynamic LayDSLoaiPhong()
        {
            var ds = db.LoaiPhongs.Select(s => new
            {
                s.ID,
                s.Ten,
                s.Gia
            }).ToList();
            return ds;
        }
        public bool KiemTraKH(KhachHang kh)
        {
            KhachHang cp = db.KhachHangs.Find(kh.ID);
            if (cp != null)
                return true;
            else
                return false;
        }
        public void SuaKH(KhachHang kh)
        {
            KhachHang cp = db.KhachHangs.Find(kh.ID);
            
            cp.HoTen = kh.HoTen;
            cp.GioiTinh = kh.GioiTinh;
            cp.NgaySinh = kh.NgaySinh;
            cp.QueQuan = kh.QueQuan;
            cp.SDT = kh.SDT;
            cp.CMND = kh.CMND;
            db.SaveChanges();
        }
        public void XoaKH(KhachHang kh)
        {
            KhachHang thue = db.KhachHangs.Find(kh.ID);
            db.KhachHangs.Remove(thue);
            db.SaveChanges();
        }
    }
}
