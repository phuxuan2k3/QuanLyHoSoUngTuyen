using DAO;
using DTO;

namespace BUS;

public class BUS_HoaDon
{
	public static DTO_HoaDon Lay(string maTTDT)
	{
		return DAO_HoaDon.Lay(maTTDT);
	}

	public static List<DTO_ChiTietHoaDon> LayTatCaChiTiet(string maTTDT)
	{
		return DAO_ChiTietHoaDon.LayTatCaCuaHoaDon(maTTDT);
	}

	public static string Them(DTO_HoaDon hoaDon)
	{
		return DAO_HoaDon.Them(hoaDon);
	}

	public static float TinhTongSoTien(DTO_HinhThucDangTuyen hinhThucDangTuyen, DTO_ThongTinDangTuyen thongTinDangTuyen)
	{
		return hinhThucDangTuyen.Gia * thongTinDangTuyen.SoNgayDangTuyen;
	}

	public static bool KiemTraThanhToanNhieuDot(DTO_ThongTinDangTuyen thongTinDangTuyen)
	{
		if (thongTinDangTuyen.SoNgayDangTuyen > 30)
		{
			return true;
		}
		return false;
	}
}
