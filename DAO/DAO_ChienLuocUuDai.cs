using DTO;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Metrics;
using System.Net;

namespace DAO
{
    public class DAO_ChienLuocUuDai
    {
        private const string tableName = "CHIENLUOCUUDAI";
        private const string detailedTableName = "CT_CLUD";

        public static List<DTO_ChienLuocUuDai> LayDSUD()
        {
            string query = "select * from CHIENLUOCUUDAI";
            var ttdtTable = SqlSingleton.Instance.ExecuteQuery(query);

            var lsCLUD = ttdtTable.AsEnumerable().Select(x => new DTO_ChienLuocUuDai()
            {
                MaChienLuoc = x.Field<int>("MaChienLuoc").ToString()!,
                TenChienLuoc = x.Field<string>("TenChienLuoc")!.ToString()!,
                MoTa = x.Field<string>("MoTa")!,
            }).ToList();

            return lsCLUD;
        }

        public static List<DTO_ChienLuocUuDai> LayDSUD(string maDN)
        {
            var lsCTCLUD = LayChiTietChienLuocUuDai(maDN);
            var lsCLUD = lsCTCLUD.Select(x => LayChienLuocUuDai(x.MACLUD)).ToList();
            return lsCLUD;
        }

        public static List<DTO_ChiTietChienLuocUuDai> LayChiTietChienLuocUuDai(string maDN)
        {
            string query = $@"SELECT * FROM {detailedTableName}  WHERE MaDoanhNghiep = @MaDN";
            var ctcludTable = SqlSingleton.Instance.ExecuteQuery(query, [new SqlParameter("MaDN", maDN)]);

            var lsCLUD = ctcludTable.AsEnumerable().Select(x => new DTO_ChiTietChienLuocUuDai()
            {
                MACLUD = x.Field<int>("MaChienLuoc").ToString()!,
                MaDN = x.Field<int>("MaDoanhNghiep")!.ToString()!,
            }).ToList();

            return lsCLUD;
        }

        public static DTO_ChienLuocUuDai LayChienLuocUuDai(string maCLUD)
        {
            string query = $@"SELECT * FROM {tableName}  WHERE MaChienLuoc = @MaCL";
            var cludTable = SqlSingleton.Instance.ExecuteQuery(query, [new SqlParameter("MaCL", maCLUD)]);
            var cludFirstEle = cludTable.AsEnumerable().ElementAt(0);
            var clud = new DTO_ChienLuocUuDai(cludFirstEle.Field<int>("MaChienLuoc")!.ToString(), cludFirstEle.Field<string>("TenChienLuoc")!, cludFirstEle.Field<string>("MoTa")!);

            return clud;
        }

        public static void XoaTatCaUuDaiCuaDoanhNghiep(string maDN)
        {
            string query = $@"DELETE FROM {detailedTableName} WHERE MaDoanhNghiep=@MaDN;";
            SqlSingleton.Instance.ExecuteNonQuery(query, [new SqlParameter("MaDN", maDN)]);
        }

        public static void ThemUuDaiChoDN(string maDN, DTO_ChienLuocUuDai uuDai)
        {
            string query = $@"  INSERT INTO {detailedTableName}(MaDoanhNghiep, MaChienLuoc)
VALUES(@MaDN,@MaCL);";
            SqlSingleton.Instance.ExecuteNonQuery(query, [new SqlParameter("MaDN", maDN), new SqlParameter("MaCL", uuDai.MaChienLuoc)]);
        }

        public static void SuaUD(DTO_ChienLuocUuDai ud)
        {
            string query = $@" UPDATE {tableName}
SET TenChienLuoc = @TenCL, MoTa = @MoTa
WHERE MaChienLuoc = @MaCL;";
            SqlSingleton.Instance.ExecuteNonQuery(query, [new SqlParameter("MaCL", ud.MaChienLuoc), new SqlParameter("TenCL", ud.TenChienLuoc), new SqlParameter("MoTa", ud.MoTa)]);
        }

        public static void XoaUD(string maUD)
        {
            string query = $@"DELETE FROM {tableName} WHERE MaChienLuoc=@MaCL;";
            SqlSingleton.Instance.ExecuteNonQuery(query, [new SqlParameter("MaCL", maUD)]);
        }
        public static void ThemUD(DTO_ChienLuocUuDai ud)
        {
            string query = $@"  INSERT INTO {tableName}(TenChienLuoc, MoTa)
VALUES(@TenCL,@MoTa);";
            SqlSingleton.Instance.ExecuteNonQuery(query, [new SqlParameter("TenCL", ud.TenChienLuoc), new SqlParameter("MoTa", ud.MoTa)]);
        }
    }
}
