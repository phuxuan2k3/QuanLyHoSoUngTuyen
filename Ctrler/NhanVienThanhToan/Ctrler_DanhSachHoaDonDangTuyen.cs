using BUS;
using DAO.Exceptions;
using DTO;
using System.Data.SqlClient;
using Utilis;

namespace Ctrler.NhanVienThanhToan
{
	public class Ctrler_DanhSachHoaDonDangTuyen
	{
		private List<DTO_HoaDon_TenViTri_TenDoanhNghiep> dsHoaDon_TenViTri_TenDoanhNghiep;

		public Ctrler_DanhSachHoaDonDangTuyen()
		{
			this.dsHoaDon_TenViTri_TenDoanhNghiep = new();
		}

		public void Load(ref List<DTO_HoaDon_TenViTri_TenDoanhNghiep> hoaDon_TenViTris)
		{
			hoaDon_TenViTris = BUS_HoaDon.LayTatCa_ChuaThanhToan_HopLe();
			this.dsHoaDon_TenViTri_TenDoanhNghiep = hoaDon_TenViTris;
		}

		public List<DTO_HoaDon_TenViTri_TenDoanhNghiep> LocKetQua(string tenViTri, string tenDoanhNghiep)
		{
			return dsHoaDon_TenViTri_TenDoanhNghiep.Where((x) =>
			{
				var destTenViTri = x.TenViTri.RemoveVietnameseAccent().ToLower().Trim();
				var destTenDoanhNghiep = x.TenDN.RemoveVietnameseAccent().ToLower().Trim();
				var srcTenViTri = tenViTri.RemoveVietnameseAccent().ToLower().Trim();
				var srcTenDoanhNghiep = tenDoanhNghiep.RemoveVietnameseAccent().ToLower().Trim();
				return destTenViTri.Contains(srcTenViTri) && destTenDoanhNghiep.Contains(srcTenDoanhNghiep);
			}).ToList();
		}

		public DTO_HoaDon? TruyVanHoaDon(string maTTDT)
		{
			if (maTTDT.All(char.IsDigit) == false)
			{
				throw new QueryException($"Mã TTDT truy vấn không được chứa ký hiệu không là số. Mã đã nhập: {maTTDT}.");
			}
			_ = int.TryParse(maTTDT, out int intMaTTDT);
			if (!(intMaTTDT > 0 && intMaTTDT < int.MaxValue))
			{
				throw new QueryException($"Mã TTDT truy vấn phải là số nguyên và nằm trong khoảng 0 - {int.MaxValue}. Mã đã nhập: {maTTDT}.");
			}
			try
			{
				return BUS_HoaDon.Lay(maTTDT);
			}
			catch (SqlException)
			{
				throw new QueryException($"Mã TTDT truy vấn không phù hợp. Mã đã nhập: {maTTDT}.");
			}
		}

		public void LoadChiTietHoaDon(string maTTDT, ref DTO_ThongTinDangTuyen thongTinDangTuyen, ref List<DTO_ChiTietHoaDon> chiTietHoaDons, ref DTO_DoanhNghiep doanhNghiep)
		{
			chiTietHoaDons = BUS_HoaDon.LayTatCaChiTiet(maTTDT);
			thongTinDangTuyen = BUS_ThongTinDangTuyen.Lay(maTTDT);
			doanhNghiep = BUS_DoanhNghiep.Lay(thongTinDangTuyen.MaDN);
		}
	}
}
