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
    public class HoaDonDAO : DBConnect
    {
        private static HoaDonDAO instance;
        public static HoaDonDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new HoaDonDAO();
                }
                return instance;
            }
        }
        public bool themHoaDon(HoaDonDTO hoaDon)
        {
            try
            {
                Con.Open();
                string sql = "INSERT INTO HOADON(TONGTIEN, NGAY, TENKHACH, SDT, DIACHI, TRANGTHAI, GIAOHANG) VALUES(@TONGTIEN, @NGAY, @TENKHACH, @SDT, @DIACHI, @TRANGTHAI, @GIAOHANG)";
                SqlCommand cmd = new SqlCommand(sql, Con);
                cmd.Parameters.Add("@TONGTIEN", SqlDbType.Money).Value = hoaDon.TongTien;
                cmd.Parameters.Add("@NGAY", SqlDbType.DateTime).Value = hoaDon.Ngay;
                cmd.Parameters.Add("@TENKHACH", SqlDbType.NVarChar).Value = hoaDon.TenKhach;
                cmd.Parameters.Add("@SDT", SqlDbType.VarChar).Value = hoaDon.Sdt;
                cmd.Parameters.Add("@DIACHI", SqlDbType.NVarChar).Value = hoaDon.DiaChi;
                cmd.Parameters.Add("@TRANGTHAI", SqlDbType.NVarChar).Value = hoaDon.TrangThai;
                cmd.Parameters.Add("@GIAOHANG", SqlDbType.Bit).Value = hoaDon.GiaoHang;
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
        public int getMaHoaDon(HoaDonDTO hoaDon)
        {
            int maHD = -1;
            try
            {
                Con.Open();
                string sql = "SELECT MAHD FROM HOADON WHERE TONGTIEN = @TONGTIEN AND NGAY=@NGAY AND TENKHACH=@TENKHACH AND SDT=@SDT AND DIACHI=@DIACHI AND TRANGTHAI=@TRANGTHAI AND GIAOHANG=@GIAOHANG";
                SqlCommand cmd = new SqlCommand(sql, Con);
                cmd.Parameters.Add("@TONGTIEN", SqlDbType.Money).Value = hoaDon.TongTien;
                cmd.Parameters.Add("@NGAY", SqlDbType.DateTime).Value = hoaDon.Ngay;
                cmd.Parameters.Add("@TENKHACH", SqlDbType.NVarChar).Value = hoaDon.TenKhach;
                cmd.Parameters.Add("@SDT", SqlDbType.VarChar).Value = hoaDon.Sdt;
                cmd.Parameters.Add("@DIACHI", SqlDbType.NVarChar).Value = hoaDon.DiaChi;
                cmd.Parameters.Add("@TRANGTHAI", SqlDbType.Bit).Value = hoaDon.TrangThai;
                cmd.Parameters.Add("@GIAOHANG", SqlDbType.Bit).Value = hoaDon.GiaoHang;
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    rd.Read(); // read first row
                    maHD = rd.GetInt32(0);
                }
            }
            catch (Exception)
            {

                Con.Close();
            }
            Con.Close();

            return maHD;
        }
        public DataTable getHoaDonCanGiao()
        {
            DataTable dtHoaDon = new DataTable();
            try
            {
                Con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM HOADON WHERE TRANGTHAI = N'Đang giao' AND GIAOHANG = 'True'", Con);
                da.Fill(dtHoaDon);
            }
            catch (Exception)
            {

                Con.Close();
            }

            Con.Close();
            return dtHoaDon;
        }
        public DataTable getHoaDonDaGiao()
        {
            DataTable dtHoaDon = new DataTable();
            try
            {
                Con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM HOADON WHERE TRANGTHAI = N'Thành công' OR TRANGTHAI = N'Thất bại'", Con);
                da.Fill(dtHoaDon);
            }
            catch (Exception)
            {

                Con.Close();

            }

            Con.Close();
            return dtHoaDon;
        }

        public bool setThanhCongHoaDon(int maHD)
        {
            try
            {
                Con.Open();
                string sql = "UPDATE HOADON SET TRANGTHAI = N'Thành công' WHERE MAHD = " + maHD;
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
        public bool setThatBaiHoaDon(int maHD)
        {
            try
            {
                Con.Open();
                string sql = "UPDATE HOADON SET TRANGTHAI = N'Thất bại' WHERE MAHD = " + maHD;
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
