using DTO.Exceptions;

namespace DTO
{
	public enum TrangThaiThongTinDangTuyen
	{
		ChuaXetDuyet,
		KhongHopLe,
		HopLe,
	}
	public static class TrangThaiThongTinDangTuyenConvert
	{
		public static string ToDisplayString(this TrangThaiThongTinDangTuyen trangThaiThongTinDangTuyen)
		{
			return trangThaiThongTinDangTuyen switch
			{
				TrangThaiThongTinDangTuyen.ChuaXetDuyet => "Chưa xét duyệt",
				TrangThaiThongTinDangTuyen.KhongHopLe => "Không hợp lệ",
				TrangThaiThongTinDangTuyen.HopLe => "Hợp lệ",
				_ => throw new EnumException(),
			};
		}

		public static TrangThaiThongTinDangTuyen ToTrangThaiThongTinDangTuyen(this string s)
		{
			return s switch
			{
				"Chưa xét duyệt" => TrangThaiThongTinDangTuyen.ChuaXetDuyet,
				"Không hợp lệ" => TrangThaiThongTinDangTuyen.KhongHopLe,
				"Hợp lệ" => TrangThaiThongTinDangTuyen.HopLe,
				_ => throw new EnumException(),
			};
		}
	}

	public enum TinhTrangThongTinDangTuyen
	{
		ChuaDangTuyen,
		DaDangTuyen,
		CanHieuChinh
	}

	public static class TinhTrangThongTinDangTuyenConvert
	{
		public static string ToDisplayString(this TinhTrangThongTinDangTuyen tinhTrangThongTinDangTuyen)
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
	}


	public class DTO_ThongTinDangTuyen(string maTTDT = "", string maDN = "", int soNgayDangTuyen = 1, string maHTDT = "", DateTime? thoiGianDangTuyen = null, string tenViTri = "", int soLuong = 1, string yeuCau = "", TrangThaiThongTinDangTuyen trangThai = TrangThaiThongTinDangTuyen.ChuaXetDuyet, TinhTrangThongTinDangTuyen tinhTrang = TinhTrangThongTinDangTuyen.ChuaDangTuyen)
	{
		public string MaTTDT { get; set; } = maTTDT;
		public string MaDN { get; set; } = maDN;
		public int SoNgayDangTuyen { get; set; } = soNgayDangTuyen;
		public string MaHTDT { get; set; } = maHTDT;
		public DateTime ThoiGianDangTuyen { get; set; } = thoiGianDangTuyen ?? DateTime.Now.AddDays(1);
		public string TenViTri { get; set; } = tenViTri;
		public int SoLuong { get; set; } = soLuong;
		public string YeuCau { get; set; } = yeuCau;
		public TrangThaiThongTinDangTuyen TrangThai { get; set; } = trangThai;
		public TinhTrangThongTinDangTuyen TinhTrang { get; set; } = tinhTrang;
	}
}
