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
    public partial class FCapNhatKH : Form
    {
        BUS_KhachHang busKH;
        public FCapNhatKH()
        {
            InitializeComponent();
            busKH = new BUS_KhachHang();
        }
        public void HienThiDSKH()
        {
            dgvKH.DataSource = null;
            busKH.LayDSKhachThue(dgvKH);
            dgvKH.Columns[0].Width = (int)(dgvKH.Width * 0.2);
            dgvKH.Columns[1].Width = (int)(dgvKH.Width * 0.3);
            dgvKH.Columns[2].Width = (int)(dgvKH.Width * 0.3); 
            dgvKH.Columns[3].Width = (int)(dgvKH.Width * 0.3);
            dgvKH.Columns[4].Width = (int)(dgvKH.Width * 0.3);
            dgvKH.Columns[5].Width = (int)(dgvKH.Width * 0.3);
            dgvKH.Columns[6].Width = (int)(dgvKH.Width * 0.3);
            //dgvKH.Columns[7].Width = (int)(dgvKH.Width * 0.3);
        }
        private void FCapNhatKH_Load(object sender, EventArgs e)
        {
            HienThiDSKH();
            //busKH.LayDSLoaiPhong(cbPhong);
        }

        private void dgvKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvKH.Rows.Count)
            {
                tbMa.Text = dgvKH.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                tbTen.Text = dgvKH.Rows[e.RowIndex].Cells["HoTen"].Value.ToString();
                tbSdt.Text = dgvKH.Rows[e.RowIndex].Cells["SDT"].Value.ToString();
                tbGioiTinh.Text = dgvKH.Rows[e.RowIndex].Cells["GioiTinh"].Value.ToString();
                tbCMND.Text = dgvKH.Rows[e.RowIndex].Cells["CMND"].Value.ToString();
                tbQueQuan.Text = dgvKH.Rows[e.RowIndex].Cells["QueQuan"].Value.ToString();
                dtpNgay.Text = dgvKH.Rows[e.RowIndex].Cells["NgaySinh"].Value.ToString();
                
            }
        }

        private void btCSua_Click(object sender, EventArgs e)
        {
            KhachHang kh = new KhachHang();
            kh.ID = int.Parse(tbMa.Text);
            kh.HoTen = tbTen.Text;
            kh.GioiTinh = tbGioiTinh.Text;
            kh.NgaySinh = dtpNgay.Value;
            kh.QueQuan = tbQueQuan.Text;
            kh.SDT = tbSdt.Text;
            kh.CMND = tbCMND.Text;
            //Gọi sự kiện sửa của BUS
            if (busKH.SuaKH(kh))
            {
                MessageBox.Show("Sửa thông tin khách hàng thành công");
                //busKH.LayDSKhachThue(dgvKH);
                HienThiDSKH();
            }
            else
            {
                MessageBox.Show("Sửa thông tin khách hàng thất bại");
            }

        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            KhachHang lp = new KhachHang();
            lp.ID = int.Parse(tbMa.Text);

            //Gọi sự kiện xóa của BUS
            if (busKH.XoaKH(lp))
            {
                MessageBox.Show("Xóa khách hàng thành công");
                busKH.LayDSKH(dgvKH);
                HienThiDSKH();
            }
            else
            {
                MessageBox.Show("Xóa khách hàng thất bại");
            }
        }
    }
}
