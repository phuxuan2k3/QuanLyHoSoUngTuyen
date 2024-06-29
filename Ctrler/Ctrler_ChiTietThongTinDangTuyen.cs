using DTO;

namespace Ctrler;

public class Ctrler_ChiTietThongTinDangTuyen
{
	private readonly DTO_ThongTinDangTuyen _ttdt;
	private readonly DTO_HoaDon _hoaDon;
	private readonly DTO_HinhThucDangTuyen _hinhThucDangTuyen;

	public Ctrler_ChiTietThongTinDangTuyen(DTO_ThongTinDangTuyen ttdt, DTO_HoaDon hoaDon, DTO_HinhThucDangTuyen hinhThucDangTuyen)
	{
		_ttdt = ttdt;
		_hoaDon = hoaDon;
		_hinhThucDangTuyen = hinhThucDangTuyen;
	}


}
