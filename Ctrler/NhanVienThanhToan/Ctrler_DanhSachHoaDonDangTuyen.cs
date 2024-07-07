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

		public Ctrler_DongPhiChoHoaDon HienThi_DongPhiChoHoaDon(string maTTDT)
		{
			var hoaDon = BUS_HoaDon.Lay(maTTDT);
			var ctHoaDon = BUS_HoaDon.LayTatCaChiTiet(maTTDT);
			var ttdt = BUS_ThongTinDangTuyen.Lay(maTTDT);
			var dn = BUS_DoanhNghiep.Lay(ttdt.MaDN);
			return new Ctrler_DongPhiChoHoaDon(ttdt, hoaDon, dn, ctHoaDon);
		}
	}
}
