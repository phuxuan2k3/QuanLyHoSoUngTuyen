using DTO;
using System.Data;

namespace DAO;

public class DAO_ChiTietHoaDon
{
	private const string tableName = "CT_HOADON";
	private static DTO_ChiTietHoaDon RowConvert(DataRow row)
	{
		var dto = new DTO_ChiTietHoaDon
		{
			MaTTDT = row["MATTDT"].ToString()!,
			LanThanhToan = Convert.ToInt32(row["LANTT"]),
			SoTienCanThanhToan = Convert.ToSingle(row["SOTIENCANTHANHTOAN"]),
			NgayThanhToan = Convert.ToDateTime(row["NGAYTHANHTOAN"])
		};
		return dto;
	}

	public static List<DTO_ChiTietHoaDon> LayTatCaCuaHoaDon(string maTTDT)
	{
		var query = $@"SELECT * FROM {tableName} WHERE MaTTDT = @MaTTDT";
		var data = SqlSingleton.Instance.ExecuteQuery(query,
			[new("MaTTDT", maTTDT)]
			);
		var dtos = new List<DTO_ChiTietHoaDon>();
		foreach (DataRow row in data.Rows)
		{
			dtos.Add(RowConvert(row));
		}
		return dtos;
	}

	public static void Them(DTO_ChiTietHoaDon chiTietHoaDon)
	{
		var query = $@"INSERT INTO {tableName} (MATTDT, LANTT, SOTIENCANTHANHTOAN, NGAYTHANHTOAN) VALUES (@MATTDT, @LANTT, @SOTIENCANTHANHTOAN, @NGAYTHANHTOAN)";
		SqlSingleton.Instance.ExecuteNonQuery(query, [
			new("MATTDT", chiTietHoaDon.MaTTDT),
			new("LANTT", chiTietHoaDon.LanThanhToan),
			new("SOTIENCANTHANHTOAN", chiTietHoaDon.SoTienCanThanhToan),
			new("NGAYTHANHTOAN", chiTietHoaDon.NgayThanhToan.ToString())
			]);
	}
}
