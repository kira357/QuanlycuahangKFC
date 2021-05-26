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
namespace BaiTapLon
{
    public partial class frmQuanLyBanHang : Form
    {
        List<Hang> gioHang = new List<Hang>();
        public frmQuanLyBanHang()
        {
            InitializeComponent();
            load();

        }
        public void load()
        {
            btnXoaDongTrongGioHang.Hide();
            dataGridView.AllowUserToAddRows = false;

            pnGaRan1Mieng.Show();
            pnGaRan2Mieng.Show();
            pnGaRan3Mieng.Show();
            pnGaRan6Mieng.Show();
            pnGaRan9Mieng.Show();
            pnGaRan12Mieng.Show();
            pnHotWings3Mieng.Show();
            pnHotWings5Mieng.Show();

            pnBurgerZinger.Hide();
            pnBurgerTom.Hide();

            pnKhoaiTayChienNho.Hide();
            pnKhoaiTayChienVua.Hide();
            pnKhoaiTayChienLon.Hide();

            pnComboGaRanA.Hide();
            pnComboGaRanB.Hide();
            pnComboGaRanC.Hide();

            pnComboNhomA.Hide();
            pnComboNhomB.Hide();
            pnComboNhomC.Hide();
            pnComboGiaDinhA.Hide();
            pnComboGiaDinhB.Hide();

            pn7up.Hide();
            pnMirindaCam.Hide();
            pnPepsi.Hide();
            pnTwister.Hide();

            ptGioHang1.Image = new Bitmap(Application.StartupPath + "\\Resources\\App\\ShoppingBasket.png");
            ptGioHang2.Image = new Bitmap(Application.StartupPath + "\\Resources\\App\\ShoppingBasket.png");
            btnXoaDongTrongGioHang.Image = new Bitmap(Application.StartupPath + "\\Resources\\App\\Delete.png");
            ptLogo.Image = new Bitmap(Application.StartupPath + "\\Resources\\App\\Logo.png");
            btnClose.Image = new Bitmap(Application.StartupPath + "\\Resources\\App\\Close.png");
            btnMinimize.Image = new Bitmap(Application.StartupPath + "\\Resources\\App\\Minimize.png");
            ptGaRan1Mieng.Image = new Bitmap(Application.StartupPath + "\\Resources\\GaRan\\GaRan1Mieng.jpg");
            ptGaRan2Mieng.Image = new Bitmap(Application.StartupPath + "\\Resources\\GaRan\\GaRan2Mieng.jpg");
            ptGaRan3Mieng.Image = new Bitmap(Application.StartupPath + "\\Resources\\GaRan\\GaRan3Mieng.jpg");
            ptGaRan6Mieng.Image = new Bitmap(Application.StartupPath + "\\Resources\\GaRan\\GaRan6Mieng.jpg");
            ptGaRan9Mieng.Image = new Bitmap(Application.StartupPath + "\\Resources\\GaRan\\GaRan9Mieng.jpg");
            ptGaRan12Mieng.Image = new Bitmap(Application.StartupPath + "\\Resources\\GaRan\\GaRan12Mieng.jpg");
            ptHotWings3Mieng.Image = new Bitmap(Application.StartupPath + "\\Resources\\GaRan\\PhanHotWings3Mieng.jpg");
            ptHotWings5Mieng.Image = new Bitmap(Application.StartupPath + "\\Resources\\GaRan\\PhanHotWings5Mieng.jpg");
            ptBurgerZinger.Image = new Bitmap(Application.StartupPath + "\\Resources\\Burger\\BurgerZinger.jpg");
            ptBurgerTom.Image = new Bitmap(Application.StartupPath + "\\Resources\\Burger\\BurgerTom.jpg");
            ptKhoaiTayChienNho.Image = new Bitmap(Application.StartupPath + "\\Resources\\KhoaiTayChien\\KhoaiTayChienNho.jpg");
            ptKhoaiTayChienVua.Image = new Bitmap(Application.StartupPath + "\\Resources\\KhoaiTayChien\\KhoaiTayChienVua.jpg");
            ptKhoaiTayChienLon.Image = new Bitmap(Application.StartupPath + "\\Resources\\KhoaiTayChien\\KhoaiTayChienLon.jpg");
            pt7Up.Image = new Bitmap(Application.StartupPath + "\\Resources\\Nuoc\\7Up.jpg");
            ptMirindaCam.Image = new Bitmap(Application.StartupPath + "\\Resources\\Nuoc\\MirindaCam.jpg");
            ptPepsi.Image = new Bitmap(Application.StartupPath + "\\Resources\\Nuoc\\Pepsi.jpg");
            ptTwister.Image = new Bitmap(Application.StartupPath + "\\Resources\\Nuoc\\twister.jpg");
            ptComboGaRanA.Image = new Bitmap(Application.StartupPath + "\\Resources\\ComboMon\\ComboGaRanA.jpg");
            ptComboGaRanB.Image = new Bitmap(Application.StartupPath + "\\Resources\\ComboMon\\ComboGaRanB.jpg");
            ptComboGaRanC.Image = new Bitmap(Application.StartupPath + "\\Resources\\ComboMon\\ComboGaRanC.jpg");
            ptComboNhomA.Image = new Bitmap(Application.StartupPath + "\\Resources\\ComboNhom\\ComboNhomA.jpg");
            ptComboNhomB.Image = new Bitmap(Application.StartupPath + "\\Resources\\ComboNhom\\ComboNhomB.jpg");
            ptComboNhomC.Image = new Bitmap(Application.StartupPath + "\\Resources\\ComboNhom\\ComboNhomC.jpg");
            ptComboGiaDinhA.Image = new Bitmap(Application.StartupPath + "\\Resources\\ComboNhom\\CombGiaDinhA.jpg");
            ptComboGiaDinhB.Image = new Bitmap(Application.StartupPath + "\\Resources\\ComboNhom\\CombGiaDinhB.jpg");
        }

        private void dataGridView_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            int thanhTien = 0;
            for (int rows = 0; rows < dataGridView.Rows.Count; rows++)
            {
                thanhTien += Convert.ToInt32(dataGridView.Rows[rows].Cells[2].Value);
            }
            lbThanhTien.Text = thanhTien.ToString();
            btnXoaDongTrongGioHang.Hide();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnXoaDongTrongGioHang.Show();
        }

        private void dataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int thanhTien = 0;
            for (int rows = 0; rows < dataGridView.Rows.Count; rows++)
            {
                thanhTien += Convert.ToInt32(dataGridView.Rows[rows].Cells[2].Value);
            }
            lbThanhTien.Text = thanhTien.ToString();
            btnXoaDongTrongGioHang.Hide();
        }

        private void btnXoaDongTrongGioHang_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView.CurrentCell.RowIndex;
            string tenMenu = dataGridView.Rows[rowIndex].Cells[0].Value.ToString();
            int maMN = MenuBUS.Instance.getMaMenuTuTenMenu(tenMenu);
            Hang hang = gioHang.Single(r => r.MaMN == maMN);
            gioHang.Remove(hang);
            dataGridView.Rows.RemoveAt(rowIndex);
        }

        private void dataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            int thanhTien = 0;
            for (int rows = 0; rows < dataGridView.Rows.Count; rows++)
            {
                thanhTien += Convert.ToInt32(dataGridView.Rows[rows].Cells[2].Value);
            }
            lbThanhTien.Text = thanhTien.ToString();
        }

        private void btnGaRan_Click(object sender, EventArgs e)
        {
            btnGaRan.BackColor = Color.White;
            btnGaRan.ForeColor = Color.Black;

            btnBurger.BackColor = Color.FromArgb(255, 128, 128);
            btnBurger.ForeColor = Color.White;

            btnKhoaiTayChien.BackColor = Color.FromArgb(255, 128, 128);
            btnKhoaiTayChien.ForeColor = Color.White;

            btnComboMon.BackColor = Color.FromArgb(255, 128, 128);
            btnComboMon.ForeColor = Color.White;

            btnComboNhom.BackColor = Color.FromArgb(255, 128, 128);
            btnComboNhom.ForeColor = Color.White;

            btnNuoc.BackColor = Color.FromArgb(255, 128, 128);
            btnNuoc.ForeColor = Color.White;

            pnGaRan1Mieng.Show();
            pnGaRan2Mieng.Show();
            pnGaRan3Mieng.Show();
            pnGaRan6Mieng.Show();
            pnGaRan9Mieng.Show();
            pnGaRan12Mieng.Show();
            pnHotWings3Mieng.Show();
            pnHotWings5Mieng.Show();

            pnBurgerZinger.Hide();
            pnBurgerTom.Hide();

            pnKhoaiTayChienNho.Hide();
            pnKhoaiTayChienVua.Hide();
            pnKhoaiTayChienLon.Hide();

            pnComboGaRanA.Hide();
            pnComboGaRanB.Hide();
            pnComboGaRanC.Hide();

            pnComboNhomA.Hide();
            pnComboNhomB.Hide();
            pnComboNhomC.Hide();
            pnComboGiaDinhA.Hide();
            pnComboGiaDinhB.Hide();

            pn7up.Hide();
            pnMirindaCam.Hide();
            pnPepsi.Hide();
            pnTwister.Hide();
        }

        private void btnBurger_Click(object sender, EventArgs e)
        {
            btnGaRan.BackColor = Color.FromArgb(255, 128, 128);
            btnGaRan.ForeColor = Color.White;

            btnBurger.BackColor = Color.White;
            btnBurger.ForeColor = Color.Black;

            btnKhoaiTayChien.BackColor = Color.FromArgb(255, 128, 128);
            btnKhoaiTayChien.ForeColor = Color.White;

            btnComboMon.BackColor = Color.FromArgb(255, 128, 128);
            btnComboMon.ForeColor = Color.White;

            btnComboNhom.BackColor = Color.FromArgb(255, 128, 128);
            btnComboNhom.ForeColor = Color.White;

            btnNuoc.BackColor = Color.FromArgb(255, 128, 128);
            btnNuoc.ForeColor = Color.White;

            pnGaRan1Mieng.Hide();
            pnGaRan2Mieng.Hide();
            pnGaRan3Mieng.Hide();
            pnGaRan6Mieng.Hide();
            pnGaRan9Mieng.Hide();
            pnGaRan12Mieng.Hide();
            pnHotWings3Mieng.Hide();
            pnHotWings5Mieng.Hide();

            pnBurgerZinger.Show();
            pnBurgerTom.Show();

            pnKhoaiTayChienNho.Hide();
            pnKhoaiTayChienVua.Hide();
            pnKhoaiTayChienLon.Hide();

            pnComboGaRanA.Hide();
            pnComboGaRanB.Hide();
            pnComboGaRanC.Hide();

            pnComboNhomA.Hide();
            pnComboNhomB.Hide();
            pnComboNhomC.Hide();
            pnComboGiaDinhA.Hide();
            pnComboGiaDinhB.Hide();

            pn7up.Hide();
            pnMirindaCam.Hide();
            pnPepsi.Hide();
            pnTwister.Hide();
        }

        private void btnKhoaiTayChien_Click(object sender, EventArgs e)
        {
            btnGaRan.BackColor = Color.FromArgb(255, 128, 128);
            btnGaRan.ForeColor = Color.White;

            btnBurger.BackColor = Color.FromArgb(255, 128, 128);
            btnBurger.ForeColor = Color.White;

            btnKhoaiTayChien.BackColor = Color.White;
            btnKhoaiTayChien.ForeColor = Color.Black;

            btnComboMon.BackColor = Color.FromArgb(255, 128, 128);
            btnComboMon.ForeColor = Color.White;

            btnComboNhom.BackColor = Color.FromArgb(255, 128, 128);
            btnComboNhom.ForeColor = Color.White;

            btnNuoc.BackColor = Color.FromArgb(255, 128, 128);
            btnNuoc.ForeColor = Color.White;

            pnGaRan1Mieng.Hide();
            pnGaRan2Mieng.Hide();
            pnGaRan3Mieng.Hide();
            pnGaRan6Mieng.Hide();
            pnGaRan9Mieng.Hide();
            pnGaRan12Mieng.Hide();
            pnHotWings3Mieng.Hide();
            pnHotWings5Mieng.Hide();

            pnBurgerZinger.Hide();
            pnBurgerTom.Hide();

            pnKhoaiTayChienNho.Show();
            pnKhoaiTayChienVua.Show();
            pnKhoaiTayChienLon.Show();

            pnComboGaRanA.Hide();
            pnComboGaRanB.Hide();
            pnComboGaRanC.Hide();

            pnComboNhomA.Hide();
            pnComboNhomB.Hide();
            pnComboNhomC.Hide();
            pnComboGiaDinhA.Hide();
            pnComboGiaDinhB.Hide();

            pn7up.Hide();
            pnMirindaCam.Hide();
            pnPepsi.Hide();
            pnTwister.Hide();
        }

        private void btnComboMon_Click(object sender, EventArgs e)
        {
            btnGaRan.BackColor = Color.FromArgb(255, 128, 128);
            btnGaRan.ForeColor = Color.White;

            btnBurger.BackColor = Color.FromArgb(255, 128, 128);
            btnBurger.ForeColor = Color.White;

            btnKhoaiTayChien.BackColor = Color.FromArgb(255, 128, 128);
            btnKhoaiTayChien.ForeColor = Color.White;

            btnComboMon.BackColor = Color.White;
            btnComboMon.ForeColor = Color.Black;

            btnComboNhom.BackColor = Color.FromArgb(255, 128, 128);
            btnComboNhom.ForeColor = Color.White;

            btnNuoc.BackColor = Color.FromArgb(255, 128, 128);
            btnNuoc.ForeColor = Color.White;

            pnGaRan1Mieng.Hide();
            pnGaRan2Mieng.Hide();
            pnGaRan3Mieng.Hide();
            pnGaRan6Mieng.Hide();
            pnGaRan9Mieng.Hide();
            pnGaRan12Mieng.Hide();
            pnHotWings3Mieng.Hide();
            pnHotWings5Mieng.Hide();

            pnBurgerZinger.Hide();
            pnBurgerTom.Hide();

            pnKhoaiTayChienNho.Hide();
            pnKhoaiTayChienVua.Hide();
            pnKhoaiTayChienLon.Hide();

            pnComboGaRanA.Show();
            pnComboGaRanB.Show();
            pnComboGaRanC.Show();

            pnComboNhomA.Hide();
            pnComboNhomB.Hide();
            pnComboNhomC.Hide();
            pnComboGiaDinhA.Hide();
            pnComboGiaDinhB.Hide();

            pn7up.Hide();
            pnMirindaCam.Hide();
            pnPepsi.Hide();
            pnTwister.Hide();
        }

        private void btnComboNhom_Click(object sender, EventArgs e)
        {
            btnGaRan.BackColor = Color.FromArgb(255, 128, 128);
            btnGaRan.ForeColor = Color.White;

            btnBurger.BackColor = Color.FromArgb(255, 128, 128);
            btnBurger.ForeColor = Color.White;

            btnKhoaiTayChien.BackColor = Color.FromArgb(255, 128, 128);
            btnKhoaiTayChien.ForeColor = Color.White;

            btnComboMon.BackColor = Color.FromArgb(255, 128, 128);
            btnComboMon.ForeColor = Color.White;

            btnComboNhom.BackColor = Color.White;
            btnComboNhom.ForeColor = Color.Black;

            btnNuoc.BackColor = Color.FromArgb(255, 128, 128);
            btnNuoc.ForeColor = Color.White;

            pnGaRan1Mieng.Hide();
            pnGaRan2Mieng.Hide();
            pnGaRan3Mieng.Hide();
            pnGaRan6Mieng.Hide();
            pnGaRan9Mieng.Hide();
            pnGaRan12Mieng.Hide();
            pnHotWings3Mieng.Hide();
            pnHotWings5Mieng.Hide();

            pnBurgerZinger.Hide();
            pnBurgerTom.Hide();

            pnKhoaiTayChienNho.Hide();
            pnKhoaiTayChienVua.Hide();
            pnKhoaiTayChienLon.Hide();

            pnComboGaRanA.Hide();
            pnComboGaRanB.Hide();
            pnComboGaRanC.Hide();

            pnComboNhomA.Show();
            pnComboNhomB.Show();
            pnComboNhomC.Show();
            pnComboGiaDinhA.Show();
            pnComboGiaDinhB.Show();

            pn7up.Hide();
            pnMirindaCam.Hide();
            pnPepsi.Hide();
            pnTwister.Hide();
        }

        private void btnNuoc_Click(object sender, EventArgs e)
        {
            btnGaRan.BackColor = Color.FromArgb(255, 128, 128);
            btnGaRan.ForeColor = Color.White;

            btnBurger.BackColor = Color.FromArgb(255, 128, 128);
            btnBurger.ForeColor = Color.White;

            btnKhoaiTayChien.BackColor = Color.FromArgb(255, 128, 128);
            btnKhoaiTayChien.ForeColor = Color.White;

            btnComboMon.BackColor = Color.FromArgb(255, 128, 128);
            btnComboMon.ForeColor = Color.White;

            btnComboNhom.BackColor = Color.FromArgb(255, 128, 128);
            btnComboNhom.ForeColor = Color.White;

            btnNuoc.BackColor = Color.White;
            btnNuoc.ForeColor = Color.Black;

            pnGaRan1Mieng.Hide();
            pnGaRan2Mieng.Hide();
            pnGaRan3Mieng.Hide();
            pnGaRan6Mieng.Hide();
            pnGaRan9Mieng.Hide();
            pnGaRan12Mieng.Hide();
            pnHotWings3Mieng.Hide();
            pnHotWings5Mieng.Hide();

            pnBurgerZinger.Hide();
            pnBurgerTom.Hide();

            pnKhoaiTayChienNho.Hide();
            pnKhoaiTayChienVua.Hide();
            pnKhoaiTayChienLon.Hide();

            pnComboGaRanA.Hide();
            pnComboGaRanB.Hide();
            pnComboGaRanC.Hide();

            pnComboNhomA.Hide();
            pnComboNhomB.Hide();
            pnComboNhomC.Hide();
            pnComboGiaDinhA.Hide();
            pnComboGiaDinhB.Hide();

            pn7up.Show();
            pnMirindaCam.Show();
            pnPepsi.Show();
            pnTwister.Show();
        }

        private void btnGaRan1Mieng_Click(object sender, EventArgs e)
        {
            int soLuongHang = MonAnBUS.Instance.getSoLuong(1);
            int soLuong = Convert.ToInt32(soLuongGaRan1Mieng.Value);
            if (soLuong > soLuongHang)
            {
                MessageBox.Show("Thiếu " + (soLuong - soLuongHang).ToString() + " so với lượng đặt");
                return;
            }
            string giaTienString = giaTienGaRan1Mieng.Text.TrimEnd('đ');
            giaTienString = giaTienString.Replace(".", "");
            int giaTienInt = Convert.ToInt32(giaTienString);
            
            Hang hang = new Hang(1, soLuong);
            for(int i= 0; i < gioHang.Count; i++)
            {
                if (gioHang[i].kiemTra(hang)){
                    gioHang[i].SoLuong = hang.SoLuong;
                    for (int rows = 0; rows < dataGridView.Rows.Count; rows++)
                    {
                        if(dataGridView.Rows[rows].Cells[0].Value.ToString().Equals("Gà Rán 1 Miếng"))
                        {
                            dataGridView.Rows[rows].Cells[1].Value = gioHang[i].SoLuong.ToString();
                            dataGridView.Rows[rows].Cells[2].Value = (gioHang[i].SoLuong * giaTienInt).ToString();
                            return;
                        }
                    }
                }
            }
            gioHang.Add(hang);
            dataGridView.Rows.Add("Gà Rán 1 Miếng", soLuong, giaTienInt*soLuong);
        }

        private void btnGaRan2Mieng_Click(object sender, EventArgs e)
        {
            int soLuong = Convert.ToInt32(soLuongGaRan2Mieng.Value);
            int soLuongHang = MonAnBUS.Instance.getSoLuong(1);
            if (soLuong*2 > soLuongHang)
            {
                MessageBox.Show("Thiếu " + (soLuong*2 - soLuongHang).ToString() + " so với lượng đặt");
                return;
            }
            string giaTienString = giaTienGaRan2Mieng.Text.TrimEnd('đ');
            giaTienString = giaTienString.Replace(".", "");
            int giaTienInt = Convert.ToInt32(giaTienString);

            Hang hang = new Hang(2, soLuong);
            for (int i = 0; i < gioHang.Count; i++)
            {
                if (gioHang[i].kiemTra(hang))
                {
                    gioHang[i].SoLuong = hang.SoLuong;
                    for (int rows = 0; rows < dataGridView.Rows.Count; rows++)
                    {
                        if (dataGridView.Rows[rows].Cells[0].Value.ToString().Equals("Gà Rán 2 Miếng"))
                        {
                            dataGridView.Rows[rows].Cells[1].Value = gioHang[i].SoLuong.ToString();
                            dataGridView.Rows[rows].Cells[2].Value = (gioHang[i].SoLuong * giaTienInt).ToString();
                            return;
                        }
                    }
                }
            }
            gioHang.Add(hang);
            dataGridView.Rows.Add("Gà Rán 2 Miếng", soLuong, giaTienInt * soLuong);
        }

        private void btnGaRan3Mieng_Click(object sender, EventArgs e)
        {
            int soLuong = Convert.ToInt32(soLuongGaRan3Mieng.Value);
            int soLuongHang = MonAnBUS.Instance.getSoLuong(1);
            if (soLuong * 3 > soLuongHang)
            {
                MessageBox.Show("Thiếu " + (soLuong * 3 - soLuongHang).ToString() + " so với lượng đặt");
                return;
            }
            string giaTienString = giaTienGaRan3Mieng.Text.TrimEnd('đ');
            giaTienString = giaTienString.Replace(".", "");
            int giaTienInt = Convert.ToInt32(giaTienString);

            Hang hang = new Hang(3, soLuong);
            for (int i = 0; i < gioHang.Count; i++)
            {
                if (gioHang[i].kiemTra(hang))
                {
                    gioHang[i].SoLuong = hang.SoLuong;
                    for (int rows = 0; rows < dataGridView.Rows.Count; rows++)
                    {
                        if (dataGridView.Rows[rows].Cells[0].Value.ToString().Equals("Gà Rán 3 Miếng"))
                        {
                            dataGridView.Rows[rows].Cells[1].Value = gioHang[i].SoLuong.ToString();
                            dataGridView.Rows[rows].Cells[2].Value = (gioHang[i].SoLuong * giaTienInt).ToString();
                            return;
                        }
                    }
                }
            }
            gioHang.Add(hang);
            dataGridView.Rows.Add("Gà Rán 3 Miếng", soLuong, giaTienInt * soLuong);
        }

        private void btnGaRan6Mieng_Click(object sender, EventArgs e)
        {
            int soLuong = Convert.ToInt32(soLuongGaRan6Mieng.Value);
            int soLuongHang = MonAnBUS.Instance.getSoLuong(1);
            if (soLuong * 6 > soLuongHang)
            {
                MessageBox.Show("Thiếu " + (soLuong * 6 - soLuongHang).ToString() + " so với lượng đặt");
                return;
            }
            string giaTienString = giaTienGaRan6Mieng.Text.TrimEnd('đ');
            giaTienString = giaTienString.Replace(".", "");
            int giaTienInt = Convert.ToInt32(giaTienString);

            Hang hang = new Hang(4, soLuong);
            for (int i = 0; i < gioHang.Count; i++)
            {
                if (gioHang[i].kiemTra(hang))
                {
                    gioHang[i].SoLuong = hang.SoLuong;
                    for (int rows = 0; rows < dataGridView.Rows.Count; rows++)
                    {
                        if (dataGridView.Rows[rows].Cells[0].Value.ToString().Equals("Gà Rán 6 Miếng"))
                        {
                            dataGridView.Rows[rows].Cells[1].Value = gioHang[i].SoLuong.ToString();
                            dataGridView.Rows[rows].Cells[2].Value = (gioHang[i].SoLuong * giaTienInt).ToString();
                            return;
                        }
                    }
                }
            }
            gioHang.Add(hang);
            dataGridView.Rows.Add("Gà Rán 6 Miếng", soLuong, giaTienInt * soLuong);
        }

        private void btnGaRan9Mieng_Click(object sender, EventArgs e)
        {
            int soLuong = Convert.ToInt32(soLuongGaRan9Mieng.Value);
            int soLuongHang = MonAnBUS.Instance.getSoLuong(1);
            if (soLuong * 9 > soLuongHang)
            {
                MessageBox.Show("Thiếu " + (soLuong * 9 - soLuongHang).ToString() + " so với lượng đặt");
                return;
            }
            string giaTienString = giaTienGaRan9Mieng.Text.TrimEnd('đ');
            giaTienString = giaTienString.Replace(".", "");
            int giaTienInt = Convert.ToInt32(giaTienString);

            Hang hang = new Hang(5, soLuong);
            for (int i = 0; i < gioHang.Count; i++)
            {
                if (gioHang[i].kiemTra(hang))
                {
                    gioHang[i].SoLuong = hang.SoLuong;
                    for (int rows = 0; rows < dataGridView.Rows.Count; rows++)
                    {
                        if (dataGridView.Rows[rows].Cells[0].Value.ToString().Equals("Gà Rán 9 Miếng"))
                        {
                            dataGridView.Rows[rows].Cells[1].Value = gioHang[i].SoLuong.ToString();
                            dataGridView.Rows[rows].Cells[2].Value = (gioHang[i].SoLuong * giaTienInt).ToString();
                            return;
                        }
                    }
                }
            }
            gioHang.Add(hang);
            dataGridView.Rows.Add("Gà Rán 9 Miếng", soLuong, giaTienInt * soLuong);
        }

        private void btnGaRan12Mieng_Click(object sender, EventArgs e)
        {
            int soLuong = Convert.ToInt32(soLuongGaRan12Mieng.Value);
            int soLuongHang = MonAnBUS.Instance.getSoLuong(1);
            if (soLuong * 12 > soLuongHang)
            {
                MessageBox.Show("Thiếu " + (soLuong * 12 - soLuongHang).ToString() + " so với lượng đặt");
                return;
            }
            string giaTienString = giaTienGaRan12Mieng.Text.TrimEnd('đ');
            giaTienString = giaTienString.Replace(".", "");
            int giaTienInt = Convert.ToInt32(giaTienString);

            Hang hang = new Hang(6, soLuong);
            for (int i = 0; i < gioHang.Count; i++)
            {
                if (gioHang[i].kiemTra(hang))
                {
                    gioHang[i].SoLuong = hang.SoLuong;
                    for (int rows = 0; rows < dataGridView.Rows.Count; rows++)
                    {
                        if (dataGridView.Rows[rows].Cells[0].Value.ToString().Equals("Gà Rán 12 Miếng"))
                        {
                            dataGridView.Rows[rows].Cells[1].Value = gioHang[i].SoLuong.ToString();
                            dataGridView.Rows[rows].Cells[2].Value = (gioHang[i].SoLuong * giaTienInt).ToString();
                            return;
                        }
                    }
                }
            }
            gioHang.Add(hang);
            dataGridView.Rows.Add("Gà Rán 12 Miếng", soLuong, giaTienInt * soLuong);
        }

        private void btnHotWings3Mieng_Click(object sender, EventArgs e)
        {
            int soLuongHang = MonAnBUS.Instance.getSoLuong(2);
            int soLuong = Convert.ToInt32(soLuongHotWings3Mieng.Value);
            if (soLuong *  3> soLuongHang)
            {
                MessageBox.Show("Thiếu " + (soLuong * 3 - soLuongHang).ToString() + " so với lượng đặt");
                return;
            }
            string giaTienString = giaTienHotWings3Mieng.Text.TrimEnd('đ');
            giaTienString = giaTienString.Replace(".", "");
            int giaTienInt = Convert.ToInt32(giaTienString);

            Hang hang = new Hang(7, soLuong);
            for (int i = 0; i < gioHang.Count; i++)
            {
                if (gioHang[i].kiemTra(hang))
                {
                    gioHang[i].SoLuong = hang.SoLuong;
                    for (int rows = 0; rows < dataGridView.Rows.Count; rows++)
                    {
                        if (dataGridView.Rows[rows].Cells[0].Value.ToString().Equals("Phần Hot Wings 3 Miếng"))
                        {
                            dataGridView.Rows[rows].Cells[1].Value = gioHang[i].SoLuong.ToString();
                            dataGridView.Rows[rows].Cells[2].Value = (gioHang[i].SoLuong * giaTienInt).ToString();
                            return;
                        }
                    }
                }
            }
            gioHang.Add(hang);
            dataGridView.Rows.Add("Phần Hot Wings 3 Miếng", soLuong, giaTienInt * soLuong);
        }

        private void btnHotWings5Mieng_Click(object sender, EventArgs e)
        {
            int soLuong = Convert.ToInt32(soLuongHotWings5Mieng.Value);
            int soLuongHang = MonAnBUS.Instance.getSoLuong(2);
            if (soLuong * 5 > soLuongHang)
            {
                MessageBox.Show("Thiếu " + (soLuong * 5 - soLuongHang).ToString() + " so với lượng đặt");
                return;
            }
            string giaTienString = giaTienHotWings5Mieng.Text.TrimEnd('đ');
            giaTienString = giaTienString.Replace(".", "");
            int giaTienInt = Convert.ToInt32(giaTienString);

            Hang hang = new Hang(8, soLuong);
            for (int i = 0; i < gioHang.Count; i++)
            {
                if (gioHang[i].kiemTra(hang))
                {
                    gioHang[i].SoLuong = hang.SoLuong;
                    for (int rows = 0; rows < dataGridView.Rows.Count; rows++)
                    {
                        if (dataGridView.Rows[rows].Cells[0].Value.ToString().Equals("Phần Hot Wings 5 Miếng"))
                        {
                            dataGridView.Rows[rows].Cells[1].Value = gioHang[i].SoLuong.ToString();
                            dataGridView.Rows[rows].Cells[2].Value = (gioHang[i].SoLuong * giaTienInt).ToString();
                            return;
                        }
                    }
                }
            }
            gioHang.Add(hang);
            dataGridView.Rows.Add("Phần Hot Wings 5 Miếng", soLuong, giaTienInt * soLuong);
        }

        private void btnBurgerTom_Click(object sender, EventArgs e)
        {
            int soLuong = Convert.ToInt32(soLuongBurgerTom.Value);
            int soLuongHang = MonAnBUS.Instance.getSoLuong(4);
            if (soLuong > soLuongHang)
            {
                MessageBox.Show("Thiếu " + (soLuong - soLuongHang).ToString() + " so với lượng đặt");
                return;
            }
            string giaTienString = giaTienBurgerTom.Text.TrimEnd('đ');
            giaTienString = giaTienString.Replace(".", "");
            int giaTienInt = Convert.ToInt32(giaTienString);

            Hang hang = new Hang(10, soLuong);
            for (int i = 0; i < gioHang.Count; i++)
            {
                if (gioHang[i].kiemTra(hang))
                {
                    gioHang[i].SoLuong = hang.SoLuong;
                    for (int rows = 0; rows < dataGridView.Rows.Count; rows++)
                    {
                        if (dataGridView.Rows[rows].Cells[0].Value.ToString().Equals("Burger Tôm 1 Phần"))
                        {
                            dataGridView.Rows[rows].Cells[1].Value = gioHang[i].SoLuong.ToString();
                            dataGridView.Rows[rows].Cells[2].Value = (gioHang[i].SoLuong * giaTienInt).ToString();
                            return;
                        }
                    }
                }
            }
            gioHang.Add(hang);
            dataGridView.Rows.Add("Burger Tôm 1 Phần", soLuong, giaTienInt * soLuong);
        }

        private void btnBurgerZinger_Click(object sender, EventArgs e)
        {
            int soLuong = Convert.ToInt32(soLuongBurgerZinger.Value);
            int soLuongHang = MonAnBUS.Instance.getSoLuong(3);
            if (soLuong > soLuongHang)
            {
                MessageBox.Show("Thiếu " + (soLuong - soLuongHang).ToString() + " so với lượng đặt");
                return;
            }
            string giaTienString = giaTienBurgerZinger.Text.TrimEnd('đ');
            giaTienString = giaTienString.Replace(".", "");
            int giaTienInt = Convert.ToInt32(giaTienString);

            Hang hang = new Hang(9, soLuong);
            for (int i = 0; i < gioHang.Count; i++)
            {
                if (gioHang[i].kiemTra(hang))
                {
                    gioHang[i].SoLuong = hang.SoLuong;
                    for (int rows = 0; rows < dataGridView.Rows.Count; rows++)
                    {
                        if (dataGridView.Rows[rows].Cells[0].Value.ToString().Equals("Burger Zinger 1 Phần"))
                        {
                            dataGridView.Rows[rows].Cells[1].Value = gioHang[i].SoLuong.ToString();
                            dataGridView.Rows[rows].Cells[2].Value = (gioHang[i].SoLuong * giaTienInt).ToString();
                            return;
                        }
                    }
                }
            }
            gioHang.Add(hang);
            dataGridView.Rows.Add("Burger Zinger 1 Phần", soLuong, giaTienInt * soLuong);
        }


        private void btnKhoaiTayChienNho_Click(object sender, EventArgs e)
        {
            int soLuong = Convert.ToInt32(soLuongKhoaiTayChienNho.Value);
            int soLuongHang = MonAnBUS.Instance.getSoLuong(5);
            if (soLuong*100 > soLuongHang)
            {
                MessageBox.Show("Thiếu " + (soLuong * 100 - soLuongHang).ToString() + "g so với lượng đặt");
                return;
            }
            string giaTienString = giaTienKhoaiTayChienNho.Text.TrimEnd('đ');
            giaTienString = giaTienString.Replace(".", "");
            int giaTienInt = Convert.ToInt32(giaTienString);

            Hang hang = new Hang(11, soLuong);
            for (int i = 0; i < gioHang.Count; i++)
            {
                if (gioHang[i].kiemTra(hang))
                {
                    gioHang[i].SoLuong = hang.SoLuong;
                    for (int rows = 0; rows < dataGridView.Rows.Count; rows++)
                    {
                        if (dataGridView.Rows[rows].Cells[0].Value.ToString().Equals("Khoai Tây Chiên Nhỏ"))
                        {
                            dataGridView.Rows[rows].Cells[1].Value = gioHang[i].SoLuong.ToString();
                            dataGridView.Rows[rows].Cells[2].Value = (gioHang[i].SoLuong * giaTienInt).ToString();
                            return;
                        }
                    }
                }
            }
            gioHang.Add(hang);
            dataGridView.Rows.Add("Khoai Tây Chiên Nhỏ", soLuong, giaTienInt * soLuong);
        }

        private void btnKhoaiTayChienVua_Click(object sender, EventArgs e)
        {
            int soLuong = Convert.ToInt32(soLuongKhoaiTayChienVua.Value);
            int soLuongHang = MonAnBUS.Instance.getSoLuong(5);
            if (soLuong*200 > soLuongHang)
            {
                MessageBox.Show("Thiếu " + (soLuong * 200 - soLuongHang).ToString() + "g so với lượng đặt");
                return;
            }
            string giaTienString = giaTienKhoaiTayChienVua.Text.TrimEnd('đ');
            giaTienString = giaTienString.Replace(".", "");
            int giaTienInt = Convert.ToInt32(giaTienString);

            Hang hang = new Hang(12, soLuong);
            for (int i = 0; i < gioHang.Count; i++)
            {
                if (gioHang[i].kiemTra(hang))
                {
                    gioHang[i].SoLuong = hang.SoLuong;
                    for (int rows = 0; rows < dataGridView.Rows.Count; rows++)
                    {
                        if (dataGridView.Rows[rows].Cells[0].Value.ToString().Equals("Khoai Tây Chiên Vừa"))
                        {
                            dataGridView.Rows[rows].Cells[1].Value = gioHang[i].SoLuong.ToString();
                            dataGridView.Rows[rows].Cells[2].Value = (gioHang[i].SoLuong * giaTienInt).ToString();
                            return;
                        }
                    }
                }
            }
            gioHang.Add(hang);
            dataGridView.Rows.Add("Khoai Tây Chiên Vừa", soLuong, giaTienInt * soLuong);

        }

        private void btnKhoaiTayChienLon_Click(object sender, EventArgs e)
        {
            int soLuong = Convert.ToInt32(soLuongKhoaiTayChienLon.Value);
            int soLuongHang = MonAnBUS.Instance.getSoLuong(5);
            if (soLuong*300 > soLuongHang)
            {
                MessageBox.Show("Thiếu " + (soLuong * 300 - soLuongHang).ToString() + "g so với lượng đặt");
                return;
            }
            string giaTienString = giaTienKhoaiTayChienLon.Text.TrimEnd('đ');
            giaTienString = giaTienString.Replace(".", "");
            int giaTienInt = Convert.ToInt32(giaTienString);
            Hang hang = new Hang(13, soLuong);
            for (int i = 0; i < gioHang.Count; i++)
            {
                if (gioHang[i].kiemTra(hang))
                {
                    gioHang[i].SoLuong = hang.SoLuong;
                    for (int rows = 0; rows < dataGridView.Rows.Count; rows++)
                    {
                        if (dataGridView.Rows[rows].Cells[0].Value.ToString().Equals("Khoai Tây Chiên Lớn"))
                        {
                            dataGridView.Rows[rows].Cells[1].Value = gioHang[i].SoLuong.ToString();
                            dataGridView.Rows[rows].Cells[2].Value = (gioHang[i].SoLuong * giaTienInt).ToString();
                            return;
                        }
                    }
                }
            }
            gioHang.Add(hang);
            dataGridView.Rows.Add("Khoai Tây Chiên Lớn", soLuong, giaTienInt * soLuong);
        }

        private void btn7up_Click(object sender, EventArgs e)
        {
            int soLuong = Convert.ToInt32(soLuong7Up.Value);
            int soLuongHang = MonAnBUS.Instance.getSoLuong(6);
            if (soLuong > soLuongHang)
            {
                MessageBox.Show("Thiếu " + (soLuong - soLuongHang).ToString() + " so với lượng đặt");
                return;
            }
            string giaTienString = giaTien7Up.Text.TrimEnd('đ');
            giaTienString = giaTienString.Replace(".", "");
            int giaTienInt = Convert.ToInt32(giaTienString);
            Hang hang = new Hang(14, soLuong);
            for (int i = 0; i < gioHang.Count; i++)
            {
                if (gioHang[i].kiemTra(hang))
                {
                    gioHang[i].SoLuong = hang.SoLuong;
                    for (int rows = 0; rows < dataGridView.Rows.Count; rows++)
                    {
                        if (dataGridView.Rows[rows].Cells[0].Value.ToString().Equals("7 Up"))
                        {
                            dataGridView.Rows[rows].Cells[1].Value = gioHang[i].SoLuong.ToString();
                            dataGridView.Rows[rows].Cells[2].Value = (gioHang[i].SoLuong * giaTienInt).ToString();
                            return;
                        }
                    }
                }
            }
            gioHang.Add(hang);
            dataGridView.Rows.Add("7 Up", soLuong, giaTienInt * soLuong);
        }

        private void btnMirindaCam_Click(object sender, EventArgs e)
        {
            int soLuong = Convert.ToInt32(soLuongMirindaCam.Value);
            int soLuongHang = MonAnBUS.Instance.getSoLuong(7);
            if (soLuong > soLuongHang)
            {
                MessageBox.Show("Thiếu " + (soLuong - soLuongHang).ToString() + " so với lượng đặt");
                return;
            }
            string giaTienString = giaTienMirindaCam.Text.TrimEnd('đ');
            giaTienString = giaTienString.Replace(".", "");
            int giaTienInt = Convert.ToInt32(giaTienString);
            Hang hang = new Hang(16, soLuong);
            for (int i = 0; i < gioHang.Count; i++)
            {
                if (gioHang[i].kiemTra(hang))
                {
                    gioHang[i].SoLuong = hang.SoLuong;
                    for (int rows = 0; rows < dataGridView.Rows.Count; rows++)
                    {
                        if (dataGridView.Rows[rows].Cells[0].Value.ToString().Equals("Mirinda Cam"))
                        {
                            dataGridView.Rows[rows].Cells[1].Value = gioHang[i].SoLuong.ToString();
                            dataGridView.Rows[rows].Cells[2].Value = (gioHang[i].SoLuong * giaTienInt).ToString();
                            return;
                        }
                    }
                }
            }
            gioHang.Add(hang);
            dataGridView.Rows.Add("Mirinda Cam", soLuong, giaTienInt * soLuong);
        }

        private void btnPepsi_Click(object sender, EventArgs e)
        {
            int soLuong = Convert.ToInt32(soLuongPepsi.Value);
            int soLuongHang = MonAnBUS.Instance.getSoLuong(8);
            if (soLuong > soLuongHang)
            {
                MessageBox.Show("Thiếu " + (soLuong - soLuongHang).ToString() + " so với lượng đặt");
                return;
            }
            string giaTienString = giaTienPepsi.Text.TrimEnd('đ');
            giaTienString = giaTienString.Replace(".", "");
            int giaTienInt = Convert.ToInt32(giaTienString);
            Hang hang = new Hang(15, soLuong);
            for (int i = 0; i < gioHang.Count; i++)
            {
                if (gioHang[i].kiemTra(hang))
                {
                    gioHang[i].SoLuong = hang.SoLuong;
                    for (int rows = 0; rows < dataGridView.Rows.Count; rows++)
                    {
                        if (dataGridView.Rows[rows].Cells[0].Value.ToString().Equals("Pepsi"))
                        {
                            dataGridView.Rows[rows].Cells[1].Value = gioHang[i].SoLuong.ToString();
                            dataGridView.Rows[rows].Cells[2].Value = (gioHang[i].SoLuong * giaTienInt).ToString();
                            return;
                        }
                    }
                }
            }
            gioHang.Add(hang);
            dataGridView.Rows.Add("Pepsi", soLuong, giaTienInt * soLuong);
        }

        private void btnTwister_Click(object sender, EventArgs e)
        {
            int soLuong = Convert.ToInt32(soLuongTwister.Value);
            int soLuongHang = MonAnBUS.Instance.getSoLuong(9);
            if (soLuong > soLuongHang)
            {
                MessageBox.Show("Thiếu " + (soLuong - soLuongHang).ToString() + " so với lượng đặt");
                return;
            }
            string giaTienString = giaTienTwister.Text.TrimEnd('đ');
            giaTienString = giaTienString.Replace(".", "");
            int giaTienInt = Convert.ToInt32(giaTienString);
            Hang hang = new Hang(17, soLuong);
            for (int i = 0; i < gioHang.Count; i++)
            {
                if (gioHang[i].kiemTra(hang))
                {
                    gioHang[i].SoLuong = hang.SoLuong;
                    for (int rows = 0; rows < dataGridView.Rows.Count; rows++)
                    {
                        if (dataGridView.Rows[rows].Cells[0].Value.ToString().Equals("Twister"))
                        {
                            dataGridView.Rows[rows].Cells[1].Value = gioHang[i].SoLuong.ToString();
                            dataGridView.Rows[rows].Cells[2].Value = (gioHang[i].SoLuong * giaTienInt).ToString();
                            return;
                        }
                    }
                }
            }
            gioHang.Add(hang);
            dataGridView.Rows.Add("Twister", soLuong, giaTienInt * soLuong);
        }

        private void btnComboGaRanA_Click(object sender, EventArgs e)
        {
            int soLuong = Convert.ToInt32(soLuongComboGaRanA.Value);
            ArrayList maMA = ChiTietMenuBUS.Instance.layMaMonAnTuMaMenu(18);
            string thongBao = "";
            for (int j = 0; j < maMA.Count; j++)
            {
                int soLuongChiTietMenu = ChiTietMenuBUS.Instance.laySoLuongTuMaMonAnVaMaMenu(Convert.ToInt32(maMA[j].ToString()), 18);
                int soLuongConLai = MonAnBUS.Instance.getSoLuong(Convert.ToInt32(maMA[j].ToString()));
                if(soLuongConLai < soLuongChiTietMenu * soLuong)
                {
                    string tenMonAn = MonAnBUS.Instance.getTenMonAn(Convert.ToInt32(maMA[j].ToString()));
                    thongBao += "Thiếu " + (soLuongChiTietMenu * soLuong - soLuongConLai).ToString() + " " + tenMonAn + " so với lượng đặt\n";
                }
            }
            if (!thongBao.Equals(""))
            {
                MessageBox.Show(thongBao);
                return;
            }
            string giaTienString = giaTienComboGaRanA.Text.TrimEnd('đ');
            giaTienString = giaTienString.Replace(".", "");
            int giaTienInt = Convert.ToInt32(giaTienString);
            Hang hang = new Hang(18, soLuong);
            for (int i = 0; i < gioHang.Count; i++)
            {
                if (gioHang[i].kiemTra(hang))
                {
                    gioHang[i].SoLuong = hang.SoLuong;
                    for (int rows = 0; rows < dataGridView.Rows.Count; rows++)
                    {
                        if (dataGridView.Rows[rows].Cells[0].Value.ToString().Equals("Combo Gà Rán A"))
                        {
                            dataGridView.Rows[rows].Cells[1].Value = gioHang[i].SoLuong.ToString();
                            dataGridView.Rows[rows].Cells[2].Value = (gioHang[i].SoLuong * giaTienInt).ToString();
                            return;
                        }
                    }
                }
            }
            gioHang.Add(hang);
            dataGridView.Rows.Add("Combo Gà Rán A", soLuong, giaTienInt * soLuong);
        }

        private void btnComboGaRanB_Click(object sender, EventArgs e)
        {
            int soLuong = Convert.ToInt32(soLuongComboGaRanB.Value);
            ArrayList maMA = ChiTietMenuBUS.Instance.layMaMonAnTuMaMenu(19);
            string thongBao = "";
            for (int j = 0; j < maMA.Count; j++)
            {
                int soLuongChiTietMenu = ChiTietMenuBUS.Instance.laySoLuongTuMaMonAnVaMaMenu(Convert.ToInt32(maMA[j].ToString()), 19);
                int soLuongConLai = MonAnBUS.Instance.getSoLuong(Convert.ToInt32(maMA[j].ToString()));
                if (soLuongConLai < soLuongChiTietMenu * soLuong)
                {
                    string tenMonAn = MonAnBUS.Instance.getTenMonAn(Convert.ToInt32(maMA[j].ToString()));
                    thongBao += "Thiếu " + (soLuongChiTietMenu * soLuong - soLuongConLai).ToString() + " " + tenMonAn + " so với lượng đặt\n";
                }
            }
            if (!thongBao.Equals(""))
            {
                MessageBox.Show(thongBao);
                return;
            }
            string giaTienString = giaTienComboGaRanB.Text.TrimEnd('đ');
            giaTienString = giaTienString.Replace(".", "");
            int giaTienInt = Convert.ToInt32(giaTienString);
            Hang hang = new Hang(19, soLuong);
            for (int i = 0; i < gioHang.Count; i++)
            {
                if (gioHang[i].kiemTra(hang))
                {
                    gioHang[i].SoLuong = hang.SoLuong;
                    for (int rows = 0; rows < dataGridView.Rows.Count; rows++)
                    {
                        if (dataGridView.Rows[rows].Cells[0].Value.ToString().Equals("Combo Gà Rán B"))
                        {
                            dataGridView.Rows[rows].Cells[1].Value = gioHang[i].SoLuong.ToString();
                            dataGridView.Rows[rows].Cells[2].Value = (gioHang[i].SoLuong * giaTienInt).ToString();
                            return;
                        }
                    }
                }
            }
            gioHang.Add(hang);
            dataGridView.Rows.Add("Combo Gà Rán B", soLuong, giaTienInt * soLuong);
        }

        private void btnComboGaRanC_Click(object sender, EventArgs e)
        {
            int soLuong = Convert.ToInt32(soLuongComboGaRanC.Value);
            ArrayList maMA = ChiTietMenuBUS.Instance.layMaMonAnTuMaMenu(20);
            string thongBao = "";
            for (int j = 0; j < maMA.Count; j++)
            {
                int soLuongChiTietMenu = ChiTietMenuBUS.Instance.laySoLuongTuMaMonAnVaMaMenu(Convert.ToInt32(maMA[j].ToString()), 20);
                int soLuongConLai = MonAnBUS.Instance.getSoLuong(Convert.ToInt32(maMA[j].ToString()));
                if (soLuongConLai < soLuongChiTietMenu * soLuong)
                {
                    string tenMonAn = MonAnBUS.Instance.getTenMonAn(Convert.ToInt32(maMA[j].ToString()));
                    thongBao += "Thiếu " + (soLuongChiTietMenu * soLuong - soLuongConLai).ToString() + " " + tenMonAn + " so với lượng đặt\n";
                }
            }
            if (!thongBao.Equals(""))
            {
                MessageBox.Show(thongBao);
                return;
            }
            string giaTienString = giaTienComboGaRanC.Text.TrimEnd('đ');
            giaTienString = giaTienString.Replace(".", "");
            int giaTienInt = Convert.ToInt32(giaTienString);
            Hang hang = new Hang(20, soLuong);
            for (int i = 0; i < gioHang.Count; i++)
            {
                if (gioHang[i].kiemTra(hang))
                {
                    gioHang[i].SoLuong = hang.SoLuong;
                    for (int rows = 0; rows < dataGridView.Rows.Count; rows++)
                    {
                        if (dataGridView.Rows[rows].Cells[0].Value.ToString().Equals("Combo Gà Rán C"))
                        {
                            dataGridView.Rows[rows].Cells[1].Value = gioHang[i].SoLuong.ToString();
                            dataGridView.Rows[rows].Cells[2].Value = (gioHang[i].SoLuong * giaTienInt).ToString();
                            return;
                        }
                    }
                }
            }
            gioHang.Add(hang);
            dataGridView.Rows.Add("Combo Gà Rán C", soLuong, giaTienInt * soLuong);
        }

        private void btnComboNhomA_Click(object sender, EventArgs e)
        {
            int soLuong = Convert.ToInt32(soLuongComboNhomA.Value);
            ArrayList maMA = ChiTietMenuBUS.Instance.layMaMonAnTuMaMenu(21);
            string thongBao = "";
            for (int j = 0; j < maMA.Count; j++)
            {
                int soLuongChiTietMenu = ChiTietMenuBUS.Instance.laySoLuongTuMaMonAnVaMaMenu(Convert.ToInt32(maMA[j].ToString()), 21);
                int soLuongConLai = MonAnBUS.Instance.getSoLuong(Convert.ToInt32(maMA[j].ToString()));
                if (soLuongConLai < soLuongChiTietMenu * soLuong)
                {
                    string tenMonAn = MonAnBUS.Instance.getTenMonAn(Convert.ToInt32(maMA[j].ToString()));
                    thongBao += "Thiếu " + (soLuongChiTietMenu * soLuong - soLuongConLai).ToString() + " " + tenMonAn + " so với lượng đặt\n";
                }
            }
            if (!thongBao.Equals(""))
            {
                MessageBox.Show(thongBao);
                return;
            }
            string giaTienString = giaTienComboNhomA.Text.TrimEnd('đ');
            giaTienString = giaTienString.Replace(".", "");
            int giaTienInt = Convert.ToInt32(giaTienString);
            Hang hang = new Hang(21, soLuong);
            for (int i = 0; i < gioHang.Count; i++)
            {
                if (gioHang[i].kiemTra(hang))
                {
                    gioHang[i].SoLuong = hang.SoLuong;
                    for (int rows = 0; rows < dataGridView.Rows.Count; rows++)
                    {
                        if (dataGridView.Rows[rows].Cells[0].Value.ToString().Equals("Combo Nhóm A"))
                        {
                            dataGridView.Rows[rows].Cells[1].Value = gioHang[i].SoLuong.ToString();
                            dataGridView.Rows[rows].Cells[2].Value = (gioHang[i].SoLuong * giaTienInt).ToString();
                            return;
                        }
                    }
                }
            }
            gioHang.Add(hang);
            dataGridView.Rows.Add("Combo Nhóm A", soLuong, giaTienInt * soLuong);
        }

        private void btnComboNhomB_Click(object sender, EventArgs e)
        {
            int soLuong = Convert.ToInt32(soLuongComboNhomB.Value);
            ArrayList maMA = ChiTietMenuBUS.Instance.layMaMonAnTuMaMenu(22);
            string thongBao = "";
            for (int j = 0; j < maMA.Count; j++)
            {
                int soLuongChiTietMenu = ChiTietMenuBUS.Instance.laySoLuongTuMaMonAnVaMaMenu(Convert.ToInt32(maMA[j].ToString()), 22);
                int soLuongConLai = MonAnBUS.Instance.getSoLuong(Convert.ToInt32(maMA[j].ToString()));
                if (soLuongConLai < soLuongChiTietMenu * soLuong)
                {
                    string tenMonAn = MonAnBUS.Instance.getTenMonAn(Convert.ToInt32(maMA[j].ToString()));
                    thongBao += "Thiếu " + (soLuongChiTietMenu * soLuong - soLuongConLai).ToString() + " " + tenMonAn + " so với lượng đặt\n";
                }
            }
            if (!thongBao.Equals(""))
            {
                MessageBox.Show(thongBao);
                return;
            }
            string giaTienString = giaTienComboNhomB.Text.TrimEnd('đ');
            giaTienString = giaTienString.Replace(".", "");
            int giaTienInt = Convert.ToInt32(giaTienString);
            Hang hang = new Hang(22, soLuong);
            for (int i = 0; i < gioHang.Count; i++)
            {
                if (gioHang[i].kiemTra(hang))
                {
                    gioHang[i].SoLuong = hang.SoLuong;
                    for (int rows = 0; rows < dataGridView.Rows.Count; rows++)
                    {
                        if (dataGridView.Rows[rows].Cells[0].Value.ToString().Equals("Combo Nhóm B"))
                        {
                            dataGridView.Rows[rows].Cells[1].Value = gioHang[i].SoLuong.ToString();
                            dataGridView.Rows[rows].Cells[2].Value = (gioHang[i].SoLuong * giaTienInt).ToString();
                            return;
                        }
                    }
                }
            }
            gioHang.Add(hang);
            dataGridView.Rows.Add("Combo Nhóm B", soLuong, giaTienInt * soLuong);
        }

        private void btnComboNhomC_Click(object sender, EventArgs e)
        {
            int soLuong = Convert.ToInt32(soLuongComboNhomC.Value);
            ArrayList maMA = ChiTietMenuBUS.Instance.layMaMonAnTuMaMenu(23);
            string thongBao = "";
            for (int j = 0; j < maMA.Count; j++)
            {
                int soLuongChiTietMenu = ChiTietMenuBUS.Instance.laySoLuongTuMaMonAnVaMaMenu(Convert.ToInt32(maMA[j].ToString()), 23);
                int soLuongConLai = MonAnBUS.Instance.getSoLuong(Convert.ToInt32(maMA[j].ToString()));
                if (soLuongConLai < soLuongChiTietMenu * soLuong)
                {
                    string tenMonAn = MonAnBUS.Instance.getTenMonAn(Convert.ToInt32(maMA[j].ToString()));
                    thongBao += "Thiếu " + (soLuongChiTietMenu * soLuong - soLuongConLai).ToString() + " " + tenMonAn + " so với lượng đặt\n";
                }
            }
            if (!thongBao.Equals(""))
            {
                MessageBox.Show(thongBao);
                return;
            }
            string giaTienString = giaTienComboNhomC.Text.TrimEnd('đ');
            giaTienString = giaTienString.Replace(".", "");
            int giaTienInt = Convert.ToInt32(giaTienString);
            Hang hang = new Hang(23, soLuong);
            for (int i = 0; i < gioHang.Count; i++)
            {
                if (gioHang[i].kiemTra(hang))
                {
                    gioHang[i].SoLuong = hang.SoLuong;
                    for (int rows = 0; rows < dataGridView.Rows.Count; rows++)
                    {
                        if (dataGridView.Rows[rows].Cells[0].Value.ToString().Equals("Combo Nhóm C"))
                        {
                            dataGridView.Rows[rows].Cells[1].Value = gioHang[i].SoLuong.ToString();
                            dataGridView.Rows[rows].Cells[2].Value = (gioHang[i].SoLuong * giaTienInt).ToString();
                            return;
                        }
                    }
                }
            }
            gioHang.Add(hang);
            dataGridView.Rows.Add("Combo Nhóm C", soLuong, giaTienInt * soLuong);
        }

        private void btnComboGiaDinhA_Click(object sender, EventArgs e)
        {
            int soLuong = Convert.ToInt32(soLuongComboGiaDinhA.Value);
            ArrayList maMA = ChiTietMenuBUS.Instance.layMaMonAnTuMaMenu(24);
            string thongBao = "";
            for (int j = 0; j < maMA.Count; j++)
            {
                int soLuongChiTietMenu = ChiTietMenuBUS.Instance.laySoLuongTuMaMonAnVaMaMenu(Convert.ToInt32(maMA[j].ToString()), 24);
                int soLuongConLai = MonAnBUS.Instance.getSoLuong(Convert.ToInt32(maMA[j].ToString()));
                if (soLuongConLai < soLuongChiTietMenu * soLuong)
                {
                    string tenMonAn = MonAnBUS.Instance.getTenMonAn(Convert.ToInt32(maMA[j].ToString()));
                    thongBao += "Thiếu " + (soLuongChiTietMenu * soLuong - soLuongConLai).ToString() + " " + tenMonAn + " so với lượng đặt\n";
                }
            }
            if (!thongBao.Equals(""))
            {
                MessageBox.Show(thongBao);
                return;
            }
            string giaTienString = giaTienComboGiaDinhA.Text.TrimEnd('đ');
            giaTienString = giaTienString.Replace(".", "");
            int giaTienInt = Convert.ToInt32(giaTienString);
            Hang hang = new Hang(24, soLuong);
            for (int i = 0; i < gioHang.Count; i++)
            {
                if (gioHang[i].kiemTra(hang))
                {
                    gioHang[i].SoLuong = hang.SoLuong;
                    for (int rows = 0; rows < dataGridView.Rows.Count; rows++)
                    {
                        if (dataGridView.Rows[rows].Cells[0].Value.ToString().Equals("Combo Gia Đình A"))
                        {
                            dataGridView.Rows[rows].Cells[1].Value = gioHang[i].SoLuong.ToString();
                            dataGridView.Rows[rows].Cells[2].Value = (gioHang[i].SoLuong * giaTienInt).ToString();
                            return;
                        }
                    }
                }
            }
            gioHang.Add(hang);
            dataGridView.Rows.Add("Combo Gia Đình A", soLuong, giaTienInt * soLuong);
        }

        private void btnComboGiaDinhB_Click(object sender, EventArgs e)
        {
            int soLuong = Convert.ToInt32(soLuongComboGiaDinhB.Value);
            ArrayList maMA = ChiTietMenuBUS.Instance.layMaMonAnTuMaMenu(25);
            string thongBao = "";
            for (int j = 0; j < maMA.Count; j++)
            {
                int soLuongChiTietMenu = ChiTietMenuBUS.Instance.laySoLuongTuMaMonAnVaMaMenu(Convert.ToInt32(maMA[j].ToString()), 25);
                int soLuongConLai = MonAnBUS.Instance.getSoLuong(Convert.ToInt32(maMA[j].ToString()));
                if (soLuongConLai < soLuongChiTietMenu * soLuong)
                {
                    string tenMonAn = MonAnBUS.Instance.getTenMonAn(Convert.ToInt32(maMA[j].ToString()));
                    thongBao += "Thiếu " + (soLuongChiTietMenu * soLuong - soLuongConLai).ToString() + " " + tenMonAn + " so với lượng đặt\n";
                }
            }
            if (!thongBao.Equals(""))
            {
                MessageBox.Show(thongBao);
                return;
            }
            string giaTienString = giaTienComboGiaDinhB.Text.TrimEnd('đ');
            giaTienString = giaTienString.Replace(".", "");
            int giaTienInt = Convert.ToInt32(giaTienString);
            Hang hang = new Hang(25, soLuong);
            for (int i = 0; i < gioHang.Count; i++)
            {
                if (gioHang[i].kiemTra(hang))
                {
                    gioHang[i].SoLuong = hang.SoLuong;
                    for (int rows = 0; rows < dataGridView.Rows.Count; rows++)
                    {
                        if (dataGridView.Rows[rows].Cells[0].Value.ToString().Equals("Combo Gia Đình B"))
                        {
                            dataGridView.Rows[rows].Cells[1].Value = gioHang[i].SoLuong.ToString();
                            dataGridView.Rows[rows].Cells[2].Value = (gioHang[i].SoLuong * giaTienInt).ToString();
                            return;
                        }
                    }
                }
            }
            gioHang.Add(hang);
            dataGridView.Rows.Add("Combo Gia Đình B", soLuong, giaTienInt * soLuong);
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (dataGridView.Rows.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn món");
                return;
            }
            frmHoaDon chiTietHoaDon = new frmHoaDon(gioHang, lbThanhTien.Text);
            chiTietHoaDon.FormClosed += new FormClosedEventHandler(ChiTietHoaDon_FormClosed);
            chiTietHoaDon.Show();
            this.Enabled = false;
        }
        private void ChiTietHoaDon_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Enabled = true;
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
