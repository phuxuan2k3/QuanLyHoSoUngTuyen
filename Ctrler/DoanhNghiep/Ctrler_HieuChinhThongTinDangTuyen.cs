using BUS;
using DTO;

namespace Ctrler.DoanhNghiep;

public class Ctrler_HieuChinhThongTinDangTuyen
{
	private readonly DTO_ThongTinDangTuyen thongTinDangTuyen;
	private readonly DTO_HoaDon hoaDon;
	private readonly DTO_HinhThucDangTuyen hinhThucDangTuyen;

	public Ctrler_HieuChinhThongTinDangTuyen(DTO_ThongTinDangTuyen thongTinDangTuyen, DTO_HoaDon hoaDon, DTO_HinhThucDangTuyen hinhThucDangTuyen)
	{
		this.thongTinDangTuyen = thongTinDangTuyen;
		this.hoaDon = hoaDon;
		this.hinhThucDangTuyen = hinhThucDangTuyen;
	}

	public void Load(ref DTO_ThongTinDangTuyen thongTinDangTuyen, ref DTO_HinhThucDangTuyen hinhThucDangTuyen)
	{
		thongTinDangTuyen = this.thongTinDangTuyen;
		hinhThucDangTuyen = this.hinhThucDangTuyen;
	}

	public void XacNhanHieuChinh(DTO_ThongTinDangTuyen thongTinDangTuyen)
	{
		this.thongTinDangTuyen.TenViTri = thongTinDangTuyen.TenViTri;
		this.thongTinDangTuyen.SoLuong = thongTinDangTuyen.SoLuong;
		this.thongTinDangTuyen.YeuCau = thongTinDangTuyen.YeuCau;
		this.thongTinDangTuyen.TinhTrang = TinhTrangThongTinDangTuyen.CanHieuChinh;
		this.thongTinDangTuyen.TrangThai = TrangThaiThongTinDangTuyen.ChuaXetDuyet;
		BUS_ThongTinDangTuyen.CapNhat(this.thongTinDangTuyen);
	}

	public void LoadChiTiet(ref DTO_ThongTinDangTuyen thongTinDangTuyen, ref DTO_HoaDon hoaDon, ref DTO_HinhThucDangTuyen hinhThucDangTuyen)
	{
		thongTinDangTuyen = this.thongTinDangTuyen;
		hoaDon = this.hoaDon;
		hinhThucDangTuyen = this.hinhThucDangTuyen;
	}

	//public Ctrler_ChiTietThongTinDangTuyen HienThi_ChiTietThongTinDangTuyen()
	//{
	//	return new Ctrler_ChiTietThongTinDangTuyen(thongTinDangTuyen, hoaDon, hinhThucDangTuyen);
	//}
}
