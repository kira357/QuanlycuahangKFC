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
    public class TraLuongBUS
    {
        private static TraLuongBUS instance;

        public static TraLuongBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TraLuongBUS();
                }
                return instance;
            }
        }

        public DataTable getLuongNhanVien()
        {
            return TraLuongDAO.Instance.getLuongNhanVien();
        }
        public bool Traluong(TraLuongDTO tk)
        {
            return TraLuongDAO.Instance.traluong(tk);
        }
        public DataTable getThongKe()
        {
            return TraLuongDAO.Instance.getThongKe();
        }
        public DataTable getLuongNhanVienTheoTimKiem(string ten)
        {
            return TraLuongDAO.Instance.getLuongNhanVienTheoTimKiem(ten);
        }
        public DateTime getNgạyKetThuc(int maNV)
        {
            return TraLuongDAO.Instance.getNgạyKetThuc(maNV);
        }


    }

}
