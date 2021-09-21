using QLNhaTro.BUS;
using QLNhaTro.Report;
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
        
        private void loaiPhongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
            FLoaiPhong f = new FLoaiPhong();
            f.MdiParent = this;
            f.Show();
        }

        private void thanhToanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
            FTinhTien f = new FTinhTien();
            f.MdiParent = this;
            f.Show();
        }

        private void traPhongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
            FTraPhong f = new FTraPhong();
            f.MdiParent = this;
            f.Show();
        }

        private void quanLyPhiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
            FPhi f = new FPhi();
            f.MdiParent = this;
            f.Show();
        }

        private void quanLyKHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
            FCapNhatKH f = new FCapNhatKH();
            f.MdiParent = this;
            f.Show();
        }

        private void danhSachPhongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
            FPhong f = new FPhong();
            f.MdiParent = this;
            f.Show();
        }

        private void thuePhongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
            FThuePhong f = new FThuePhong();
            f.MdiParent = this;
            f.Show();
        }

        private void capNhatPhongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
            FCapNhatPhong f = new FCapNhatPhong();
            f.MdiParent = this;
            f.Show();
        }

        private void ReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DBQLNhaTroEntities db = new DBQLNhaTroEntities();
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
            FReport f = new FReport();
            cReport c = new cReport();
            c.SetDataSource(db.HoaDons.Select(s=> new { 
                s.ThangID,
                s.ThuePhong.PhongID,
                s.TongTien
            }).ToList().OrderBy(s => s.ThangID));

            f.MdiParent = this;
            f.cRVDoanhThu.ReportSource = c;
            f.Show();
        }
    }
}
