using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietHoaDonDTO
    {
        private int maHD;
        private int maMN;
        private int soLuong;

        public int MaHD { get => maHD; set => maHD = value; }
        public int MaMN { get => maMN; set => maMN = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }

        public ChiTietHoaDonDTO(int maHD, int maMN, int soLuong)
        {
            this.maHD = maHD;
            this.maMN = maMN;
            this.soLuong = soLuong;
        }
    }
}
