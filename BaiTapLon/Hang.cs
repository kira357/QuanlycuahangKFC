using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLon
{
    public class Hang
    {
        private int maMN;
        private int soLuong;

        public int MaMN { get => maMN; set => maMN = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }

        public Hang(int maMN, int soLuong)
        {
            this.maMN = maMN;
            this.soLuong = soLuong;
        }
        public bool kiemTra(Hang hang)
        {
            if (this.maMN == hang.MaMN)
            {
                return true;
            }
            return false;
        }
    }
}
