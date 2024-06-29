using DTO;

namespace Ctrler;

public class Ctrler_ChiTietThongTinDangTuyen
{
	private readonly DTO_ThongTinDangTuyen _ttdt;
	private readonly DTO_HoaDon _hoaDon;
	private readonly DTO_HinhThucDangTuyen _hinhThucDangTuyen;

	public Ctrler_DanhSachThongTinDangTuyen Owner { get; set; }

	public Ctrler_ChiTietThongTinDangTuyen(DTO_ThongTinDangTuyen ttdt, DTO_HoaDon hoaDon, DTO_HinhThucDangTuyen hinhThucDangTuyen, Ctrler_DanhSachThongTinDangTuyen owner)
	{
		_ttdt = ttdt;
		_hoaDon = hoaDon;
		_hinhThucDangTuyen = hinhThucDangTuyen;
		Owner = owner;
	}


	public void Load(ref DTO_ThongTinDangTuyen thongTinDangTuyen, ref DTO_HoaDon hoaDon, ref DTO_HinhThucDangTuyen hinhThucDangTuyen)
	{
		thongTinDangTuyen = _ttdt;
		hoaDon = _hoaDon;
		hinhThucDangTuyen = _hinhThucDangTuyen;
	}

	public void HienThi_HoaDon()
	{
		// todo
	}

	public void HienThi_HieuChinh()
	{
		// todo
	}
}
