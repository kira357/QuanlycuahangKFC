using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BUS;
using DTO;

namespace BaiTapLon
{
    public partial class frmDangNhap : Form
    {
        public static string ID_User = "";

        public frmDangNhap()
        {
            InitializeComponent();
            btnClose.BackgroundImage = new Bitmap(Application.StartupPath + "\\Resources\\App\\Close.png");
            btnMinimize.BackgroundImage = new Bitmap(Application.StartupPath + "\\Resources\\App\\Minimize.png");
            this.BackgroundImage = new Bitmap(Application.StartupPath + "\\Resources\\App\\Login.jpg");
            txttaikhoan.Font = new Font("Segoe UI", 14, FontStyle.Italic);
            txttaikhoan.Text = "Tài khoản";
            txtmatkhau.Font = new Font("Segoe UI", 14, FontStyle.Italic);
            txtmatkhau.Text = "Mật khẩu";
        }

        private void btLogin_Click(object sender, EventArgs e)
        {

            if (CheckLogin())
            {
        SqlConnection Con = new SqlConnection(@"Data Source=LAPTOP-QNLSN9K3\SQLEXPRESS;Initial Catalog=QUANLYKFC;User ID=sa;Password=123");
        SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM DANGNHAP WHERE TAIKHOAN = '" + txttaikhoan.Text + "' AND MATKHAU = '" + txtmatkhau.Text + "'", Con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    frmMain Main = new frmMain(dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString());
                    this.Hide();
                    Main.Show();
                }
                else
                {
                    MessageBox.Show("Đăng nhập không thành công", "Sai mật khẩu hoặc tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public bool CheckLogin()
        {
            if (txttaikhoan.Text.Equals("") && txtmatkhau.Text.Equals(""))
            {
                MessageBox.Show("Bạn chưa nhập tài khoản và mật khẩu! ", "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            else if (string.IsNullOrEmpty(txttaikhoan.Text))
            {
                MessageBox.Show("Vui lòng nhập tài khoản vào", "Tài khoản không được để trống ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (string.IsNullOrEmpty(txtmatkhau.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu vào ", "mật khẩu không được để trống ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void txttaikhoan_Click(object sender, EventArgs e)
        {
            if(txttaikhoan.Text.Equals("Tài khoản"))
            {
                txttaikhoan.Text = "";
            }
        }

        private void txtmatkhau_Click(object sender, EventArgs e)
        {
            if (txtmatkhau.Text.Equals("**********"))
            {
                txtmatkhau.Text = "";
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

        private void frmDangNhap_Click(object sender, EventArgs e)
        {
            if (txtmatkhau.Text.Equals(""))
            {
                txtmatkhau.PasswordChar = '\0';
                txtmatkhau.Text = "Mật khẩu";
                txtmatkhau.Font = new Font("Segoe UI", 14, FontStyle.Italic);
            }
            if (txttaikhoan.Text.Equals(""))
            {
                txttaikhoan.Text = "Tài khoản";
                txttaikhoan.Font = new Font("Segoe UI", 14, FontStyle.Italic);
            }
        }
    }
}
