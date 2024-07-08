namespace DTO
{
    public class DTO_UngVienDat(string maUV = "", string tenUV = "", string email = "")
    {
        public string MaUV { get; set; } = maUV;
        public string TenUV { get; set; } = tenUV;
        public string Email { get; set; } = email;
    }
}
