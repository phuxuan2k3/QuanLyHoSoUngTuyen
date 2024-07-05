using DTO;

namespace Ctrler;

public class Ctrler_ChiTietThongTinDangTuyen
{
	private readonly DTO_ThongTinDangTuyen _thongTinDangTuyen;
	private readonly DTO_HoaDon _hoaDon;
	private readonly DTO_HinhThucDangTuyen _hinhThucDangTuyen;

	public Ctrler_ChiTietThongTinDangTuyen(DTO_ThongTinDangTuyen ttdt, DTO_HoaDon hoaDon, DTO_HinhThucDangTuyen hinhThucDangTuyen)
	{
		_thongTinDangTuyen = ttdt;
		_hoaDon = hoaDon;
		_hinhThucDangTuyen = hinhThucDangTuyen;
	}

	public void Load(ref DTO_ThongTinDangTuyen thongTinDangTuyen, ref DTO_HoaDon hoaDon, ref DTO_HinhThucDangTuyen hinhThucDangTuyen)
	{
		thongTinDangTuyen = _thongTinDangTuyen;
		hoaDon = _hoaDon;
		hinhThucDangTuyen = _hinhThucDangTuyen;
	}

	public Ctrler_HoaDonThongTinDangTuyen HienThi_HoaDon()
	{
		return new Ctrler_HoaDonThongTinDangTuyen(_thongTinDangTuyen, _hoaDon, _hinhThucDangTuyen);
	}

	public Ctrler_HieuChinhThongTinDangTuyen HienThi_HieuChinh()
	{
		return new Ctrler_HieuChinhThongTinDangTuyen(_thongTinDangTuyen, _hinhThucDangTuyen);
	}
}
