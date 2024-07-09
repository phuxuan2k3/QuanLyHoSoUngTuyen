using BUS;
using DTO;

namespace Ctrler.DoanhNghiep;

public class Ctrler_XacNhanThanhToan
{
	private DTO_ThongTinDangTuyen thongTinDangTuyen;
	public DTO_ThongTinDangTuyen ThongTinDangTuyen { get => thongTinDangTuyen; }

	private DTO_HinhThucDangTuyen hinhThucDangTuyen;
	private float tongTien;

	public Ctrler_XacNhanThanhToan(DTO_ThongTinDangTuyen thongTinDangTuyen)
	{
		this.thongTinDangTuyen = thongTinDangTuyen;
		hinhThucDangTuyen = new();
	}

	public void Load(ref DTO_ThongTinDangTuyen thongTinDangTuyen, ref DTO_HinhThucDangTuyen hinhThucDangTuyen, ref float tongTien, ref bool coTheThanhToanNhieuDot)
	{
		thongTinDangTuyen = this.thongTinDangTuyen;
		this.hinhThucDangTuyen = BUS_HinhThucDangTuyen.Lay(thongTinDangTuyen.MaHTDT);
		this.tongTien = BUS_HoaDon.TinhTongSoTien(this.hinhThucDangTuyen, thongTinDangTuyen);
		hinhThucDangTuyen = this.hinhThucDangTuyen;
		tongTien = this.tongTien;
		coTheThanhToanNhieuDot = BUS_HoaDon.KiemTraThanhToanNhieuDot(thongTinDangTuyen);
	}

	public void XacNhanThanhToan(CachThucThanhToan cachThucThanhToan)
	{
		var id = BUS_ThongTinDangTuyen.Them(thongTinDangTuyen);
		var hoaDon = new DTO_HoaDon(id.ToString(), tongTien, DateTime.Now, TrangThaiThanhToan.ChuaThanhToan, cachThucThanhToan);
		BUS_HoaDon.Them(hoaDon);
	}
}