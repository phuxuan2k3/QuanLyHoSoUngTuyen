using BUS;
using DTO;

namespace Ctrler
{
    public class Ctrler_DoanhNghiepHetHan
    {
        public static void LoadDanhSachDNHetHan(out List<DTO_DoanhNghiep> lsDoanhNghiep)
        {
            lsDoanhNghiep = BUS_DoanhNghiep.LayDN();
        }
        //  public static void LoadKetQuaUngTuyenCuaDN(string maDN, ref List<Tuple<DTO_ThongTinDangTuyen, DTO_KetQuaUngTuyen>> lsKetQuaUngTuyen)
        //{

        //}
        public static void TienHanhGiaHan()
        {

        }
    }
}
