using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAO_TaiKhoan
    {
        private const string tableName = "TAIKHOAN";

        public static DTO_TaiKhoan? LayTaiKhoan(string tenTaiKhoan, string matKhau)
        {
            string query = $@"SELECT * FROM {tableName}  WHERE TenTaiKhoan = @TenTaiKhoan and MatKhau = @MatKhau";
            var taiKhoanTable = SqlSingleton.Instance.ExecuteQuery(query, [new SqlParameter("TenTaiKhoan", tenTaiKhoan), new SqlParameter("MatKhau", matKhau)]);
            if (taiKhoanTable.Rows.Count == 0)
            {
                return null;
            }
            var taiKhoanFirstEle = taiKhoanTable.AsEnumerable().ElementAt(0);
            var taiKhoan = new DTO_TaiKhoan(taiKhoanFirstEle.Field<string>("TenTaiKhoan")!.ToString(), taiKhoanFirstEle.Field<string>("MatKhau")!, taiKhoanFirstEle.Field<string>("VaiTro")!);

            return taiKhoan;
        }

        public static int? LaySoLuongTaiKhoan(string tenTaiKhoan)
        {
            string query = $@"SELECT COUNT(*) FROM {tableName}  WHERE TenTaiKhoan = @TenTaiKhoan";
            var soLuongTaiKhoan = SqlSingleton.Instance.ExecuteScalar(query, [
                new SqlParameter("TenTaiKhoan", tenTaiKhoan)]);
            return (int)soLuongTaiKhoan;
        }

        public static void ThemTaiKhoan(DTO_TaiKhoan taiKhoan)
        {
            string query = $@"  INSERT INTO {tableName}(TenTaiKhoan, MatKhau, VaiTro)
VALUES(@TenTaiKhoan,@MatKhau, @VaiTro);";
            SqlSingleton.Instance.ExecuteNonQuery(query, [new SqlParameter("TenTaiKhoan", taiKhoan.TenTaiKhoan), new SqlParameter("MatKhau", taiKhoan.MatKhau), new SqlParameter("VaiTro", taiKhoan.VaiTro)]);
        }
    }
}
