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
    public partial class frmQuanLyThucPham : Form
    {
        public frmQuanLyThucPham()
        {
            InitializeComponent();
            btnClose.BackgroundImage = new Bitmap(Application.StartupPath + "\\Resources\\App\\Close.png");
            btnMinimize.BackgroundImage = new Bitmap(Application.StartupPath + "\\Resources\\App\\Minimize.png");
            ptLogo.Image = new Bitmap(Application.StartupPath + "\\Resources\\App\\Logo.png");
        }

        private void btnTTTP_Click(object sender, EventArgs e)
        {
            
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
