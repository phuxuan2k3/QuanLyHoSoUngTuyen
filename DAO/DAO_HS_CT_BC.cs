using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DAO
{
    public class DAO_HS_CT_BC
    {
        public static List<string> Load_BC(string mauv)
        {
            string QueryStr = $"SELECT * FROM HS_CT_BC WHERE MAUNGVIEN = '{mauv}';";

            List<string> Result = new List<string>();
            SqlDataReader reader = DatabaseDAO.getQueryStr(QueryStr);

            while (reader.Read())
            {
                Result.Add(reader["TENCTBC"].ToString());
            }
            return Result;

        }
        public static int GetID(string ctbc, string mauv)
        {
            int ID=0;
            string QueryStr = $"SELECT MACTBC FROM HS_CT_BC WHERE TENCTBC = N'{ctbc}' AND MAUNGVIEN = '{mauv}';";
            using (SqlConnection sqlConn = DatabaseDAO.getConnectionString())
            {
                try
                {
                    sqlConn.Open();
                    SqlCommand cmd = new SqlCommand(QueryStr, sqlConn);
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        ID = Convert.ToInt32(result);
                    }

                }
                catch (Exception ex)
                {
                    // Handle exception (log it, rethrow it, etc.)
                    Console.WriteLine(ex.Message);
                }
                sqlConn.Close();
            }

            return ID;
        }

        public static int ThemHS(string mauv, string tenhs)
        {
            if (DAO_UngVien.check_mauv(mauv))
            {
                string QueryStr = "EXEC INSERT_HSCTBC @MaUngVien, @TENCTBC;";
                using (SqlConnection sqlConn = DatabaseDAO.getConnectionString())
                {
                    try
                    {
                        sqlConn.Open();
                        using (SqlCommand cmd = new SqlCommand(QueryStr, sqlConn))
                        {
                            cmd.Parameters.AddWithValue("@MaUngVien", mauv);
                            cmd.Parameters.AddWithValue("@TENCTBC", tenhs);

                            cmd.ExecuteNonQuery();  // Execute the command
                        }
                        return 1;  // Indicate success
                    }
                    catch (Exception ex)
                    {
                        // Handle exception (log it, rethrow it, etc.)
                        Console.WriteLine(ex.Message);
                    }
                    finally
                    {
                        sqlConn.Close();
                    }
                }
            }
            return 0; // Indicate failure
        }

    }
}
