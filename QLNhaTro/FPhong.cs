using QLNhaTro.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNhaTro
{
    public partial class FPhong : Form
    {
        BUS_Phong bPhong;
        public FPhong()
        {
            InitializeComponent();
            bPhong = new BUS_Phong();
        }

        void chinhDep()
        {
            dGVPhong.Columns[0].Width = (int)(dGVPhong.Width * 0.209);
            dGVPhong.Columns[1].Width = (int)(dGVPhong.Width * 0.34);
            dGVPhong.Columns[2].Width = (int)(dGVPhong.Width * 0.34);
        }

        private void FTrangChu_Load(object sender, EventArgs e)
        {
            bPhong.LayDSPTrong(dGVPhong);
            chinhDep();
        }

        private void dGVPhong_DoubleClick(object sender, EventArgs e)
        {
            FThuePhong f = new FThuePhong();
            f.Show();
            Close(); 
        }
    }
}
