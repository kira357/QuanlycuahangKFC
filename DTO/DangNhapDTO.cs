using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DangNhapDTO
    {
        string taiKhoan;
        string matKhau;
        string quyen;

        public string TaiKhoan { get => taiKhoan; set => taiKhoan = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public string Quyen { get => quyen; set => quyen = value; }


        public DangNhapDTO(string taiKhoan, string matKhau, string quyen)
        {
            this.taiKhoan = taiKhoan;
            this.matKhau = matKhau;
            this.quyen = quyen;
        }
        public DangNhapDTO(string taiKhoan, string matKhau)
        {
            this.taiKhoan = taiKhoan;
            this.matKhau = matKhau;

        }
    }
}
