using BUS;
using DTO;

namespace Ctrler
{
	public class Ctrler_DanhSachThongTinDangTuyen
	{
		public void Load(string maDN, ref List<DTO_ThongTinDangTuyen> thongTinDangTuyen)
		{
			thongTinDangTuyen = BUS_ThongTinDangTuyen.LayTatCaCuaDoanhNghiep(maDN);
		}

		public void HienThi_ChiTietThongTinDangTuyen(string maTTDT)
		{

		}
	}
}
