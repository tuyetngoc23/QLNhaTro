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
    public partial class FThuePhong : Form
    {
        BUS_Phong bPhong;
        BUS_KhachHang bKhachHang;
        public FThuePhong()
        {
            InitializeComponent();
            bPhong = new BUS_Phong();
            bKhachHang = new BUS_KhachHang();
        }
        void chinhDep()
        {
            dGVPhong.Columns[0].Width = (int)(dGVPhong.Width * 0.11);
            dGVPhong.Columns[1].Width = (int)(dGVPhong.Width * 0.4);
            dGVPhong.Columns[2].Width = (int)(dGVPhong.Width * 0.27);
            dGVPhong.Columns[3].Width = (int)(dGVPhong.Width * 0.35);
            dGVPhong.Columns[4].Width = (int)(dGVPhong.Width * 0.35);
        }
        public void LayDSKH()
        {
            bKhachHang.LayDSKH(dGVKhachHang);

            dGVKhachHang.Columns[0].Width = (int)(dGVKhachHang.Width * 0.11);
            dGVKhachHang.Columns[1].Width = (int)(dGVKhachHang.Width * 0.35);
            dGVKhachHang.Columns[2].Width = (int)(dGVKhachHang.Width * 0.3);
            dGVKhachHang.Columns[3].Width = (int)(dGVKhachHang.Width * 0.3);
            dGVKhachHang.Columns[4].Width = (int)(dGVKhachHang.Width * 0.3);
            dGVKhachHang.Columns[5].Width = (int)(dGVKhachHang.Width * 0.35);
            dGVKhachHang.Columns[6].Width = (int)(dGVKhachHang.Width * 0.35);
            dGVKhachHang.Columns[7].Width = (int)(dGVKhachHang.Width * 0.35);
        }
        public void LayDSPTrong()
        {
            bPhong.LayDSPTrong(dGVPhong);
            chinhDep();
        }
        private void FThuePhong_Load(object sender, EventArgs e)
        {
            LayDSKH();
            LayDSPTrong();
            bPhong.LayDSLoaiPhong(cbLoaiPhong);
        }

        private void cbLoaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLoaiPhong.SelectedIndex == 0)
            {
                bPhong.LayDSPTheoPhongNho(dGVPhong);
            }
            else if (cbLoaiPhong.SelectedIndex == 1)
            {
                bPhong.LayDSPTheoPhongVua(dGVPhong);
            }
            else if (cbLoaiPhong.SelectedIndex == 2)
            {
                bPhong.LayDSPTheoPhongLon(dGVPhong);
            }
        }

        private void dGVKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dGVKhachHang.Rows.Count)
            {
                tbMaKhach.Text = dGVKhachHang.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                tbTen.Text = dGVKhachHang.Rows[e.RowIndex].Cells["HoTen"].Value.ToString();
                tbSdt.Text = dGVKhachHang.Rows[e.RowIndex].Cells["SDT"].Value.ToString();
                tbGioiTinh.Text = dGVKhachHang.Rows[e.RowIndex].Cells["GioiTinh"].Value.ToString();
                tbCMND.Text = dGVKhachHang.Rows[e.RowIndex].Cells["CMND"].Value.ToString();
                tbDiaChi.Text = dGVKhachHang.Rows[e.RowIndex].Cells["QueQuan"].Value.ToString();
                dtpNgaySinh.Text = dGVKhachHang.Rows[e.RowIndex].Cells["NgaySinh"].Value.ToString();
            }
        }

        private void dGVPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dGVPhong.Rows.Count)
            {
                tbMaPhong.Text = dGVPhong.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                tbPhong.Text = dGVPhong.Rows[e.RowIndex].Cells["SoPhong"].Value.ToString();
                tbTienPhong.Text = dGVPhong.Rows[e.RowIndex].Cells["Gia"].Value.ToString();
            }
        }

        private void btThue_Click(object sender, EventArgs e)
        {

        }
    }
}
