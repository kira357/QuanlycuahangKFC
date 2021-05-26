using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TraLuongDTO
    {
        private
        int maNV;
        decimal luongTong;
        DateTime ngayBatDau;
        DateTime ngayTraLuong;

        public TraLuongDTO(int maNV, DateTime ngayBatDau, DateTime ngayTraLuong, decimal luongTong)
        {
            this.MaNV = maNV;
            this.ngayBatDau = ngayBatDau;
            this.ngayTraLuong = ngayTraLuong;
            this.LuongTong = luongTong;
        }

        public int MaNV { get => maNV; set => maNV = value; }
        public DateTime NgayBatDau { get => ngayBatDau; set => ngayBatDau = value; }
        public DateTime NgayTraLuong { get => ngayTraLuong; set => ngayTraLuong = value; }
        public decimal LuongTong { get => luongTong; set => luongTong = value; }
    }
}
