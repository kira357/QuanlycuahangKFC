using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CongThucDTO
    {
        int maMon;
        int maHH;
        int soLuongHH;

        public int MaMon { get => maMon; set => maMon = value; }
        public int MaHH { get => maHH; set => maHH = value; }
        public int SoLuongHH { get => soLuongHH; set => soLuongHH = value; }
    }
}
