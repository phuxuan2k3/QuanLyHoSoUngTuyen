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
    public static List<DTO_ThongTinDangTuyen> LayDSTTDTDuyet()
    {

        string query = "SELECT t.MATTDT, t.TENVITRI, t.SOLUONG, t.SONGAYDT\r\nFROM \r\n    THONGTINDANGTUYEN t\r\nLEFT JOIN \r\n    PHIEUDANGKYUNGTUYEN p ON t.MATTDT = p.MATTDT\r\nGROUP BY \r\n    t.MATTDT, t.TENVITRI, t.SOLUONG, t.SONGAYDT\r\nHAVING \r\n    COUNT(p.MAUV) >= t.SOLUONG ";
        DataTable dataTable = new DataTable();
        dataTable = SqlSingleton.Instance.ExecuteQuery(query);

        List<DTO_ThongTinDangTuyen> ds = new List<DTO_ThongTinDangTuyen>();

        foreach (DataRow row in dataTable.Rows)
        {
            DTO_ThongTinDangTuyen ttdt = new DTO_ThongTinDangTuyen
            {
                MaTTDT = row["MATTDT"].ToString(),
                SoNgayDangTuyen = Convert.ToInt32(row["SONGAYDT"]),
                ThoiGianDangTuyen = DateTime.Now.AddDays(-4),
            };

            ds.Add(ttdt);
        }
        return ds;

    }
    public static DTO_ThongTinDangTuyen LayCTTTDT(string maTTDT)
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
    public static List<DTO_PhieuDangKyUngTuyen> LayDSPDK(string maTTDT)
    {
        string query = "SELECT \r\n    p.MAUV,\r\n    u.TenUngVien,\r\n    p.TRANGTHAI \r\nFROM \r\n    PHIEUDANGKYUNGTUYEN p\r\nJOIN \r\n    UNGVIEN u ON p.MAUV = u.MaUngVien\r\nWHERE \r\n    p.MATTDT = " + maTTDT;
        DataTable dataTable = new DataTable();
        dataTable = SqlSingleton.Instance.ExecuteQuery(query);

        List<DTO_PhieuDangKyUngTuyen> dsPhDK = new List<DTO_PhieuDangKyUngTuyen>();

        foreach (DataRow row in dataTable.Rows)
        {
            //TrangThaiPhieuDangKyUngTuyen trangThai = (TrangThaiPhieuDangKyUngTuyen)Enum.Parse(typeof(TrangThaiPhieuDangKyUngTuyen),row["TRANGTHAI"].ToString());

            DTO_PhieuDangKyUngTuyen PhDK = new DTO_PhieuDangKyUngTuyen(TrangThaiPhieuDangKyUngTuyen.HopLe, maTTDT,row["MAUV"].ToString());

            dsPhDK.Add(PhDK);
        }

        return dsPhDK;
    }
<<<<<<< Updated upstream
=======
    public static DTO_ThongTinDangTuyen LayThongTinDangTuyen(string maTTDT)
    {
        string query = "select * from THONGTINDANGTUYEN where MATTDT = " + maTTDT;
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

    public static List<DTO_DuyetPhieuDangKy_ThongTinDangTuyen> LayDSThongTinDangTuyenDuyetPDK()
    {
        string query = "SELECT MATTDT,MADN,SoLuong FROM THONGTINDANGTUYEN " +
            "WHERE SOLUONG <= (SELECT COUNT(*) FROM PHIEUDANGKYUNGTUYEN WHERE PHIEUDANGKYUNGTUYEN.MATTDT = THONGTINDANGTUYEN.MATTDT)";

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

>>>>>>> Stashed changes
}
