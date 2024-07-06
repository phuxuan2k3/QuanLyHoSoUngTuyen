namespace DTO;

public class DTO_ChiTietHoaDon(string? maTTDT = null, int lanThanhToan = 0, float soTienCanThanhToan = 0, DateTime? ngayThanhToan = null)
{
	public string MaTTDT { get; set; } = maTTDT ?? string.Empty;
	public int LanThanhToan { get; set; } = lanThanhToan;
	public float SoTienCanThanhToan { get; set; } = soTienCanThanhToan;
	public DateTime NgayThanhToan { get; set; } = ngayThanhToan ?? DateTime.Now;
}
