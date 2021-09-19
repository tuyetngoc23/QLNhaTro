using QLNhaTro.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNhaTro.BUS
{
    class BUS_TraPhong
    {
        DAO_TraPhong dTraPhong;
        public BUS_TraPhong()
        {
            dTraPhong = new DAO_TraPhong();
        }
        public void LayDSThuePhong(DataGridView dg)
        {
            dg.DataSource =  dTraPhong.LayDSThuePhong();
        }
        public void TraPhong(int maPhong, int maKH, int maThue)
        {
            dTraPhong.TraPhong(maPhong, maKH, maThue);
        }
    }
}
