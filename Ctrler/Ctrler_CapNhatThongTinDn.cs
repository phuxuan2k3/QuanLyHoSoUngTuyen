using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ctrler
{
    public class Ctrler_CapNhatThongTinDn
    {
        public DTO_DoanhNghiep Load(string MaDN)
        {
            return BUS_DoanhNghiep.LoadTTDN(MaDN);
        }
        public void CapNhatTTDN(DTO_DoanhNghiep doanhNghiep)
        {
            BUS_DoanhNghiep.CapNhatThongTinDN(doanhNghiep);
        }

    }
}
