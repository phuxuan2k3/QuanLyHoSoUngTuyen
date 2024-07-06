using BUS;
using DTO;

namespace Ctrler.DoanhNghiep;

public class Ctrler_HieuChinhThongTinDangTuyen
{
	private readonly DTO_ThongTinDangTuyen _thongTinDangTuyen;
	private readonly DTO_HoaDon _hoaDon;
	private readonly DTO_HinhThucDangTuyen _hinhThucDangTuyen;

	public Ctrler_HieuChinhThongTinDangTuyen(DTO_ThongTinDangTuyen thongTinDangTuyen, DTO_HoaDon hoaDon, DTO_HinhThucDangTuyen hinhThucDangTuyen)
	{
		_thongTinDangTuyen = thongTinDangTuyen;
		_hoaDon = hoaDon;
		_hinhThucDangTuyen = hinhThucDangTuyen;
	}

	public void Load(ref DTO_ThongTinDangTuyen thongTinDangTuyen, ref DTO_HinhThucDangTuyen hinhThucDangTuyen)
	{
		thongTinDangTuyen = _thongTinDangTuyen;
		hinhThucDangTuyen = _hinhThucDangTuyen;
	}

	public void XacNhanHieuChinh(DTO_ThongTinDangTuyen thongTinDangTuyen)
	{
		_thongTinDangTuyen.TenViTri = thongTinDangTuyen.TenViTri;
		_thongTinDangTuyen.SoLuong = thongTinDangTuyen.SoLuong;
		_thongTinDangTuyen.YeuCau = thongTinDangTuyen.YeuCau;
		BUS_ThongTinDangTuyen.CapNhat(_thongTinDangTuyen);
	}

	public Ctrler_ChiTietThongTinDangTuyen HienThi_ChiTietThongTinDangTuyen()
	{
		return new Ctrler_ChiTietThongTinDangTuyen(_thongTinDangTuyen, _hoaDon, _hinhThucDangTuyen);
	}
}
