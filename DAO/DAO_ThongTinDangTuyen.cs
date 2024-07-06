using DTO;
using System.Data;

namespace DAO;

public class DAO_ThongTinDangTuyen
{
    public static List<DTO_ThongTinDangTuyen> LayDSTTDT()
    {
        string query = "select * from THONGTINDANGTUYEN";
        var ttdtTable = SqlSingleton.Instance.ExecuteQuery(query);

        List<DTO_ThongTinDangTuyen> ds = new List<DTO_ThongTinDangTuyen>();
        var x = DateTime.Now.AddDays(-4);
        foreach (DataRow row in ttdtTable.Rows)
        {
            DTO_ThongTinDangTuyen ttdt = new DTO_ThongTinDangTuyen
            {
                MaTTDT = row["MATTDT"].ToString()!,
                MaDN = row["MADN"].ToString()!,
                SoNgayDangTuyen = Convert.ToInt32(row["SONGAYDT"]),
                MaHTDT = row["MAHTDT"].ToString()!,
                ThoiGianDangTuyen = DateTime.Now.AddDays(-31),
                TenViTri = row["TENVITRI"].ToString()!,
                SoLuong = Convert.ToInt32(row["SOLUONG"]),
                YeuCau = row["YEUCAU"].ToString()!
            };
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

    public static DTO_ThongTinDangTuyen Lay(string maTTDT)
    {
        return new DTO_ThongTinDangTuyen { TenViTri = "Test", SoLuong = 1 };
    }

    public static List<DTO_ThongTinDangTuyen> LayTatCaCuaDoanhNghiep(string maDN)
    {
        return [new DTO_ThongTinDangTuyen { TenViTri = "Test", SoLuong = 1 }];
    }
}
