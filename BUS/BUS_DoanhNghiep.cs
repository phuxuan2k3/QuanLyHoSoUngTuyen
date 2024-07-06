using DAO;
using DTO;
using System.Data;

namespace BUS
{
    public class BUS_DoanhNghiep
    {
        public static List<DTO_DoanhNghiep> LayDN()
        {
            return DAO_DoanhNghiep.LayDN();
        }

        public static DTO_DoanhNghiep LayThongTinDoanhNghiep(string maDoanhNghiep)
        {
            return DAO_DoanhNghiep.LayThongTinDoanhNghiep(maDoanhNghiep);
        }
    }
}
