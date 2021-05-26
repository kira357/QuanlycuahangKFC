using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapLon
{
    public partial class frmMain : Form
    {
        string taikhoan = "", matkhau = "", quyen = "";

        public frmMain(string taikhoan, string matkhau, string quyen)
        {
            InitializeComponent();
            this.taikhoan = taikhoan;
            this.matkhau = matkhau;
            this.quyen = quyen;
            btQuanLyNguoiDung.Image = new Bitmap(Application.StartupPath + "\\Resources\\App\\people96.png");
            btQuanLyDoanhThu.Image = new Bitmap(Application.StartupPath + "\\Resources\\App\\ComboChart96.png");
            btQuanLyBanHang.Image = new Bitmap(Application.StartupPath + "\\Resources\\App\\KfcChicken96.png");
            btQuanLyKho.Image = new Bitmap(Application.StartupPath + "\\Resources\\App\\WareHouse96.png");
            btQuanLyNhanVien.Image = new Bitmap(Application.StartupPath + "\\Resources\\App\\UserGroup96.png");
            btQuanLyThucPham.Image = new Bitmap(Application.StartupPath + "\\Resources\\App\\baobun96.png");
            btQuanLyGiaoHang.Image = new Bitmap(Application.StartupPath + "\\Resources\\App\\Scooter96.png");
            btnClose.BackgroundImage = new Bitmap(Application.StartupPath + "\\Resources\\App\\Close.png");
            btnMinimize.BackgroundImage = new Bitmap(Application.StartupPath + "\\Resources\\App\\Minimize.png");
            if (quyen == "Quản trị viên")
            {
            }
            if (quyen == "Nhân viên bán hàng")
            {
                btQuanLyNhanVien.Enabled = false;
                btQuanLyNguoiDung.Enabled = false;
                btQuanLyBanHang.Enabled = true;
                btQuanLyGiaoHang.Enabled = false;
                btQuanLyDoanhThu.Enabled = false;
                btQuanLyKho.Enabled = false;
                btQuanLyThucPham.Enabled = false;

            }
            if (quyen == "Nhân viên giao hàng")
            {
                btQuanLyNhanVien.Enabled = false;
                btQuanLyNguoiDung.Enabled = false;
                btQuanLyBanHang.Enabled = false;
                btQuanLyGiaoHang.Enabled = true;
                btQuanLyDoanhThu.Enabled = false;
                btQuanLyKho.Enabled = false;
                btQuanLyThucPham.Enabled = false;

            }
            if (quyen == "Quản trị viên")
            {
                btQuanLyNhanVien.Enabled = false;
                btQuanLyNguoiDung.Enabled = true;
                btQuanLyBanHang.Enabled = false;
                btQuanLyGiaoHang.Enabled = false;
                btQuanLyDoanhThu.Enabled = false;
                btQuanLyKho.Enabled = false;
                btQuanLyThucPham.Enabled = false;

            }
            if (quyen == "Quản lý viên")
            {
                btQuanLyNhanVien.Enabled = true;
                btQuanLyNguoiDung.Enabled = false;
                btQuanLyBanHang.Enabled = true;
                btQuanLyGiaoHang.Enabled = true;
                btQuanLyDoanhThu.Enabled = true;
                btQuanLyKho.Enabled = true;
                btQuanLyThucPham.Enabled = true;

            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btQuanLyThucPham_Click(object sender, EventArgs e)
        {
            frmQuanLyThucPham thucPham = new frmQuanLyThucPham();
            thucPham.Show();
        }

        private void btQuanLyKho_Click(object sender, EventArgs e)
        {
            new frmQuanLyKho().Show();
        }

        private void btQuanLyDoanhThu_Click(object sender, EventArgs e)
        {
            frmQuanLyDoanhThu doanhThu = new frmQuanLyDoanhThu();
            doanhThu.Show();
        }

        private void btQuanLyBanHang_Click(object sender, EventArgs e)
        {
            new frmQuanLyBanHang().Show();
        }

        private void btQuanLyGiaoHang_Click(object sender, EventArgs e)
        {
            new frmQuanLyGiaoHang().Show();
        }

        private void btQuanLyNguoiDung_Click(object sender, EventArgs e)
        {
            frmQuanLyNguoiDung nguoidung = new frmQuanLyNguoiDung();
            nguoidung.Show();
        }

        private void btQuanLyNhanVien_Click(object sender, EventArgs e)
        {
            frmQuanLyNhanVien quanLyNhanVien = new frmQuanLyNhanVien();
            quanLyNhanVien.Show();
        }
    }
}
