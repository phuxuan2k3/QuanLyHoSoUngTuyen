using DAO;
using DTO;

namespace BUS;

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
    public static int KiemTraMaUV(string value)
    {
        bool check = DAO_UngVien.check_mauv(value);
        if (check == true)
        {
            return 1;
        }
        else
        {
            return 0;
        }
    }

    public static int KiemTraHoTenUV(string mauv, string name)
    {
        bool check = DAO_UngVien.check_hoten(mauv, name);
        if (check == true)
        {
            return 1;
        }
        else
        {
            return 0;
        }
    }

    public static int KiemTraActtionThem(int mattdt, string mauv)
    {
        bool check = DAO_PhieuDangKyUngTuyen.Them_Phieu(mattdt, mauv);
        if (check == true)
        {
            return 1;
        }
        else
        {
            return 0;
        }
    }

    public static int Them_Phieu(int mattdt, string mauv, string name)
    {
        if (KiemTraMaUV(mauv) == 0) return 0; // ALERT ERROR MAUV
        if (KiemTraHoTenUV(mauv, name) == 0) return 0; // ALERT ERROR MAUV
        if (KiemTraActtionThem(mattdt, mauv) == 0) return 0;
        return 1;
    }


    public static void CapNhatThongTinPhieuDangKy(DTO_ThongTinHoSo ttpdk)
    {
        DAO_PhieuDangKyUngTuyen.CapNhatThongTinPhieuDangKy(ttpdk);
    }
}