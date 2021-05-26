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
    public partial class frmQuanLyNhanVien : Form
    {
        public frmQuanLyNhanVien()
        {
            InitializeComponent();
            userQuanLyNhanVienControl.BringToFront();
            ptLogo.Image = new Bitmap(Application.StartupPath + "\\Resources\\App\\Logo.png");
            btnClose.Image = new Bitmap(Application.StartupPath + "\\Resources\\App\\Close.png");
            btnMinimize.Image = new Bitmap(Application.StartupPath + "\\Resources\\App\\Minimize.png");
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnThongTin_Click(object sender, EventArgs e)
        {
            btnThongTin.BackColor = Color.White;
            btnThongTin.ForeColor = Color.Black;

            btnLuong.BackColor = Color.FromArgb(255, 128, 128);
            btnLuong.ForeColor = Color.White;

            btnChamCong.BackColor = Color.FromArgb(255, 128, 128);
            btnChamCong.ForeColor = Color.White;

            userQuanLyNhanVienControl.BringToFront();
        }

        private void btnChamCong_Click(object sender, EventArgs e)
        {
            btnThongTin.BackColor = Color.FromArgb(255, 128, 128);
            btnThongTin.ForeColor = Color.White;

            btnLuong.BackColor = Color.FromArgb(255, 128, 128);
            btnLuong.ForeColor = Color.White;

            btnChamCong.BackColor = Color.White;
            btnChamCong.ForeColor = Color.Black;
            userChamCongControl.load();
            userChamCongControl.BringToFront();
        }

        private void btnLuong_Click(object sender, EventArgs e)
        {
            btnThongTin.BackColor = Color.FromArgb(255, 128, 128);
            btnThongTin.ForeColor = Color.White;

            btnLuong.BackColor = Color.White;
            btnLuong.ForeColor = Color.Black;

            btnChamCong.BackColor = Color.FromArgb(255, 128, 128);
            btnChamCong.ForeColor = Color.White;
            userLuongControl.load(); 
            userLuongControl.BringToFront();
        }
    }
}
