using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO

{
    public class NhapKhoDTO
    {

        int maNL;
        int soLuong;
        DateTime ngayNhap;

        public int MaNL { get => maNL; set => maNL = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public DateTime NgayNhap { get => ngayNhap; set => ngayNhap = value; }

        public NhapKhoDTO(int a, int b, DateTime c)
        {
            maNL = a;
            soLuong = b;
            ngayNhap = c;
        }
    }
}
