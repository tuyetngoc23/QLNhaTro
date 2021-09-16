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
    public partial class FCapNhatPhong : Form
    {
        BUS_Phong busP;
        public FCapNhatPhong()
        {
            InitializeComponent();
            busP = new BUS_Phong();
        }
        public void HienThiDSPhong()
        {
            dgvPhong.DataSource = null;
            busP.LayDSPhong(dgvPhong);
            dgvPhong.Columns[0].Width = (int)(dgvPhong.Width * 0.2);
            dgvPhong.Columns[1].Width = (int)(dgvPhong.Width * 0.25);
            dgvPhong.Columns[2].Width = (int)(dgvPhong.Width * 0.25);
            dgvPhong.Columns[3].Width = (int)(dgvPhong.Width * 0.25);
        }

        private void FCapNhatPhong_Load(object sender, EventArgs e)
        {
            HienThiDSPhong();
        }
    }
}
