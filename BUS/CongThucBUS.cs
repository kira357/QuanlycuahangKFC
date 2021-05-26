using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class CongThucBUS
    {
        private static CongThucBUS instance;
        public static CongThucBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CongThucBUS();
                }
                return instance;
            }
        }

        public DataTable getCongThuc(int maMonAn)
        {
            return CongThucDAO.Instance.getCongThuc(maMonAn);
        }
    }
}
