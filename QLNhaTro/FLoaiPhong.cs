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

        private void FLoaiPhong_Load(object sender, EventArgs e)
        {
            HienThiDSLoaiPhong();
            
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            LoaiPhong lp = new LoaiPhong();
            lp.Gia = int.Parse(tbGia.Text);
            lp.Ten = tbTen.Text;
            
            if (busP.ThemLoaiPhong(lp))
            {
                MessageBox.Show("Thêm loại phòng thành công");
                busP.LayDSLoaiPhong(dgvLoai);
                HienThiDSLoaiPhong();
            }
            else
            {
                MessageBox.Show("Thêm loại phòng thất bại");
            }

        }

        private void dgvLoai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvLoai.Rows.Count)
            {
                tbMa.Text = dgvLoai.Rows[e.RowIndex].Cells[0].Value.ToString();
                tbTen.Text = dgvLoai.Rows[e.RowIndex].Cells[1].Value.ToString();
                tbGia.Text = dgvLoai.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            LoaiPhong lp = new LoaiPhong();
            lp.ID = int.Parse(tbMa.Text);
            lp.Ten = tbTen.Text;
            lp.Gia = int.Parse(tbGia.Text);
            //Gọi sự kiện sửa của BUS
            if (busP.SuaLoaiPhong(lp))
            {
                MessageBox.Show("Sửa loại phòng thành công");
                busP.LayDSLoaiPhong(dgvLoai);
                HienThiDSLoaiPhong();
            }
            else
            {
                MessageBox.Show("Sửa loại phòng thất bại");
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            LoaiPhong lp = new LoaiPhong();
            lp.ID = int.Parse(tbMa.Text);

            //Gọi sự kiện xóa của BUS
            if (busP.XoaLoaiPhong(lp))
            {
                MessageBox.Show("Xóa loại phòng thành công");
                busP.LayDSLoaiPhong(dgvLoai);
                HienThiDSLoaiPhong();
            }
            else
            {
                MessageBox.Show("Xóa loại phòng thất bại");
            }
        }
    }
}
