using DTO;
using System.Data;

namespace DAO;

public class DAO_ThongTinDangTuyen
{
	public static List<DTO_ThongTinDangTuyen> LayDSTTDT()
	{
		throw new NotImplementedException();
	}

	public static List<DTO_ThongTinDangTuyen> LayDSTTDT(string maDN)
	{
		return new List<DTO_ThongTinDangTuyen>
			{
				new DTO_ThongTinDangTuyen()
			};
	}

	public static DTO_ThongTinDangTuyen Lay(string maTTDT)
	{
        string query = "select * from THONGTINDANGTUYEN where MATTDT =  " + maTTDT;
        DataTable dataTable = new DataTable();
        dataTable = SqlSingleton.Instance.ExecuteQuery(query);

        if (dataTable.Rows.Count > 0)			
        {
            DataRow row = dataTable.Rows[0];
            DTO_ThongTinDangTuyen doanhNghiep = new DTO_ThongTinDangTuyen
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

            return doanhNghiep;
        }
        else
        {
            return null;
        }
    }

	public static List<DTO_ThongTinDangTuyen> LayTatCaCuaDoanhNghiep(string maDN)
	{
		var dtoArray = new DTO_ThongTinDangTuyen[]
{
	new DTO_ThongTinDangTuyen(
		maTTDT: "TTDT001",
		maDN: "DN001",
		soNgayDangTuyen: 30,
		maHTDT: "HTDT001",
		thoiGianDangTuyen: DateTime.Now,
		tenViTri: "Software Developer",
		soLuong: 5,
		yeuCau: "Bachelor's degree in Computer Science"
	),
	new DTO_ThongTinDangTuyen(
		maTTDT: "TTDT002",
		maDN: "DN002",
		soNgayDangTuyen: 15,
		maHTDT: "HTDT002",
		thoiGianDangTuyen: DateTime.Now.AddDays(-1),
		tenViTri: "Data Analyst",
		soLuong: 3,
		yeuCau: "Experience with SQL and Python"
	),
	new DTO_ThongTinDangTuyen(
		maTTDT: "TTDT003",
		maDN: "DN003",
		soNgayDangTuyen: 45,
		maHTDT: "HTDT003",
		thoiGianDangTuyen: DateTime.Now.AddDays(-2),
		tenViTri: "Project Manager",
		soLuong: 2,
		yeuCau: "PMP certification"
	),
	new DTO_ThongTinDangTuyen(
		maTTDT: "TTDT004",
		maDN: "DN004",
		soNgayDangTuyen: 60,
		maHTDT: "HTDT004",
		thoiGianDangTuyen: DateTime.Now.AddDays(-3),
		tenViTri: "System Administrator",
		soLuong: 4,
		yeuCau: "Experience with Windows and Linux servers"
	),
	new DTO_ThongTinDangTuyen(
		maTTDT: "TTDT005",
		maDN: "DN005",
		soNgayDangTuyen: 90,
		maHTDT: "HTDT005",
		thoiGianDangTuyen: DateTime.Now.AddDays(-4),
		tenViTri: "Network Engineer",
		soLuong: 6,
		yeuCau: "CCNA certification"
	)
};
		return dtoArray.ToList();
	}


    public static List<DTO_ThongTinDangTuyen> LoadTTDTXD()
    {

        string query = "select * from THONGTINDANGTUYEN where TINHTRANG = N'Chưa xét duyệt' ";
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
                MaHTDT= row["MAHTDT"].ToString(),
				ThoiGianDangTuyen= DateTime.Now.AddDays(-4),
                TenViTri = row["TENVITRI"].ToString(),
                SoLuong = Convert.ToInt32(row["SOLUONG"]),
                YeuCau = row["YEUCAU"].ToString()
            };

            ds.Add(ttdt);
        }

        return ds;

    }

	public static void CapNhatTrangThaiTTDT(string MaTTDT, string TrangThai)
	{
		string query = "update THONGTINDANGTUYEN set TINHTRANG = N'" + TrangThai + "' where MATTDT = " + MaTTDT; 
        SqlSingleton.Instance.ExecuteNonQuery(query);

    }

	public static void CapNhatTrangThaiDangTuyen(string MaTTDT)
	{
        string query = "update THONGTINDANGTUYEN set TRANGTHAI = N'Đã đăng tuyển' where MATTDT = " + MaTTDT;
        ;
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
