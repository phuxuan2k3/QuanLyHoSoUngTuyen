using BUS;
using DTO;

namespace Ctrler.NhanVienThanhToan
{
	public class Ctrler_DanhSachHoaDonDangTuyen
	{
		public void Load(ref List<DTO_HoaDon> hoaDons)
		{
			hoaDons = BUS_HoaDon.LayTatCaChuaThanhToan();
		}

		public DTO_HoaDon? TruyVanHoaDon(string maTTDT)
		{
			return BUS_HoaDon.Lay(maTTDT);
		}

		public void LoadChiTietHoaDon(string maTTDT, ref DTO_ThongTinDangTuyen thongTinDangTuyen, ref List<DTO_ChiTietHoaDon> chiTietHoaDons, ref DTO_DoanhNghiep doanhNghiep)
		{
			chiTietHoaDons = BUS_HoaDon.LayTatCaChiTiet(maTTDT);
			thongTinDangTuyen = BUS_ThongTinDangTuyen.Lay(maTTDT);
			doanhNghiep = BUS_DoanhNghiep.Lay(thongTinDangTuyen.MaDN);
		}
	}
}
