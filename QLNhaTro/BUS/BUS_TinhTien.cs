using QLNhaTro.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNhaTro.BUS
{
    class BUS_TinhTien
    {
        DAO_TinhTien dTinhTien;
        public BUS_TinhTien()
        {
            dTinhTien = new DAO_TinhTien();
        }
        public void LayDSThang(ComboBox cb)
        {
            cb.DataSource = dTinhTien.LayDSThang();
            cb.DisplayMember = "Ten";
            cb.ValueMember = "ID";
        }
        public void LayDSPChuaThanhToan(DataGridView dg)
        {
            dg.DataSource = dTinhTien.LayDSPChuaThanhToan();
        }
        public void TinhTien(DataTable dtTinhTien)
        {
            foreach(DataRow item in dtTinhTien.Rows)
            {
                HoaDon hd = new HoaDon();
                hd.ThuePhongID = int.Parse(item[0].ToString());
                hd.SoDien = int.Parse(item[1].ToString());
                hd.SoNuoc = int.Parse(item[2].ToString());
                hd.TongTien = Decimal.Parse(item[3].ToString());
                hd.ThangID = int.Parse(item[4].ToString());

                dTinhTien.TinhTien(hd);
            }
        }
    }
}
