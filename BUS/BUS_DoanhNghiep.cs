using DAO;
using DTO;

namespace BUS
{
    public class BUS_DoanhNghiep
    {
        public static List<DTO_DoanhNghiep> LayDN()
        {
            return DAO_DoanhNghiep.LayDN();
        }
    }
}
