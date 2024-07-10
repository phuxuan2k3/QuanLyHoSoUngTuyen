using DTO;
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
        private const string tableName = "UNGVIEN";
        public static bool check_mauv(string mauv)
        {
            string QueryStr = $"SELECT count(*) FROM {tableName} WHERE MAUNGVIEN = '{mauv}';";
            var res = SqlSingleton.Instance.ExecuteScalar(QueryStr);
            if (int.Parse(res.ToString()!) > 0)
            {
                return true;
            }
            return false;


            //Console.WriteLine(QueryStr);
            //SqlDataReader reader = DatabaseDAO.getQueryStr(QueryStr);

            //if (reader.Read())
            //{
            //    reader.Close();
            //    return true;
            //}
            //else
            //{
            //    reader.Close();
            //    return false;
            //}
        }
        public static void ThemUngVien(DTO_UngVien ungVien)
        {
            string query = $@"INSERT INTO {tableName}(MaUngVien,TenUngVien, DiaChi,Email,TenTaiKhoan)
VALUES(@MaUngVien,@TenUngVien, @DiaChi,@Email,@TenTaiKhoan);";
            SqlSingleton.Instance.ExecuteNonQuery(query, [
                new SqlParameter("MaUngVien", ungVien.MaUV),
                new SqlParameter("TenUngVien", ungVien.TenUV),
                new SqlParameter("DiaChi", ungVien.DiaChi),
                new SqlParameter("Email", ungVien.Email),
                new SqlParameter("TenTaiKhoan", ungVien.TenTaiKhoan)]);
        }

        public static bool check_hoten(string mauv, string name)
        {
            string QueryStr = $"SELECT count(*) FROM {tableName} WHERE MAUNGVIEN = '{mauv}' AND TENUNGVIEN = N'{name}';";
            var res = SqlSingleton.Instance.ExecuteScalar(QueryStr);
            if (int.Parse(res.ToString()!) > 0)
            {
                return true;
            }
            return false;
            //Console.WriteLine(QueryStr);
            //SqlDataReader reader = DatabaseDAO.getQueryStr(QueryStr);

            //if (reader.Read())
            //{
            //    reader.Close();
            //    return true;
            //}
            //else
            //{
            //    reader.Close();
            //    return false;
            //}
        }
    }
}
