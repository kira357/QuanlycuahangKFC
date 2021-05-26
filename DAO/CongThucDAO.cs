using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class CongThucDAO : DBConnect
    {
        private static CongThucDAO instance;
        public static CongThucDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CongThucDAO();
                }
                return instance;
            }
        }
        public DataTable getCongThuc(int maMonAn)
        {
            DataTable dtCongThuc = new DataTable();

            try
            {
                Con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT NL.MANL, NL.TENNL, CT.SOLUONGHANGHOA, NL.DONVITINH FROM CONGTHUC CT INNER JOIN NGUYENLIEU NL ON CT.MANL = NL.MANL INNER JOIN MONAN MA ON CT.MAMONAN = MA.MAMONAN WHERE CT.MAMONAN = '" + maMonAn + "'", Con);
                da.Fill(dtCongThuc);
            }
            catch (Exception)
            {

                Con.Close();
            }

            Con.Close();
            return dtCongThuc;
        }
    }
}
