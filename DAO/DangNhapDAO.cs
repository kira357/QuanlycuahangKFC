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
    public class DangNhapDAO : DBConnect
    {
        private static DangNhapDAO instance;

        public static DangNhapDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DangNhapDAO();
                }
                return instance;
            }
        }
        public DataTable getDangNhap()
        {
            DataTable dt = new DataTable();

            try
            {
                Con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM DANGNHAP", Con);
                da.Fill(dt);
            }
            catch (Exception)
            {

            }

            Con.Close();
            return dt;

        }
        public DataTable DangNhap(DangNhapDTO DN)
        {
            DataTable dt = new DataTable();

            try
            {
                Con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM DANGNHAP WHERE TAIKHOAN= '" + DN.TaiKhoan + "' AND MATKHAU= '" + DN.MatKhau + "'", Con);
                da.Fill(dt);
            }
            catch (Exception)
            {
               
            }
            Con.Close();
            return dt;

        }
        public bool themTaiKhoan(DangNhapDTO dn)
        {
            try
            {
                Con.Open();
                string sql = "INSERT INTO DANGNHAP(TAIKHOAN,MATKHAU,QUYEN) VALUES(@TAIKHOAN ,@MATKHAU, @QUYEN)";
                SqlCommand cmd = new SqlCommand(sql, Con);
                cmd.Parameters.Add("@TAIKHOAN", SqlDbType.NVarChar).Value = dn.TaiKhoan;
                cmd.Parameters.Add("@MATKHAU", SqlDbType.NVarChar).Value = dn.MatKhau;
                cmd.Parameters.Add("@QUYEN", SqlDbType.NVarChar).Value = dn.Quyen;
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception)
            {
                return false;
            }
            Con.Close();

            return true;
        }

        public bool suaTaiKhoan(DangNhapDTO dn)
        {
            try
            {
                Con.Open();
                string sql = "UPDATE DANGNHAP SET MATKHAU=@MATKHAU, QUYEN=@QUYEN WHERE TAIKHOAN=@TAIKHOAN";
                SqlCommand cmd = new SqlCommand(sql, Con);
                
                cmd.Parameters.Add("@MATKHAU", SqlDbType.NVarChar).Value = dn.MatKhau;
                cmd.Parameters.Add("@QUYEN", SqlDbType.NVarChar).Value = dn.Quyen;
                cmd.Parameters.Add("@TAIKHOAN", SqlDbType.NVarChar).Value = dn.TaiKhoan;
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
        public bool xoaTaiKhoan(string taiKhoan)
        {
            try
            {
                Con.Open();
                string sql = "DELETE DANGNHAP WHERE TAIKHOAN = @TAIKHOAN";
                SqlCommand cmd = new SqlCommand(sql, Con);
                cmd.Parameters.Add("@TAIKHOAN", SqlDbType.NVarChar).Value = taiKhoan;
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                

                return false;
            }
            Con.Close();

            return true;

        }



    }
}
