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
                            s.LoaiPhong.Gia
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

        public dynamic LayDSPhong()
        {
            var ds = db.Phongs.Select(s => new 
                {
                    s.ID,
                    s.LoaiPhong.Ten,
                    s.SoPhong,
                    s.LoaiPhong.Gia
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
        public void ThemLoaiPhong(LoaiPhong lp)
        {
            db.LoaiPhongs.Add(lp);
            db.SaveChanges();
        }
        public bool KiemTraThemLP(LoaiPhong lp)
        {
            LoaiPhong loaiP = db.LoaiPhongs.Find(lp.ID);
            if (loaiP != null)
                return true;
            else
                return false;
        }
        public void SuaLoaiPhong(LoaiPhong lp)
        {
            LoaiPhong loaiP = db.LoaiPhongs.Find(lp.ID);
            loaiP.ID = lp.ID;
            loaiP.Ten = lp.Ten;
            loaiP.Gia = lp.Gia;
            db.SaveChanges();
        }

        public void XoaLoaiPhong(LoaiPhong lp)
        {
            LoaiPhong loaiP = db.LoaiPhongs.Find(lp.ID);
            db.LoaiPhongs.Remove(loaiP);
            db.SaveChanges();
        }
        public void ThemPhong(Phong p)
        {
            db.Phongs.Add(p);
            db.SaveChanges();
        }
        public bool KiemTraThemP(Phong p)
        {
            Phong P = db.Phongs.Find(p.ID);
            if (P != null)
                return true;
            else
                return false;
        }
        public void SuaPhong(Phong p)
        {
            Phong P = db.Phongs.Find(p.ID);
            P.LoaiPhongID = p.LoaiPhongID;
            p.SoPhong = p.SoPhong;
            db.SaveChanges();
        }

        public void XoaPhong(Phong p)
        {
            Phong P = db.Phongs.Find(p.ID);
            db.Phongs.Remove(P);
            db.SaveChanges();
        }

    }
}
