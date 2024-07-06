﻿using DTO;
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
			TongTien = row.IsNull("TONGTIEN") ? -1 : (float)row["TONGTIEN"],
			CachThucThanhToan = row["CACHTHUCTHANHTOAN"].ToString()!.ToCachThucThanhToan(),
			TrangThaiThanhToan = row["TRANGTHAITHANHTOAN"].ToString()!.ToTrangThaiThanhToan(),
			NgayLap = row.IsNull("TONGTIEN") ? DateTime.MinValue : (DateTime)row["NGAYLAP"],
		};
		return htdt;
	}

	public static DTO_HoaDon Lay(string maTTDT)
	{
		var query = @$"SELECT * FROM {tableName} WHERE MATTDT = @MaTTDT";
		var data = SqlSingleton.Instance.ExecuteQuery(query, [new SqlParameter("MaTTDT", maTTDT)]);
		return RowConvert(data.Rows[0]);
	}

	public static void Them(DTO_HoaDon hoaDon)
	{
		var query = $@"INSERT INTO {tableName} (MATTDT, TONGTIEN, CACHTHUC, TRANGTHAI, NGAYLAP) VALUES (@MATTDT, @TONGTIEN, @CACHTHUC, @TRANGTHAI, @NGAYLAP)";
		SqlSingleton.Instance.ExecuteQuery(query, [
			new SqlParameter("MATTDT", hoaDon.MaTTDT),
			new SqlParameter("TONGTIEN", hoaDon.TongTien),
			new SqlParameter("CACHTHUC", hoaDon.CachThucThanhToan.ToString()),
			new SqlParameter("TRANGTHAI", hoaDon.TrangThaiThanhToan.ToString() ),
			new SqlParameter("NGAYLAP", hoaDon.NgayLap.ToString()),
			]);
	}
}