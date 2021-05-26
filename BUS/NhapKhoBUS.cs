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
    public class NhapKhoBUS
    {
        private static NhapKhoBUS instance;
        public static NhapKhoBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new NhapKhoBUS();
                }
                return instance;
            }
        }
        public DataTable getNhapKho()
        {
            return NhapKhoDAO.Instance.getNhapKho();
        }
        public bool setNhapKho(NhapKhoDTO a)
        {
            return NhapKhoDAO.Instance.setNhapKho(a);
        }
    }
}