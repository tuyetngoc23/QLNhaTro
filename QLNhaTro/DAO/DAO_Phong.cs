using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNhaTro.DAO
{
    class DAO_Phong
    {
        DBQLNhaTroEntities db;
        public DAO_Phong()
        {
            db = new DBQLNhaTroEntities();
        }
        public dynamic LayDSPTrong()
        {
            var ds = db.Phongs.Where(s => s.TrangThai == false)
                .Select(s => new { 
                            s.ID,
                            TenLoaiPhong = s.LoaiPhong.Ten,
                            s.SoPhong,
                            s.SoNguoiToiDa
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
                    s.SoNguoiToiDa
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
                    s.SoNguoiToiDa
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
                    s.SoNguoiToiDa
                }).ToList();
            return ds;
        }
        public dynamic LayDSLoaiPhong()
        {
            var ds = db.LoaiPhongs.Select(s => new {
                                                s.ID,
                                                 s.Ten
                                         }).ToList();
            return ds;
        }
        
    }
}
