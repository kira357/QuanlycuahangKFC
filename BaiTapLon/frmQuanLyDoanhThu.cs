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
    public partial class frmQuanLyDoanhThu : Form
    {
        public frmQuanLyDoanhThu()
        {
            InitializeComponent();
            btnClose.BackgroundImage = new Bitmap(Application.StartupPath + "\\Resources\\App\\Close.png");
            btnMinimize.BackgroundImage = new Bitmap(Application.StartupPath + "\\Resources\\App\\Minimize.png");
            ptLogo.Image = new Bitmap(Application.StartupPath + "\\Resources\\App\\Logo.png");
            userThongKeDoanhThuControl.BringToFront();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            btnDoanhThu.BackColor = Color.White;
            btnDoanhThu.ForeColor = Color.Black;

            btnXuatNhapKho.BackColor = Color.FromArgb(255, 128, 128);
            btnXuatNhapKho.ForeColor = Color.White;

            userThongKeDoanhThuControl.BringToFront();
        }

        private void btnXuatNhapKho_Click(object sender, EventArgs e)
        {
            btnDoanhThu.BackColor = Color.FromArgb(255, 128, 128);
            btnDoanhThu.ForeColor = Color.White;

            btnXuatNhapKho.BackColor = Color.White;
            btnXuatNhapKho.ForeColor = Color.Black;

            userThongKeXuatNhapKhoControl.BringToFront();
        }

    }
}
