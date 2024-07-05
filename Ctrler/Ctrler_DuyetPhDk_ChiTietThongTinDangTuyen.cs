using BUS;
using DTO;

namespace Ctrler;
public class Ctrler_DuyetPhDk_ChiTietThongTinDangTuyen
{
    private readonly DTO_ThongTinDangTuyen _thongTinDangTuyen;


    public Ctrler_DuyetPhDk_ChiTietThongTinDangTuyen(DTO_ThongTinDangTuyen ttdt)
    {
        _thongTinDangTuyen = ttdt;
    }


    public void Load(ref DTO_ThongTinDangTuyen thongTinDangTuyen,ref List<DTO_PhieuDangKyUngTuyen> thongTinPhieuDangKyUngTuyen)
    {
        thongTinDangTuyen = _thongTinDangTuyen;
        thongTinPhieuDangKyUngTuyen = BUS_ThongTinDangTuyen.LayDSPDK(thongTinDangTuyen.MaTTDT);
    }

    public Ctrler_DuyetPhDk_ChiTietPhieuDangKy ChiTietThongTinPhieuDangKy(string maTTDT, string maUV)
    {
        var ttdt = BUS_ThongTinDangTuyen.Lay(maTTDT);
        var ttuv = BUS_.Lay(maTTDT);
        var hinhThucDangTuyen = BUS_HinhThucDangTuyen.Lay(ttdt.MaHTDT);

        return new Ctrler_DuyetPhDk_ChiTietPhieuDangKy(ttdt, ttuv);
    }
}
