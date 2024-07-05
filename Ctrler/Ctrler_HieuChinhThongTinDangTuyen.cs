using DTO;

namespace Ctrler;

public class Ctrler_HieuChinhThongTinDangTuyen
{
	private readonly DTO_ThongTinDangTuyen _thongTinDangTuyen;
	private readonly DTO_HinhThucDangTuyen _hinhThucDangTuyen;

	public Ctrler_HieuChinhThongTinDangTuyen(DTO_ThongTinDangTuyen thongTinDangTuyen, DTO_HinhThucDangTuyen hinhThucDangTuyen)
	{
		_thongTinDangTuyen = thongTinDangTuyen;
		_hinhThucDangTuyen = hinhThucDangTuyen;
	}

	public void Load(ref DTO_ThongTinDangTuyen thongTinDangTuyen, ref DTO_HinhThucDangTuyen hinhThucDangTuyen)
	{
		thongTinDangTuyen = _thongTinDangTuyen;
		hinhThucDangTuyen = _hinhThucDangTuyen;
	}
}
