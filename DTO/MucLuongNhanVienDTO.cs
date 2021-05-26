using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class MucLuongNhanVienDTO
    {
        private
        int maNV;
        int bacLuong;
        float heSoLuong;

        public int MaNV { get => maNV; set => maNV = value; }
        public int BacLuong { get => bacLuong; set => bacLuong = value; }
        public float HeSoLuong { get => heSoLuong; set => heSoLuong = value; }
        public MucLuongNhanVienDTO(int maNV, int bacLuong, float heSoLuong)
        {
            this.maNV = maNV;
            this.bacLuong = bacLuong;
            this.heSoLuong = heSoLuong;
        }
    }
}
