using DTO.Exceptions;

namespace DTO;

public enum TrangThaiThanhToan
{
	ChuaThanhToan = 1,
	ChuaThanhToanHoanTat = 2,
	DaThanhToanHoanTat = 3,
}

public static class TrangThaiThanhToanConvert
{
	public static string ToDisplayString(this TrangThaiThanhToan trangThaiThanhToan)
	{
		return trangThaiThanhToan switch
		{
			TrangThaiThanhToan.ChuaThanhToan => "Chưa thanh toán",
			TrangThaiThanhToan.ChuaThanhToanHoanTat => "Chưa thanh toán hoàn tất",
			TrangThaiThanhToan.DaThanhToanHoanTat => "Đã thanh toán hoàn tất",
			_ => throw new EnumException()
		};
	}

	public static TrangThaiThanhToan ToTrangThaiThanhToan(this string s)
	{
		return s switch
		{
			"Chưa thanh toán" => TrangThaiThanhToan.ChuaThanhToan,
			"Chưa thanh toán hoàn tất" => TrangThaiThanhToan.ChuaThanhToanHoanTat,
			"Đã thanh toán hoàn tất" => TrangThaiThanhToan.DaThanhToanHoanTat,
			_ => throw new EnumException(),
		};
	}
}

public enum CachThucThanhToan
{
	ToanBo = 1,
	NhieuDot = 2,
}

public static class CachThucThanhToanConvert
{
	public static string ToDisplayString(this CachThucThanhToan cachThucThanhToan)
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
}

public class DTO_HoaDon(string maTTDT = "", float tongTien = 0, DateTime? ngayLap = null, TrangThaiThanhToan trangThaiThanhToan = TrangThaiThanhToan.ChuaThanhToan, CachThucThanhToan cachThucThanhToan = CachThucThanhToan.ToanBo)
{
	public string MaTTDT { get; set; } = maTTDT;
	public float TongTien { get; set; } = tongTien;
	public DateTime? NgayLap { get; set; } = ngayLap;
	public TrangThaiThanhToan TrangThaiThanhToan { get; set; } = trangThaiThanhToan;
	public CachThucThanhToan CachThucThanhToan { get; set; } = cachThucThanhToan;
}
