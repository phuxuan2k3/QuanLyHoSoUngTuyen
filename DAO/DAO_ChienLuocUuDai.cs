using DTO;
using System.Data;

namespace DAO
{
    public class DAO_ChienLuocUuDai
    {
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
            return new List<DTO_ChienLuocUuDai>
            {
                new DTO_ChienLuocUuDai("cl1"),
                new DTO_ChienLuocUuDai("cl2")
            };
        }

        public static void XoaTatCaUuDaiCuaDoanhNghiep(string maDN)
        {
            throw new NotImplementedException();
        }

        public static void ThemUuDaiChoDN(string maDN, DTO_ChienLuocUuDai uuDai)
        {
            throw new NotImplementedException();
        }

        public static void SuaUD(DTO_ChienLuocUuDai ud)
        {
            throw new NotImplementedException();
        }
        public static void XoaUD(string maUD)
        {
            throw new NotImplementedException();
        }
        public static void ThemUD(DTO_ChienLuocUuDai ud)
        {
            throw new NotImplementedException();
        }
    }
}
