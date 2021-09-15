using QLNhaTro.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNhaTro.BUS
{
    class BUS_KhachHang
    {
        DAO_KhachHang dKH;
        public BUS_KhachHang()
        {
            dKH = new DAO_KhachHang();
        }
    }
}
