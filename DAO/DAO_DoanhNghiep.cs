using DTO;
using System;
using System.Data;
using Utilis;

namespace DAO
{
    public class DAO_DoanhNghiep
    {
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
    }
}
