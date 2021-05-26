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
    public class TraLuongDAO : DBConnect
    {
        private static TraLuongDAO instance;

        public static TraLuongDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TraLuongDAO();
                }
                return instance;
            }
        }
        public DataTable getLuongNhanVien()
        {
            DataTable dtthongke = new DataTable();
            try
            {
                Con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT NV.MaNV,Hodem + Ten AS 'Ho va Ten ',MLNV.BACLUONG,LUONGCB,HESOLUONG FROM NHANVIEN NV INNER JOIN MUCLUONGNHANVIEN MLNV ON NV.MaNV =MLNV.MaNV INNER JOIN LUONG L ON L.BACLUONG = MLNV.BACLUONG", Con);
                da.Fill(dtthongke);
            }
            catch (Exception)
            {

                Con.Close();
            }

            Con.Close();
            return dtthongke;

        }


        public DataTable getThongKe()
        {
            DataTable dtthongke = new DataTable();
            try
            {

                Con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT Hodem + Ten AS 'Ho va Ten ',HESOLUONG,LUONGCB ,LUONGTONG ,NGAYBATDAU,NGAYKETTHUC  FROM NHANVIEN NV INNER JOIN TRALUONG TL ON NV.MaNV = TL.MaNV INNER JOIN MUCLUONGNHANVIEN MLNV ON NV.MaNV =MLNV.MaNV INNER JOIN LUONG L ON L.BACLUONG = MLNV.BACLUONG", Con);
                da.Fill(dtthongke);
            }
            catch (Exception)
            {

                Con.Close();
            }
            Con.Close();
            return dtthongke;

        }
        public bool traluong(TraLuongDTO tk)
        {
            try
            {
                Con.Open();
                string sql = "INSERT INTO TRALUONG(MaNV,LUONGTONG,NGAYBATDAU,NGAYKETTHUC) VALUES(@MaNV,@LUONGTONG,@NGAYBATDAU,@NGAYKETTHUC)";
                SqlCommand cmd = new SqlCommand(sql, Con);
                cmd.Parameters.Add("@MaNV", SqlDbType.Int).Value = tk.MaNV;
                cmd.Parameters.Add("@LUONGTONG", SqlDbType.Float).Value = tk.LuongTong;
                cmd.Parameters.Add("@NGAYBATDAU", SqlDbType.DateTime).Value = tk.NgayBatDau;
                cmd.Parameters.Add("@NGAYKETTHUC", SqlDbType.DateTime).Value = tk.NgayTraLuong;
                cmd.ExecuteNonQuery();
                Con.Close();
            }
            catch (Exception)
            {
                Con.Close();

                return false;
            }
            Con.Close();

            return true;

        }
        public DataTable getLuongNhanVienTheoTimKiem(string ten)
        {
            DataTable dtluong = new DataTable();

            try
            {
                Con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT NV.MaNV, Ten,MLNV.BACLUONG,LUONGCB,MLNV.HESOLUONG  FROM NHANVIEN NV INNER JOIN MUCLUONGNHANVIEN MLNV ON NV.MaNV = MLNV.MaNV INNER JOIN LUONG L ON MLNV.BACLUONG=L.BACLUONG WHERE Hodem LIKE N'%" + ten + "%' OR Ten LIKE N'%" + ten + "%'", Con);
                da.Fill(dtluong);
            }
            catch (Exception)
            {

                Con.Close();
            }

            Con.Close();
            return dtluong;
        }

        public DateTime getNgạyKetThuc(int maNV)
        {
            DateTime ngayKetThuc = DateTime.MinValue;
            Con.Open();
            try
            {
                string sql = "SELECT MAX(NGAYKETTHUC) FROM TRALUONG WHERE MANV = " + maNV;
                SqlCommand cmd = new SqlCommand(sql, Con);
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    rd.Read();
                    ngayKetThuc = rd.GetDateTime(0).Date;
                }
            }
            catch (Exception)
            {

                Con.Close();
            }

            Con.Close();
            return ngayKetThuc;
        }

    }
}
