using BUS;
using DTO;

namespace Ctrler.DoanhNghiep;

public class Ctrler_DanhSachThongTinDangTuyen
{
	private readonly string maDN;

	public Ctrler_DanhSachThongTinDangTuyen(string maDN)
	{
		this.maDN = maDN;
	}

	// todo
	public List<DTO_DuyetPhieuDangKy_ThongTinDangTuyen> LayDSThongTinDangTuyenChoDNDuyet()
	{
		return BUS_ThongTinDangTuyen.LayDSThongTinDangTuyenChoDNDuyet();
	}

	public void Load(ref List<DTO_ThongTinDangTuyen> thongTinDangTuyen)
	{
		thongTinDangTuyen = BUS_ThongTinDangTuyen.LayTatCaCuaDoanhNghiep(maDN);
	}

	public Ctrler_ChiTietThongTinDangTuyen HienThi_ChiTiet(string maTTDT)
	{
		var ttdt = BUS_ThongTinDangTuyen.Lay(maTTDT);
		var hoaDon = BUS_HoaDon.Lay(maTTDT);
		var hinhThucDangTuyen = BUS_HinhThucDangTuyen.Lay(ttdt.MaHTDT);
		return new Ctrler_ChiTietThongTinDangTuyen(ttdt, hoaDon!, hinhThucDangTuyen);
	}
}
