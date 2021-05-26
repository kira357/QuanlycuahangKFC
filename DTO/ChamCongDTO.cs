using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChamCongDTO
    {
        private
        int maNV;
        DateTime ngayLam;
        string caTruc;

        public int MaNV { get => maNV; set => maNV = value; }

        public DateTime NgayLam { get => ngayLam; set => ngayLam = value; }
        public string CaTruc { get => caTruc; set => caTruc = value; }

        public ChamCongDTO(int maNV, DateTime ngayLam, string caTruc)
        {
            this.maNV = maNV;
            this.ngayLam = ngayLam;
            this.caTruc = caTruc;
        }
    }
}

