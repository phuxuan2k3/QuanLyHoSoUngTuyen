using BUS;
using Ctrler.Sub;
using DTO;

namespace Ctrler
{
	public class Ctrler_HoaDonThongTinDangTuyen
	{
		private readonly DTO_ThongTinDangTuyen _thongTinDangTuyen;
		private readonly DTO_HoaDon _hoaDon;
		private readonly DTO_HinhThucDangTuyen _hinhThucDangTuyen;
		private readonly List<DTO_ChiTietHoaDon> _dsChiTietHoaDon;

		public Ctrler_HoaDonThongTinDangTuyen(DTO_ThongTinDangTuyen thongTinDangTuyen, DTO_HoaDon hoaDon, DTO_HinhThucDangTuyen hinhThucDangTuyen)
		{
			_thongTinDangTuyen = thongTinDangTuyen;
			_hoaDon = hoaDon;
			_hinhThucDangTuyen = hinhThucDangTuyen;
			_dsChiTietHoaDon = BUS_HoaDon.LayTatCaChiTiet(thongTinDangTuyen.MaTTDT);
		}

		public void Load(ref DTO_ThongTinDangTuyen thongTinDangTuyen, ref DTO_HoaDon hoaDon, ref DTO_HinhThucDangTuyen hinhThucDangTuyen, ref List<DTO_ChiTietHoaDon> dsChiTietHoaDon)
		{
			thongTinDangTuyen = _thongTinDangTuyen;
			hoaDon = _hoaDon;
			hinhThucDangTuyen = _hinhThucDangTuyen;
			dsChiTietHoaDon = _dsChiTietHoaDon;
		}

		public Ctrler_ChiTietThongTinDangTuyen HienThi_ChiTiet()
		{
			return new Ctrler_ChiTietThongTinDangTuyen(_thongTinDangTuyen, _hoaDon, _hinhThucDangTuyen);
		}

		public void XuatPDF(string outPath)
		{
			Ctrler_PDF.Xuat(_thongTinDangTuyen, _hoaDon, outPath);
		}
	}
}
