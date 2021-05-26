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
    public partial class UserThongKeXuatNhapKhoControl : UserControl
    {
        public UserThongKeXuatNhapKhoControl()
        {
            InitializeComponent();
            
        }
        private void UserControl2_Load(object sender, EventArgs e)
        {
            dataGridViewNhapKho.DataSource = ThongKeBUS.Instance.getAllNhapKho();
            dataGridViewXuatKho.DataSource = ThongKeBUS.Instance.getAllXuatKho();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            dataGridViewNhapKho.DataSource = ThongKeBUS.Instance.getNhap(dateTimePicker1.Value, dateTimePicker2.Value);
            dataGridViewXuatKho.DataSource = ThongKeBUS.Instance.getXuat(dateTimePicker1.Value, dateTimePicker2.Value);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ToExcel_NhapKho(dataGridViewNhapKho, saveFileDialog1.FileName);

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (saveFileDialog2.ShowDialog() == DialogResult.OK)
            {
                ToExcel_XuatKho(dataGridViewXuatKho, saveFileDialog2.FileName);

            }
        }

        private void ToExcel_NhapKho(DataGridView dataGridViewNhapKho, string fileNameNhapKho)
        {
            Microsoft.Office.Interop.Excel.Application excel;
            Microsoft.Office.Interop.Excel.Workbook workbook;
            Microsoft.Office.Interop.Excel.Worksheet worksheet;

            try
            {
                excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = false;
                excel.DisplayAlerts = false;

                workbook = excel.Workbooks.Add(Type.Missing);

                worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets["Sheet1"];
                worksheet.Name = "Thống kê nhập kho";

                // Export header
                for (int i = 0; i < dataGridViewNhapKho.ColumnCount; i++)
                {
                    worksheet.Cells[1, i + 1] = dataGridViewNhapKho.Columns[i].HeaderText;
                }

                // Export content

                for (int i = 0; i < dataGridViewNhapKho.RowCount; i++)
                {
                    for (int j = 0; j < dataGridViewNhapKho.ColumnCount; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dataGridViewNhapKho.Rows[i].Cells[j].Value.ToString();
                    }
                }

                // Save work book
                workbook.SaveAs(fileNameNhapKho);
                workbook.Close();
                excel.Quit();
                MessageBox.Show("Xuất file Excels thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ToExcel_XuatKho(DataGridView dataGridViewXuatKho, string fileNameXuatKho)
        {
            Microsoft.Office.Interop.Excel.Application excel;
            Microsoft.Office.Interop.Excel.Workbook workbook;
            Microsoft.Office.Interop.Excel.Worksheet worksheet;

            try
            {
                excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = false;
                excel.DisplayAlerts = false;

                workbook = excel.Workbooks.Add(Type.Missing);

                worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets["Sheet1"];
                worksheet.Name = "Thống kê xuất kho";

                // Export header
                for (int i = 0; i < dataGridViewXuatKho.ColumnCount; i++)
                {
                    worksheet.Cells[1, i + 1] = dataGridViewXuatKho.Columns[i].HeaderText;
                }

                // Export content

                for (int i = 0; i < dataGridViewXuatKho.RowCount; i++)
                {
                    for (int j = 0; j < dataGridViewXuatKho.ColumnCount; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dataGridViewXuatKho.Rows[i].Cells[j].Value.ToString();
                    }
                }

                // Save work book
                workbook.SaveAs(fileNameXuatKho);
                workbook.Close();
                excel.Quit();
                MessageBox.Show("Xuất file Excels thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UserXuatNhapKhoControl_Load(object sender, EventArgs e)
        {
            dataGridViewNhapKho.DataSource = ThongKeBUS.Instance.getAllNhapKho();
            dataGridViewXuatKho.DataSource = ThongKeBUS.Instance.getAllXuatKho();
        }
    }
}
