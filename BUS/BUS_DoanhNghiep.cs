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


        public static List<DTO_DoanhNghiep> LayDNCanXacThuc()
        {
            return DAO_DoanhNghiep.LayDNChuaXacThuc();
        }

        public static DTO_DoanhNghiep LoadTTDN(string MaDN)
        {
            return DAO_DoanhNghiep.LoadTTDN(MaDN);
            
        }

        public static void CapNhatTrangThaiDN(string MaDN,string TrangThai) {
            
            DAO_DoanhNghiep.CapNhatTrangThaiDN(MaDN, TrangThai);
        }
    }


}
