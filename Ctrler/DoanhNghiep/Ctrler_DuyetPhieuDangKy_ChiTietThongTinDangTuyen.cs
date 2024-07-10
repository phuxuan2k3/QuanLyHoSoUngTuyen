using BUS;
using DTO;

namespace Ctrler.DoanhNghiep;

public class Ctrler_DuyetPhieuDangKy_ChiTietThongTinDangTuyen
{
	private readonly DTO_ThongTinDangTuyen _thongTinDangTuyen;

	public Ctrler_DuyetPhieuDangKy_ChiTietThongTinDangTuyen(DTO_ThongTinDangTuyen ttdt)
	{
		_thongTinDangTuyen = ttdt;
	}

	public void ThongTinDangTuyenvaDSPDk(ref DTO_ThongTinDangTuyen thongTinDangTuyen, ref List<DTO_ThongTinHoSo> thongTinPhieuDangKyUngTuyen)
	{
		thongTinDangTuyen = _thongTinDangTuyen;
		thongTinPhieuDangKyUngTuyen = BUS_ThongTinDangTuyen.LayDSPhieuDangKy(thongTinDangTuyen.MaTTDT);
	}

    public void DanhSachHoSo(ref DTO_ThongTinDangTuyen thongTinDangTuyen, ref List<DTO_ThongTinHoSo> thongTinPhieuDangKyUngTuyen)
    {
        thongTinDangTuyen = _thongTinDangTuyen;
        thongTinPhieuDangKyUngTuyen = BUS_ThongTinDangTuyen.DanhSachHoSo(thongTinDangTuyen.MaTTDT);
    }
}
