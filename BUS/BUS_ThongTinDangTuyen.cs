using DAO;
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
	}

	public static List<DTO_ThongTinDangTuyen> LayDanhSachTTDT(string maDN)
	{
		return DAO_ThongTinDangTuyen.LayDSTTDT(maDN);
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

    public static void CapNhatTrangThaiTTDT(string MaTTDT, string TrangThai) { 
		DAO_ThongTinDangTuyen.CapNhatTrangThaiTTDT(MaTTDT, TrangThai);
	
	}

	public static void CapNhatTrangThaiDangTuyen(string MaTTDT)
	{
		DAO_ThongTinDangTuyen.CapNhatTrangThaiDangTuyen(MaTTDT);
	}
}
