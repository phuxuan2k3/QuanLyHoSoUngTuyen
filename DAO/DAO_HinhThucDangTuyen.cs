using DAO.Exceptions;
using DTO;
using System.Data;

namespace DAO;
public class DAO_HinhThucDangTuyen
{
	const string tableName = "HINHTHUCDANGTUYEN";
	private static DTO_HinhThucDangTuyen RowConvert(DataRow row)
	{
		try
		{
			DTO_HinhThucDangTuyen htdt = new DTO_HinhThucDangTuyen
			{
				MaHTDT = row["MAHINHTHUC"].ToString()!,
				TenHinhThuc = row["TENHINHTHUC"]!.ToString()!,
				MoTa = row["MOTA"].ToString()!,

				Gia = row.IsNull("GIA") ? -1 : Convert.ToSingle(row["GIA"])
			};
			return htdt;
		}
		catch (NullReferenceException)
		{
			throw new NullDatarowException();
		}
	}

	public static DTO_HinhThucDangTuyen Lay(string maHTDT)
	{
		var query = $@"select * from {tableName} where MaHinhThuc = @MaHinhThuc";
		var dataTable = SqlSingleton.Instance.ExecuteQuery(query, [new("MaHinhThuc", maHTDT)]);
		return RowConvert(dataTable.Rows[0]);
	}

	public static List<DTO_HinhThucDangTuyen> LayTatCa()
	{
		var query = @$"select * from {tableName}";
		var dataTable = SqlSingleton.Instance.ExecuteQuery(query);
		var hinhThucDangTuyens = new List<DTO_HinhThucDangTuyen>();
		foreach (DataRow row in dataTable.Rows)
		{
			hinhThucDangTuyens.Add(RowConvert(row));
		}
		return hinhThucDangTuyens;
	}
}
