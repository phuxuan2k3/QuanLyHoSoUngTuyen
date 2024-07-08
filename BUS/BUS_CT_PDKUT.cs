using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_CT_PDKUT
    {
        public static int Xoa_Phieu(int mattdt, string mauv)
        {
            Boolean check = DAO_PhieuDangKyUngTuyen.Xoa_Phieu(mattdt, mauv);
            if (check == true)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public static int Them(int mattdt, string mauv, string ctbc)
        {
            int mactbc = DAO_HS_CT_BC.GetID(ctbc, mauv);
            if (mactbc == 0) return 0;
            if (DAO_CT_PDKUT.Them(mattdt, mauv, mactbc) == 0) return 0;
            return 1;
        }
    }
}
