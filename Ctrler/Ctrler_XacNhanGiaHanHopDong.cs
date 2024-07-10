using BUS;
using DTO;

namespace Ctrler
{
    public class Ctrler_XacNhanGiaHanHopDong
    {
        public static void LoadChienLuocUuDai(out List<DTO_ChienLuocUuDai> lsChienLuocUuDai)
        {
            lsChienLuocUuDai = BUS_ChienLuocUuDai.LayDanhSachUD();
        }

        public static void LoadChienLuocUuDaiCuaDN(string maDN, out List<DTO_ChienLuocUuDai> lsChienLuocUuDai)
        {
            lsChienLuocUuDai = BUS_ChienLuocUuDai.LayDanhSachUD(maDN);
        }

        public static void GiaHanDoanhNghiep(string maDN, List<DTO_ChienLuocUuDai> lsChienLuocUuDai)
        {
            BUS_DoanhNghiep.CapNhatTrangThaiDN(maDN, TrangThaiDoanhNghiep.TiemNang.GetString());
            BUS_ChienLuocUuDai.XoaTatCaUuDaiCuaDoanhNghiep(maDN);
            BUS_ChienLuocUuDai.ThemUuDaiChoDoanhNghiep(maDN, lsChienLuocUuDai);
            BUS_DoanhNghiep.LuuDoanhNghiepTiemNang(maDN);
        }
    }
}
