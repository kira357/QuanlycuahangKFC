using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class NguyenLieuBUS
    {
        private static NguyenLieuBUS instance;
        public static NguyenLieuBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new NguyenLieuBUS();
                }
                return instance;
            }
        }
        public bool capNhat(int maNL, int soLuong, int heSo)
        {
            return NguyenLieuDAO.Instance.capNhat(maNL, soLuong, heSo);
        }
        public DataTable getAllNguyenLieu()
        {
            return NguyenLieuDAO.Instance.getAllNguyenLieu();
        }
        public bool setNhapNguyenLieu(int maNL, int soLuong)
        {
            return NguyenLieuDAO.Instance.setNhapNguyenLieu(maNL, soLuong);
        }
        public bool setXuatNguyenLieu(int maNL, int soLuong)
        {
            return NguyenLieuDAO.Instance.setXuatNguyenLieu(maNL, soLuong);
        }
    }
}
