using DTO;

namespace DAO;

public class DAO_ThongTinDangTuyen
{
	public static List<DTO_ThongTinDangTuyen> LayDSTTDT()
	{
		throw new NotImplementedException();
	}

	public static List<DTO_ThongTinDangTuyen> LayDSTTDT(string maDN)
	{
		return new List<DTO_ThongTinDangTuyen>
			{
				new DTO_ThongTinDangTuyen()
			};
	}

	public static DTO_ThongTinDangTuyen Lay(string maTTDT)
	{
		return new DTO_ThongTinDangTuyen { TenViTri = "Test", SoLuong = 1 };
	}

	public static List<DTO_ThongTinDangTuyen> LayTatCaCuaDoanhNghiep(string maDN)
	{
		return [new DTO_ThongTinDangTuyen { TenViTri = "Test", SoLuong = 1 }];
	}
}
