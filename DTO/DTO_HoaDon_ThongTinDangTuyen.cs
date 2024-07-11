namespace DTO;

public class DTO_HoaDon_TenViTri_TenDoanhNghiep(string maTTDT = "", float tongTien = 0, DateTime? ngayLap = null, TrangThaiThanhToan trangThaiThanhToan = TrangThaiThanhToan.ChuaThanhToan, CachThucThanhToan cachThucThanhToan = CachThucThanhToan.ToanBo, string tenViTri = "", string tenDN = "")
{
	public string MaTTDT { get; set; } = maTTDT;
	public float TongTien { get; set; } = tongTien;
	public DateTime? NgayLap { get; set; } = ngayLap;
	public TrangThaiThanhToan TrangThaiThanhToan { get; set; } = trangThaiThanhToan;
	public CachThucThanhToan CachThucThanhToan { get; set; } = cachThucThanhToan;
	public string TenViTri { get; set; } = tenViTri;
	public string TenDN { get; set; } = tenDN;

}
