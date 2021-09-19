using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNhaTro.DAO
{
    class DAO_TraPhong
    {
        DBQLNhaTroEntities db;

        public DAO_TraPhong()
        {
            db = new DBQLNhaTroEntities();
        }

        public dynamic LayDSThuePhong()
        {
            var ds = db.ThuePhongs.Where(s => s.TrangThaiTraPhong == false).Select(s => new {
                MaThue = s.ID,
                MaKhach = s.KhachHangID,
                MaPhong = s.Phong.ID,
                s.Phong.SoPhong,
                LoaiPhong = s.Phong.LoaiPhong.Ten,
                s.NgayThue,
                s.TienCoc
            }).ToList();
            return ds;
        }
        public void TraPhong(int maPhong, int maKH, int maThue)
        {
            db.sp_TraPhong(maPhong, maKH, maThue);
            db.SaveChanges();
        }
    }
    
}
