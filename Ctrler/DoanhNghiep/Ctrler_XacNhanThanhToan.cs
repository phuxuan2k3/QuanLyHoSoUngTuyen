using BUS;
using DTO;

namespace Ctrler.DoanhNghiep;

public class Ctrler_XacNhanThanhToan
{
	private DTO_ThongTinDangTuyen _thongTinDangTuyen;
	private DTO_HinhThucDangTuyen _hinhThucDangTuyen;
	private float _tongTien;

	public Ctrler_XacNhanThanhToan(DTO_ThongTinDangTuyen thongTinDangTuyen)
	{
		_thongTinDangTuyen = thongTinDangTuyen;
		_hinhThucDangTuyen = new();
	}

	public void Load(ref DTO_ThongTinDangTuyen thongTinDangTuyen, ref DTO_HinhThucDangTuyen hinhThucDangTuyen, ref float tongTien, ref bool coTheThanhToanNhieuDot)
	{
		thongTinDangTuyen = _thongTinDangTuyen;
		_hinhThucDangTuyen = BUS_HinhThucDangTuyen.Lay(thongTinDangTuyen.MaHTDT);
		_tongTien = BUS_HoaDon.TinhTongSoTien(_hinhThucDangTuyen, thongTinDangTuyen);
		hinhThucDangTuyen = _hinhThucDangTuyen;
		tongTien = _tongTien;
		coTheThanhToanNhieuDot = BUS_HoaDon.KiemTraThanhToanNhieuDot(thongTinDangTuyen);
	}

	public void XacNhanThanhToan(CachThucThanhToan cachThucThanhToan)
	{
		var id = BUS_ThongTinDangTuyen.Them(_thongTinDangTuyen);
		var hoaDon = new DTO_HoaDon(id.ToString(), _tongTien, DateTime.Now, TrangThaiThanhToan.ChuaThanhToan, cachThucThanhToan);
		BUS_HoaDon.Them(hoaDon);
	}

	public Ctrler_DienThongTinDangTuyen HienThi_DienThongTinDangTuyen()
	{
		return new Ctrler_DienThongTinDangTuyen(_thongTinDangTuyen);
	}
}