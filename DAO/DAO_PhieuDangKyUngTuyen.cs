using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAO_PhieuDangKyUngTuyen
    {
        public static List<DTO_PhieuDangKyUngTuyen> LayPDKUT(string maTTDT)
        {
            return new List<DTO_PhieuDangKyUngTuyen>
            {
                new DTO_PhieuDangKyUngTuyen(TrangThaiPhieuDangKyUngTuyen.KhongHopLe),
                new DTO_PhieuDangKyUngTuyen(TrangThaiPhieuDangKyUngTuyen.HopLe),
                new DTO_PhieuDangKyUngTuyen(TrangThaiPhieuDangKyUngTuyen.ChuaXetDuyet),
            };
        }

        public static Boolean Them_Phieu(int mattdt, string mauv)
        {
            // Open the database connection if it's not already open
            using (SqlConnection sqlConn = DatabaseDAO.getConnectionString())
            {
                try
                {
                    sqlConn.Open();
                    string QueryStr = $"INSERT INTO PHIEUDANGKYUNGTUYEN(MATTDT, MAUV, TRANGTHAI) VALUES({mattdt}, '{mauv}', N'Chưa xét duyệt'); ";
                    using (SqlCommand insert = new SqlCommand(QueryStr, sqlConn))
                    {

                        insert.ExecuteNonQuery();
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    // Handle exception (log it, rethrow it, etc.)
                    Console.WriteLine(ex.Message);
                }
                sqlConn.Close();
            }
            return false;
        }

        public static Boolean Xoa_Phieu(int mattdt, string mauv)
        {
            using (SqlConnection sqlConn = DatabaseDAO.getConnectionString())
            {
                try
                {
                    sqlConn.Open();
                    string QueryStr = $"DELETE FROM PHIEUDANGKYUNGTUYEN WHERE MATTDT = {mattdt} AND MAUV = '{mauv}';";
                    using (SqlCommand insert = new SqlCommand(QueryStr, sqlConn))
                    {

                        insert.ExecuteNonQuery();
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    // Handle exception (log it, rethrow it, etc.)
                    Console.WriteLine(ex.Message);
                }
                sqlConn.Close();
            }
            return false;
        }
    }
}
