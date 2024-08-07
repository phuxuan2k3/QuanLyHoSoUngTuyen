﻿using BUS;
using DTO;

namespace Ctrler.DoanhNghiep
{
	public class Ctrler_CapNhatThongTinDoanhNghiep
	{
		public DTO_DoanhNghiep Load(string MaDN)
		{
			return BUS_DoanhNghiep.Lay(MaDN);
		}
		public void CapNhatTTDN(DTO_DoanhNghiep doanhNghiep)
		{
			BUS_DoanhNghiep.CapNhatThongTinDN(doanhNghiep);
		}

        public static int KiemTraMaSothue(string maDN, string MST)
        {
            return BUS_DoanhNghiep.KiemTraMaSoThue(maDN, MST);
        }
    }
}
