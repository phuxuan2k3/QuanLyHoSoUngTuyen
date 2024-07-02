using BUS;
using DTO;

namespace Ctrler;

public class Ctrler_XacNhanThanhToan
{
	private readonly DTO_ThongTinDangTuyen _thongTinDangTuyen;
	private readonly DTO_HinhThucDangTuyen _hinhThucDangTuyen;

	public Ctrler_XacNhanThanhToan(DTO_ThongTinDangTuyen thongTinDangTuyen)
	{
		_thongTinDangTuyen = thongTinDangTuyen;
		_hinhThucDangTuyen = BUS_HinhThucDangTuyen.Lay(thongTinDangTuyen.MaHTDT);
	}

	public void Load(ref DTO_ThongTinDangTuyen thongTinDangTuyen, ref DTO_HinhThucDangTuyen hinhThucDangTuyen)
	{
		thongTinDangTuyen = _thongTinDangTuyen;
		hinhThucDangTuyen = _hinhThucDangTuyen;
	}
}