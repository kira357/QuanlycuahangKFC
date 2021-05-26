using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ThongKeDAO : DBConnect
    {
        private static ThongKeDAO instance;

        public static ThongKeDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ThongKeDAO();
                }
                return instance;
            }
        }

        public DataTable getData()
        {
            DataTable dt = new DataTable();
            try
            {
                Con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT MAHD, NGAY, TONGTIEN FROM HOADON", Con);
                da.Fill(dt);
            }
            catch (Exception)
            {

                Con.Close();
            }

            Con.Close();
            return dt;
        }

        public DataTable getDonHangTheoNgay(DateTime tuNgay, DateTime denNgay)
        {
            DataTable dt = new DataTable();
            try
            {
                Con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT MAHD, NGAY, TONGTIEN FROM HOADON WHERE NGAY >= '" + tuNgay + "' AND NGAY <= '" + denNgay + "'", Con);
                da.Fill(dt);
            }
            catch (Exception)
            {

                Con.Close();
            }

            Con.Close();
            return dt;

        }
        public DataTable getDonHangTheoThang()
        {
            DataTable dt = new DataTable();
            try
            {
                Con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT MONTH(NGAY) AS THANG, SUM(TONGTIEN) AS TONGTIEN FROM HOADON GROUP BY MONTH(NGAY) ORDER BY MONTH(NGAY)", Con);
                da.Fill(dt);
            }
            catch (Exception)
            {

                Con.Close();
            }

            Con.Close();
            return dt;
        }

        public DataTable getData_NhapKho()
        {
            DataTable dt = new DataTable();
            try
            {
                Con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM NHAPKHO", Con);
                da.Fill(dt);
            }
            catch (Exception)
            {

                Con.Close();
            }

            Con.Close();
            return dt;
        }

        public DataTable getData_XuatKho()
        {
            DataTable dt = new DataTable();
            try
            {
                Con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM XUATKHO", Con);
                da.Fill(dt);
            }
            catch (Exception)
            {

                Con.Close();
            }

            Con.Close();
            return dt;
        }


        public DataTable getNhap(DateTime tuNgay, DateTime denNgay)
        {
            DataTable dt = new DataTable();
            try
            {
                Con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM NHAPKHO WHERE NGAYNHAPKHO >= '" + tuNgay + "' AND NGAYNHAPKHO <= '" + denNgay + "'", Con);
                da.Fill(dt);
            }
            catch (Exception)
            {

                Con.Close();
            }

            Con.Close();
            return dt;
        }
        public DataTable getXuat(DateTime tuNgay, DateTime denNgay)
        {
            DataTable dt = new DataTable();
            try
            {
                Con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM XUATKHO WHERE NGAYXUATKHO >= '" + tuNgay + "' AND NGAYXUATKHO <= '" + denNgay + "'", Con);
                da.Fill(dt);
            }
            catch (Exception)
            {

                Con.Close();
            }

            Con.Close();
            return dt;
        }
    }
}
