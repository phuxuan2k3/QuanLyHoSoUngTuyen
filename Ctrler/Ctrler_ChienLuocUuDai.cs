using BUS;
using DTO;

namespace Ctrler
{
    public class Ctrler_ChienLuocUuDai
    {
        public static void LoadChienLuocUuDai(out List<DTO_ChienLuocUuDai> lsChienLuocUuDai)
        {
            lsChienLuocUuDai = BUS_ChienLuocUuDai.LayDanhSachUD();
        }

        public static void ThemCLUD(DTO_ChienLuocUuDai ud)
        {
            BUS_ChienLuocUuDai.ThemUD(ud);
        }
        public static void XoaCLUD(string maCLUD)
        {
            BUS_ChienLuocUuDai.XoaUD(maCLUD);
        }
        public static void SuaCLUD(DTO_ChienLuocUuDai ud)
        {
            BUS_ChienLuocUuDai.SuaUD(ud);
        }
    }
}
