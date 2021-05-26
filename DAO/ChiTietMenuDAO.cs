using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ChiTietMenuDAO : DBConnect
    {
        private static ChiTietMenuDAO instance;
        public static ChiTietMenuDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ChiTietMenuDAO();
                }
                return instance;
            }
        }
        public ArrayList layMaMonAnTuMaMenu(int maMN)
        {
            ArrayList maMA = new ArrayList();
            try
            {
                Con.Open();
                string sql = "SELECT MAMONAN FROM CHITIETMENU WHERE MAMENU = @MAMENU";
                SqlCommand cmd = new SqlCommand(sql, Con);
                cmd.Parameters.Add("@MAMENU", SqlDbType.Int).Value = maMN;
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        maMA.Add(rd.GetInt32(0));
                    }
                }
            }
            catch (Exception)
            {

                Con.Close();
            }

            Con.Close();
            return maMA;
        }
        public int laySoLuongTuMaMonAnVaMaMenu(int maMA, int maMN)
        {
            int soLuong = 0;
            try
            {
                Con.Open();
                string sql = "SELECT SOLUONGMONAN FROM CHITIETMENU WHERE MAMONAN = @MAMONAN AND MAMENU = @MAMENU";
                SqlCommand cmd = new SqlCommand(sql, Con);
                cmd.Parameters.Add("@MAMONAN", SqlDbType.Int).Value = maMA;
                cmd.Parameters.Add("@MAMENU", SqlDbType.Int).Value = maMN;
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
    }
}
