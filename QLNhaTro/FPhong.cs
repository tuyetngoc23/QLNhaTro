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
            dGVPhong.Columns[0].Width = (int)(dGVPhong.Width * 0.19);
            dGVPhong.Columns[1].Width = (int)(dGVPhong.Width * 0.25);
            dGVPhong.Columns[2].Width = (int)(dGVPhong.Width * 0.25);
            dGVPhong.Columns[3].Width = (int)(dGVPhong.Width * 0.2);
           // dGVPhong.Columns[4].Width = (int)(dGVPhong.Width * 0.3);
        }
        
        private void FTrangChu_Load(object sender, EventArgs e)
        {
            
            bPhong.LayDSPTrong(dGVPhong);
            
            chinhDep();
            bPhong.LayDSLoaiPhong(cbLoai);
        }

        private void dGVPhong_DoubleClick(object sender, EventArgs e)
        {
            FThuePhong f = new FThuePhong();
            f.Show();
            Close(); 
        }

        private void cbLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (cbLoai.SelectedIndex == 0)
            {
                bPhong.LayDSPTheoPhongNho(dGVPhong);
            }
            else if (cbLoai.SelectedIndex == 1)
            {
                bPhong.LayDSPTheoPhongVua(dGVPhong);
            }
            else if (cbLoai.SelectedIndex == 2)
            {
                bPhong.LayDSPTheoPhongLon(dGVPhong);
            }
            
        }
    }
}
