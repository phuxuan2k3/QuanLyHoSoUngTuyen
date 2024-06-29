using DAO;
using DTO;

namespace BUS;

public class BUS_HoaDon
{
	public static DTO_HoaDon Lay(string maTTDT)
	{
		return DAO_HoaDon.Lay(maTTDT);
	}
}
