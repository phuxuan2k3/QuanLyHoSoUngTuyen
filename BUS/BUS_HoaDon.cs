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

	public static List<DTO_HoaDon> LayTatCaChuaThanhToan()
	{
		return DAO_HoaDon.LayTatCaChuaThanhToan();
	}

	public static void Them(DTO_HoaDon hoaDon)
	{
		DAO_HoaDon.Them(hoaDon);
	}

	public static void ThemLanThanhToan(DTO_HoaDon hoaDon, List<DTO_ChiTietHoaDon> chiTietHoaDons, DTO_ChiTietHoaDon lanThanhToan)
	{
		if (chiTietHoaDons.Sum(x => x.SoTienCanThanhToan) >= hoaDon.TongTien)
		{
			hoaDon.TrangThaiThanhToan = TrangThaiThanhToan.DaThanhToanHoanTat;
		}
		else if (hoaDon.TrangThaiThanhToan == TrangThaiThanhToan.ChuaThanhToan)
		{
			hoaDon.TrangThaiThanhToan = TrangThaiThanhToan.ChuaThanhToanHoanTat;
		}
		DAO_HoaDon.CapNhat(hoaDon);
		DAO_ChiTietHoaDon.Them(lanThanhToan);
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

	public static DTO_ChiTietHoaDon? TaoLanThanhToan(DTO_HoaDon hoaDon, List<DTO_ChiTietHoaDon> cacLanThanhToan)
	{
		if (hoaDon.CachThucThanhToan == CachThucThanhToan.ToanBo)
		{
			return new DTO_ChiTietHoaDon(hoaDon.MaTTDT, 1, hoaDon.TongTien, DateTime.Now);
		}
		var tongTienDaDong = cacLanThanhToan.Sum(x => x.SoTienCanThanhToan);
		if (tongTienDaDong >= hoaDon.TongTien)
		{
			return null;
		}
		var soTienDongCoBan = hoaDon.TongTien * 0.3f;
		var soTienCanDong = hoaDon.TongTien - (tongTienDaDong + soTienDongCoBan) > 0 ? soTienDongCoBan : hoaDon.TongTien - tongTienDaDong;
		var lanDong = cacLanThanhToan.Max(x => x.LanThanhToan);
		return new DTO_ChiTietHoaDon(hoaDon.MaTTDT, lanDong + 1, soTienCanDong, DateTime.Now);
	}
}
