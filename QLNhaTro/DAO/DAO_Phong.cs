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
                            s.LoaiPhong.Ten,
                            s.SoPhong
                        }).ToList();
            return ds;
        }
    }
}
