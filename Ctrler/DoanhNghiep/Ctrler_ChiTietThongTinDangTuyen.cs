using BUS;
using DTO;

namespace Ctrler.DoanhNghiep;

public class Ctrler_ChiTietThongTinDangTuyen
{
	private readonly DTO_ThongTinDangTuyen thongTinDangTuyen;
	private readonly DTO_HoaDon hoaDon;
	private readonly DTO_HinhThucDangTuyen hinhThucDangTuyen;

	public Ctrler_ChiTietThongTinDangTuyen(DTO_ThongTinDangTuyen thongTinDangTuyen, DTO_HoaDon hoaDon, DTO_HinhThucDangTuyen hinhThucDangTuyen)
	{
		this.thongTinDangTuyen = thongTinDangTuyen;
		this.hoaDon = hoaDon;
		this.hinhThucDangTuyen = hinhThucDangTuyen;
	}

	public void Load(ref DTO_ThongTinDangTuyen thongTinDangTuyen, ref DTO_HoaDon hoaDon, ref DTO_HinhThucDangTuyen hinhThucDangTuyen)
	{
		thongTinDangTuyen = this.thongTinDangTuyen;
		hoaDon = this.hoaDon;
		hinhThucDangTuyen = this.hinhThucDangTuyen;
	}

    public static void CapNhatThongTinPhieuDangKy(DTO_ThongTinHoSo ttpdk)
    {
         BUS_PhieuDangKyUngTuyen.CapNhatThongTinPhieuDangKy(ttpdk);
    }    
	public static void CapNhatThongTinPhieuDangKy_DN(DTO_ThongTinHoSo ttpdk)
    {
         BUS_PhieuDangKyUngTuyen.CapNhatThongTinPhieuDangKy_DN(ttpdk);
    }
}
