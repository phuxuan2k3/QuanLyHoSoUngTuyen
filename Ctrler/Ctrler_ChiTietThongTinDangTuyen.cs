using BUS;
using DTO;

namespace Ctrler;

public class Ctrler_ChiTietThongTinDangTuyen
{
	private readonly DTO_ThongTinDangTuyen _ttdt;
	private readonly DTO_HoaDon _hoaDon;
	private readonly DTO_HinhThucDangTuyen _hinhThucDangTuyen;
	private readonly DTO_DoanhNghiep _DoanhNghiep;

<<<<<<< Updated upstream
	public Ctrler_DanhSachThongTinDangTuyen Owner { get; set; }

	public Ctrler_ChiTietThongTinDangTuyen(DTO_ThongTinDangTuyen ttdt, DTO_HoaDon hoaDon, DTO_HinhThucDangTuyen hinhThucDangTuyen, Ctrler_DanhSachThongTinDangTuyen owner)
=======

    public Ctrler_ChiTietThongTinDangTuyen(DTO_ThongTinDangTuyen ttdt, DTO_HoaDon hoaDon, DTO_HinhThucDangTuyen hinhThucDangTuyen)
>>>>>>> Stashed changes
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

    public void Load2(ref DTO_ThongTinDangTuyen thongTinDangTuyen, ref DTO_HoaDon hoaDon, ref DTO_HinhThucDangTuyen hinhThucDangTuyen, ref DTO_DoanhNghiep doanhNghiep)
    {
        thongTinDangTuyen = _ttdt;
        hinhThucDangTuyen = _hinhThucDangTuyen;
		hoaDon = _hoaDon;
		doanhNghiep = _DoanhNghiep;
    }

    public void HienThi_HoaDon()
	{
		// todo
	}

	public void HienThi_HieuChinh()
	{
		// todo
	}
    public DTO_ThongTinDangTuyen LayThongTinDangTuyen(string maTTDT)
    {
        return BUS_ThongTinDangTuyen.LayThongTinDangTuyen(maTTDT);
    }
    


    public Ctrler_ChiTietThongTinDangTuyen(DTO_ThongTinDangTuyen ttdt)
    {
        _thongTinDangTuyen = ttdt;
    }


    public void ThongTinDangTuyenvaDSPDk(ref DTO_ThongTinDangTuyen thongTinDangTuyen, ref List<DTO_ThongTinHoSo> thongTinPhieuDangKyUngTuyen)
    {
        thongTinDangTuyen = _thongTinDangTuyen;
        thongTinPhieuDangKyUngTuyen = BUS_ThongTinDangTuyen.LayDSPhieuDangKy(thongTinDangTuyen.MaTTDT);
    }
    public static void CapNhatThongTinPhieuDangKy(DTO_ThongTinHoSo ttpdk)
    {
        BUS_PhieuDangKyUngTuyen.CapNhatThongTinPhieuDangKy(ttpdk);
    }


}
