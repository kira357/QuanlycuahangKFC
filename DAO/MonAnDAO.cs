using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DAO
{
    public class MonAnDAO : DBConnect
    {
        private static MonAnDAO instance;
        public static MonAnDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MonAnDAO();
                }
                return instance;
            }
        }
        public DataTable getAllMonAn()
        {
            DataTable dtMonAn = new DataTable();
            try
            {
                Con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM MONAN", Con);
                da.Fill(dtMonAn);
            }
            catch (Exception)
            {

                Con.Close();
            }
            Con.Close();
            return dtMonAn;
        }
        public int getSoLuong(int maMA)
        {
            int soLuong = 0;
            try
            {
                Con.Open();
                string sql = "SELECT SOLUONG FROM MONAN WHERE MAMONAN = @MAMA";
                SqlCommand cmd = new SqlCommand(sql, Con);
                cmd.Parameters.Add("@MAMA", SqlDbType.Int).Value = maMA;
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    rd.Read(); // read first row
                    soLuong = rd.GetInt32(0);
                }
            }
            catch (Exception)
            {

                Con.Close();
            }
            Con.Close();
            return soLuong;
        }

        public bool updateSoLuongMonAn(int maMA, int soLuong)
        {
            try
            {
                Con.Open();
                string sql = "UPDATE MONAN SET SOLUONG = SOLUONG + @SOLUONG WHERE MAMONAN=@MAMA";
                SqlCommand cmd = new SqlCommand(sql, Con);
                cmd.Parameters.Add("@MAMA", SqlDbType.Int).Value = maMA;
                cmd.Parameters.Add("@SOLUONG", SqlDbType.Int).Value = soLuong;
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                Con.Close();
                return false;
            }
            Con.Close();
            return true;
        }
        public string getTenMonAn(int maMA)
        {
            string ten = "";
            try
            {
                Con.Open();
                string sql = "SELECT TENMONAN FROM MONAN WHERE MAMONAN = @MAMA";
                SqlCommand cmd = new SqlCommand(sql, Con);
                cmd.Parameters.Add("@MAMA", SqlDbType.Int).Value = maMA;
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    rd.Read(); // read first row
                    ten = rd.GetString(0);
                }
            }
            catch (Exception)
            {

                Con.Close();
            }
            Con.Close();
            return ten;
        }
    }
}
