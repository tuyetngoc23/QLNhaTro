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
    }
}
