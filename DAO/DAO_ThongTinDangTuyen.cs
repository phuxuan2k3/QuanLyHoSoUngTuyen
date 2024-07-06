using DTO;
using System.Data;
using System.Data.SqlClient;
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
			ThoiGianDangTuyen = DateTime.Now.AddDays(-4),
			TenViTri = row["TENVITRI"].ToString()!,
			SoLuong = Convert.ToInt32(row["SOLUONG"])!,
			YeuCau = row["YEUCAU"].ToString()!,
			TrangThai = row["TRANGTHAI"].ToString()!.ToTrangTraiThongTinDangTuyen(),
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

    public static void Them(DTO_ThongTinDangTuyen thongTinDangTuyen)
    {
        var query = $@"INSERT INTO {tableName} (MaDN, SoNgayDT, MaHTDT, ThoiGianDangTuyen, TrangThai, TinhTrang, TenViTri, SoLuong, YeuCau) VALUES (@MaDN, @SoNgayDT, @MaHTDT, @ThoiGianDangTuyen, @TrangThai, @TinhTrang, @TenViTri, @SoLuong, @YeuCau)";
        SqlSingleton.Instance.ExecuteNonQuery(query, [
            new SqlParameter("MaDN", thongTinDangTuyen.MaDN),
            new SqlParameter("SoNgayDT", thongTinDangTuyen.SoNgayDangTuyen),
            new SqlParameter("ThoiGianDangTuyen", thongTinDangTuyen.ThoiGianDangTuyen.ToString()),
            new SqlParameter("MaHTDT", thongTinDangTuyen.MaHTDT),
            new SqlParameter("TrangThai", thongTinDangTuyen.TrangThai.ToString()),
            new SqlParameter("TinhTrang", thongTinDangTuyen.TinhTrang.ToString()),
            new SqlParameter("TenViTri", thongTinDangTuyen.TenViTri),
            new SqlParameter("SoLuong", thongTinDangTuyen.SoLuong),
            new SqlParameter("YeuCau", thongTinDangTuyen.YeuCau),
        ]);
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
			new SqlParameter("TrangThai", thongTinDangTuyen.TrangThai.ToString()),
			new SqlParameter("TinhTrang", thongTinDangTuyen.TinhTrang.ToString()),
			new SqlParameter("TenViTri", thongTinDangTuyen.TenViTri),
			new SqlParameter("SoLuong", thongTinDangTuyen.SoLuong),
			new SqlParameter("YeuCau", thongTinDangTuyen.YeuCau),
		]);
	}

    //public static List<DTO_ThongTinDangTuyen> LayDSTTDT()
    //{
    //    string query = "select * from THONGTINDANGTUYEN";
    //    var ttdtTable = SqlSingleton.Instance.ExecuteQuery(query);
    //    var lsTTDT = ttdtTable.AsEnumerable().Select(x => new DTO_ThongTinDangTuyen()
    //    {
    //        MaTTDT = x.Field<int>("MATTDT").ToString()!,
    //        MaDN = x.Field<int>("MADN").ToString()!,
    //        SoNgayDangTuyen = x.Field<int>("SONGAYDT")!,
    //        ThoiGianDangTuyen = x.Field<DateTime>("THOIGIANDANGTUYEN")!,
    //        MaHTDT = x.Field<string>("MAHTDT")!,
    //        TenViTri = x.Field<string>("TENVITRI")!,
    //        SoLuong = x.Field<int>("SOLUONG")!,
    //        YeuCau = x.Field<string>("YEUCAU")!
    //    }).ToList();
    //    return lsTTDT;
    //}

    public static List<DTO_ThongTinDangTuyen> LoadTTDTXD()
    {
        string query = "select * from THONGTINDANGTUYEN where TINHTRANG = N'Chưa xét duyệt' ";
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
            MaTTDT = x.Field<string>("MATTDT")!,
            MaDN = x.Field<string>("MADN")!,
            SoNgayDangTuyen = x.Field<int>("SONGAYDT")!,
            MaHTDT = x.Field<string>("MAHTDT")!,
            TenViTri = x.Field<string>("TENVITRI")!,
            SoLuong = x.Field<int>("SOLUONG")!,
            YeuCau = x.Field<string>("YEUCAU")!
        }).ToList();
        return lsTTDT;
    }

    public static void CapNhatTrangThaiTTDT(string MaTTDT, string TrangThai)
	{
		string query = "update THONGTINDANGTUYEN set TINHTRANG = N'" + TrangThai + "' where MATTDT = " + MaTTDT;
		SqlSingleton.Instance.ExecuteNonQuery(query);
	}

    public static void CapNhatTrangThaiDangTuyen(string MaTTDT)
    {
        string query = "update THONGTINDANGTUYEN set TRANGTHAI = N'Đã đăng tuyển' where MATTDT = " + MaTTDT;
        SqlSingleton.Instance.ExecuteNonQuery(query);
    }


	public static List<DTO_ThongTinDangTuyen> LoadTTDTHopLe()
	{
		string query = "select * from THONGTINDANGTUYEN where TINHTRANG = N'Hợp lệ' AND TRANGTHAI <> N'Đã đăng tuyển'";
		DataTable dataTable = new DataTable();
		dataTable = SqlSingleton.Instance.ExecuteQuery(query);
        List<DTO_ThongTinDangTuyen> ds = new List<DTO_ThongTinDangTuyen>();
        foreach (DataRow row in dataTable.Rows)
        {
            DTO_ThongTinDangTuyen ttdt = new DTO_ThongTinDangTuyen
            {
                MaTTDT = row["MATTDT"].ToString(),
                MaDN = row["MADN"].ToString(),
                SoNgayDangTuyen = Convert.ToInt32(row["SONGAYDT"]),
                MaHTDT = row["MAHTDT"].ToString(),
                ThoiGianDangTuyen = DateTime.Now.AddDays(-4),
                TenViTri = row["TENVITRI"].ToString(),
                SoLuong = Convert.ToInt32(row["SOLUONG"]),
                YeuCau = row["YEUCAU"].ToString()
            };
            ds.Add(ttdt);
        }
        return ds;
    }
}
