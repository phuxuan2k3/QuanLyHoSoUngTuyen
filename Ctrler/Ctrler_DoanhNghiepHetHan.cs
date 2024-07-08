using BUS;
using DAO;
using DTO;

namespace Ctrler
{
    public class Ctrler_DoanhNghiepHetHan
    {
        public static void LoadDanhSachDNHetHan(out List<DTO_DoanhNghiep> lsDoanhNghiep)
        {
            var lsTTDT = BUS_ThongTinDangTuyen.LayDanhSachTTDTSapHetHan();
            var lsDN = lsTTDT.DistinctBy(x => x.MaDN).Select(x => BUS_DoanhNghiep.Lay(x.MaDN)).ToList();
            lsDoanhNghiep = lsDN;
        }

        public static void LoadKetQuaUngTuyenCuaDN(string maDN, out List<DTO_KetQuaUngTuyen> lsKetQuaUngTuyen)
        {
            var lsKQUT = new List<DTO_KetQuaUngTuyen>();
            var lsTTDT = DAO_ThongTinDangTuyen.LayDSTTDT(maDN);
            foreach (var ttdt in lsTTDT)
            {
                var ketQuaUngTuyen = BUS_PhieuDangKyUngTuyen.TinhToanKetQuaUngTuyen(ttdt.MaTTDT);
                ketQuaUngTuyen.TenViTri = ttdt.TenViTri;
                lsKQUT.Add(ketQuaUngTuyen);
            }
            lsKetQuaUngTuyen = lsKQUT;
        }
    }
}
