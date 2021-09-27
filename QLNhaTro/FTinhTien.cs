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
    public partial class FTinhTien : Form
    {
        BUS_TinhTien bTinhTien;
        int tienPhong;
        public FTinhTien()
        {
            InitializeComponent();
            bTinhTien = new BUS_TinhTien();
        }

        public void LayDSPChuaThanhToan()
        {
            bTinhTien.LayDSPChuaThanhToan(dGVThuePhong);

            dGVThuePhong.Columns[0].Width = (int)(dGVThuePhong.Width * 0.15);
            dGVThuePhong.Columns[1].Width = (int)(dGVThuePhong.Width * 0.16);
            dGVThuePhong.Columns[2].Width = (int)(dGVThuePhong.Width * 0.2);
            dGVThuePhong.Columns[3].Width = (int)(dGVThuePhong.Width * 0.2);
            dGVThuePhong.Columns[4].Width = (int)(dGVThuePhong.Width * 0.2);
        }

        private void FTinhTien_Load(object sender, EventArgs e)
        {
            bTinhTien.LayDSThang(cbThang);
            LayDSPChuaThanhToan();
        }

        private void dGVThuePhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dGVThuePhong.Rows.Count)
            {
                tbMaThue.Text = dGVThuePhong.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                tbMaPhong.Text = dGVThuePhong.Rows[e.RowIndex].Cells["PhongID"].Value.ToString();
                tbMaKhach.Text = dGVThuePhong.Rows[e.RowIndex].Cells["KhachHangID"].Value.ToString();
                tbSoPhong.Text = dGVThuePhong.Rows[e.RowIndex].Cells["SoPhong"].Value.ToString();
                tbTienPhong.Text = dGVThuePhong.Rows[e.RowIndex].Cells["Gia"].Value.ToString();
                tbTongTien.Text = dGVThuePhong.Rows[e.RowIndex].Cells["Gia"].Value.ToString();
                tienPhong = int.Parse(tbTongTien.Text);
            }
        }

        private void tbSoNuoc_TextChanged(object sender, EventArgs e)
        {
            int soDien;
            int soNuoc;
            int tienDien;
            int tienNuoc;
            int tongTien;
            int tienDichVu;

            try
            {
                soDien = int.Parse(tbSoDien.Text);
                tienDien = soDien * 3500;
                tienDichVu = int.Parse(tbDichVu.Text);
                if (tbTongTien.Text == null || tbTongTien.Text.Equals(""))
                {
                    MessageBox.Show("Vui lòng chọn phòng cần thanh toán");
                }
                else
                {
                    tongTien = int.Parse(tbTongTien.Text);
                    try
                    {
                        soNuoc = int.Parse(tbSoNuoc.Text);
                        tienNuoc = soNuoc * 7000;
                        tongTien = tongTien + tienNuoc;
                        tbTienNuoc.Text = tienNuoc.ToString();
                        tbTongTien.Text = tongTien.ToString();
                    }
                    catch (Exception)
                    {
                        soNuoc = 0;
                        tbTienNuoc.Text = (soNuoc * 7000).ToString();
                        tbTongTien.Text = (tienPhong + tienDien + tienDichVu).ToString();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng nhập số điện");
            }
        }

        private void tbSoDien_TextChanged(object sender, EventArgs e)
        {
            int soDien;
            int tienDien;
            int tongTien;
            int soNuoc;
            int tienNuoc;
            int tienDichVu;

            try
            {
                soNuoc = int.Parse(tbSoNuoc.Text);
                tienNuoc = soNuoc * 7000;
                tienDichVu = int.Parse(tbDichVu.Text);
                if (tbTongTien.Text == null || tbTongTien.Text.Equals(""))
                {
                    MessageBox.Show("Vui lòng chọn phòng cần thanh toán");
                }
                else
                {
                    tongTien = int.Parse(tbTongTien.Text);
                    try
                    {
                        soDien = int.Parse(tbSoDien.Text);
                        tienDien = soDien * 3500;
                        tongTien += tienDien;
                        tbTienDien.Text = tienDien.ToString();
                        tbTongTien.Text = tongTien.ToString();
                    }
                    catch (Exception)
                    {
                        soDien = 0;
                        tbTienDien.Text = (soDien * 3500).ToString();
                        tbTongTien.Text = (tienPhong + tienNuoc + tienDichVu).ToString();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng nhập số nước");
            }
            
        }

        private void btThanhToan_Click(object sender, EventArgs e)
        {
            bool co = true;
            DataTable dtTinhTien = new DataTable();

            dtTinhTien.Columns.Add("MaThue");
            dtTinhTien.Columns.Add("SoDien");
            dtTinhTien.Columns.Add("SoNuoc");
            dtTinhTien.Columns.Add("TongTien");
            dtTinhTien.Columns.Add("ThangID");

            DataRow r;
            r = dtTinhTien.NewRow();
            r[0] = tbMaThue.Text;
            r[1] = tbSoDien.Text;
            r[2] = tbSoNuoc.Text;
            r[3] = tbTongTien.Text;
            r[4] = cbThang.SelectedValue.ToString();

            for(int i = 0; i < 5; i++)
            {
                if (r[i] == null || r[i].Equals(""))
                {
                    co = false;
                    break;
                }
            }
            if(co)
            {
                dtTinhTien.Rows.Add(r);
                bTinhTien.TinhTien(dtTinhTien);
                MessageBox.Show("Thanh toán thành công");
                LayDSPChuaThanhToan();
                tbMaThue.Text = null;
                tbMaPhong.Text = null;
                tbMaKhach.Text = null;
                tbSoPhong.Text = null;
                tbTienPhong.Text = null;
                tbTongTien.Text = "0";
                tbSoDien.Text = "0";
                tbSoNuoc.Text = "0";
            }
            else
            {
                MessageBox.Show("Vui lòng tính tông tiền");
            }
        }
    }
}
