using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class XuatKhoBUS
    {
        private static XuatKhoBUS instance;
        public static XuatKhoBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new XuatKhoBUS();
                }
                return instance;
            }
        }
        public DataTable getXuatKho()
        {
            return XuatKhoDAO.Instance.getXuatKho();
        }
        public bool setXuatKho(XuatKhoDTO a)
        {
            return XuatKhoDAO.Instance.setXuatKho(a);
        }
    }
}
