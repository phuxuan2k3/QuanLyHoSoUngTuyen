using DAO;
using DAO.Exceptions;
using DTO;

namespace BUS;

public class BUS_ThongTinDangTuyen
{
	public static List<DTO_ThongTinDangTuyen> LayDanhSachTTDTSapHetHan()
	{
		var lsTTDT = DAO_ThongTinDangTuyen.LayDSTTDT();
		var lsTTDTSapHetHan = lsTTDT.Where(ttdt =>
		{
			var ngayHetHan = ttdt.ThoiGianDangTuyen.AddDays(ttdt.SoNgayDangTuyen);
			return (ngayHetHan - DateTime.Now).TotalDays < 3.0;
		}).ToList();
		return lsTTDTSapHetHan;
		return [];
	}

	public static List<DTO_ThongTinDangTuyen> LayDanhSachTTDT(string maDN)
	{
		return DAO_ThongTinDangTuyen.LayTatCaCuaDoanhNghiep(maDN);
	}

	public static DTO_ThongTinDangTuyen Lay(string maTTDT)
	{
		return DAO_ThongTinDangTuyen.Lay(maTTDT);
	}

	public static List<DTO_ThongTinDangTuyen> LayTatCaCuaDoanhNghiep(string maDN)
	{
		return DAO_ThongTinDangTuyen.LayTatCaCuaDoanhNghiep(maDN);
	}

	public static List<DTO_ThongTinDangTuyen> LayDSTTDTXD()
	{
		return DAO_ThongTinDangTuyen.LoadTTDTXD();
	}

	public static List<DTO_ThongTinDangTuyen> LayDSTTDTHopLe()
	{
		return DAO_ThongTinDangTuyen.LoadTTDTHopLe();
	}

	private static bool KiemTra(DTO_ThongTinDangTuyen thongTinDangTuyen)
	{
		if (thongTinDangTuyen.SoNgayDangTuyen < 1 ||
			thongTinDangTuyen.ThoiGianDangTuyen.Date < DateTime.Now.AddDays(1).Date ||
			string.IsNullOrEmpty(thongTinDangTuyen.TenViTri) == true ||
			thongTinDangTuyen.SoLuong < 1 ||
			string.IsNullOrEmpty(thongTinDangTuyen.YeuCau) == true)
		{
			return false;
		}
		try
		{
			DAO_HinhThucDangTuyen.Lay(thongTinDangTuyen.MaHTDT);
		}
		catch (NullDatarowException)
		{
			return false;
		}
		return true;
	}

	public static void Them(DTO_ThongTinDangTuyen thongTinDangTuyen)
	{
		if (KiemTra(thongTinDangTuyen) == false)
		{
			return;
		}
		DAO_ThongTinDangTuyen.Them(thongTinDangTuyen);
	}
	
	public static void CapNhat(DTO_ThongTinDangTuyen thongTinDangTuyen)
	{
		if (KiemTra(thongTinDangTuyen) == false)
		{
			return;
		}
		DAO_ThongTinDangTuyen.CapNhat(thongTinDangTuyen);
	}

	public static void CapNhatTrangThaiTTDT(string MaTTDT, string TrangThai)
	{
		DAO_ThongTinDangTuyen.CapNhatTrangThaiTTDT(MaTTDT, TrangThai);

	}

	public static void CapNhatTrangThaiDangTuyen(string MaTTDT)
	{
		DAO_ThongTinDangTuyen.CapNhatTrangThaiDangTuyen(MaTTDT);
	}
}
