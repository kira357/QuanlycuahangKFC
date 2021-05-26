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
    public class ChamCongDAO : DBConnect
    {
        private static ChamCongDAO instance;

        public static ChamCongDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ChamCongDAO();
                }
                return instance;
            }
        }
        public DataTable getChamCong()
        {
            DataTable dt = new DataTable();
            try
            {
                Con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT NV.MaNV, NV.Hodem, NV.Ten , NV.Gioitinh,Ngaylam,Catruc FROM dbo.NHANVIEN NV INNER JOIN CHAMCONG CC ON NV.MaNV = CC.MaNV", Con);
                da.Fill(dt);
                
            }
            catch (Exception)
            {

            }
            Con.Close();
            return dt;
        }
        public DataTable getChamCongTheoCaTruc(string caTruc)
        {
            DataTable dtChamcong = new DataTable();
            try
            {
                Con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT NV.MaNV, NV.Hodem, NV.Ten , NV.Gioitinh,Ngaylam,Catruc FROM dbo.NHANVIEN NV INNER JOIN CHAMCONG CC ON NV.MaNV = CC.MaNV WHERE Catruc = N'" + caTruc + "'", Con);
                da.Fill(dtChamcong);
                

            }
            catch (Exception)
            {

                Con.Close();
            }
            Con.Close();
            return dtChamcong;
        }

        public int getSoBuoi(int maNV, DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            int soBuoi = 0;
            try
            {
                Con.Open();
                string sql = "SELECT COUNT(*) FROM CHAMCONG WHERE MANV = " + maNV + " AND Ngaylam >= '" + ngayBatDau.Date + "'AND Ngaylam <= '" + ngayKetThuc.Date + "'  GROUP BY MaNV";
                SqlCommand cmd = new SqlCommand(sql, Con);
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    rd.Read();
                    soBuoi = rd.GetInt32(0);
                }
            }
            catch (Exception)
            {

                throw;
            }
            Con.Close();
            return soBuoi;
        }

        public DateTime getMinDate(int maNV)
        {
            DateTime ngay = new DateTime();
            try
            {
                Con.Open();
                string sql = "SELECT MIN(NGAYLAM) FROM CHAMCONG WHERE MANV = " + maNV;
                SqlCommand cmd = new SqlCommand(sql, Con);
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    rd.Read();
                    ngay = rd.GetDateTime(0).Date;
                }
            }
            catch (Exception)
            {

                Con.Close();
            }
            Con.Close();
            return ngay;
        }

        public bool chamCong(ChamCongDTO chamCong)
        {
            try
            {
                Con.Open();
                string sql = "INSERT INTO CHAMCONG(MANV,NGAYLAM,CATRUC) VALUES(@MaNV,@Ngaylam,@Catruc)";
                SqlCommand cmd = new SqlCommand(sql, Con);
                cmd.Parameters.Add("@MaNV", SqlDbType.Int).Value = chamCong.MaNV;
                cmd.Parameters.Add("@Ngaylam", SqlDbType.DateTime).Value = chamCong.NgayLam;
                cmd.Parameters.Add("@Catruc", SqlDbType.NVarChar).Value = chamCong.CaTruc;
                cmd.ExecuteNonQuery();

            }
            catch (Exception)
            {

                return false;
            }
            finally
            {
                Con.Close();
            }
            return true;

        }
        public bool xoaChamCong(ChamCongDTO chamCong)
        {
            try
            {
                Con.Open();
                string sql = "DELETE CHAMCONG WHERE MaNV=@MaNV AND Catruc=@Catruc AND Ngaylam=@Ngaylam ";
                SqlCommand cmd = new SqlCommand(sql, Con);
                cmd.Parameters.Add("@MaNV", SqlDbType.Int).Value = chamCong.MaNV;
                cmd.Parameters.Add("@Ngaylam", SqlDbType.DateTime).Value = chamCong.NgayLam;
                cmd.Parameters.Add("@Catruc", SqlDbType.NVarChar).Value = chamCong.CaTruc;
                cmd.ExecuteNonQuery();
                Con.Close();
            }
            catch (Exception)
            {

                return false;
            }
            return true;
        }

        public DataTable getChamCongTheoTimKiem(String tenNhanVien)
        {
            DataTable dtchammcong = new DataTable();
            try
            {
                Con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT Hodem +Ten AS HovaTen ,Gioitinh,Ngaylam,Catruc FROM NHANVIEN NV INNER JOIN CHAMCONG CC ON NV.MaNV = CC.MaNV WHERE Hodem LIKE N'%" + tenNhanVien + "%' OR Ten LIKE N'%" + tenNhanVien + "%'  OR Ngaylam LIKE N'%" + tenNhanVien + "%'", Con);
                da.Fill(dtchammcong);
            }
            catch (Exception)
            {

                Con.Close();
            }
            Con.Close();
            return dtchammcong;
        }

        public DataTable getChamCongTheoNgayLam(DateTime ngaylam)
        {
            DataTable dtChamcong = new DataTable();
            try
            {
                Con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT Hodem +Ten AS HovaTen ,Gioitinh,Ngaylam,Catruc FROM dbo.NHANVIEN NV INNER JOIN CHAMCONG CC ON NV.MaNV = CC.MaNV WHERE Ngaylam = N'" + ngaylam + "'", Con);
                da.Fill(dtChamcong);
            }
            catch (Exception)
            {

                Con.Close();
            }
            Con.Close();
            return dtChamcong;
        }

    }
}

