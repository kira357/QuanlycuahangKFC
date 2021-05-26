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
    public partial class UserDanhSachGiaoHangControl : UserControl
    {
        private int maHD;
        public UserDanhSachGiaoHangControl()
        {
            InitializeComponent();
            dgvDSGH.DataSource = HoaDonBUS.Instance.getHoaDonCanGiao();
            dgvLSGH.DataSource = HoaDonBUS.Instance.getHoaDonDaGiao();
        }
        private void btnCTDH_DSGH_Click(object sender, EventArgs e)
        {
            frmChiTietHoaDon frmCTDH = new frmChiTietHoaDon(maHD);
            frmCTDH.Show();
        }
        private void dgvDSGH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvDSGH.CurrentRow.Index;
            maHD = Int32.Parse(dgvDSGH.Rows[index].Cells[0].Value.ToString());
        }
        private void btnThanhCong_Click(object sender, EventArgs e)
        {
            HoaDonBUS.Instance.setThanhCongHoaDon(maHD);
            dgvDSGH.DataSource = HoaDonBUS.Instance.getHoaDonCanGiao();
            dgvLSGH.DataSource = HoaDonBUS.Instance.getHoaDonDaGiao();
        }

        private void btnThatBai_Click(object sender, EventArgs e)
        {
            HoaDonBUS.Instance.setThatBaiHoaDon(maHD);
            dgvDSGH.DataSource = HoaDonBUS.Instance.getHoaDonCanGiao();
            dgvLSGH.DataSource = HoaDonBUS.Instance.getHoaDonDaGiao();
        }

        private void btnCTDH_LSGH_Click(object sender, EventArgs e)
        {
            frmChiTietHoaDon frmCTDH = new frmChiTietHoaDon(maHD);
            frmCTDH.Show();
        }

        private void dgvLSGH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvLSGH.CurrentRow.Index;
            maHD = Int32.Parse(dgvLSGH.Rows[index].Cells[0].Value.ToString());
        }
    }
}
