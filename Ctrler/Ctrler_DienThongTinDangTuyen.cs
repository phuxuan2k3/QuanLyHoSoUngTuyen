using BUS;
using DTO;

namespace Ctrler;

public class Ctrler_DienThongTinDangTuyen
{
	private DTO_ThongTinDangTuyen _thongTinDangTuyen;

	public Ctrler_DienThongTinDangTuyen(DTO_ThongTinDangTuyen? thongTinDangTuyen = null)
	{
		_thongTinDangTuyen = thongTinDangTuyen ?? new DTO_ThongTinDangTuyen();
	}

	public void Load(ref DTO_ThongTinDangTuyen thongTinDangTuyen, ref List<DTO_HinhThucDangTuyen> dsHinhThucDangTuyen)
	{
		thongTinDangTuyen = _thongTinDangTuyen;
		dsHinhThucDangTuyen = BUS_HinhThucDangTuyen.LayTatCa();
	}

	public Ctrler_XacNhanThanhToan HienThi_XacNhanThanhToan(DTO_ThongTinDangTuyen thongTinDangTuyen)
	{
		_thongTinDangTuyen = thongTinDangTuyen;
		return new Ctrler_XacNhanThanhToan(_thongTinDangTuyen);
	}
}
