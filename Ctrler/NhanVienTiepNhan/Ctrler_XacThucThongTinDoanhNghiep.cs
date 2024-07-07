using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ctrler.NhanVienTiepNhan
{
    public class Ctrler_XacThucThongTinDoanhNghiep
    {
        public static void Load(ref List<DTO_DoanhNghiep> dsDNXT)
        {
            dsDNXT = BUS_DoanhNghiep.LayDoanhNghiepCanXacThuc();
        }

        public static DTO_DoanhNghiep LayThongTinDoanhNghiep(string MaDN)
        {
            DTO_DoanhNghiep DNXT = BUS_DoanhNghiep.Lay(MaDN);
            return DNXT;
        }

        public static void CapNhatTrangThaiDoanhNghiep(string MaDN, string TrangThai)
        {

            BUS_DoanhNghiep.CapNhatTrangThaiDN(MaDN, TrangThai);
        }


    }
}
