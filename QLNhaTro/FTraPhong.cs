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
    public partial class FTraPhong : Form
    {
        BUS_TraPhong bTraPhong;
        
        public FTraPhong()
        {
            InitializeComponent();
            bTraPhong = new BUS_TraPhong();
        }
        public void LayDSThuePhong()
        {
            bTraPhong.LayDSThuePhong(dvgTraPhong);

            dvgTraPhong.Columns[0].Width = (int)(dvgTraPhong.Width * 0.15);
            dvgTraPhong.Columns[1].Width = (int)(dvgTraPhong.Width * 0.15);
            dvgTraPhong.Columns[2].Width = (int)(dvgTraPhong.Width * 0.15);
            dvgTraPhong.Columns[3].Width = (int)(dvgTraPhong.Width * 0.15);
            dvgTraPhong.Columns[4].Width = (int)(dvgTraPhong.Width * 0.2);
            dvgTraPhong.Columns[5].Width = (int)(dvgTraPhong.Width * 0.2);
            dvgTraPhong.Columns[6].Width = (int)(dvgTraPhong.Width * 0.2);
        }

        private void FTraPhong_Load(object sender, EventArgs e)
        {
            LayDSThuePhong();
        }

        private void dvgTraPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dvgTraPhong.Rows.Count)
            {
                tbMaThue.Text =  dvgTraPhong.Rows[e.RowIndex].Cells["MaThue"].Value.ToString();
                tbMaPhong.Text = dvgTraPhong.Rows[e.RowIndex].Cells["MaPhong"].Value.ToString();
                tbMaKhach.Text = dvgTraPhong.Rows[e.RowIndex].Cells["MaKhach"].Value.ToString();
                tbSoPhong.Text = dvgTraPhong.Rows[e.RowIndex].Cells["SoPhong"].Value.ToString();
                tbTenPhong.Text = dvgTraPhong.Rows[e.RowIndex].Cells["LoaiPhong"].Value.ToString();
                dtpNgayThue.Text = dvgTraPhong.Rows[e.RowIndex].Cells["NgayThue"].Value.ToString();
                tbTienCoc.Text = dvgTraPhong.Rows[e.RowIndex].Cells["TienCoc"].Value.ToString();
            }
        }

        private void btXacNhan_Click(object sender, EventArgs e)
        {
            int maPhong;
            int maKH;
            int maThue;

            if (tbMaKhach.Text == null || tbMaKhach.Text.Equals("") || tbMaPhong.Text == null || tbMaPhong.Text.Equals("")
                || tbMaThue.Text == null || tbMaThue.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng chọn phòng cần trả");
            }
            else
            {
                maPhong = int.Parse(tbMaPhong.Text);
                maKH = int.Parse(tbMaKhach.Text);
                maThue = int.Parse(tbMaThue.Text);

                bTraPhong.TraPhong(maPhong, maKH, maThue);
                MessageBox.Show("Trả phòng thành công");
                LayDSThuePhong();

                tbMaThue.Text = null;
                tbMaPhong.Text = null;
                tbMaKhach.Text = null;
                tbSoPhong.Text = null;
                tbTenPhong.Text = null;
                dtpNgayThue.Text = null;
                tbTienCoc.Text = null;
            }

            
        }
    }
}
