using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLNhaTro.DAO;

namespace QLNhaTro.BUS
{
    class BUS_Phi
    {
        DAO_Phi dPhi;
        public BUS_Phi()
        {
            dPhi = new DAO_Phi();
        }
        public void LayDSPhi(DataGridView dg)
        {
            dg.DataSource = dPhi.layDSPhi();
        }

        public bool themPhi(ChiPhi cphi)
        {
            try
            {
                dPhi.themPhi(cphi);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public bool SuaPhi(ChiPhi cphi)
        {
            if (dPhi.KiemTraP(cphi))
            {
                try
                {
                    dPhi.SuaPhi(cphi);
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
        public bool XoaPhi(ChiPhi cphi)
        {
            if (dPhi.KiemTraP(cphi))
            {
                try
                {
                    dPhi.XoaPhi(cphi);
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
    }
}
