using DTO;

namespace DAO
{
    public class DAO_DoanhNghiep
    {
        public static List<DTO_DoanhNghiep> LayDN()
        {
            return new List<DTO_DoanhNghiep>
            {
                new DTO_DoanhNghiep ("abc"),
                new DTO_DoanhNghiep ("xyz")
            };
        }
    }
}
