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

        }

        private void FTrangChu_Load(object sender, EventArgs e)
        {
            bPhong.LayDSPTrong(dGVPhong);
        }

        private void dGVPhong_DoubleClick(object sender, EventArgs e)
        {
            FThuePhong f = new FThuePhong();
            f.Show();
            Close();
        }
    }
}
