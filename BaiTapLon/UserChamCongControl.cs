using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace BaiTapLon
{
    public partial class UserChamCongControl : UserControl
    {
        public UserChamCongControl()
        {
            InitializeComponent();
            load();
        }

        public void load()
        {
            cbxCatruc.SelectedIndex = 0;
            dgvNhanVien.DataSource = NhanVienBUS.Instance.getNhanVien();
            dgvChamCong.DataSource = ChamCongBUS.Instance.getChamCong();

        }
        private void UserChamCongControl_Load(object sender, EventArgs e)
        {

        }
        private void cbxCatruc_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ca = cbxCatruc.Text;
            dgvChamCong.DataSource = ChamCongBUS.Instance.getChamCongTheoCaTruc(ca);
        }

        private void btChamCong_Click(object sender, EventArgs e)
        {
            int n = dgvNhanVien.CurrentRow.Index;
            int maNV = Convert.ToInt32(dgvNhanVien.Rows[n].Cells[0].Value.ToString());
            ChamCongDTO CC = new ChamCongDTO(maNV, date_Ngaylam.Value, cbxCatruc.Text);

            if (ChamCongBUS.Instance.chamCong(CC))
            {
                dgvChamCong.DataSource = ChamCongBUS.Instance.getChamCong();
                MessageBox.Show("Them thanh cong");
            }
            else
            {
                MessageBox.Show("them khong thanh cong");
            }
        }
        private void btTimKiem_Click(object sender, EventArgs e)
        {
            string Ten = txtTimKiem.Text;
            if (!string.IsNullOrEmpty(Ten)) // kiem tra neu khong tim kiem khong rong
            {
                dgvChamCong.DataSource = ChamCongBUS.Instance.getChamCongTheoTimKiem(Ten);
            }
            else
            {
                dgvChamCong.DataSource = ChamCongBUS.Instance.getChamCong();
            }
        }

        private void date_Ngaylam_ValueChanged(object sender, EventArgs e)
        {
            DateTime ngaylam = date_Ngaylam.Value.Date;
            dgvChamCong.DataSource = ChamCongBUS.Instance.getChamCongTheoNgayLam(ngaylam);
        }


        private void dgvNhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvNhanVien.Rows[e.RowIndex];
                btnXoa.Enabled = false;
                btnChamCong.Enabled = true;
                cbxCatruc.Enabled = true;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = dgvChamCong.CurrentRow.Index;
            int maNV = Convert.ToInt32(dgvChamCong.Rows[n].Cells[0].Value.ToString());
            ChamCongDTO CC = new ChamCongDTO(maNV, date_Ngaylam.Value, cbxCatruc.Text);

            if (ChamCongBUS.Instance.xoaChamCong(CC))
            {
                dgvChamCong.DataSource = ChamCongBUS.Instance.getChamCong();
                MessageBox.Show("xoa thanh cong");
            }
            else
            {
                MessageBox.Show("xoa khong thanh cong");
            }

        }

        private void dgvChamCong_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int n = dgvChamCong.CurrentRow.Index;
            /*            string hoVaTen = dgvChamCong.Rows[n].Cells[1].Value.ToString();*/
            date_Ngaylam.Text = dgvChamCong.Rows[n].Cells[4].Value.ToString();
            cbxCatruc.Text = dgvChamCong.Rows[n].Cells[5].Value.ToString();
            btnChamCong.Enabled = false;
            btnXoa.Enabled = true;
            cbxCatruc.Enabled = false;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                dgvChamCong.DataSource = ChamCongBUS.Instance.getChamCong();
            }
        }
    }
}
