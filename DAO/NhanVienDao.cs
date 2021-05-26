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
    public class NhanVienDAO : DBConnect
    {
        private static NhanVienDAO instance;

        public static NhanVienDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new NhanVienDAO();
                }
                return instance;
            }
        }
        public DataTable getNhanVien()
        {
            DataTable dtNhanvien = new DataTable();
            try
            {
                Con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT MANV, HODEM, TEN, NGAYSINH, GIOITINH, QUEQUAN, SDT, EMAIL, CHUCVU FROM NHANVIEN", Con);
                da.Fill(dtNhanvien);
            }
            catch (Exception)
            {

                Con.Close();
            }
            Con.Close();
            return dtNhanvien;

        }
        public string getImage(int MaNV)
        {
            string Hinh = "\\Resources\\image.jpg";
            try
            {
                Con.Open();
                string sql = "SELECT HINH FROM NHANVIEN WHERE MANV = " + MaNV.ToString();
                SqlCommand cmd = new SqlCommand(sql, Con);
               
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    rd.Read(); // read first row
                    Hinh = rd.GetString(0);
                    if (Hinh.Equals(""))
                    {
                        Hinh = "\\Resources\\image.jpg";
                    }
                }
            }
            catch (Exception)
            {

                Con.Close();
            }
            Con.Close();

            return Hinh;
        }
            public bool themNhanVien(NhanVienDTO nv)
        {
            try
            {
                Con.Open();
                string sql = "INSERT INTO NHANVIEN(Hodem,Ten,Hinh,Ngaysinh,Gioitinh,Quequan,SDT,Email,Chucvu) VALUES(@Hodem ,@Ten, @Hinh, @Ngaysinh, @Gioitinh, @Quequan, @SDT, @Email,@Chucvu)";
                SqlCommand cmd = new SqlCommand(sql, Con);
                cmd.Parameters.Add("@Hodem", SqlDbType.NVarChar).Value = nv.HoDem;
                cmd.Parameters.Add("@Ten", SqlDbType.NVarChar).Value = nv.Ten;
                cmd.Parameters.Add("@Hinh", SqlDbType.NVarChar).Value = nv.Hinh;
                cmd.Parameters.Add("@Ngaysinh", SqlDbType.DateTime).Value = nv.NgaySinh;
                cmd.Parameters.Add("@Gioitinh", SqlDbType.NVarChar).Value = nv.GioiTinh;
                cmd.Parameters.Add("@Quequan", SqlDbType.NVarChar).Value = nv.QueQuan;
                cmd.Parameters.Add("@SDT", SqlDbType.VarChar).Value = nv.SDT;
                cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = nv.EMail;
                cmd.Parameters.Add("@Chucvu", SqlDbType.NVarChar).Value = nv.ChucVu;
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception)
            {
                Con.Close();

                return false;
            }
            Con.Close();

            return true;
        }
        public bool suaNhanVien(NhanVienDTO nv)
        {
            try
            {
                Con.Open();
                string sql = "UPDATE NHANVIEN SET Hodem=@Hodem, Ten=@Ten, Hinh=@Hinh, Ngaysinh=@Ngaysinh, Gioitinh=@Gioitinh, Quequan=@Quequan, SDT=@SDT, Email=@Email, Chucvu=@Chucvu WHERE MaNV=@MaNV";
                SqlCommand cmd = new SqlCommand(sql, Con);
                cmd.Parameters.Add("@MaNV", SqlDbType.Int).Value = nv.MaNV;
                cmd.Parameters.Add("@Hodem", SqlDbType.NVarChar).Value = nv.HoDem;
                cmd.Parameters.Add("@Ten", SqlDbType.NVarChar).Value = nv.Ten;
                cmd.Parameters.Add("@Hinh", SqlDbType.NVarChar).Value = nv.Hinh;
                cmd.Parameters.Add("@Ngaysinh", SqlDbType.DateTime).Value = nv.NgaySinh;
                cmd.Parameters.Add("@Gioitinh", SqlDbType.NVarChar).Value = nv.GioiTinh;
                cmd.Parameters.Add("@Quequan", SqlDbType.NVarChar).Value = nv.QueQuan;
                cmd.Parameters.Add("@SDT", SqlDbType.VarChar).Value = nv.SDT;
                cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = nv.EMail;
                cmd.Parameters.Add("@Chucvu", SqlDbType.NVarChar).Value = nv.ChucVu;
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
        public bool xoaNhanVien(int maNV)
        {
            try
            {
                Con.Open();
                string sql = "DELETE NHANVIEN WHERE MaNV = @MaNV";
                SqlCommand cmd = new SqlCommand(sql, Con);
                cmd.Parameters.Add("@MaNV", SqlDbType.Int).Value = maNV;
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
        public DataTable timKiemNhanVien(string ten)
        {
            DataTable dtNhanvien = new DataTable();
            try
            {
                Con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM NHANVIEN WHERE Hodem LIKE N'%" + ten + "%' OR Ten LIKE N'%" + ten + "%'  OR Chucvu LIKE N'%" + ten + "%'", Con);
                da.Fill(dtNhanvien);
            }
            catch (Exception)
            {

                Con.Close();
            }

            return dtNhanvien;
        }
        public int getMaNhanVien(string hoDem, string ten, string hinh, DateTime ngaySinh, string gioiTinh, string queQuan, string sDT, string eMail, string chucVu)
        {
            int maNV = -1;
            try
            {
                Con.Open();
                string sql = "SELECT MaNV FROM NHANVIEN WHERE Hodem=@Hodem and Ten=@Ten and Hinh=@Hinh and Ngaysinh=@Ngaysinh and Gioitinh=@Gioitinh and Quequan=@Quequan and SDT=@SDT and Email=@Email and Chucvu=@Chucvu";
                SqlCommand cmd = new SqlCommand(sql, Con);
                cmd.Parameters.Add("@Hodem", SqlDbType.NVarChar).Value = hoDem;
                cmd.Parameters.Add("@Ten", SqlDbType.NVarChar).Value = ten;
                cmd.Parameters.Add("@Hinh", SqlDbType.NVarChar).Value = hinh;
                cmd.Parameters.Add("@Ngaysinh", SqlDbType.DateTime).Value = ngaySinh;
                cmd.Parameters.Add("@Gioitinh", SqlDbType.NVarChar).Value = gioiTinh;
                cmd.Parameters.Add("@Quequan", SqlDbType.NVarChar).Value = queQuan;
                cmd.Parameters.Add("@SDT", SqlDbType.VarChar).Value = sDT;
                cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = eMail;
                cmd.Parameters.Add("@Chucvu", SqlDbType.NVarChar).Value = chucVu;
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    rd.Read(); // read first row
                    maNV = rd.GetInt32(0);
                }
            }
            catch (Exception)
            {

                Con.Close();
            }
            Con.Close();
           
            return maNV;
        }
    }
}
