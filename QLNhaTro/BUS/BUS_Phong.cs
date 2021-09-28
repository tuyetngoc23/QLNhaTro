using QLNhaTro.DAO;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
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

        public void LayDSPTheoPhongNho(DataGridView dg)
        {
            dg.DataSource = dPhong.LayDSPTheoPhongNho();
        }
        public void LayDSPTheoPhongVua(DataGridView dg)
        {
            dg.DataSource = dPhong.LayDSPTheoPhongVua();
        }
        public void LayDSPTheoPhongLon(DataGridView dg)
        {
            dg.DataSource = dPhong.LayDSPTheoPhongLon();
        }
        public void LayDSLoaiPhong(ComboBox cb)
        {
            cb.DataSource = dPhong.LayDSLoaiPhong();
            cb.DisplayMember = "Ten";
            cb.ValueMember = "ID";
        }

        public void LayDSPhong(DataGridView dg)
        {
            dg.DataSource = dPhong.LayDSPhong();
        }
        public void LayDSLoaiPhong(DataGridView dg)
        {
            dg.DataSource = dPhong.LayDSLoaiPhong();
        }
        public bool ThemLoaiPhong(LoaiPhong lp)
        {
            try
            {
                dPhong.ThemLoaiPhong(lp);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public bool SuaLoaiPhong(LoaiPhong lp)
        {
            if (dPhong.KiemTraThemLP(lp))
            {
                try
                {
                    dPhong.SuaLoaiPhong(lp);
                    return true;
                }
                catch (DbUpdateException ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public bool XoaLoaiPhong(LoaiPhong lp)
        {
            if (dPhong.KiemTraThemLP(lp))
            {
                try
                {
                    dPhong.XoaLoaiPhong(lp);
                    return true;
                }
                catch (Exception)
                {
                    MessageBox.Show("Không thể xóa loại phòng đang được thuê");
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public bool ThemPhong(Phong p)
        {
            try
            {
                dPhong.ThemPhong(p);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool SuaPhong(Phong p)
        {
            if (dPhong.KiemTraThemP(p))
            {
                try
                {
                    dPhong.SuaPhong(p);
                    return true;
                }
                catch (DbUpdateException ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public bool XoaPhong(Phong p)
        {
            if (dPhong.KiemTraThemP(p))
            {
                try
                {
                    dPhong.XoaPhong(p);
                    return true;
                }
                catch (Exception)
                {
                    MessageBox.Show("Không thể xóa phòng đang được thuê");
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
