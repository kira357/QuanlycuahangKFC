using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class MenuDAO : DBConnect
    {
        private static MenuDAO instance;
        public static MenuDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MenuDAO();
                }
                return instance;
            }
        }
        public DataTable getAllMenu()
        {
            DataTable dtMenu = new DataTable();

            try
            {
                Con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM MENU", Con);
                da.Fill(dtMenu);
            }
            catch (Exception)
            {

                Con.Close();
            }
            Con.Close();

            Con.Close();
            return dtMenu;
        }
        public int getMaMenuTuTenMenu(string tenMN)
        {
            int soLuong = 0;
            try
            {
                Con.Open();
                string sql = "SELECT MAMENU FROM MENU WHERE TENMENU = @TENMENU";
                SqlCommand cmd = new SqlCommand(sql, Con);
                cmd.Parameters.Add("@TENMENU", SqlDbType.NVarChar).Value = tenMN;
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

        public string getTenMenuTuMaMenu(int maMN)
        {
            string tenMenu = "";
            try
            {
                Con.Open();
                string sql = "SELECT TENMENU FROM MENU WHERE MAMENU = @MAMENU";
                SqlCommand cmd = new SqlCommand(sql, Con);
                cmd.Parameters.Add("@MAMENU", SqlDbType.Int).Value = maMN;
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    rd.Read(); // read first row
                    tenMenu = rd.GetString(0);
                }
            }
            catch (Exception)
            {

                Con.Close();
            }

            Con.Close();
            return tenMenu;
        }

        public decimal getGiaTienTuMaMenu(int maMN)
        {
            int giaTien = 0;
            try
            {
                Con.Open();
                string sql = "SELECT DONGIA FROM MENU WHERE MAMENU = @MAMENU";
                SqlCommand cmd = new SqlCommand(sql, Con);
                cmd.Parameters.Add("@MAMENU", SqlDbType.Int).Value = maMN;
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    rd.Read(); // read first row
                    giaTien = rd.GetInt32(0);
                }
            }
            catch (Exception)
            {

                Con.Close();
            }

            Con.Close();
            return giaTien;
        }
    }
}
