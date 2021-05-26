using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
namespace BaiTapLon
{
    public partial class frmHoaDon : Form
    {
        List<Hang> gioHang;
        public frmHoaDon(List<Hang> gioHang, string tien)
        {
            InitializeComponent();
            btnClose.BackgroundImage = new Bitmap(Application.StartupPath + "\\Resources\\App\\Close.png");
            btnMinimize.BackgroundImage = new Bitmap(Application.StartupPath + "\\Resources\\App\\Minimize.png");
            btnXacNhan.BackgroundImage = new Bitmap(Application.StartupPath + "\\Resources\\App\\Plus.png");
            this.gioHang = gioHang;
            foreach (DataGridViewColumn c in dataGridView1.Columns)
            {
                c.DefaultCellStyle.Font = new Font("Segoe UI", 8.5F);
            }
            for (int i = 0; i < gioHang.Count; i++)
            {
                string tenMenu = MenuBUS.Instance.getTenMenuTuMaMenu(gioHang[i].MaMN);
                int giaTien = Convert.ToInt32(MenuBUS.Instance.getGiaTienTuMaMenu(gioHang[i].MaMN));
                dataGridView1.Rows.Add(tenMenu, gioHang[i].SoLuong, giaTien, giaTien * gioHang[i].SoLuong);
            }
            lbTongTien.Text = lbTongTien.Text + tien;
            tbTenKhachHang.Enabled = false;
            tbSDT.Enabled = false;
            tbDiaChi.Enabled = false;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            string tongTienString = lbTongTien.Text.TrimEnd('đ');
            tongTienString = tongTienString.Replace("Tổng: ", "");
            int tongTienInt = Convert.ToInt32(tongTienString);
            DateTime dt = DateTime.Now;
            bool giaoHang = true;
            string trangThai = "Đang giao";
            if (rbMuaTaiQuan.Checked)
            {
                giaoHang = false;
                trangThai = "";
            }
            HoaDonDTO hoaDon = new HoaDonDTO(0, tongTienInt, tbTenKhachHang.Text, tbDiaChi.Text, tbSDT.Text, dt, giaoHang, trangThai);
            if (HoaDonBUS.Instance.themHoaDon(hoaDon))
            {
                for(int i = 0; i < gioHang.Count; i++)
                {
                    ArrayList maMA = ChiTietMenuBUS.Instance.layMaMonAnTuMaMenu(gioHang[i].MaMN);
                    for(int j = 0; j < maMA.Count; j++)
                    {
                        string thongBao = "";
                        int soLuongMATru = ChiTietMenuBUS.Instance.laySoLuongTuMaMonAnVaMaMenu(Convert.ToInt32(maMA[j].ToString()), gioHang[i].MaMN);
                        int soLuongMA = MonAnBUS.Instance.getSoLuong(gioHang[i].MaMN);
                        if(MonAnBUS.Instance.updateSoLuongMonAn(Convert.ToInt32(maMA[j].ToString()), soLuongMA - soLuongMATru * gioHang[i].SoLuong))
                        {
                            
                        }
                       
                    }
                    int maHD = HoaDonBUS.Instance.getMaHoaDon(hoaDon);
                    ChiTietHoaDonBUS.Instance.themChiTietHoaDon(new ChiTietHoaDonDTO(maHD, gioHang[i].MaMN, gioHang[i].SoLuong));
                }
                MessageBox.Show("Thêm hoá đơn thành công");
                this.Close();
            }
        }

        private void rbMuaTaiQuan_CheckedChanged(object sender, EventArgs e)
        {
            tbTenKhachHang.Enabled = false;
            tbSDT.Enabled = false;
            tbDiaChi.Enabled = false;
        }

        private void rbDatHang_CheckedChanged(object sender, EventArgs e)
        {
            tbTenKhachHang.Enabled = true;
            tbSDT.Enabled = true;
            tbDiaChi.Enabled = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
