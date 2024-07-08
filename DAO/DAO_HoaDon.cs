using DTO;
using System.Data;
using System.Data.SqlClient;
using Utilis;

namespace DAO;

public class DAO_HoaDon
{
	private const string tableName = "HOADON";
	private static DTO_HoaDon RowConvert(DataRow row)
	{
		DTO_HoaDon htdt = new DTO_HoaDon
		{
			MaTTDT = row["MATTDT"].ToString()!,
			TongTien = row.IsNull("TONGTIEN") ? -1 : Convert.ToSingle(row["TONGTIEN"]),
			CachThucThanhToan = row["CACHTHUC"].ToString()!.ToCachThucThanhToan(),
			TrangThaiThanhToan = row["TRANGTHAI"].ToString()!.ToTrangThaiThanhToan(),
			NgayLap = row.IsNull("TONGTIEN") ? DateTime.MinValue : (DateTime)row["NGAYLAP"],
		};
		return htdt;
	}

	public static DTO_HoaDon? Lay(string maTTDT)
	{
		var query = @$"SELECT * FROM {tableName} WHERE MATTDT = @MaTTDT";
		var data = SqlSingleton.Instance.ExecuteQuery(query, [new SqlParameter("MaTTDT", maTTDT)]);
		if (data.Rows.Count == 0)
		{
			return null;
		}
		return RowConvert(data.Rows[0]);
	}

	public static List<DTO_HoaDon> LayTatCaChuaThanhToan()
	{
		var query = $@"SELECT * FROM {tableName} WHERE TRANGTHAI IN (N'Chưa thanh toán', N'Chưa thanh toán hoàn tất')";
		var data = SqlSingleton.Instance.ExecuteQuery(query);
		var dtos = new List<DTO_HoaDon>();
		foreach (DataRow row in data.Rows)
		{
			dtos.Add(RowConvert(row));
		}
		return dtos;
	}

	public static void Them(DTO_HoaDon hoaDon)
	{
		var query = $@"INSERT INTO {tableName} (MATTDT, TONGTIEN, CACHTHUC, TRANGTHAI, NGAYLAP) VALUES (@MATTDT, @TONGTIEN, @CACHTHUC, @TRANGTHAI, @NGAYLAP);";
		SqlSingleton.Instance.ExecuteNonQuery(query, [
			new SqlParameter("MATTDT", hoaDon.MaTTDT),
			new SqlParameter("TONGTIEN", hoaDon.TongTien),
			new SqlParameter("CACHTHUC", hoaDon.CachThucThanhToan.ToDisplayString()),
			new SqlParameter("TRANGTHAI", hoaDon.TrangThaiThanhToan.ToDisplayString() ),
			new SqlParameter("NGAYLAP", hoaDon.NgayLap.ToString()),
			]);
	}

	public static void CapNhat(DTO_HoaDon hoaDon)
	{
		var query = $@"UPDATE {tableName} SET TONGTIEN = @TONGTIEN, CACHTHUC = @CACHTHUC, TRANGTHAI = @TRANGTHAI, NGAYLAP = @NGAYLAP WHERE MATTDT = @MATTDT";
		SqlSingleton.Instance.ExecuteQuery(query, [
			new ("MATTDT", hoaDon.MaTTDT),
			new ("TONGTIEN", hoaDon.TongTien),
			new ("CACHTHUC", hoaDon.CachThucThanhToan.ToDisplayString()),
			new ("TRANGTHAI", hoaDon.TrangThaiThanhToan.ToDisplayString()),
			new ("NGAYLAP", hoaDon.NgayLap.ToString()),
			]);
	}
}
