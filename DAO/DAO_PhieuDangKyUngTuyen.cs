using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
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
            string query = $"SELECT * FROM PHIEUDANGKYUNGTUYEN WHERE MATTDT = N'{maTTDT}';";
            var res = SqlSingleton.Instance.ExecuteQuery(query);
            var lsPDKUT = res.AsEnumerable().Select(x => new DTO_PhieuDangKyUngTuyen(
                 TrangThaiPDKUTConvert.GetTrangThaiEnum(x.Field<string>("TRANGTHAI")!),
                 maTTDT,
                 x.Field<string>("MAUV")!)).ToList();
            return lsPDKUT;
        }

        public static bool Them_Phieu(int mattdt, string mauv)
        {
            string QueryStr = $"INSERT INTO PHIEUDANGKYUNGTUYEN(MATTDT, MAUV, TRANGTHAI) VALUES({mattdt}, '{mauv}', N'Chưa xét duyệt'); ";
            SqlSingleton.Instance.ExecuteNonQuery(QueryStr);
            return true;
        }

        //todo: fix tthis
        public static bool Xoa_Phieu(int mattdt, string mauv)
        {
            string QueryStr = $"DELETE FROM PHIEUDANGKYUNGTUYEN WHERE MATTDT = {mattdt} AND MAUV = '{mauv}';";
            SqlSingleton.Instance.ExecuteNonQuery(QueryStr);
            return true;
            //using (SqlConnection sqlConn = DatabaseDAO.getConnectionString())
            //{
            //    try
            //    {
            //        sqlConn.Open();
            //        string QueryStr = $"DELETE FROM PHIEUDANGKYUNGTUYEN WHERE MATTDT = {mattdt} AND MAUV = '{mauv}';";
            //        using (SqlCommand insert = new SqlCommand(QueryStr, sqlConn))
            //        {

            //            insert.ExecuteNonQuery();
            //            return true;
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        // Handle exception (log it, rethrow it, etc.)
            //        Console.WriteLine(ex.Message);
            //    }
            //    sqlConn.Close();
            //}
            //return false;
        }

        public static DTO_ThongTinHoSo LayThongTinDangTuyenTheoMaUV(string maTTDT, string maUV)
        {
            string query = @"
            SELECT 
                p.MAUV,
                p.TRANGTHAI,
                STRING_AGG(b.TENCTBC, ', ') AS BangCap,
                t.TENVITRI
            FROM 
                PHIEUDANGKYUNGTUYEN p
            JOIN 
                UNGVIEN u ON p.MAUV = u.MaUngVien
            JOIN 
                THONGTINDANGTUYEN t ON t.MATTDT = p.MATTDT
            LEFT JOIN 
                HS_CT_BC b ON p.MAUV = b.MAUngVien
            WHERE 
                p.MATTDT = @maTTDT AND p.MAUV = @maUV
            GROUP BY 
                p.MAUV,
                p.TRANGTHAI,
                t.TENVITRI";


            DataTable dataTable = new DataTable();
            using (SqlCommand cmd = new SqlCommand(query, SqlSingleton.Instance.Connection))
            {
                cmd.Parameters.AddWithValue("@maTTDT", maTTDT);
                cmd.Parameters.AddWithValue("@maUV", maUV);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dataTable);
            }

            DataRow row = dataTable.Rows[0];

            DTO_ThongTinHoSo phDK = new DTO_ThongTinHoSo(
                row["MAUV"].ToString(),
                maTTDT,
                0,
                row["TENVITRI"].ToString(),
                row["BangCap"].ToString(),
                row["TrangThai"].ToString());

            return phDK;
        }
        public static void CapNhatThongTinPhieuDangKy(DTO_ThongTinHoSo ttpdk)
        {
            string query = "UPDATE PHIEUDANGKYUNGTUYEN SET TRANGTHAI = @TrangThai WHERE MATTDT = @MaTTDT AND MAUV = @MaUV and DOUUTIEN = @Uutien";

            using (SqlCommand cmd = new SqlCommand(query, SqlSingleton.Instance.Connection))
            {
                cmd.Parameters.AddWithValue("@TrangThai", ttpdk.TrangThai.ToString());
                cmd.Parameters.AddWithValue("@MaTTDT", Convert.ToInt32(ttpdk.MaTTDT));
                cmd.Parameters.AddWithValue("@MaUV", ttpdk.MaUV);
                cmd.Parameters.AddWithValue("@Uutien", Convert.ToInt32(ttpdk.UuTien));


                SqlSingleton.Instance.Connection.Open();
                cmd.ExecuteNonQuery();
                SqlSingleton.Instance.Connection.Close();

            }
        }
        public static List<DTO_UngVienDat> LayDanhSachUngVienDat(string maTTDT)
        {
            string query = "SELECT  p.MAUV,u.Email, u.TenUngVien " +
                           "FROM PHIEUDANGKYUNGTUYEN p " +
                           "JOIN UNGVIEN u ON p.MAUV = u.MaUngVien " +
                           "WHERE p.MATTDT = @MaTTDT AND p.TRANGTHAI = N'Đạt'";

            DataTable dataTable = new DataTable();
            using (SqlCommand cmd = new SqlCommand(query, SqlSingleton.Instance.Connection))
            {
                cmd.Parameters.AddWithValue("@MaTTDT", maTTDT);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dataTable);
            }

            List<DTO_UngVienDat> danhSachUngVien = new List<DTO_UngVienDat>();
            foreach (DataRow row in dataTable.Rows)
            {
                DTO_UngVienDat ungVien = new DTO_UngVienDat
                {
                    MaUV = row["MaUV"].ToString(),
                    TenUV = row["TenUngVien"].ToString(),
                    Email = row["Email"].ToString(),
                };
                danhSachUngVien.Add(ungVien);
            }

            return danhSachUngVien;
        }

    }
}
