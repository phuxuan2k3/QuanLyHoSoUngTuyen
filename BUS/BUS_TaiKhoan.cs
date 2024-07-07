using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_TaiKhoan
    {
        public static DTO_TaiKhoan? LayTaiKhoan(string tenTaiKhoan, string matKhau)
        {
            return DAO_TaiKhoan.LayTaiKhoan(tenTaiKhoan, matKhau);
        }

        public static bool KiemTraTenTaiKhoanTonTai(string tenTaiKhoan)
        {
            if (DAO_TaiKhoan.LaySoLuongTaiKhoan(tenTaiKhoan) > 0)
            {
                return true;
            }
            return false;
        }

        public static void ThemTaiKhoan(DTO_TaiKhoan taiKhoan)
        {
            DAO_TaiKhoan.ThemTaiKhoan(taiKhoan);
        }

    }
}
