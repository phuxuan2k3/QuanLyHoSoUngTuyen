using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
//using ConnectString;
namespace DAO
{
    public class DatabaseDAO
    {
        public static SqlConnection sqlConn=null;
        public static string connectionString = @"Data Source=nleethuong\SQLLEETHUONG;Initial Catalog=QL_HSUT;Integrated Security=True;Encrypt=True"; 

        public static SqlConnection getConnectionString()
        {
           //Console.WriteLine(sqlConn);
            sqlConn = new SqlConnection(connectionString);
            //sqlConn.Open();
            Console.WriteLine(sqlConn);
            return sqlConn;
        }
        public static SqlDataReader getQueryStr(string queryStr)
        {
            SqlConnection sqlConn = DatabaseDAO.getConnectionString();
            SqlDataReader reader = null;

            try
            {
                sqlConn.Open();
                SqlCommand sqlCmd = new SqlCommand(queryStr, sqlConn);
                reader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {
                // Handle exception (log it, rethrow it, etc.)
                Console.WriteLine(ex.Message);
                if (sqlConn != null && sqlConn.State == System.Data.ConnectionState.Open)
                {
                    sqlConn.Close();
                }
                throw;
            }

            return reader;
        }

    }
}
