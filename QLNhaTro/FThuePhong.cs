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
        DataTable dtKhachHang;
        DataTable dtThuePhong;
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
        }
        public void LayDSKHTrong()
        {
            bKhachHang.LayDSKHTrong(dGVKhachHang);

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
            LayDSKHTrong();
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

        private void btThemKH_Click(object sender, EventArgs e)
        {
            bool co = true;
            DataRow r;

            try
            {
                dtKhachHang = new DataTable();
                dtKhachHang.Columns.Add("Ten");
                dtKhachHang.Columns.Add("CMND");
                dtKhachHang.Columns.Add("DiaChi");
                dtKhachHang.Columns.Add("GioiTinh");
                dtKhachHang.Columns.Add("NgaySinh");
                dtKhachHang.Columns.Add("SDT");
                dtKhachHang.Columns.Add("ID");

                r = dtKhachHang.NewRow();
                r[0] = tbTen.Text;
                r[1] = tbCMND.Text;
                r[2] = tbDiaChi.Text;
                r[3] = tbGioiTinh.Text;
                r[4] = dtpNgaySinh.Value.ToString();
                r[5] = tbSdt.Text;
                r[6] = tbMaKhach.Text;

                for (int i = 0; i < 6; i++)
                {
                    if (r[i] == null || r[i].Equals(""))
                    {
                        co = false;
                        break;
                    }
                }

                if (co)
                {
                    dtKhachHang.Rows.Add(r);
                    bKhachHang.ThemKH(dtKhachHang);
                    MessageBox.Show("Them Thanh Cong");
                    LayDSKHTrong();
                }
                else
                {
                    throw new Exception("Vui lòng điền đầy đủ thông tin");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm thất bại");
            }
}   

        private void btClear_Click(object sender, EventArgs e)
        {
            tbTen.Text = null;
            tbCMND.Text = null;
            tbDiaChi.Text = null;
            tbGioiTinh.Text = null;
            tbSdt.Text = null;
            tbMaKhach.Text = null;

            tbTienCoc.Text = null;
            tbMaPhong.Text = null;
            tbPhong.Text = null;
            tbTienPhong.Text = null;
        }

        private void btThue_Click(object sender, EventArgs e)
        {
            DataRow r;
            bool co =true;

            dtThuePhong = new DataTable();
            dtThuePhong.Columns.Add("TienCoc");
            dtThuePhong.Columns.Add("NgayNhanCoc");
            dtThuePhong.Columns.Add("PhongID");
            dtThuePhong.Columns.Add("KhachHangID");

            r = dtThuePhong.NewRow();
            r[0] = tbTienCoc.Text;
            r[1] = dtpNgayNhanCoc.Text;
            r[2] = tbMaPhong.Text;
            r[3] = tbMaKhach.Text;

            for (int i = 0; i < 4; i++)
            {
                if (r[i] == null || r[i].Equals(""))
                {
                    co = false;
                    break;
                }
            }

            if (co)
            {
                dtThuePhong.Rows.Add(r);
                bKhachHang.ThuePhong(dtThuePhong);
                MessageBox.Show("Them phong thanh cong");
                LayDSKHTrong();
                LayDSPTrong();
                
                btClear_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
            }
        }
    }
}
