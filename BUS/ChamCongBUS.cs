using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class ChamCongBUS
    {
        private static ChamCongBUS instance;

        public static ChamCongBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ChamCongBUS();
                }
                return instance;
            }
        }

        public DataTable getChamCong()
        {
            return ChamCongDAO.Instance.getChamCong();
        }
        public DataTable getChamCongTheoCaTruc(string caTruc)
        {
            return ChamCongDAO.Instance.getChamCongTheoCaTruc(caTruc);
        }
        public bool chamCong(ChamCongDTO chamCong)
        {
            return ChamCongDAO.Instance.chamCong(chamCong);
        }
        public bool xoaChamCong(ChamCongDTO chamCong)
        {
            return ChamCongDAO.Instance.xoaChamCong(chamCong);
        }
        public DataTable getChamCongTheoTimKiem(String tenNhanVien)
        {
            return ChamCongDAO.Instance.getChamCongTheoTimKiem(tenNhanVien);
        }
        public DataTable getChamCongTheoNgayLam(DateTime ngaylam)
        {
            return ChamCongDAO.Instance.getChamCongTheoNgayLam(ngaylam);
        }

        public int getSoBuoi(int maNV, DateTime a, DateTime b)
        {
            return ChamCongDAO.Instance.getSoBuoi(maNV, a, b);
        }
        public DateTime getMinDate(int maNV)
        {
            return ChamCongDAO.Instance.getMinDate(maNV);
        }
    }
}
