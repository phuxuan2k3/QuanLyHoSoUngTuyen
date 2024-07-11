using BUS;
using DAO.Exceptions;
using DTO;
using System.Data.SqlClient;

namespace Ctrler.NhanVienThanhToan
{
	public class Ctrler_DanhSachHoaDonDangTuyen
	{
		public void Load(ref List<DTO_HoaDon> hoaDons)
		{
			hoaDons = BUS_HoaDon.LayTatCaChuaThanhToan();
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
