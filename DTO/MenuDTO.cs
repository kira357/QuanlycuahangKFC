using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class MenuDTO
    {
        private int maMN;
        private string tenMenu;
        private float giaTien;

        public int MaMN { get => maMN; set => maMN = value; }
        public string TenMenu { get => tenMenu; set => tenMenu = value; }
        public float GiaTien { get => giaTien; set => giaTien = value; }

        public MenuDTO(int maMN, string tenMenu, float giaTien)
        {
            this.maMN = maMN;
            this.tenMenu = tenMenu;
            this.giaTien = giaTien;
        }
    }
}
