using BUS;
using Ctrler.Sub;
using DTO;

namespace Ctrler.DoanhNghiep
{
	public class Ctrler_HoaDonThongTinDangTuyen
	{
		private DTO_ThongTinDangTuyen thongTinDangTuyen;
		private DTO_HoaDon hoaDon;
		private DTO_HinhThucDangTuyen hinhThucDangTuyen;
		private List<DTO_ChiTietHoaDon> dsChiTietHoaDon;

		public Ctrler_HoaDonThongTinDangTuyen(DTO_ThongTinDangTuyen thongTinDangTuyen, DTO_HoaDon hoaDon, DTO_HinhThucDangTuyen hinhThucDangTuyen)
		{
			this.thongTinDangTuyen = thongTinDangTuyen;
			this.hoaDon = hoaDon;
			this.hinhThucDangTuyen = hinhThucDangTuyen;
			dsChiTietHoaDon = new();
		}

		public void Load(ref DTO_ThongTinDangTuyen thongTinDangTuyen, ref DTO_HoaDon hoaDon, ref DTO_HinhThucDangTuyen hinhThucDangTuyen, ref List<DTO_ChiTietHoaDon> dsChiTietHoaDon)
		{
			thongTinDangTuyen = this.thongTinDangTuyen;
			hoaDon = this.hoaDon;
			hinhThucDangTuyen = this.hinhThucDangTuyen;
			this.dsChiTietHoaDon = BUS_HoaDon.LayTatCaChiTiet(thongTinDangTuyen.MaTTDT);
			dsChiTietHoaDon = this.dsChiTietHoaDon;
		}

		public void LoadChiTiet(ref DTO_ThongTinDangTuyen thongTinDangTuyen, ref DTO_HoaDon hoaDon, ref DTO_HinhThucDangTuyen hinhThucDangTuyen)
		{
			thongTinDangTuyen = this.thongTinDangTuyen;
			hoaDon = this.hoaDon;
			hinhThucDangTuyen = this.hinhThucDangTuyen;
		}

		public void XuatPDF(string outPath)
		{
			Ctrler_PDF.Xuat(thongTinDangTuyen, hinhThucDangTuyen, hoaDon, dsChiTietHoaDon, outPath);
		}
	}
}
