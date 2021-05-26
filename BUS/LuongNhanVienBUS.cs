using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class LuongNhanVienBUS
    {
        private static LuongNhanVienBUS instance;
        public static LuongNhanVienBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LuongNhanVienBUS();
                }
                return instance;
            }
        }
        public DataTable getLuongNhanVien()
        {
            return LuongNhanVienDAO.Instance.getLuongNhanVien();
        }
        public DataTable getBacLuong()
        {
            return LuongNhanVienDAO.Instance.getBacLuong();
        }
        public bool themLuongNhanVien(MucLuongNhanVienDTO ML)
        {
            return LuongNhanVienDAO.Instance.themLuongNhanVien(ML);
        }
        public bool suaLuongNhanVien(MucLuongNhanVienDTO ML)
        {
            return LuongNhanVienDAO.Instance.suaLuongNhanVien(ML);
        }
        public bool xoaLuongNhanVien(MucLuongNhanVienDTO ML)
        {
            return LuongNhanVienDAO.Instance.xoaLuongNhanVien(ML);
        }
        public DataTable getLuongNhanVienTheoTimKiem(String tenNhanVien)
        {
            return LuongNhanVienDAO.Instance.getLuongNhanVienTheoTimKiem(tenNhanVien);
        }
    }
}
