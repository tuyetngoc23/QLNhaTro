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
    public partial class FMain : Form
    {
        public FMain()
        {
            InitializeComponent();
        }

        private void ptbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ptbMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ptbState_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
                this.WindowState = FormWindowState.Maximized;
                ptbState.Image = Properties.Resources.max;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                ptbState.Image = Properties.Resources.nut;
            }
        }
        

        private void phòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FCapNhatPhong f = new FCapNhatPhong();
            f.MdiParent = this;
            f.Show();
        }

        private void loaiPhongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FLoaiPhong f = new FLoaiPhong();
            f.MdiParent = this;
            f.Show();
        }

        private void thanhToanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FTinhTien f = new FTinhTien();
            f.MdiParent = this;
            f.Show();
        }

        private void traPhongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FTraPhong f = new FTraPhong();
            f.MdiParent = this;
            f.Show();
        }

        private void quanLyPhiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FPhi f = new FPhi();
            f.MdiParent = this;
            f.Show();
        }

        private void quanLyKHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FCapNhatKH f = new FCapNhatKH();
            f.MdiParent = this;
            f.Show();
        }
    }
}
