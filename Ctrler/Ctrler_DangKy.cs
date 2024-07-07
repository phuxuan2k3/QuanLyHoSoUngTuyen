
using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ctrler
{
    public class Ctrler_DangKy
    {
        public static void DangKyUngVien(DTO_TaiKhoan taiKhoan, DTO_UngVien ungVien)
        {
            BUS_TaiKhoan.ThemTaiKhoan(taiKhoan);
            BUS_UngVien.ThemUngVien(ungVien);
        }     
        public static void DangKyDoanhNghiep(DTO_TaiKhoan taiKhoan, DTO_DoanhNghiep doanhNghiep)
        {
            BUS_TaiKhoan.ThemTaiKhoan(taiKhoan);
            BUS_DoanhNghiep.ThemDoanhNghiep(doanhNghiep);
        }
    }
}
