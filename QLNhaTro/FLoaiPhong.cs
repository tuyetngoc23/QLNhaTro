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
    public partial class FLoaiPhong : Form
    {
        BUS_Phong busP;
        public int maLoaiPhong;
        public FLoaiPhong()
        {
            InitializeComponent();
            busP = new BUS_Phong();
        }
        public void HienThiDSLoaiPhong()
        {
            dgvLoai.DataSource = null;
            busP.LayDSLoaiPhong(dgvLoai);
            dgvLoai.Columns[0].Width = (int)(dgvLoai.Width * 0.25);
            dgvLoai.Columns[1].Width = (int)(dgvLoai.Width * 0.375);
            dgvLoai.Columns[2].Width = (int)(dgvLoai.Width * 0.375);
            
        }
        private void dgvLoai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void FLoaiPhong_Load(object sender, EventArgs e)
        {
            HienThiDSLoaiPhong();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            //Gọi form loại phòng
            FLoaiPhong f = new FLoaiPhong();
            //Truyền mã đơn qua form
            f.maLoaiPhong = this.maLoaiPhong;

            //f.ShowDialog();
        }
    }
}
