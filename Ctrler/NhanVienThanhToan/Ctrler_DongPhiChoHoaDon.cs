using BUS;
using DTO;

namespace Ctrler.NhanVienThanhToan
{
	public class Ctrler_DongPhiChoHoaDon
	{
		private DTO_ThongTinDangTuyen _thongTinDangTuyen;
		private DTO_HoaDon _hoaDon;
		private DTO_DoanhNghiep _doanhNghiep;
		private List<DTO_ChiTietHoaDon> _chiTietHoaDons;
		private DTO_ChiTietHoaDon? _lanDongHienTai;
		public Ctrler_DongPhiChoHoaDon(DTO_ThongTinDangTuyen thongTinDangTuyen, DTO_HoaDon hoaDon, DTO_DoanhNghiep doanhNghiep, List<DTO_ChiTietHoaDon> chiTietHoaDons)
		{
			_thongTinDangTuyen = thongTinDangTuyen;
			_hoaDon = hoaDon;
			_doanhNghiep = doanhNghiep;
			_chiTietHoaDons = chiTietHoaDons;
			_lanDongHienTai = BUS_HoaDon.TaoLanThanhToan(hoaDon, chiTietHoaDons);
		}

		public void Load(ref DTO_ThongTinDangTuyen thongTinDangTuyen, ref DTO_HoaDon hoaDon, ref DTO_DoanhNghiep doanhNghiep, ref List<DTO_ChiTietHoaDon> chiTietHoaDons, ref DTO_ChiTietHoaDon? lanDongHienTai)
		{
			thongTinDangTuyen = _thongTinDangTuyen;
			hoaDon = _hoaDon;
			doanhNghiep = _doanhNghiep;
			chiTietHoaDons = _chiTietHoaDons;
			lanDongHienTai = _lanDongHienTai;
		}

		public void DongPhiChoHoaDon()
		{
			if (_lanDongHienTai == null)
			{
				throw new Exception("Hóa đơn đã được đóng phí");
			}
			BUS_HoaDon.ThemLanThanhToan(_hoaDon, _chiTietHoaDons, _lanDongHienTai);
		}
	}
}
