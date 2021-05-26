using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class XuatKhoDTO
    {
        int maNL;
        int soLuong;
        DateTime ngayXuatKho;

        public int MaNL { get => maNL; set => maNL = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public DateTime NgayXuatKho { get => ngayXuatKho; set => ngayXuatKho = value; }

        public XuatKhoDTO(int a, int b, DateTime c)
        {
            maNL = a;
            soLuong = b;
            ngayXuatKho = c;
        }
    }
}
