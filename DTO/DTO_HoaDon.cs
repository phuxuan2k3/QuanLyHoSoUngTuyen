namespace DTO;

public enum TrangThaiThanhToan
{
	ChuaThanhToan = 1,
	ChuaThanhToanHoanTat = 2,
	ThanhToanHoaTat = 3,
}

public enum CachThucThanhToan
{
	ToanBo = 1,
	NhieuDot = 2,
}

public class DTO_HoaDon(string maTTDT = "", float tongTien = 0, DateTime? ngayLap = null, TrangThaiThanhToan trangThaiThanhToan = TrangThaiThanhToan.ChuaThanhToan, CachThucThanhToan cachThucThanhToan = CachThucThanhToan.ToanBo)
{
	public string MaTTDT { get; set; } = maTTDT;
	public float TongTien { get; set; } = tongTien;
	public DateTime? NgayLap { get; set; } = ngayLap;
	public TrangThaiThanhToan TrangThaiThanhToan { get; set; } = trangThaiThanhToan;
	public CachThucThanhToan CachThucThanhToan { get; set; } = cachThucThanhToan;
}
