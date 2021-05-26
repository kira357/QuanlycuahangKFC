using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVienDTO
    {
        private
        int maNV;
        string hoDem;
        string ten;
        string hinh;
        DateTime ngaySinh;
        string gioiTinh;
        string queQuan;
        string sDT;
        string eMail;
        string chucVu;

        public int MaNV { get => maNV; set => maNV = value; }
        public string HoDem { get => hoDem; set => hoDem = value; }
        public string Ten { get => ten; set => ten = value; }
        public string Hinh { get => hinh; set => hinh = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string QueQuan { get => queQuan; set => queQuan = value; }
        public string SDT { get => sDT; set => sDT = value; }
        public string EMail { get => eMail; set => eMail = value; }
        public string ChucVu { get => chucVu; set => chucVu = value; }

        public NhanVienDTO(int maNV, string hoDem, string ten, string hinh, DateTime ngaySinh, string gioiTinh, string queQuan, string sDT, string eMail, string chucVu)
        {
            this.maNV = maNV;
            this.hoDem = hoDem;
            this.ten = ten;
            this.hinh = hinh;
            this.ngaySinh = ngaySinh;
            this.gioiTinh = gioiTinh;
            this.QueQuan = queQuan;
            this.sDT = sDT;
            this.eMail = eMail;
            this.chucVu = chucVu;
        }
    }
}

