using DTO;
using DTO.Exceptions;

namespace Utilis;

public static class EnumConvert
{
	public static string ToString(this TrangThaiThongTinDangTuyen trangThaiThongTinDangTuyen)
	{
		return trangThaiThongTinDangTuyen switch
		{
			TrangThaiThongTinDangTuyen.ChuaXetDuyet => "Chưa xét duyệt",
			TrangThaiThongTinDangTuyen.KhongHopLe => "Không hợp lệ",
			TrangThaiThongTinDangTuyen.HopLe => "Hợp lệ",
			_ => throw new EnumException(),
		};
	}

	public static TrangThaiThongTinDangTuyen ToTrangTraiThongTinDangTuyen(this string s)
	{
		return s switch
		{
			"Chưa xét duyệt" => TrangThaiThongTinDangTuyen.ChuaXetDuyet,
			"Không hợp lệ" => TrangThaiThongTinDangTuyen.KhongHopLe,
			"Hợp lệ" => TrangThaiThongTinDangTuyen.HopLe,
			_ => throw new EnumException(),
		};
	}

	public static string ToString(this TinhTrangThongTinDangTuyen tinhTrangThongTinDangTuyen)
	{
		return tinhTrangThongTinDangTuyen switch
		{
			TinhTrangThongTinDangTuyen.ChuaDangTuyen => "Chưa đăng tuyển",
			TinhTrangThongTinDangTuyen.DaDangTuyen => "Đã đăng tuyển",
			TinhTrangThongTinDangTuyen.CanHieuChinh => "Cần hiệu chỉnh",
			_ => throw new EnumException()
		};
	}

	public static TinhTrangThongTinDangTuyen ToTinhTrangThongTinDangTuyen(this string s)
	{
		return s switch
		{
			"Chưa đăng tuyển" => TinhTrangThongTinDangTuyen.ChuaDangTuyen,
			"Đã đăng tuyển" => TinhTrangThongTinDangTuyen.DaDangTuyen,
			"Cần hiệu chỉnh" => TinhTrangThongTinDangTuyen.CanHieuChinh,
			_ => throw new EnumException(),
		};
	}

	public static string ToString(this CachThucThanhToan cachThucThanhToan)
	{
		return cachThucThanhToan switch
		{
			CachThucThanhToan.ToanBo => "Toàn bộ",
			CachThucThanhToan.NhieuDot => "Nhiều đợt",
			_ => throw new EnumException()
		};
	}

	public static CachThucThanhToan ToCachThucThanhToan(this string s)
	{
		return s switch
		{
			"Toàn bộ" => CachThucThanhToan.ToanBo,
			"Nhiều đợt" => CachThucThanhToan.NhieuDot,
			_ => throw new EnumException(),
		};
	}

	public static string ToString(this TrangThaiThanhToan trangThaiThanhToan)
	{
		return trangThaiThanhToan switch
		{
			TrangThaiThanhToan.ChuaThanhToan => "Chưa thanh toán",
			TrangThaiThanhToan.ChuaThanhToanHoanTat => "Chưa thanh toán hoàn tất",
			TrangThaiThanhToan.ThanhToanHoanTat => "Thanh toán hoàn tất",
			_ => throw new EnumException()
		};
	}

	public static TrangThaiThanhToan ToTrangThaiThanhToan(this string s)
	{
		return s switch
		{
			"Chưa thanh toán" => TrangThaiThanhToan.ChuaThanhToan,
			"Chưa thanh toán hoàn tất" => TrangThaiThanhToan.ChuaThanhToanHoanTat,
			"Thanh toán hoàn tất" => TrangThaiThanhToan.ThanhToanHoanTat,
			_ => throw new EnumException(),
		};
	}


}
