using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
