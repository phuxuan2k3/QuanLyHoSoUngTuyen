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

		public Ctrler_DongPhiChoHoaDon HienThi_DongPhiChoHoaDon(DTO_HoaDon hoaDon)
		{
			var ctHoaDon = BUS_HoaDon.LayTatCaChiTiet(hoaDon.MaTTDT);
			var ttdt = BUS_ThongTinDangTuyen.Lay(hoaDon.MaTTDT);
			var dn = BUS_DoanhNghiep.Lay(ttdt.MaDN);
			return new Ctrler_DongPhiChoHoaDon(ttdt, hoaDon, dn, ctHoaDon);
		}
	}
}
