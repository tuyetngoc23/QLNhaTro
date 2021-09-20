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
    public partial class FPhi : Form
    {
        BUS_Phi bPhi;
        public FPhi()
        {
            InitializeComponent();
            bPhi = new BUS_Phi();
        }

        public void HienThiDSPhi()
        {
            dgvPhi.DataSource = null;
            bPhi.LayDSPhi(dgvPhi);
            dgvPhi.Columns[0].Width = (int)(dgvPhi.Width * 0.2);
            dgvPhi.Columns[1].Width = (int)(dgvPhi.Width * 0.4);
            dgvPhi.Columns[2].Width = (int)(dgvPhi.Width * 0.4);

        }

        private void FPhi_Load(object sender, EventArgs e)
        {
            HienThiDSPhi();
        }

        private void dgvPhi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvPhi.Rows.Count)
            {
                tbMa.Text = dgvPhi.Rows[e.RowIndex].Cells[0].Value.ToString();
                tbTen.Text = dgvPhi.Rows[e.RowIndex].Cells[1].Value.ToString();
                tbGia.Text = dgvPhi.Rows[e.RowIndex].Cells[2].Value.ToString();
            }    
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            ChiPhi cp = new ChiPhi();
            cp.Ten = tbTen.Text;
            cp.Gia = int.Parse(tbGia.Text);
            if (bPhi.themPhi(cp))
            {
                MessageBox.Show("Thêm phí thành công");
                bPhi.LayDSPhi(dgvPhi);
                HienThiDSPhi();
            }
            else
            {
                MessageBox.Show("Thêm phí thất bại");
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            ChiPhi cphi = new ChiPhi();
            cphi.ID = int.Parse(tbMa.Text);
            cphi.Ten = tbTen.Text;
            cphi.Gia = int.Parse(tbGia.Text);
            //Gọi sự kiện sửa của BUS
            if (bPhi.SuaPhi(cphi))
            {
                MessageBox.Show("Sửa phí thành công");
                bPhi.LayDSPhi(dgvPhi);
                HienThiDSPhi();
            }
            else
            {
                MessageBox.Show("Sửa phí thất bại");
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            ChiPhi cp = new ChiPhi();
            cp.ID = int.Parse(tbMa.Text);

            //Gọi sự kiện xóa của BUS
            if (bPhi.XoaPhi(cp))
            {
                MessageBox.Show("Xóa phí thành công");
                bPhi.LayDSPhi(dgvPhi);
                HienThiDSPhi();
            }
            else
            {
                MessageBox.Show("Xóa phí thất bại");
            }
        }
    }
}
