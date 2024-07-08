using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ctrler.NhanVienNghiepVu
{
    public class Ctrler_XemThongTinDoanhNghiep
    {
        public static List<DTO_DoanhNghiep> LayDanhSachDoanhNghiep()
        {
            return BUS_DoanhNghiep.LayDanhSachDoanhNghiep();
        }
        public static List<DTO_DoanhNghiep> LayDanhSachDoanhNghiepChuaXacThuc()
        {
            return BUS_DoanhNghiep.LayDanhSachDoanhNghiepChuaXacThuc();
        }
        public static List<DTO_DoanhNghiep> LayDanhSachDoanhNghiepKhongHopLe()
        {
            return BUS_DoanhNghiep.LayDanhSachDoanhNghiepKhongHopLe();
        }
        public static List<DTO_DoanhNghiep> LayDanhSachDoanhNghiepHopLe()
        {
            return BUS_DoanhNghiep.LayDanhSachDoanhNghiepHopLe();
        }
        public static List<DTO_DoanhNghiep> LayDanhSachDoanhNghiepTiemNang()
        {
            return BUS_DoanhNghiep.LayDanhSachDoanhNghiepTiemNang();
        }

        public static List<DTO_ChienLuocUuDai> LayDanhSachUuDai(string maDN)
        {
            return BUS_ChienLuocUuDai.LayDanhSachUD(maDN);
        }
    }
}
