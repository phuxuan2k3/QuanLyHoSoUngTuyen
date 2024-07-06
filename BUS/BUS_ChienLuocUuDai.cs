using DAO;
using DTO;

namespace BUS
{
    public class BUS_ChienLuocUuDai
    {
        public static List<DTO_ChienLuocUuDai> LayDanhSachUD()
        {
            return DAO_ChienLuocUuDai.LayDSUD();
        }

        public static List<DTO_ChienLuocUuDai> LayDanhSachUD(string maDN)
        {
            return DAO_ChienLuocUuDai.LayDSUD(maDN);
        }

        public static void XoaTatCaUuDaiCuaDoanhNghiep(string maDN)
        {
            DAO_ChienLuocUuDai.XoaTatCaUuDaiCuaDoanhNghiep(maDN);
        }

        public static void ThemUuDaiChoDoanhNghiep(string maDN, List<DTO_ChienLuocUuDai> lsChienLuocUuDai)
        {
            foreach (var uuDai in lsChienLuocUuDai)
            {
                DAO_ChienLuocUuDai.ThemUuDaiChoDN(maDN, uuDai);
            }
        }

        public static void ThemUD(DTO_ChienLuocUuDai ud)
        {
            DAO_ChienLuocUuDai.ThemUD(ud);
        }

        public static void XoaUD(string maUD)
        {
            DAO_ChienLuocUuDai.XoaUD(maUD);

        }
        public static void SuaUD(DTO_ChienLuocUuDai ud)
        {
            DAO_ChienLuocUuDai.SuaUD(ud);
        }
    }
}
