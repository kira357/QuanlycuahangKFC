using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using System.Data;

namespace BUS
{
    public class NhanVienBUS
    {
        private static NhanVienBUS instance;
        public static NhanVienBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new NhanVienBUS();
                }
                return instance;
            }
        }
        public DataTable getNhanVien() 
        {  
            return NhanVienDAO.Instance.getNhanVien();
        }
        public bool themNhanVien(NhanVienDTO nv)
        {
            return NhanVienDAO.Instance.themNhanVien(nv);    
        }
        public bool suaNhanVien(NhanVienDTO nv)
        {
            return NhanVienDAO.Instance.suaNhanVien(nv);
        }
        public bool xoaNhanVien(int maNV)
        {
            return NhanVienDAO.Instance.xoaNhanVien(maNV);
        }
        public DataTable timKiemNhanVien(string nv)
        {
            return NhanVienDAO.Instance.timKiemNhanVien(nv);
        }
        public int getMaNhanVien(string hoDem, string ten,string hinh, DateTime ngaySinh, string gioiTinh,string queQuan,string sDT,string eMail,string chucVu)
        {
            return NhanVienDAO.Instance.getMaNhanVien(hoDem, ten, hinh, ngaySinh, gioiTinh, queQuan, sDT, eMail, chucVu);
        }
        public string getImage(int ma)
        {
            return NhanVienDAO.Instance.getImage(ma);
        }
    }
}
