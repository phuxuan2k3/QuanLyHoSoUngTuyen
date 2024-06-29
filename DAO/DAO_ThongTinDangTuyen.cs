using DTO;

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
		return new DTO_ThongTinDangTuyen { TenViTri = "Test", SoLuong = 1 };
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
}
