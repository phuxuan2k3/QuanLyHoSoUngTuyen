namespace DTO
{
	public class DTO_HinhThucDangTuyen(string maHTDT = "", string tenHinhThuc = "", string moTa = "", float gia = -1)
	{
		public string MaHTDT { get; set; } = maHTDT;
		public string TenHinhThuc { get; set; } = tenHinhThuc;
		public string MoTa { get; set; } = moTa;
		public float Gia { get; set; } = gia;
	}
}
