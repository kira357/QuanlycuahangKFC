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
    public class DangNhapBUS
    {
        private static DangNhapBUS instance;
        public static DangNhapBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DangNhapBUS();
                }
                return instance;
            }
        }

        public DataTable DangNhap(DangNhapDTO DN)
        {
            return DangNhapDAO.Instance.DangNhap(DN);
        }
        public bool themTaiKhoan(DangNhapDTO dn)
        {
            return DangNhapDAO.Instance.themTaiKhoan(dn);
        }
        public bool suaTaiKhoan(DangNhapDTO dn)
        {
            return DangNhapDAO.Instance.suaTaiKhoan(dn);
        }
        public bool xoaTaiKhoan(string taiKhoan)
        {
            return DangNhapDAO.Instance.xoaTaiKhoan(taiKhoan);
        }
        public DataTable getDangNhap()
        {
            return DangNhapDAO.Instance.getDangNhap();
        }
    }
}