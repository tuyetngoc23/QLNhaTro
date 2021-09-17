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
    class BUS_KhachHang
    {
        DAO_KhachHang dKH;
        public BUS_KhachHang()
        {
            dKH = new DAO_KhachHang();
        }
        public void LayDSKH(DataGridView dg)
        {
            dg.DataSource = dKH.LayDSKH();
        }
        public void LayDSKHTrong(DataGridView dg)
        {
            dg.DataSource = dKH.LayDSKHTrong();
        }
        public void ThemKH(DataTable dtKhachHang)
        {
            try
            {
                foreach (DataRow item in dtKhachHang.Rows)
                {
                    KhachHang d = new KhachHang();
                    d.HoTen = item[0].ToString();
                    d.CMND = item[1].ToString();
                    d.QueQuan = item[2].ToString();
                    d.GioiTinh = item[3].ToString();
                    d.NgaySinh = DateTime.Parse(item[4].ToString());
                    d.SDT= item[5].ToString();

                    if (item[6] == null || item[6].Equals(""))
                    {
                        d.ID = 0;
                    }
                    else
                    {
                        d.ID = int.Parse(item[6].ToString());
                    }

                    dKH.ThemKH(d);
                }

            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }
        }


        public void ThuePhong(DataTable dtThuePhong)
        {
            foreach(DataRow item in dtThuePhong.Rows)
            {
                ThuePhong tp = new ThuePhong();
                tp.TienCoc = decimal.Parse( item[0].ToString());
                tp.NgayNhanCoc = DateTime.Parse( item[1].ToString());
                tp.PhongID = int.Parse(item[2].ToString());
                tp.KhachHangID = int.Parse(item[3].ToString());

                dKH.ThuePhong(tp);
            }
        }

    }
}
