using DAO;
using DTO;

namespace BUS;

public class BUS_HinhThucDangTuyen
{
	public static DTO_HinhThucDangTuyen Lay(string maHTDT)
	{
		return DAO_HinhThucDangTuyen.Lay(maHTDT);
	}

	public static List<DTO_HinhThucDangTuyen> LayTatCa()
	{
		return DAO_HinhThucDangTuyen.LayTatCa();
	}
}
