using DTO;
using System.Data;

namespace DAO;

public class DAO_HinhThucDangTuyen
{
	public static DTO_HinhThucDangTuyen Lay(string maHTDT)
	{
        string query = "select * from HINHTHUCDANGTUYEN where MaHinhThuc = '" + maHTDT +"'";
        DataTable dataTable = new DataTable();
        dataTable = SqlSingleton.Instance.ExecuteQuery(query);

        if (dataTable.Rows.Count > 0)
        {
            DataRow row = dataTable.Rows[0];
            DTO_HinhThucDangTuyen ht = new DTO_HinhThucDangTuyen
            {
                MaHTDT = row["MAHINHTHUC"].ToString(),
                TenHinhThuc = row["TENHINHTHUC"].ToString()
            };

            return ht;
        }
        else
        {
            return null;
        }
    }
}
