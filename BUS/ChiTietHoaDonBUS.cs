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
    public class ChiTietHoaDonBUS
    {
        private static ChiTietHoaDonBUS instance;
        public static ChiTietHoaDonBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ChiTietHoaDonBUS();
                }
                return instance;
            }
        }
        public DataTable getCTHD(int maDH)
        {
            return ChiTietHoaDonDAO.Instance.getCTHD(maDH);
        }
        public void themChiTietHoaDon(ChiTietHoaDonDTO CTHD)
        {
            ChiTietHoaDonDAO.Instance.themChiTietHoaDon(CTHD);
        }
    }
}
