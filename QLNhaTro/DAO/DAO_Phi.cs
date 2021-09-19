using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNhaTro.DAO
{
    class DAO_Phi
    {
        DBQLNhaTroEntities db;
        public DAO_Phi()
        {
            db = new DBQLNhaTroEntities();
        }

        public dynamic layDSPhi()
        {
            var ds = db.ChiPhis.Select(s => new
            {
                s.ID,
                s.Ten,
                s.Gia
            }).ToList();
            return ds;
        }

        public void themPhi(ChiPhi p)
        {
            db.ChiPhis.Add(p);
            db.SaveChanges();
        }
        public bool KiemTraP(ChiPhi cphi)
        {
            ChiPhi cp = db.ChiPhis.Find(cphi.ID);
            if (cp != null)
                return true;
            else
                return false;
        }
        public void SuaPhi(ChiPhi cphi)
        {
            ChiPhi cp = db.ChiPhis.Find(cphi.ID);
            cp.ID = cphi.ID;
            cp.Ten = cphi.Ten;
            cp.Gia = cphi.Gia;
            db.SaveChanges();
        }

        public void XoaPhi(ChiPhi cphi)
        {
            ChiPhi phi = db.ChiPhis.Find(cphi.ID);
            db.ChiPhis.Remove(phi);
            db.SaveChanges();
        }

        
    }



}
