using DTO;
using Utilis;

namespace DAO
{
    public class DAO_DoanhNghiep
    {
        public static List<DTO_DoanhNghiep> LayDN()
        {
            var query = "select * from DOANHNGHIEP";
            var dn = SqlSingleton.Instance.ExecuteQuery(query);
            return null;
        }
    }
}
