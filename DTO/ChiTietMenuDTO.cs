using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class ChiTietMenuDTO
    {
        private int maMN;
        private int maMA;
        private int soLuong;

        public int MaMN { get => maMN; set => maMN = value; }
        public int MaMA { get => maMA; set => maMA = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }

        public ChiTietMenuDTO(int maMN, int maMA, int soLuong)
        {
            MaMN = maMN;
            MaMA = maMA;
            SoLuong = soLuong;
        }
    }
}
