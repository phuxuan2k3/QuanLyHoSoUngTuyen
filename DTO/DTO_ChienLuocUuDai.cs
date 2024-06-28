namespace DTO
{
    public class DTO_ChienLuocUuDai(string maChienLuoc = "", string tenChienLuoc = "", string moTa = "")
    {
        public string MaChienLuoc { get; set; } = maChienLuoc;
        public string TenChienLuoc { get; set; } = tenChienLuoc;
        public string MoTa { get; set; } = moTa;
    }
}
