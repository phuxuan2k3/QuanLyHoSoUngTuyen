using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAO_CT_PDKUT
    {
        public static int Them(int mattdt, string mauv, int mactbc)
        {
            string QueryStr = $"INSERT INTO CT_PDKUT(MATTDT, MAUV, MACTBC) VALUES({mattdt}, '{mauv}', {mactbc}); ";
            SqlSingleton.Instance.ExecuteNonQuery(QueryStr);
            return 1;
            /*
            using (SqlConnection sqlConn = DatabaseDAO.getConnectionString())
            {
                try
                {
                    sqlConn.Open();
                    string QueryStr = $"INSERT INTO CT_PDKUT(MATTDT, MAUV, MACTBC) VALUES({mattdt}, '{mauv}', {mactbc}); ";
                    using (SqlCommand insert = new SqlCommand(QueryStr, sqlConn))
                    {

                        insert.ExecuteNonQuery();
                        return 1;
                    }
                }
                catch (Exception ex)
                {
                    // Handle exception (log it, rethrow it, etc.)
                    Console.WriteLine(ex.Message);
                }
                sqlConn.Close();
            }
            return 0;*/
        }
    }
}
