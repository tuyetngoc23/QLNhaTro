﻿using QLNhaTro.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNhaTro.BUS
{
    class BUS_Phong
    {
        DAO_Phong dPhong;
        public BUS_Phong()
        {
            dPhong = new DAO_Phong();
        }
        public void LayDSPTrong(DataGridView dg)
        {
            dg.DataSource = dPhong.LayDSPTrong();
        }
        public void LayDSPhong(DataGridView dg)
        {
            dg.DataSource = dPhong.LayDSPhong();
        }
        public void LayDSLoaiPhong(DataGridView dg)
        {
            dg.DataSource = dPhong.LayDSLoaiPhong();
        }
        public bool ThemLoaiPhong(LoaiPhong p)
        {
            try
            {
                dPhong.ThemLoaiPhong(p);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
