using DTO;

namespace DAO;

public class DAO_ChiTietHoaDon
{
	public static List<DTO_ChiTietHoaDon> LayTatCaCuaHoaDon(string maTTDT)
	{
		// todo
		return new List<DTO_ChiTietHoaDon>()
	   {
			new("TT001", 1, 1500.50f, new DateTime(2023, 5, 15)),
			new("TT002", 2, 2500.75f, new DateTime(2023, 6, 20)),
			new("TT003", 3, 3500.00f, new DateTime(2023, 7, 25)),
			new("TT004", 4, 4500.25f, new DateTime(2023, 8, 30)),
		};
	}
}
