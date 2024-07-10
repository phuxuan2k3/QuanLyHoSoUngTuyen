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

	public void LoadChiTiet(string maTTDT, ref DTO_ThongTinDangTuyen thongTinDangTuyen, ref DTO_HoaDon hoaDon, ref DTO_HinhThucDangTuyen hinhThucDangTuyen)
	{
		thongTinDangTuyen = BUS_ThongTinDangTuyen.Lay(maTTDT);
		hoaDon = BUS_HoaDon.Lay(maTTDT) ?? new DTO_HoaDon();
		hinhThucDangTuyen = BUS_HinhThucDangTuyen.Lay(thongTinDangTuyen.MaHTDT);
	}
}
