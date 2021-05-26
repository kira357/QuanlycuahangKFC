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
    public class HoaDonBUS
    {
        private static HoaDonBUS instance;
        public static HoaDonBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new HoaDonBUS();
                }
                return instance;
            }
        }
        public bool themHoaDon(HoaDonDTO hoaDon)
        {
            return HoaDonDAO.Instance.themHoaDon(hoaDon);
        }
        public int getMaHoaDon(HoaDonDTO hoaDon)
        {
            return HoaDonDAO.Instance.getMaHoaDon(hoaDon);
        }
        public DataTable getHoaDonCanGiao()
        {
            return HoaDonDAO.Instance.getHoaDonCanGiao();
        }
        public DataTable getHoaDonDaGiao()
        {
            return HoaDonDAO.Instance.getHoaDonDaGiao();
        }
        public bool setThanhCongHoaDon(int maHD)
        {
            return HoaDonDAO.Instance.setThanhCongHoaDon(maHD);
        }
        public bool setThatBaiHoaDon(int maHD)
        {
            return HoaDonDAO.Instance.setThatBaiHoaDon(maHD);
        }
    }
}
