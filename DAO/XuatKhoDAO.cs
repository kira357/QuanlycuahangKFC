using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class XuatKhoDAO : DBConnect
    {
        private static XuatKhoDAO instance;
        public static XuatKhoDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new XuatKhoDAO();
                }
                return instance;
            }
        }
        public DataTable getXuatKho()
        {
            DataTable dt = new DataTable();
            try
            {
                Con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT XK.MANL, NL.TENNL, XK.SOLUONG, NL.DONVITINH, XK.NGAYXUATKHO  FROM XUATKHO XK INNER JOIN NGUYENLIEU NL ON XK.MANL = NL.MANL", Con);
                da.Fill(dt);
            }
            catch (Exception)
            {

                Con.Close();
            }

            Con.Close();
            return dt;
        }

        public bool setXuatKho(XuatKhoDTO a)
        {
            try
            {
                Con.Open();
                string sql = "INSERT INTO XUATKHO(MANL, SOLUONG, NGAYXUATKHO) VALUES(@MANL, @SOLUONG, @NGAYXUATKHO)";
                SqlCommand cmd = new SqlCommand(sql, Con);
                cmd.Parameters.Add("@MANL", SqlDbType.Int).Value = a.MaNL;
                cmd.Parameters.Add("@SOLUONG", SqlDbType.Int).Value = a.SoLuong;
                cmd.Parameters.Add("@NGAYXUATKHO", SqlDbType.DateTime).Value = a.NgayXuatKho;

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
