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
        public void ThemKH(KhachHang kh)
        {
            db.sp_ThemKH(kh.HoTen, kh.CMND, kh.QueQuan, kh.GioiTinh, kh.NgaySinh, kh.SDT, kh.ID);
            db.SaveChanges();
        }
    }
}
