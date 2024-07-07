using DAO;
using DTO;
using System.Data;

namespace BUS
{
    public class BUS_DoanhNghiep
    {
        public static List<DTO_DoanhNghiep> LayDanhSachDoanhNghiep()
        {
            return DAO_DoanhNghiep.LayDanhSachDoanhNghiep();
        }


        public static List<DTO_DoanhNghiep> LayDoanhNghiepCanXacThuc()
        {
            return DAO_DoanhNghiep.LayDoanhNghiepCanXacThuc();
        }

        public static DTO_DoanhNghiep Lay(string MaDN)
        {
            return DAO_DoanhNghiep.LoadTTDN(MaDN);
        }

        public static void CapNhatTrangThaiDN(string MaDN, string TrangThai)
        {

            DAO_DoanhNghiep.CapNhatTrangThaiDN(MaDN, TrangThai);
        }

        public static void CapNhatThongTinDN(DTO_DoanhNghiep doanhNghiep)
        {
            DAO_DoanhNghiep.CapNhatThongTinDn(doanhNghiep);
        }

        public static int KiemTraTrangThaiDN(string maDN)
        {
            return DAO_DoanhNghiep.KiemTraTrangThai(maDN);
        }

        public static void ThemDoanhNghiep(DTO_DoanhNghiep doanhNghiep)
        {
            DAO_DoanhNghiep.ThemDoanhNghiep(doanhNghiep);
        }
        public static DTO_DoanhNghiep LayThongTinDoanhNghiep(string maDoanhNghiep)
        {
            return DAO_DoanhNghiep.LayThongTinDoanhNghiep(maDoanhNghiep);
        }
    }


}
