using BUS;
using DTO;

namespace Ctrler.NhanVienThanhToan
{
	public class Ctrler_DongPhiChoHoaDon
	{
		private DTO_ThongTinDangTuyen thongTinDangTuyen;
		private DTO_HoaDon hoaDon;
		private DTO_DoanhNghiep doanhNghiep;
		private List<DTO_ChiTietHoaDon> chiTietHoaDons;
		private DTO_ChiTietHoaDon? lanDongHienTai;
		public Ctrler_DongPhiChoHoaDon(DTO_ThongTinDangTuyen thongTinDangTuyen, DTO_HoaDon hoaDon, DTO_DoanhNghiep doanhNghiep, List<DTO_ChiTietHoaDon> chiTietHoaDons)
		{
			this.thongTinDangTuyen = thongTinDangTuyen;
			this.hoaDon = hoaDon;
			this.doanhNghiep = doanhNghiep;
			this.chiTietHoaDons = chiTietHoaDons;
		}

		public void Load(ref DTO_ThongTinDangTuyen thongTinDangTuyen, ref DTO_HoaDon hoaDon, ref DTO_DoanhNghiep doanhNghiep, ref List<DTO_ChiTietHoaDon> chiTietHoaDons, ref DTO_ChiTietHoaDon? lanDongHienTai)
		{
			thongTinDangTuyen = this.thongTinDangTuyen;
			hoaDon = this.hoaDon;
			doanhNghiep = this.doanhNghiep;
			chiTietHoaDons = this.chiTietHoaDons;
			this.lanDongHienTai = BUS_HoaDon.TaoLanThanhToan(hoaDon, chiTietHoaDons);
			lanDongHienTai = this.lanDongHienTai;
		}

		public void DongPhiChoHoaDon()
		{
			if (lanDongHienTai == null)
			{
				throw new Exception("Hóa đơn đã được đóng phí");
			}
			BUS_HoaDon.ThemLanThanhToan(hoaDon, chiTietHoaDons, lanDongHienTai);
		}
	}
}
