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
    public partial class FCapNhatPhong : Form
    {
        BUS_Phong busP;
        public FCapNhatPhong()
        {
            InitializeComponent();
            busP = new BUS_Phong();
        }
        public void HienThiDSPhong()
        {
            dgvPhong.DataSource = null;
            busP.LayDSPhong(dgvPhong);
            dgvPhong.Columns[0].Width = (int)(dgvPhong.Width * 0.2);
            dgvPhong.Columns[1].Width = (int)(dgvPhong.Width * 0.4);
            dgvPhong.Columns[2].Width = (int)(dgvPhong.Width * 0.4);
           
        }

        private void FCapNhatPhong_Load(object sender, EventArgs e)
        {
            HienThiDSPhong();
            busP.LayDSLoaiPhong(cbLoaiPhong);
        }

        private void dgvPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0 && e.RowIndex < dgvPhong.Rows.Count)
            {
                tbMa.Text = dgvPhong.Rows[e.RowIndex].Cells[0].Value.ToString();
                cbLoaiPhong.Text = dgvPhong.Rows[e.RowIndex].Cells[1].Value.ToString();
                tbPhong.Text = dgvPhong.Rows[e.RowIndex].Cells[2].Value.ToString();
                tbGia.Text = dgvPhong.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }
        
        private void btThem_Click(object sender, EventArgs e)
        {
            Phong p = new Phong();
            p.SoPhong = int.Parse(tbPhong.Text);
            p.LoaiPhongID = int.Parse(cbLoaiPhong.SelectedValue.ToString());
            if (busP.ThemPhong(p))
            {
                MessageBox.Show("Thêm phòng thành công");
                busP.LayDSPhong(dgvPhong);
                HienThiDSPhong();
            }
            else
            {
                MessageBox.Show("Thêm phòng thất bại");
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            Phong p = new Phong();
            p.ID = int.Parse(tbMa.Text);
            p.SoPhong = int.Parse(tbPhong.Text);
            p.LoaiPhongID = int.Parse(cbLoaiPhong.SelectedValue.ToString());
            //Gọi sự kiện sửa của BUS
            if (busP.SuaPhong(p))
            {
                MessageBox.Show("Sửa phòng thành công");
                busP.LayDSPhong(dgvPhong);
                HienThiDSPhong();
            }
            else
            {
                MessageBox.Show("Sửa phòng thất bại");
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            Phong p = new Phong();
            p.ID = int.Parse(tbMa.Text);

            //Gọi sự kiện xóa của BUS
            if (busP.XoaPhong(p))
            {
                MessageBox.Show("Xóa loại phòng thành công");
                busP.LayDSPhong(dgvPhong);
                HienThiDSPhong();
            }
            else
            {
                MessageBox.Show("Xóa loại phòng thất bại");
            }
        }
    }
}
