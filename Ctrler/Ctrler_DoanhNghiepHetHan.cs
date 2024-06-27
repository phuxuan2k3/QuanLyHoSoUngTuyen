using BUS;
using DAO;
using DTO;
using System.Security.Cryptography.X509Certificates;

namespace Ctrler
{
    public class Ctrler_DoanhNghiepHetHan
    {
        public static void LoadDanhSachDNHetHan(out List<DTO_DoanhNghiep> lsDoanhNghiep)
        {
            lsDoanhNghiep = BUS_DoanhNghiep.LayDN();
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

        public static void TienHanhGiaHan()
        {

        }
    }
}
