using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
namespace BUS
{
    public class ThongKeBUS
    {
        private static ThongKeBUS instance;

        public static ThongKeBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ThongKeBUS();
                }
                return instance;
            }
        }
        public DataTable getAll()
        {
            return ThongKeDAO.Instance.getData();
        }

        public DataTable getDonHangTheoNgay(DateTime TuNgay, DateTime DenNgay)
        {
            return ThongKeDAO.Instance.getDonHangTheoNgay(TuNgay, DenNgay);
        }
        public DataTable getAllNhapKho()
        {
            return ThongKeDAO.Instance.getData_NhapKho();
        }
        public DataTable getAllXuatKho()
        {
            return ThongKeDAO.Instance.getData_XuatKho();
        }
        public DataTable getNhap(DateTime TuNgay1, DateTime DenNgay1)
        {
            return ThongKeDAO.Instance.getNhap(TuNgay1, DenNgay1);
        }
        public DataTable getXuat(DateTime TuNgay2, DateTime DenNgay2)
        {
            return ThongKeDAO.Instance.getXuat(TuNgay2, DenNgay2);
        }

        public DataTable getHoaDonTheoThang()
        {
            return ThongKeDAO.Instance.getDonHangTheoThang();
        }
    }
}
