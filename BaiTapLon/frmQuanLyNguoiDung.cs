using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
namespace BaiTapLon
{
    public partial class frmQuanLyNguoiDung : Form
    {

        public frmQuanLyNguoiDung()
        {
            InitializeComponent();
            dgvDangNhap.DataSource = DangNhapBUS.Instance.getDangNhap();

            btnXoa.BackgroundImage = new Bitmap(Application.StartupPath + "\\Resources\\App\\icons8-delete-document-48.png");
            btnXacNhan.BackgroundImage = new Bitmap(Application.StartupPath + "\\Resources\\App\\icons8-add-property-48.png");
            btnChinhSua.BackgroundImage = new Bitmap(Application.StartupPath + "\\Resources\\App\\icons8-edit-property-48.png");
            btnClose.BackgroundImage = new Bitmap(Application.StartupPath + "\\Resources\\App\\Close.png");
            btnMinimize.BackgroundImage = new Bitmap(Application.StartupPath + "\\Resources\\App\\Minimize.png");
        }

        public bool CheckData()
        {
            if (txtTaiKhoan.Text.ToString() == "")
            {
                MessageBox.Show("Tài khoản không đuọc để trống ", "Tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTaiKhoan.Focus();
                return false;
            }
            else if (txtMatKhau.Text.ToString() == "")
            {
                MessageBox.Show("Mật Khẩu không đuọc để trống ", "Mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatKhau.Focus();
                return false;

            }
            return true;
        }
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                DangNhapDTO dn = new DangNhapDTO(txtTaiKhoan.Text, txtMatKhau.Text, cbxQuyen.SelectedItem.ToString());
                if (DangNhapBUS.Instance.themTaiKhoan(dn))
                {
                    dgvDangNhap.DataSource = DangNhapBUS.Instance.getDangNhap();
                    MessageBox.Show("Thêm tài khoản thành công");
                }
                else
                {
                    MessageBox.Show("thêm tài khoản không thành công ");
                }
            }
        }
        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                DangNhapDTO dn = new DangNhapDTO(txtTaiKhoan.Text, txtMatKhau.Text, cbxQuyen.SelectedItem.ToString());
                if (DangNhapBUS.Instance.suaTaiKhoan(dn))
                {
                    
                    MessageBox.Show("Sửa tài khoản thành công");
                }
                else
                {
                    MessageBox.Show("Sửa tài khoản không thành công ");
                }
            }
            dgvDangNhap.DataSource = DangNhapBUS.Instance.getDangNhap();

        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDangNhap.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Bạn có chắc muốn xoá Tài khoản này ko ", "WARNING!!!!!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (DangNhapBUS.Instance.xoaTaiKhoan(txtTaiKhoan.Text))
                    {
                        MessageBox.Show("xoá thành công nhé anh trai ");
                    }
                    else
                    {
                        MessageBox.Show("Xoá không được nhá anh trai");
                    }
                }
            }
            dgvDangNhap.DataSource = DangNhapBUS.Instance.getDangNhap();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void dgvDangNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = dgvDangNhap.CurrentRow.Index;
            txtTaiKhoan.Text = dgvDangNhap.Rows[n].Cells[0].Value.ToString();
            txtMatKhau.Text = dgvDangNhap.Rows[n].Cells[1].Value.ToString();
            cbxQuyen.Text = dgvDangNhap.Rows[n].Cells[2].Value.ToString();
        }
    }
}
