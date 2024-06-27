namespace DTO
{
    public class DTO_HinhThucDangTuyen(string maHTDT, string tenHinhThuc, string moTa)
    {
        public string MaHTDT { get; set; } = maHTDT;
        public string TenHinhThuc { get; set; } = tenHinhThuc;
        public string MoTa { get; set; } = moTa;
    }
}
