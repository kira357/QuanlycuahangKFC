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
    public class NhapKhoDAO : DBConnect
    {
        private static NhapKhoDAO instance;
        public static NhapKhoDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new NhapKhoDAO();
                }
                return instance;
            }
        }
        public DataTable getNhapKho()
        {
            DataTable dt = new DataTable();
            try
            {
                Con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT NK.MANL, NL.TENNL, NK.SOLUONG, NL.DONVITINH, NK.NGAYNHAPKHO  FROM NHAPKHO NK INNER JOIN NGUYENLIEU NL ON NK.MANL = NL.MANL", Con);
                da.Fill(dt);
            }
            catch (Exception)
            {

                Con.Close();
            }
            Con.Close();

            return dt;
        }

        public bool setNhapKho(NhapKhoDTO a)
        {
            try
            {
                Con.Open();
                string sql = "INSERT INTO NHAPKHO(MANL, SOLUONG, NGAYNHAPKHO) VALUES(@MANL, @SOLUONG, @NGAYNHAPKHO)";
                SqlCommand cmd = new SqlCommand(sql, Con);
                cmd.Parameters.Add("@MANL", SqlDbType.Int).Value = a.MaNL;
                cmd.Parameters.Add("@SOLUONG", SqlDbType.Int).Value = a.SoLuong;
                cmd.Parameters.Add("@NGAYNHAPKHO", SqlDbType.DateTime).Value = a.NgayNhap;

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


