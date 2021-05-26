using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class MonAnDTO
    {
        private int maMA;
        private string tenMonAn;
        private int soLuong;

        public int MaMA
        {
            get { return maMA; }
            set { maMA = value; }
        }

        public string TenMonAn
        {
            get { return tenMonAn; }
            set { tenMonAn = value; }
        }

        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }

        public MonAnDTO(int maMA, string tenMonAn, int soLuong)
        {
            this.maMA = maMA;
            this.tenMonAn = tenMonAn;
            this.soLuong = soLuong;
        }
    }
}
