using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LuongDTO
    {
        private
        int bacLuong;
        float luongCoBan;

        public int BacLuong { get => bacLuong; set => bacLuong = value; }
        public float LuongCoBan { get => luongCoBan; set => luongCoBan = value; }
        public LuongDTO(int bacLuong, float luongCoBan)
        {
            this.bacLuong = bacLuong;
            this.luongCoBan = luongCoBan;
        }
    }
}
