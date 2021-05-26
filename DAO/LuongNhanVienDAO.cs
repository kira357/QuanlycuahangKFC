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
    public class LuongNhanVienDAO : DBConnect
    {
        private static LuongNhanVienDAO instance;
        public static LuongNhanVienDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LuongNhanVienDAO();
                }
                return instance;
            }
        }
        public DataTable getLuongNhanVien()
        {
            DataTable dtChamcong = new DataTable();

            try
            {
                Con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT NV.MANV,NV.HODEM, NV.TEN,L.LUONGCB ,MLNV.BACLUONG,MLNV.HESOLUONG  FROM MUCLUONGNHANVIEN MLNV INNER JOIN LUONG L ON MLNV.BACLUONG = L.BACLUONG INNER JOIN NHANVIEN NV ON MLNV.MANV = NV.MANV", Con);
                da.Fill(dtChamcong);
            }
            catch (Exception)
            {

                Con.Close();
            }

            Con.Close();
            return dtChamcong;
        }

        public DataTable getBacLuong()
        {
            DataTable dt = new DataTable();
            try
            {
                Con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT DISTINCT BACLUONG FROM LUONG", Con);
                da.Fill(dt);
            }
            catch (Exception)
            {

                Con.Close();
            }

            Con.Close();
            return dt;
        }
        public bool themLuongNhanVien(MucLuongNhanVienDTO ML)
        {
            try
            {
                Con.Open();
                string sql = "INSERT INTO MUCLUONGNHANVIEN(MANV,BACLUONG,HESOLUONG) VALUES(@MaNV,@BACLUONG,@HESOLUONG)";
                SqlCommand cmd = new SqlCommand(sql, Con);
                cmd.Parameters.Add("@MaNV", SqlDbType.Int).Value = ML.MaNV;
                cmd.Parameters.Add("@BACLUONG", SqlDbType.Int).Value = ML.BacLuong;
                cmd.Parameters.Add("@HESOLUONG", SqlDbType.Float).Value = ML.HeSoLuong;
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
        public bool suaLuongNhanVien(MucLuongNhanVienDTO ML)
        {
            try
            {
                Con.Open();
                string sql = "UPDATE MUCLUONGNHANVIEN SET BACLUONG=@BACLUONG,HESOLUONG=@HESOLUONG WHERE MaNV=@MaNV ";
                SqlCommand cmd = new SqlCommand(sql, Con);
                cmd.Parameters.Add("@MaNV", SqlDbType.Int).Value = ML.MaNV;
                cmd.Parameters.Add("@BACLUONG", SqlDbType.Int).Value = ML.BacLuong;
                cmd.Parameters.Add("@HESOLUONG", SqlDbType.Float).Value = ML.HeSoLuong;
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
        public bool xoaLuongNhanVien(MucLuongNhanVienDTO ML)
        {
            try
            {
                Con.Open();
                string sql = "DELETE MUCLUONGNHANVIEN WHERE MANV=@MaNV AND BACLUONG=@BACLUONG";
                SqlCommand cmd = new SqlCommand(sql, Con);
                cmd.Parameters.Add("@MaNV", SqlDbType.Int).Value = ML.MaNV;
                cmd.Parameters.Add("@BACLUONG", SqlDbType.Int).Value = ML.BacLuong;
                cmd.ExecuteNonQuery();

            }
            catch (Exception)
            {
                Con.Close();

                return false;

            }
            return true;
        }
        public DataTable getLuongNhanVienTheoTimKiem(String tenNhanVien)
        {
            DataTable dtluong = new DataTable();

            try
            {
                Con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT NV.MANV,NV.HODEM, NV.TEN,MLNV.BACLUONG,MLNV.HESOLUONG  FROM NHANVIEN NV INNER JOIN MUCLUONGNHANVIEN MLNV ON NV.MANV = MLNV.MANV WHERE HODEM LIKE N'%" + tenNhanVien + "%' OR TEN LIKE N'%" + tenNhanVien + "%'", Con);
                da.Fill(dtluong);
            }
            catch (Exception)
            {

                Con.Close();
            }

            Con.Close();
            return dtluong;
        }
    }
}
