using BUS;
using DTO;

namespace Ctrler;

public class Ctrler_DanhSachThongTinDangTuyen
{
	private string _maDN;

	public Ctrler_DanhSachThongTinDangTuyen(string maDN)
	{
		_maDN = maDN;
	}

	public void Load(ref List<DTO_ThongTinDangTuyen> thongTinDangTuyen)
	{
		thongTinDangTuyen = BUS_ThongTinDangTuyen.LayTatCaCuaDoanhNghiep(_maDN);
	}

	public static Ctrler_ChiTietThongTinDangTuyen ChiTietThongTinDangTuyen(string maTTDT)
	{
		var ttdt = BUS_ThongTinDangTuyen.Lay(maTTDT);
		var hoaDon = BUS_HoaDon.Lay(maTTDT);
		var hinhThucDangTuyen = BUS_HinhThucDangTuyen.Lay(ttdt.MaHTDT);
		return new Ctrler_ChiTietThongTinDangTuyen(ttdt, hoaDon, hinhThucDangTuyen);
	}
}
