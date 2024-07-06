using DAO;
using DTO;

namespace BUS
{
    public class BUS_PhieuDangKyUngTuyen
    {
        public static DTO_KetQuaUngTuyen TinhToanKetQuaUngTuyen(string maTTDT)
        {
            var lsPhieuDangKyUngTuyen = DAO_PhieuDangKyUngTuyen.LayPDKUT(maTTDT);
            var total = lsPhieuDangKyUngTuyen.Count;
            var countHopLe = lsPhieuDangKyUngTuyen.Count(pdkut => pdkut.TrangThai == TrangThaiPhieuDangKyUngTuyen.HopLe);
            var countDat = lsPhieuDangKyUngTuyen.Count(pdkut => pdkut.TrangThai == TrangThaiPhieuDangKyUngTuyen.HopLe); //todo: trang thai la cai gi

            return new DTO_KetQuaUngTuyen(maTTDT, "", total, countHopLe, countDat);
        }
        
    }
}
