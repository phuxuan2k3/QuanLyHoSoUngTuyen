using DTO;

namespace DAO;

public class DAO_HinhThucDangTuyen
{
	public static DTO_HinhThucDangTuyen Lay(string maHTDT)
	{
		// todo
		return new DTO_HinhThucDangTuyen("1", "test");
	}

	public static List<DTO_HinhThucDangTuyen> LayTatCa()
	{
		// todo
		return [
			new DTO_HinhThucDangTuyen("1", "Bao"),
			new DTO_HinhThucDangTuyen("2", "mang"),
			new DTO_HinhThucDangTuyen("3", "banner"),
		];
	}
}
