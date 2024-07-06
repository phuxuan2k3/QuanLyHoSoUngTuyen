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
			var ngayHetHan = ttdt.ThoiGianDangTuyen!.Value.AddDays(ttdt.SoNgayDangTuyen);
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
    public static List<DTO_ThongTinDangTuyen> LayDSTTDTDuyet()
    {
        return DAO_ThongTinDangTuyen.LayDSTTDTDuyet();
    }
    public static DTO_ThongTinDangTuyen LayCTTTDT(string maTTDT)
    {
        return DAO_ThongTinDangTuyen.LayCTTTDT(maTTDT);
    }
    public static List<DTO_PhieuDangKyUngTuyen> LayDSPDK(string maTTDT)
    {
        return DAO_ThongTinDangTuyen.LayDSPDK(maTTDT);
    }
}
