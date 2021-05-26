using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDonDTO
    {
        private int maHD;
        private int tongTien;
        private string tenKhach;
        private string diaChi;
        private string sdt;
        private DateTime ngay;
        private bool giaoHang;
        private string trangThai;

        public int MaHD { get => maHD; set => maHD = value; }
        public int TongTien { get => tongTien; set => tongTien = value; }
        public string TenKhach { get => tenKhach; set => tenKhach = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public DateTime Ngay { get => ngay; set => ngay = value; }
        public bool GiaoHang { get => giaoHang; set => giaoHang = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }

        public HoaDonDTO(int maHD, int tongTien, string tenKhach, string diaChi, string sdt, DateTime ngay, bool giaoHang, string trangThai)
        {
            MaHD = maHD;
            TongTien = tongTien;
            TenKhach = tenKhach;
            DiaChi = diaChi;
            Sdt = sdt;
            Ngay = ngay;
            GiaoHang = giaoHang;
            TrangThai = trangThai;
            MaHD = maHD;
            TongTien = tongTien;
            TenKhach = tenKhach;
            DiaChi = diaChi;
            Sdt = sdt;
            Ngay = ngay;
            GiaoHang = giaoHang;
            TrangThai = trangThai;
        }
    }
}
