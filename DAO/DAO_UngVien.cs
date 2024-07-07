using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAO_UngVien
    {

        public static Boolean check_mauv(string mauv)
        {
            string QueryStr = $"SELECT * FROM UNGVIEN WHERE MAUNGVIEN = '{mauv}';";

            Console.WriteLine(QueryStr);
            SqlDataReader reader = DatabaseDAO.getQueryStr(QueryStr);

            if (reader.Read())
            {
                reader.Close();
                return true;
            }
            else
            {
                reader.Close();
                return false;
            }
        }


        public static Boolean check_hoten(string mauv, string name)
        {
            string QueryStr = $"SELECT * FROM UNGVIEN WHERE MAUNGVIEN = '{mauv}' AND TENUNGVIEN = N'{name}';";

            Console.WriteLine(QueryStr);
            SqlDataReader reader = DatabaseDAO.getQueryStr(QueryStr);

            if (reader.Read())
            {
                reader.Close();
                return true;
            }
            else
            {
                reader.Close();
                return false;
            }
        }
    }
}
