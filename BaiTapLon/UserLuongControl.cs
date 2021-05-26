using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace BaiTapLon
{
    public partial class UserLuongControl : UserControl
    {

        public UserLuongControl()
        {
            InitializeComponent();
            load();
        }

        public void load()
        {
            dgvLuong.DataSource = LuongNhanVienBUS.Instance.getLuongNhanVien();

            cbxBacLuong.DisplayMember = "BACLUONG";
            cbxBacLuong.ValueMember = "BACLUONG";
            cbxBacLuong.DataSource = LuongNhanVienBUS.Instance.getBacLuong();

            dgvThongKe.DataSource = TraLuongBUS.Instance.getThongKe();
        }

        private void dgvLuong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = dgvLuong.CurrentRow.Index;
            txtMaNV.Text = dgvLuong.Rows[n].Cells[0].Value.ToString();
            txtHodem.Text = dgvLuong.Rows[n].Cells[1].Value.ToString();
            txtTen.Text = dgvLuong.Rows[n].Cells[2].Value.ToString();
            txtLuongCB.Text = dgvLuong.Rows[n].Cells[3].Value.ToString();
            cbxBacLuong.Text = dgvLuong.Rows[n].Cells[4].Value.ToString();
            txtHesoluong.Text = dgvLuong.Rows[n].Cells[5].Value.ToString();
            if (dgvThongKe.Rows.Count != 0)
            {
                if(TraLuongBUS.Instance.getNgạyKetThuc(Convert.ToInt32(txtMaNV.Text)) == DateTime.MinValue){
                    txtSoBuoi.Text = "0";
                    return;
                }
                date_Batdau.Value = TraLuongBUS.Instance.getNgạyKetThuc(Convert.ToInt32(txtMaNV.Text));
            }
            else
            {
                date_Batdau.Value = ChamCongBUS.Instance.getMinDate(Convert.ToInt32(txtMaNV.Text));
            }
            txtSoBuoi.Text = ChamCongBUS.Instance.getSoBuoi(Convert.ToInt32(txtMaNV.Text), date_Batdau.Value, date_Traluong.Value).ToString();
            date_Traluong.Value = DateTime.Now.Date;
            txtMaNV.Enabled = false;
            txtHodem.Enabled = false;
            txtTen.Enabled = false;
            btnSuaLuong.Enabled = true;
        }
        public bool CheckData()
        {
            if (txtHesoluong.Text.Equals(""))
            {
                MessageBox.Show("Hệ số lương không được để trống  ", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHodem.Focus();
                return false;
            }
            return true;
        }

        private void btSuaLuong_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                MucLuongNhanVienDTO ML = new MucLuongNhanVienDTO(Int32.Parse(txtMaNV.Text), Int32.Parse(cbxBacLuong.Text), Convert.ToSingle(txtHesoluong.Text));
                if (LuongNhanVienBUS.Instance.suaLuongNhanVien(ML))
                {
                    dgvLuong.DataSource = LuongNhanVienBUS.Instance.getLuongNhanVien();
                    MessageBox.Show("sua thanh cong");
                }
                else
                {
                    MessageBox.Show("sua khong thanh cong");
                }
            }
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            string Ten = txtTimKiem.Text;
            if (!string.IsNullOrEmpty(Ten)) // kiem tra neu khong tim kiem khong rong
            {
                dgvLuong.DataSource = LuongNhanVienBUS.Instance.getLuongNhanVienTheoTimKiem(Ten);
            }
            else
            {
                dgvLuong.DataSource = LuongNhanVienBUS.Instance.getLuongNhanVien();
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                dgvLuong.DataSource = LuongNhanVienBUS.Instance.getLuongNhanVien();
            }
        }

        private void btXacNhan_Click(object sender, EventArgs e)
        {
            if (txtSoBuoi.Text.Equals("0"))
            {
                MessageBox.Show("Người này chưa đi làm");
                return;
            }
            int maNV = Convert.ToInt32(txtMaNV.Text);
            float luongcb = float.Parse(txtLuongCB.Text);
            float hesoluong = float.Parse(txtHesoluong.Text);
            float tienthuong = float.Parse(txtTienthuong.Text);
            int sobuoi = Int32.Parse(txtSoBuoi.Text);
            
            decimal tongtien = Convert.ToDecimal((luongcb * hesoluong * sobuoi) / 30 + tienthuong);
            TraLuongDTO tk = new TraLuongDTO(maNV, date_Batdau.Value, date_Traluong.Value, tongtien);

            if (TraLuongBUS.Instance.Traluong(tk))
            {
                dgvThongKe.DataSource = TraLuongBUS.Instance.getThongKe();
                MessageBox.Show("Trả lương thành công");
            }
            else
            {
                MessageBox.Show("Trả lương không thành công");
            }
        }
    }
}
