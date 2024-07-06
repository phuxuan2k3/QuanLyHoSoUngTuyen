using BUS;
using Ctrler.NhanVienNghiepVu;
using DTO;

namespace Ctrler.DoanhNghiep;

public class Ctrler_DanhSachThongTinDangTuyen
{
	private readonly string _maDN;

	public Ctrler_DanhSachThongTinDangTuyen(string maDN)
	{
		_maDN = maDN;
	}

	public void Load(ref List<DTO_ThongTinDangTuyen> thongTinDangTuyen)
	{
		thongTinDangTuyen = BUS_ThongTinDangTuyen.LayTatCaCuaDoanhNghiep(_maDN);
	}

	public void LoadTTDTXD(ref List<DTO_ThongTinDangTuyen> thongTinDangTuyen)
	{
		thongTinDangTuyen = BUS_ThongTinDangTuyen.LayDSTTDTXD();
	}

	public void LoadTTDTHopLe(ref List<DTO_ThongTinDangTuyen> thongTinDangTuyen)
	{
		thongTinDangTuyen = BUS_ThongTinDangTuyen.LayDSTTDTHopLe();
	}

	public Ctrler_ChiTietThongTinDangTuyen HienThi_ChiTiet(string maTTDT)
	{
		var ttdt = BUS_ThongTinDangTuyen.Lay(maTTDT);
		var hoaDon = BUS_HoaDon.Lay(maTTDT);
		var hinhThucDangTuyen = BUS_HinhThucDangTuyen.Lay(ttdt.MaHTDT);
		return new Ctrler_ChiTietThongTinDangTuyen(ttdt, hoaDon, hinhThucDangTuyen);
	}

	public Ctrler_DangTuyenThongTinDangTuyen ChiTietThongTinDangTuyenHopLe(string maTTDT)
	{
		var ttdt = BUS_ThongTinDangTuyen.Lay(maTTDT);
		var hinhThucDangTuyen = BUS_HinhThucDangTuyen.Lay(ttdt.MaHTDT);
		var doanhNghiep = BUS_DoanhNghiep.LoadTTDN(ttdt.MaDN);
		return new Ctrler_DangTuyenThongTinDangTuyen(ttdt, hinhThucDangTuyen, doanhNghiep, this);
	}
}
