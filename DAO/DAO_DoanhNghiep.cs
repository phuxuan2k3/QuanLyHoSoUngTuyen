﻿using DTO;
using System.Data;
using System.Data.SqlClient;
using Utilis;
namespace DAO
{
    public class DAO_DoanhNghiep
    {
        private const string tableName = "DOANHNGHIEP";

        public static void ThemDoanhNghiep(DTO_DoanhNghiep doanhNghiep)
        {
            string query = $@"  INSERT INTO {tableName}(TenDoanhNghiep, MASOTHUE,NGUOIDAIDIEN,DIACHI,EMAIL,TRANGTHAI,NGAYDK,TenTaiKhoan)
VALUES(@TenDoanhNghiep, @MASOTHUE,@NGUOIDAIDIEN,@DIACHI,@EMAIL,@TRANGTHAI,@NGAYDK,@TenTaiKhoan);";
            SqlSingleton.Instance.ExecuteNonQuery(query, [
                new SqlParameter("TenDoanhNghiep", doanhNghiep.TenDN),
                new SqlParameter("MASOTHUE", doanhNghiep.MaSoThue),
                new SqlParameter("NGUOIDAIDIEN", doanhNghiep.NguoiDaiDien),
                new SqlParameter("DIACHI", doanhNghiep.DiaChi),
                new SqlParameter("EMAIL", doanhNghiep.Email),
                new SqlParameter("TRANGTHAI", doanhNghiep.TrangThai.GetString()),
                new SqlParameter("NGAYDK", DateTime.Now.ToString()),
                new SqlParameter("TenTaiKhoan", doanhNghiep.TenTaiKhoan)]);
        }
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
                    NgayDangKy = Convert.ToDateTime(row["NGAYDK"]),
                    TrangThai = TrangThaiDoanhNghiepConvert.GetTrangThaiEnum(row.Field<string>("TRANGTHAI")!.ToString()),
                };

                lsDoanhNghiep.Add(doanhNghiep);
            }

            return lsDoanhNghiep;
        }
        public static DTO_DoanhNghiep Lay(string MaDN)
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
                    NgayDangKy = Convert.ToDateTime(row["NGAYDK"]),
                    TrangThai = TrangThaiDoanhNghiepConvert.GetTrangThaiEnum(row.Field<string>("TRANGTHAI")!.ToString()),
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

		public static int KiemTraMaSoThue(string MaDN, string MST)
		{
            string query = "select * from DOANHNGHIEP where MASOTHUE = '"+MST+"' and MaDoanhNghiep <> "+ MaDN;
            if (SqlSingleton.Instance.ExecuteScalar(query) == null)
            { return 1; }
            return 0;
        }


        public static List<DTO_DoanhNghiep> LayDanhSachDoanhNghiep()
        {
            var query = "select * from DOANHNGHIEP";
            var doanhNghieps = SqlSingleton.Instance.ExecuteQuery(query);
            var listDoanhNghiep = doanhNghieps.AsEnumerable()
            .Select(row => new DTO_DoanhNghiep()
            {
                MaDN = row.Field<int>("MaDoanhNghiep").ToString()!,
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
                    NgayDangKy = Convert.ToDateTime(row["NGAYDK"]),
                    TrangThai = TrangThaiDoanhNghiepConvert.GetTrangThaiEnum(row.Field<string>("TRANGTHAI")!.ToString()),

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
            string QueryStr = $"SELECT TENDOANHNGHIEP FROM {tableName} WHERE MADOANHNGHIEP = '{Ma}';";
            var res = SqlSingleton.Instance.ExecuteQuery(QueryStr);
            var tenDoanhNghiep = res.AsEnumerable().ElementAt(0).Field<string>("TENDOANHNGHIEP")!.ToString();
            return tenDoanhNghiep;
            //using (SqlConnection sqlConn = DatabaseDAO.getConnectionString())
            //{
            //    try
            //    {
            //        sqlConn.Open();
            //        SqlCommand cmd = new SqlCommand(QueryStr, sqlConn);

            //        doanhNghiep = cmd.ExecuteScalar().ToString()!;

            //    }
            //    catch (Exception ex)
            //    {
            //        // Handle exception (log it, rethrow it, etc.)
            //        Console.WriteLine(ex.Message);
            //    }
            //    sqlConn.Close();
            //}

            //return doanhNghiep;
        }

        public static DTO_DoanhNghiep LayDNBangTenTaiKhoan(string tenTaiKhoan)
        {
            string query = @$"select * from DOANHNGHIEP where TenTaiKhoan = '{tenTaiKhoan}'";
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
                    NgayDangKy = Convert.ToDateTime(row["NGAYDK"]),
                    TrangThai = TrangThaiDoanhNghiepConvert.GetTrangThaiEnum(row.Field<string>("TRANGTHAI")!.ToString()),
                };
                return doanhNghiep;
            }
            else
            {
                return null;
            }
        }
    }
}
