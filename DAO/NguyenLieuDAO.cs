using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class NguyenLieuDAO : DBConnect
    {
        private static NguyenLieuDAO instance;
        public static NguyenLieuDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new NguyenLieuDAO();
                }
                return instance;
            }
        }
        public DataTable getAllNguyenLieu()
        {
            DataTable dt = new DataTable();

            try
            {
                Con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM NGUYENLIEU", Con);
                da.Fill(dt);
            }
            catch (Exception)
            {
                Con.Close();
            }

            Con.Close();
            return dt;
        }
        public bool setNhapNguyenLieu(int maNL, int soLuong)
        {
            try
            {
                Con.Open();
                string sql = "UPDATE NGUYENLIEU SET SOLUONG = SOLUONG + " + soLuong + " WHERE MANL = " + maNL;
                SqlCommand cmd = new SqlCommand(sql, Con);
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
        public bool setXuatNguyenLieu(int maNL, int soLuong)
        {
            try
            {
                Con.Open();
                string sql = "UPDATE NGUYENLIEU SET SOLUONG = SOLUONG - " + soLuong + " WHERE MANL = " + maNL;
                SqlCommand cmd = new SqlCommand(sql, Con);
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
        public bool capNhat(int maNL, int soLuong, int heSo)
        {
            try
            {
                Con.Open();
                string sql = "UPDATE NGUYENLIEU SET SOLUONG = SOLUONG - " + soLuong * heSo + " WHERE MANL = " + maNL;
                SqlCommand cmd = new SqlCommand(sql, Con);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                Con.Close();
            }
        }

    }
}
