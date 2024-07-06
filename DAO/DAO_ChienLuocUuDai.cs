using DTO;

namespace DAO
{
	public class DAO_ChienLuocUuDai
    {
        public static List<DTO_ChienLuocUuDai> LayDSUD()
        {
            return new List<DTO_ChienLuocUuDai>
            {
                new DTO_ChienLuocUuDai("cl1"),
                new DTO_ChienLuocUuDai("cl2"),
                new DTO_ChienLuocUuDai("cl3"),
                new DTO_ChienLuocUuDai("cl4")
            };
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
