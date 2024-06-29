namespace DTO
{
	public enum TrangThaiThongTinDangTuyen
	{
		ChuaXetDuyet,
		KhongHopLe,
		HopLe,
	}

	public enum TinhTrangThongTinDangTuyen
	{
		ChuaDangTuyen,
		DaDangTuyen,
		CanHieuChinh
	}

	public class DTO_ThongTinDangTuyen(string maTTDT = "", string maDN = "", int soNgayDangTuyen = 0, string maHTDT = "", DateTime? thoiGianDangTuyen = null, string tenViTri = "", int soLuong = 0, string yeuCau = "", TrangThaiThongTinDangTuyen trangThai = TrangThaiThongTinDangTuyen.ChuaXetDuyet, TinhTrangThongTinDangTuyen tinhTrang = TinhTrangThongTinDangTuyen.ChuaDangTuyen)
	{
		public string MaTTDT { get; set; } = maTTDT;
		public string MaDN { get; set; } = maDN;
		public int SoNgayDangTuyen { get; set; } = soNgayDangTuyen;
		public string MaHTDT { get; set; } = maHTDT;
		public DateTime? ThoiGianDangTuyen { get; set; } = thoiGianDangTuyen;
		public string TenViTri { get; set; } = tenViTri;
		public int SoLuong { get; set; } = soLuong;
		public string YeuCau { get; set; } = yeuCau;
		public TrangThaiThongTinDangTuyen TrangThai { get; set; } = trangThai;
		public TinhTrangThongTinDangTuyen TinhTrang { get; set; } = tinhTrang;
	}
}
