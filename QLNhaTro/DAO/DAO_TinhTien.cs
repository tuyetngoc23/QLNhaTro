using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNhaTro.DAO
{
    class DAO_TinhTien
    {
        DBQLNhaTroEntities db;
        public DAO_TinhTien()
        {
            db = new DBQLNhaTroEntities();
        }
        public dynamic LayDSThang()
        {
            var ds = db.Thangs.Select(s => new { 
                s.ID,
                s.Ten
            }).ToList();
            return ds;
        }
        public dynamic LayDSPChuaThanhToan()
        {
            var ds = db.ThuePhongs.Where(s => s.TrangThaiThanhToan == false && s.TrangThaiTraPhong == false)
                                .Select(s => new { 
                                    s.ID,
                                    s.PhongID,
                                    s.KhachHangID,
                                    s.Phong.SoPhong,
                                    s.Phong.LoaiPhong.Gia
                                }).ToList();
            return ds;
        }
        public void TinhTien(HoaDon hd)
        {
            db.sp_TinhTien(hd.ThuePhongID, hd.SoDien, hd.SoNuoc, hd.TongTien, hd.ThangID);
            db.SaveChanges();
        }
    }
}
