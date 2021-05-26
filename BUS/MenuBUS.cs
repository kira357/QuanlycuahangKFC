using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
namespace BUS
{
    public class MenuBUS
    {
        private static MenuBUS instance;
        public static MenuBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MenuBUS();
                }
                return instance;
            }
        }

        public int getMaMenuTuTenMenu(string tenMenu)
        {
            return MenuDAO.Instance.getMaMenuTuTenMenu(tenMenu);
        }

        public string getTenMenuTuMaMenu(int maMN)
        {
            return MenuDAO.Instance.getTenMenuTuMaMenu(maMN);
        }
        public decimal getGiaTienTuMaMenu(int maMN)
        {
            return MenuDAO.Instance.getGiaTienTuMaMenu(maMN);
        }
    }
}
