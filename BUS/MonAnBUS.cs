using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
namespace BUS
{
    public class MonAnBUS
    {
        private static MonAnBUS instance;
        public static MonAnBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MonAnBUS();
                }
                return instance;
            }
        }
        public DataTable getAllMonAn()
        {
            return MonAnDAO.Instance.getAllMonAn();
        }

        public int getSoLuong(int maMA)
        {
            return MonAnDAO.Instance.getSoLuong(maMA);
        }

        public bool updateSoLuongMonAn(int maMA, int soLuong)
        {
            return MonAnDAO.Instance.updateSoLuongMonAn(maMA, soLuong);
        }
        public string getTenMonAn(int maMA)
        {
            return MonAnDAO.Instance.getTenMonAn(maMA);
        }
    }
}
