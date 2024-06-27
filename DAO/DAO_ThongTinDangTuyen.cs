using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
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
    }
}
