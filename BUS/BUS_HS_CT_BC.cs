using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_HS_CT_BC
    {
        public static List<string> Load_HS (string mauv)
        {
            List<string> list = new List<string>();
            list = DAO_HS_CT_BC.Load_BC(mauv);
            return list;
        }

        public static int ThemHS(string mauv, string tenhs,string hoten)
        {
            if (DAO_UngVien.check_hoten(mauv, hoten)==false) return 0;
            if (DAO_HS_CT_BC.ThemHS(mauv, tenhs) == 0) return 0;
            return 1;

        }
    }
}
