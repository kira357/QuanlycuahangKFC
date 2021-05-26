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
    public partial class UserThongKeDoanhThuControl : UserControl
    {
        public UserThongKeDoanhThuControl()
        {
            InitializeComponent();
            dataGridView1.DataSource = ThongKeBUS.Instance.getAll();
            fillChart();
        }

        private void fillChart()
        {
            chart1.Series["Doanh thu"].Points.AddXY("1", "10000");
            chart1.Series["Doanh thu"].Points.AddXY("2", "30000");
            chart1.Series["Doanh thu"].Points.AddXY("3", "40000");
            chart1.Series["Doanh thu"].Points.AddXY("4", "20000");
            chart1.Series["Doanh thu"].Points.AddXY("5", "100000");
            chart1.Series["Doanh thu"].Points.AddXY("6", "70000");
            chart1.Series["Doanh thu"].Points.AddXY("7", "22000");
            chart1.Series["Doanh thu"].Points.AddXY("8", "200000");
            chart1.Series["Doanh thu"].Points.AddXY("9", "110000");
            chart1.Series["Doanh thu"].Points.AddXY("10", "98000");
            chart1.Series["Doanh thu"].Points.AddXY("11", "40000");
            chart1.Series["Doanh thu"].Points.AddXY("12", "21000");

        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {

            // Xuất ra thống kê từ ngày đến ngày
            dataGridView1.DataSource = ThongKeBUS.Instance.getDonHangTheoNgay(dtpTuNgay.Value, dtpDenNgay.Value);

            // Tổng tiền
            lblTongTien.Text = "0";
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                lblTongTien.Text = Convert.ToString(float.Parse(lblTongTien.Text) + float.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString()));
            }

            chart1.Series["Doanh thu"].XValueMember = "NGAY";
            chart1.Series["Doanh thu"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            chart1.Series["Doanh thu"].YValueMembers = "TONGTIEN";
            chart1.Series["Doanh thu"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            chart1.DataSource = ThongKeBUS.Instance.getDonHangTheoNgay(dtpTuNgay.Value, dtpDenNgay.Value);
        }

        private void ToExcel(DataGridView dataGridView, string fileName)
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
                worksheet.Name = "Thống kê doanh thu";

                // Export header
                for (int i = 0; i < dataGridView.ColumnCount; i++)
                {
                    worksheet.Cells[1, i + 1] = dataGridView.Columns[i].HeaderText;
                }

                // Export content

                for (int i = 0; i < dataGridView.RowCount; i++)
                {
                    for (int j = 0; j < dataGridView.ColumnCount; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dataGridView.Rows[i].Cells[j].Value.ToString();
                    }
                }

                // Save work book
                workbook.SaveAs(fileName);
                workbook.Close();
                excel.Quit();
                MessageBox.Show("Xuất file Excels thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ToExcel(dataGridView1, saveFileDialog1.FileName);
            }
        }
    }
}
