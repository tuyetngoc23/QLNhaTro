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
            cp.ID = kh.ID;
            cp.HoTen = kh.HoTen;
            cp.GioiTinh = kh.GioiTinh;
            cp.NgaySinh = kh.NgaySinh;
            cp.QueQuan = kh.QueQuan;
            cp.SDT = kh.SDT;
            cp.CMND = kh.CMND;
            cp.ThuePhongs = kh.ThuePhongs;
            db.SaveChanges();
        }

        public void XoaKH(KhachHang kh)
        {
            KhachHang cp = db.KhachHangs.Find(kh.ID);
            db.KhachHangs.Remove(cp);
            db.SaveChanges();
        }
    }
}
