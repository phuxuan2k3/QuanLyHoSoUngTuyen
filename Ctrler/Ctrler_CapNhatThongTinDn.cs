using BUS;
using DTO;

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
