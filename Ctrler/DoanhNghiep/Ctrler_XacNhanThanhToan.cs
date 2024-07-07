using BUS;
using DTO;

namespace Ctrler.DoanhNghiep;

public class Ctrler_XacNhanThanhToan
{
    private readonly DTO_ThongTinDangTuyen _thongTinDangTuyen;
    private readonly DTO_HinhThucDangTuyen _hinhThucDangTuyen;
    private readonly float _tongTien;

    public Ctrler_XacNhanThanhToan(DTO_ThongTinDangTuyen thongTinDangTuyen)
    {
        _thongTinDangTuyen = thongTinDangTuyen;
        _hinhThucDangTuyen = BUS_HinhThucDangTuyen.Lay(thongTinDangTuyen.MaHTDT);
        _tongTien = BUS_HoaDon.TinhTongSoTien(_hinhThucDangTuyen, thongTinDangTuyen);
    }

    public void Load(ref DTO_ThongTinDangTuyen thongTinDangTuyen, ref DTO_HinhThucDangTuyen hinhThucDangTuyen, ref float tongTien, ref bool coTheThanhToanNhieuDot)
    {
        thongTinDangTuyen = _thongTinDangTuyen;
        hinhThucDangTuyen = _hinhThucDangTuyen;
        tongTien = _tongTien;
        coTheThanhToanNhieuDot = BUS_HoaDon.KiemTraThanhToanNhieuDot(thongTinDangTuyen);
    }

    public void XacNhanThanhToan(CachThucThanhToan cachThucThanhToan)
    {
        var hoaDon = new DTO_HoaDon(_thongTinDangTuyen.MaTTDT, _tongTien, DateTime.Now, TrangThaiThanhToan.ChuaThanhToan, cachThucThanhToan);
        BUS_ThongTinDangTuyen.Them(_thongTinDangTuyen);
        BUS_HoaDon.Them(hoaDon);
    }

    public Ctrler_DienThongTinDangTuyen HienThi_DienThongTinDangTuyen()
    {
        return new Ctrler_DienThongTinDangTuyen(_thongTinDangTuyen);
    }
}