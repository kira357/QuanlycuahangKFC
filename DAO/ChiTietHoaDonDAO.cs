using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class ChiTietHoaDonDAO : DBConnect
    {
        private static ChiTietHoaDonDAO instance;
        public static ChiTietHoaDonDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ChiTietHoaDonDAO();
                }
                return instance;
            }
        }
        public DataTable getCTHD(int maHD)
        {
            DataTable dtCTDH = new DataTable();
            try
            {
                Con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT MAHD, MENU.TENMENU, SOLUONG  FROM CHITIETHOADON CTHD INNER JOIN MENU ON CTHD.MAMENU = MENU.MAMENU WHERE MAHD = " + maHD , Con);
                da.Fill(dtCTDH);
            }
            catch (Exception)
            {
                Con.Close();
            }
            Con.Close();
            return dtCTDH;
        }
        public void themChiTietHoaDon(ChiTietHoaDonDTO CTHD)
        {
            try
            {
                Con.Open();
                string sql = "INSERT INTO CHITIETHOADON(MAMENU, MAHD, SOLUONG) VALUES(@MAMN, @MAHD, @SOLUONG)";
                SqlCommand cmd = new SqlCommand(sql, Con);
                cmd.Parameters.Add("@MAMN", SqlDbType.Int).Value = CTHD.MaMN;
                cmd.Parameters.Add("@MAHD", SqlDbType.Int).Value = CTHD.MaHD;
                cmd.Parameters.Add("@SOLUONG", SqlDbType.Int).Value = CTHD.SoLuong;
                cmd.ExecuteNonQuery();  
            }
            catch (Exception)
            {
                Con.Close();
            }
            Con.Close();
        }
    }
}
