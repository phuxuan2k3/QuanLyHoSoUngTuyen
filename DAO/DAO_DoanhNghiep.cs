using DTO;
using System.Data;
using System.Data.SqlClient;
using Utilis;
namespace DAO
{
    public class DAO_DoanhNghiep
    {
        public static List<DTO_DoanhNghiep> LayDNChuaXacThuc()
        {

            string query = "select * from DOANHNGHIEP where TRANGTHAI = N'Chưa xác thực' ";
            DataTable dataTable = new DataTable();
            dataTable = SqlSingleton.Instance.ExecuteQuery(query);

            List<DTO_DoanhNghiep> lsDoanhNghiep = new List<DTO_DoanhNghiep>();

            foreach (DataRow row in dataTable.Rows)
            {
                DTO_DoanhNghiep doanhNghiep = new DTO_DoanhNghiep
                {
                    MaDN = row["MaDoanhNghiep"].ToString(),
                    TenDN = row["TenDoanhNghiep"].ToString(),
                    MaSoThue = row["MASOTHUE"].ToString(),
                    NguoiDaiDien = row["NGUOIDAIDIEN"].ToString(),
                    DiaChi = row["DIACHI"].ToString(),
                    Email = row["EMAIL"].ToString(),
                    NgayDangKy = Convert.ToDateTime(row["NGAYDK"])
                    // Map other columns as needed
                };

                lsDoanhNghiep.Add(doanhNghiep);
            }

            return lsDoanhNghiep;


        }


        public static DTO_DoanhNghiep LoadTTDN(string MaDN)
        {
            string query = "select * from DOANHNGHIEP where MaDoanhNghiep = " + MaDN;
            DataTable dataTable = new DataTable();
            dataTable = SqlSingleton.Instance.ExecuteQuery(query);

            if (dataTable.Rows.Count > 0)
            {
                DataRow row = dataTable.Rows[0];
                DTO_DoanhNghiep doanhNghiep = new DTO_DoanhNghiep
                {
                    MaDN = row["MaDoanhNghiep"].ToString(),
                    TenDN = row["TenDoanhNghiep"].ToString(),
                    MaSoThue = row["MASOTHUE"].ToString(),
                    NguoiDaiDien = row["NGUOIDAIDIEN"].ToString(),
                    DiaChi = row["DIACHI"].ToString(),
                    Email = row["EMAIL"].ToString(),
                    NgayDangKy = Convert.ToDateTime(row["NGAYDK"])
                };

                return doanhNghiep;
            }
            else
            {
                return null;
            }
        }

        public static void CapNhatTrangThaiDN(string MaDN, string TrangThai)
        {
            string query = "update DOANHNGHIEP set TRANGTHAI = N'" + TrangThai + "' where MaDoanhNghiep = " + MaDN;
            SqlSingleton.Instance.ExecuteNonQuery(query);
        }

        public static void CapNhatThongTinDn(DTO_DoanhNghiep doanhNghiep)
        {
            string query = "UPDATE DOANHNGHIEP set TenDoanhNghiep = N'" + doanhNghiep.TenDN + "', NGUOIDAIDIEN = N'" + doanhNghiep.NguoiDaiDien + "', DIACHI = N'" + doanhNghiep.DiaChi + "', EMAIL = '" + doanhNghiep.Email + "', NGAYDK = GETDATE(), TRANGTHAI = N'Chưa xác thực' where MaDoanhNghiep = " + doanhNghiep.MaDN;
            ;
            SqlSingleton.Instance.ExecuteNonQuery(query);
        }

        public static int KiemTraTrangThai(string MaDN)
        {
            string query = "SELECT * FROM DOANHNGHIEP where ((TRANGTHAI=N'Chưa xác thực' AND DATEDIFF(DAY,NGAYDK,GETDATE()) < 7 ) OR TRANGTHAI =N'Không hợp lệ') AND MaDoanhNghiep =" + MaDN;
            if (SqlSingleton.Instance.ExecuteScalar(query) == null)
            { return 1; }
            return 0;


        }


        public static List<DTO_DoanhNghiep> LayDN()
        {
            var query = "select * from DOANHNGHIEP";
            var doanhNghieps = SqlSingleton.Instance.ExecuteQuery(query);
            var listDoanhNghiep = doanhNghieps.AsEnumerable()
            .Select(row => new DTO_DoanhNghiep()
            {
                MaDN = row.Field<string>("MaDoanhNghiep")!,
                TenDN = row.Field<string>("TenDoanhNghiep")!,
                MaSoThue = row.Field<string>("MASOTHUE")!,
                NguoiDaiDien = row.Field<string>("NGUOIDAIDIEN")!,
                DiaChi = row.Field<string>("DIACHI")!,
                Email = row.Field<string>("EMAIL")!,
                TrangThai = TrangThaiDoanhNghiepConvert.GetTrangThaiEnum(row.Field<string>("TRANGTHAI")!.ToString()),
                NgayDangKy = row.Field<DateTime>("NGAYDK"),
            })
        .ToList();

            return listDoanhNghiep;
        }

        public static DTO_DoanhNghiep LayThongTinDoanhNghiep(string maDoanhNghiep)
        {
            string query = "select * from DOANHNGHIEP where MaDoanhNghiep = " + maDoanhNghiep;
            var dataTable = SqlSingleton.Instance.ExecuteQuery(query);

            if (dataTable.Rows.Count > 0)
            {
                DataRow row = dataTable.Rows[0];
                DTO_DoanhNghiep doanhNghiep = new DTO_DoanhNghiep
                {
                    MaDN = row["MaDoanhNghiep"].ToString(),
                    TenDN = row["TenDoanhNghiep"].ToString(),
                    MaSoThue = row["MASOTHUE"].ToString(),
                    NguoiDaiDien = row["NGUOIDAIDIEN"].ToString(),
                    DiaChi = row["DIACHI"].ToString(),
                    Email = row["EMAIL"].ToString(),
                    NgayDangKy = Convert.ToDateTime(row["NGAYDK"])
                };
                return doanhNghiep;
            }
            else
            {
                return null;
            }
        }

        public static string LayTenDoanhNghiep(string Ma)
        {
            string doanhNghiep = string.Empty;
            string QueryStr = $"SELECT TENDOANHNGHIEP FROM DOANHNGHIEP WHERE MADOANHNGHIEP = '{Ma}';";
            using (SqlConnection sqlConn = DatabaseDAO.getConnectionString())
            {
                try
                {
                    sqlConn.Open();
                    SqlCommand cmd = new SqlCommand(QueryStr, sqlConn);

                    doanhNghiep = cmd.ExecuteScalar().ToString()!;

                }
                catch (Exception ex)
                {
                    // Handle exception (log it, rethrow it, etc.)
                    Console.WriteLine(ex.Message);
                }
                sqlConn.Close();
            }

            return doanhNghiep;
        }
    }
}
