using BUS;
using Ctrler.NhanVienNghiepVu;
using DTO;

namespace Ctrler.DoanhNghiep;

public class Ctrler_DuyetPhieuDangKy_DanhSachThongTinDangTuyen
{
    private readonly string _maDN;
    private readonly DTO_ThongTinDangTuyen _thongTinDangTuyen;

    public Ctrler_DuyetPhieuDangKy_DanhSachThongTinDangTuyen(string maDN)
    {
        _maDN = maDN;
    }
    public void ThongTinDangTuyenvaDSPDk(ref DTO_ThongTinDangTuyen thongTinDangTuyen, ref List<DTO_ThongTinHoSo> thongTinPhieuDangKyUngTuyen)
    {
        thongTinDangTuyen = _thongTinDangTuyen;
        thongTinPhieuDangKyUngTuyen = BUS_ThongTinDangTuyen.LayDSPhieuDangKy(thongTinDangTuyen.MaTTDT);
    }
    public static List<DTO_DuyetPhieuDangKy_ThongTinDangTuyen> LayDSThongTinDangTuyenChoDNDuyet()
    {
        return BUS_ThongTinDangTuyen.LayDSThongTinDangTuyenChoDNDuyet();
    }

    public void Load(ref List<DTO_ThongTinDangTuyen> thongTinDangTuyen)
    {
        thongTinDangTuyen = BUS_ThongTinDangTuyen.LayTatCaCuaDoanhNghiep(_maDN);
    }

    public static Ctrler_DuyetPhieuDangKy_ChiTietThongTinDangTuyen HienThi_ChiTiet(string maTTDT)
    {
        var ttdt = BUS_ThongTinDangTuyen.Lay(maTTDT);
        var hoaDon = BUS_HoaDon.Lay(maTTDT);
        var hinhThucDangTuyen = BUS_HinhThucDangTuyen.Lay(ttdt.MaHTDT);
        return new Ctrler_DuyetPhieuDangKy_ChiTietThongTinDangTuyen(ttdt, hoaDon, hinhThucDangTuyen);
    }
    public List<DTO_DuyetPhieuDangKy_ThongTinDangTuyen> LayDSThongTinDangTuyenDuyetPDK()
    {
        return BUS_ThongTinDangTuyen.LayDSThongTinDangTuyenDuyetPDK();
    }


}
