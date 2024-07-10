using DTO;
using System.Data;
using System.Data.SqlClient;
using System.Net.Http.Headers;
using Utilis;

namespace DAO;

public class DAO_ThongTinDangTuyen
{
	private const string tableName = "THONGTINDANGTUYEN";
	private static DTO_ThongTinDangTuyen ConvertRow(DataRow row)
	{
		return new DTO_ThongTinDangTuyen
		{
			MaTTDT = row["MATTDT"].ToString()!,
			MaDN = row["MADN"].ToString()!,
			SoNgayDangTuyen = Convert.ToInt32(row["SONGAYDT"]),
			MaHTDT = row["MAHTDT"].ToString()!,
			ThoiGianDangTuyen = Convert.ToDateTime(row["THOIGIANDANGTUYEN"]),
			TenViTri = row["TENVITRI"].ToString()!,
			SoLuong = Convert.ToInt32(row["SOLUONG"])!,
			YeuCau = row["YEUCAU"].ToString()!,
			TrangThai = row["TRANGTHAI"].ToString()!.ToTrangThaiThongTinDangTuyen(),
			TinhTrang = row["TINHTRANG"].ToString()!.ToTinhTrangThongTinDangTuyen()
		};
	}

	public static DTO_ThongTinDangTuyen Lay(string maTTDT)
	{
		var query = @$"select * from {tableName} where MATTDT =  " + maTTDT;
		var dataTable = SqlSingleton.Instance.ExecuteQuery(query);
		return ConvertRow(dataTable.Rows[0]);
	}

	public static List<DTO_ThongTinDangTuyen> LayTatCaCuaDoanhNghiep(string maDN)
	{
		var query = $@"select * from {tableName} where MaDN = @MaDN";
		var dataTable = SqlSingleton.Instance.ExecuteQuery(query, [new SqlParameter("MaDN", maDN)]);
		var thongTinDangTuyens = new List<DTO_ThongTinDangTuyen>();
		foreach (DataRow row in dataTable.Rows)
		{
			thongTinDangTuyens.Add(ConvertRow(row));
		}
		return thongTinDangTuyens;
	}

	public static int Them(DTO_ThongTinDangTuyen thongTinDangTuyen)
	{
		var query = $@"INSERT INTO {tableName} (MaDN, SoNgayDT, MaHTDT, ThoiGianDangTuyen, TrangThai, TinhTrang, TenViTri, SoLuong, YeuCau) VALUES (@MaDN, @SoNgayDT, @MaHTDT, @ThoiGianDangTuyen, @TrangThai, @TinhTrang, @TenViTri, @SoLuong, @YeuCau); SELECT SCOPE_IDENTITY();";
		var idRaw = SqlSingleton.Instance.ExecuteScalar(query, [
			new SqlParameter("MaDN", thongTinDangTuyen.MaDN),
			new SqlParameter("SoNgayDT", thongTinDangTuyen.SoNgayDangTuyen),
			new SqlParameter("ThoiGianDangTuyen", thongTinDangTuyen.ThoiGianDangTuyen.ToString()),
			new SqlParameter("MaHTDT", thongTinDangTuyen.MaHTDT),
			new SqlParameter("TrangThai", thongTinDangTuyen.TrangThai.ToDisplayString()),
			new SqlParameter("TinhTrang", thongTinDangTuyen.TinhTrang.ToDisplayString()),
			new SqlParameter("TenViTri", thongTinDangTuyen.TenViTri),
			new SqlParameter("SoLuong", thongTinDangTuyen.SoLuong),
			new SqlParameter("YeuCau", thongTinDangTuyen.YeuCau),
		]);
		var id = Convert.ToInt32(idRaw);
		return id;
	}

	public static List<DTO_ThongTinDangTuyen> LayDSTTDT()
	{
		var query = $@"select * from {tableName} ";
		var dataTable = SqlSingleton.Instance.ExecuteQuery(query);
		var thongTinDangTuyens = new List<DTO_ThongTinDangTuyen>();
		foreach (DataRow row in dataTable.Rows)
		{
			thongTinDangTuyens.Add(ConvertRow(row));
		}
		return thongTinDangTuyens;
	}

	public static void CapNhat(DTO_ThongTinDangTuyen thongTinDangTuyen)
	{
		var query = $@"UPDATE {tableName} SET MaDN = @MaDN, SoNgayDT = @SoNgayDT, MaHTDT = @MaHTDT, ThoiGianDangTuyen = @ThoiGianDangTuyen, TrangThai = @TrangThai, TinhTrang = @TinhTrang, TenViTri = @TenViTri, SoLuong = @SoLuong, YeuCau = @YeuCau WHERE MaTTDT = @MaTTDT";
		SqlSingleton.Instance.ExecuteNonQuery(query, [
			new SqlParameter("MaTTDT", thongTinDangTuyen.MaTTDT),
			new SqlParameter("MaDN", thongTinDangTuyen.MaDN),
			new SqlParameter("SoNgayDT", thongTinDangTuyen.SoNgayDangTuyen),
			new SqlParameter("ThoiGianDangTuyen", thongTinDangTuyen.ThoiGianDangTuyen.ToString()),
			new SqlParameter("MaHTDT", thongTinDangTuyen.MaHTDT),
			new SqlParameter("TrangThai", thongTinDangTuyen.TrangThai.ToDisplayString()),
			new SqlParameter("TinhTrang", thongTinDangTuyen.TinhTrang.ToDisplayString()),
			new SqlParameter("TenViTri", thongTinDangTuyen.TenViTri),
			new SqlParameter("SoLuong", thongTinDangTuyen.SoLuong),
			new SqlParameter("YeuCau", thongTinDangTuyen.YeuCau),
		]);
	}

	public static List<DTO_ThongTinDangTuyen> LayDSTTDTCanXetDuyet()
	{
		string query = "select * from THONGTINDANGTUYEN where TRANGTHAI = N'Chưa xét duyệt' ";
		DataTable dataTable = new DataTable();
		dataTable = SqlSingleton.Instance.ExecuteQuery(query);
		List<DTO_ThongTinDangTuyen> ds = new List<DTO_ThongTinDangTuyen>();
		foreach (DataRow row in dataTable.Rows)
		{
			DTO_ThongTinDangTuyen ttdt = ConvertRow(row);
			ds.Add(ttdt);
		}
		return ds;
	}

	public static List<DTO_ThongTinDangTuyen> LayDSTTDT(string maDN)
	{
		string query = "select * from THONGTINDANGTUYEN where MADN =  " + maDN;
		var dataTable = SqlSingleton.Instance.ExecuteQuery(query);
		var lsTTDT = dataTable.AsEnumerable().Select(x => new DTO_ThongTinDangTuyen()
		{
			MaTTDT = x.Field<int>("MATTDT").ToString()!,
			MaDN = x.Field<int>("MADN").ToString()!,
			SoNgayDangTuyen = x.Field<int>("SONGAYDT")!,
			MaHTDT = x.Field<string>("MAHTDT")!,
			TenViTri = x.Field<string>("TENVITRI")!,
			SoLuong = x.Field<int>("SOLUONG")!,
			YeuCau = x.Field<string>("YEUCAU")!
		}).ToList();
		return lsTTDT;
	}

	public static void CapNhatTrangThai(string MaTTDT, TrangThaiThongTinDangTuyen trangThai)
	{
		string query = "update THONGTINDANGTUYEN set TRANGTHAI = N'" + trangThai.ToDisplayString() + "' where MATTDT = " + MaTTDT;
		SqlSingleton.Instance.ExecuteNonQuery(query);
	}

	public static void CapNhatDaDangTuyen(string MaTTDT)
	{
		string query = "update THONGTINDANGTUYEN set TINHTRANG = N'Đã đăng tuyển' where MATTDT = " + MaTTDT;
		SqlSingleton.Instance.ExecuteNonQuery(query);
	}

	public static List<DTO_ThongTinDangTuyen> LayDSTTDTCanDangTuyen()
	{
		string query = $@"select * from {tableName} where TINHTRANG = N'Hợp lệ' AND TRANGTHAI <> N'Đã đăng tuyển'";
		DataTable dataTable = new DataTable();
		dataTable = SqlSingleton.Instance.ExecuteQuery(query);
		List<DTO_ThongTinDangTuyen> ds = new List<DTO_ThongTinDangTuyen>();
		foreach (DataRow row in dataTable.Rows)
		{
			DTO_ThongTinDangTuyen ttdt = ConvertRow(row);
			ds.Add(ttdt);
		}
		return ds;
	}

	public static List<DTO_DuyetPhieuDangKy_ThongTinDangTuyen> LayDSThongTinDangTuyenChoDNDuyet()
	{
		string query = "SELECT MATTDT,MADN,SoLuong FROM THONGTINDANGTUYEN " +
			"WHERE SOLUONG <= (SELECT COUNT(*) FROM PHIEUDANGKYUNGTUYEN WHERE PHIEUDANGKYUNGTUYEN.MATTDT = THONGTINDANGTUYEN.MATTDT and TRANGTHAI In (N'Đã xử lý',N'Đạt',N'Không đạt'))";

		DataTable dataTable = new DataTable();
		dataTable = SqlSingleton.Instance.ExecuteQuery(query);

		List<DTO_DuyetPhieuDangKy_ThongTinDangTuyen> ds = new List<DTO_DuyetPhieuDangKy_ThongTinDangTuyen>();

		foreach (DataRow row in dataTable.Rows)
		{
			DTO_DuyetPhieuDangKy_ThongTinDangTuyen ttdt = new DTO_DuyetPhieuDangKy_ThongTinDangTuyen
			{
				MaTTDT = row["MATTDT"].ToString(),
				MaDN = row["MADN"].ToString(),
				SoLuong = Convert.ToInt32(row["SoLuong"]),
			};

			ds.Add(ttdt);
		}
		return ds;
	}
	public static List<DTO_DuyetPhieuDangKy_ThongTinDangTuyen> LayDSThongTinDangTuyenDuyetPDK()
	{
		string query = "SELECT MATTDT,MADN,SoLuong FROM THONGTINDANGTUYEN " +
			"WHERE SOLUONG <= (SELECT COUNT(*) FROM PHIEUDANGKYUNGTUYEN WHERE PHIEUDANGKYUNGTUYEN.MATTDT = THONGTINDANGTUYEN.MATTDT )";

		DataTable dataTable = new DataTable();
		dataTable = SqlSingleton.Instance.ExecuteQuery(query);

		List<DTO_DuyetPhieuDangKy_ThongTinDangTuyen> ds = new List<DTO_DuyetPhieuDangKy_ThongTinDangTuyen>();

		foreach (DataRow row in dataTable.Rows)
		{
			DTO_DuyetPhieuDangKy_ThongTinDangTuyen ttdt = new DTO_DuyetPhieuDangKy_ThongTinDangTuyen
			{
				MaTTDT = row["MATTDT"].ToString(),
				MaDN = row["MADN"].ToString(),
				SoLuong = Convert.ToInt32(row["SoLuong"]),
			};

			ds.Add(ttdt);
		}
		return ds;
	}

	public static DTO_ThongTinDangTuyen LayThongTinDangTuyen(string maTTDT)
	{
		string query = "select * from THONGTINDANGTUYEN where MATTDT = " + maTTDT;
		DataTable dataTable = new DataTable();
		dataTable = SqlSingleton.Instance.ExecuteQuery(query);

		if (dataTable.Rows.Count > 0)
		{
			DataRow row = dataTable.Rows[0];
			DTO_ThongTinDangTuyen doanhNghiep = ConvertRow(row);
			return doanhNghiep;
		}
		else
		{
			return null;
		}
	}
	public static List<DTO_ThongTinHoSo> LayDSPhieuDangKy(string maTTDT)
	{
		string query = "SELECT \r\n    p.MAUV,\r\n    u.TenUngVien,\r\n    p.TRANGTHAI \r\nFROM \r\n    PHIEUDANGKYUNGTUYEN p\r\nJOIN \r\n    UNGVIEN u ON p.MAUV = u.MaUngVien\r\nWHERE \r\n    p.MATTDT = " + maTTDT;
		DataTable dataTable = new DataTable();
		dataTable = SqlSingleton.Instance.ExecuteQuery(query);

		List<DTO_ThongTinHoSo> dsPhDK = new List<DTO_ThongTinHoSo>();

		foreach (DataRow row in dataTable.Rows)
		{
			DTO_ThongTinHoSo phDK = new DTO_ThongTinHoSo
			{
				MaUV = row["MAUV"].ToString(),
				TrangThai = row["TRANGTHAI"].ToString()
			};

			dsPhDK.Add(phDK);
		}
		return dsPhDK;
	}


	public static List<DTO_ThongTinHoSo> DanhSachHoSo(string maTTDT)
	{
		string query = "SELECT \r\n    p.MAUV,\r\n    u.TenUngVien,\r\n    p.TRANGTHAI \r\nFROM \r\n    PHIEUDANGKYUNGTUYEN p\r\nJOIN \r\n    UNGVIEN u ON p.MAUV = u.MaUngVien\r\nWHERE \r\n  p.TRANGTHAI in( N'Đạt',N'Đã xử lý',N'Không đạt') and  p.MATTDT = " + maTTDT;
		DataTable dataTable = new DataTable();
		dataTable = SqlSingleton.Instance.ExecuteQuery(query);

		List<DTO_ThongTinHoSo> dsPhDK = new List<DTO_ThongTinHoSo>();

		foreach (DataRow row in dataTable.Rows)
		{
			DTO_ThongTinHoSo phDK = new DTO_ThongTinHoSo
			{
				MaUV = row["MAUV"].ToString(),
				TrangThai = row["TRANGTHAI"].ToString()
			};

			dsPhDK.Add(phDK);
		}
		return dsPhDK;
	}

	public static List<DTO_ThongTinDangTuyen> LoadTTDTHopLe()
	{
		string query = "select * from THONGTINDANGTUYEN where TINHTRANG = N'Hợp lệ' AND TRANGTHAI <> N'Đã đăng tuyển'";
		DataTable dataTable = new DataTable();
		dataTable = SqlSingleton.Instance.ExecuteQuery(query);
		List<DTO_ThongTinDangTuyen> ds = new List<DTO_ThongTinDangTuyen>();
		foreach (DataRow row in dataTable.Rows)
		{
			DTO_ThongTinDangTuyen ttdt = ConvertRow(row);
			ds.Add(ttdt);
		}
		return ds;
	}

	public static Boolean check_Vitri(string value)
	{
		string QueryStr = $"SELECT * FROM THONGTINDANGTUYEN WHERE TENVITRI LIKE N'%{value}%';";

		Console.WriteLine(QueryStr);
		SqlDataReader reader = DatabaseDAO.getQueryStr(QueryStr);

		if (reader.Read())
		{
			reader.Close();
			return true;
		}
		else
		{
			reader.Close();
			return false;
		}
	}

	public static SqlDataReader getList(string value)
	{
		SqlConnection sqlConn = DatabaseDAO.getConnectionString();
		SqlDataReader reader = null;
		string QueryStr = $"SELECT * FROM THONGTINDANGTUYEN WHERE TENVITRI LIKE N'%{value}%' AND TINHTRANG = N'Đã đăng tuyển';";
		try
		{
			sqlConn.Open();
			SqlCommand cmd = new SqlCommand(QueryStr, sqlConn);
			reader = cmd.ExecuteReader(CommandBehavior.CloseConnection); // Ensure the connection is closed when the reader is closed
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
			if (sqlConn != null && sqlConn.State == System.Data.ConnectionState.Open)
			{
				sqlConn.Close();
			}
			throw;
		}
		return reader;
	}
}
