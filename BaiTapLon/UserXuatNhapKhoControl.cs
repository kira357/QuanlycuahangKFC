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
    public partial class UserXuatNhapKhoControl : UserControl
    {
        public UserXuatNhapKhoControl()
        {
            InitializeComponent();
            dgvNhapKho.DataSource = NhapKhoBUS.Instance.getNhapKho();
            dgvXuatKho.DataSource = XuatKhoBUS.Instance.getXuatKho();
            dgvNguyenLieu.DataSource = NguyenLieuBUS.Instance.getAllNguyenLieu();

        }
        private void btnNhapVaoKho_Click(object sender, EventArgs e)
        {
            if (rbNhapKho.Checked)
            {
                NhapKhoBUS.Instance.setNhapKho(new NhapKhoDTO(Convert.ToInt32(txtMaNL.Text), Convert.ToInt32(txtSoLuong.Text), DateTime.Now.Date));
                NguyenLieuBUS.Instance.setNhapNguyenLieu(Convert.ToInt32(txtMaNL.Text), Convert.ToInt32(txtSoLuong.Text));
            }
            if (rbXuatKho.Checked)
            {
                XuatKhoBUS.Instance.setXuatKho(new XuatKhoDTO(Convert.ToInt32(txtMaNL.Text), Convert.ToInt32(txtSoLuong.Text), DateTime.Now.Date));
                NguyenLieuBUS.Instance.setXuatNguyenLieu(Convert.ToInt32(txtMaNL.Text), Convert.ToInt32(txtSoLuong.Text));
            }
            dgvNhapKho.DataSource = NhapKhoBUS.Instance.getNhapKho();
            dgvXuatKho.DataSource = XuatKhoBUS.Instance.getXuatKho();
            dgvNguyenLieu.DataSource = NguyenLieuBUS.Instance.getAllNguyenLieu();
        }
    }
}
