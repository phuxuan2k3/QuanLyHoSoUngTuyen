using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BUS;

namespace Ctrler
{
    public class Ctrler_DangNhap
    {
        public static DTO_TaiKhoan? XacThuc(string tenTaiKhoan, string matKhau)
        {
            return BUS_TaiKhoan.LayTaiKhoan(tenTaiKhoan, matKhau);
        }
    }
}