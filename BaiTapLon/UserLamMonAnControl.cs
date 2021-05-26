using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
namespace BaiTapLon
{
    public partial class UserLamMonAnControl : UserControl
    {
        public UserLamMonAnControl()
        {
            InitializeComponent();
            dgvMonAn.DataSource = MonAnBUS.Instance.getAllMonAn();
        }
        int maMonAn;
        private void dgvMonAn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvMonAn.CurrentRow.Index;
            maMonAn = Int32.Parse(dgvMonAn.Rows[index].Cells[0].Value.ToString());
            dgvHangHoa.DataSource = CongThucBUS.Instance.getCongThuc(maMonAn);
        }

        private void btnLamMon_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvHangHoa.Rows.Count - 1; i++)
            {
                NguyenLieuBUS.Instance.capNhat(Int32.Parse(dgvHangHoa.Rows[i].Cells[0].Value.ToString()), Int32.Parse(dgvHangHoa.Rows[i].Cells[2].Value.ToString()), Int32.Parse(txtSoLuong.Text.ToString()));

            }
            if (MonAnBUS.Instance.updateSoLuongMonAn(maMonAn, Int32.Parse(txtSoLuong.Text.ToString())))
            {
                MessageBox.Show("Thêm món ăn thành công");
            }
            else
            {
                MessageBox.Show("Thêm món ăn thất bại");
            }
            dgvMonAn.DataSource = MonAnBUS.Instance.getAllMonAn();
        }
    }
}
