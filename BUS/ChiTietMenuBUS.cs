using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
namespace BUS
{
    public class ChiTietMenuBUS
    {
        private static ChiTietMenuBUS instance;
        public static ChiTietMenuBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ChiTietMenuBUS();
                }
                return instance;
            }
        }
        public ArrayList layMaMonAnTuMaMenu(int maMN)
        {
            return ChiTietMenuDAO.Instance.layMaMonAnTuMaMenu(maMN);
        }

        public int laySoLuongTuMaMonAnVaMaMenu(int maMA, int maMN)
        {
            return ChiTietMenuDAO.Instance.laySoLuongTuMaMonAnVaMaMenu(maMA, maMN);
        }
    }
}
