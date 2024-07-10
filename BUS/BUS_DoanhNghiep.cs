using DAO;
using DTO;
using System.Data;

namespace BUS
{
    public class BUS_DoanhNghiep
    {
        public static List<DTO_DoanhNghiep> LayDanhSachDanhNghiepSapHetHan()
        {
            var lsDN = DAO_DoanhNghiep.LayDanhSachDoanhNghiep();
            var lsDNChuaXacThuc = lsDN.Where(x => x.TrangThai == TrangThaiDoanhNghiep.ChuaXacThuc).ToList();
            return lsDNChuaXacThuc;
        }
        public static List<DTO_DoanhNghiep> LayDanhSachDoanhNghiepChuaXacThuc()
        {
            var lsDN = DAO_DoanhNghiep.LayDanhSachDoanhNghiep();
            var lsDNChuaXacThuc = lsDN.Where(x => x.TrangThai == TrangThaiDoanhNghiep.ChuaXacThuc).ToList();
            return lsDNChuaXacThuc;
        }
        public static List<DTO_DoanhNghiep> LayDanhSachDoanhNghiepKhongHopLe()
        {
            var lsDN = DAO_DoanhNghiep.LayDanhSachDoanhNghiep();
            var lsDNKhongHopLe = lsDN.Where(x => x.TrangThai == TrangThaiDoanhNghiep.KhongHopLe).ToList();
            return lsDNKhongHopLe;
        }
        public static List<DTO_DoanhNghiep> LayDanhSachDoanhNghiepHopLe()
        {
            var lsDN = DAO_DoanhNghiep.LayDanhSachDoanhNghiep();
            var lsDNHopLe = lsDN.Where(x => x.TrangThai == TrangThaiDoanhNghiep.HopLe).ToList();
            return lsDNHopLe;
        }
        public static List<DTO_DoanhNghiep> LayDanhSachDoanhNghiepTiemNang()
        {
            var lsDN = DAO_DoanhNghiep.LayDanhSachDoanhNghiep();
            var lsDNTiemNang = lsDN.Where(x => x.TrangThai == TrangThaiDoanhNghiep.TiemNang).ToList();
            return lsDNTiemNang;
        }
        public static List<DTO_DoanhNghiep> LayDanhSachDoanhNghiep()
        {
            return DAO_DoanhNghiep.LayDanhSachDoanhNghiep();
        }

        public static List<DTO_DoanhNghiep> LayDoanhNghiepCanXacThuc()
        {
            return DAO_DoanhNghiep.LayDNChuaXacThuc();
        }


        public static DTO_DoanhNghiep Lay(string MaDN)
        {
            return DAO_DoanhNghiep.Lay(MaDN);
        }

        public static void CapNhatTrangThaiDN(string MaDN, string TrangThai)
        {

            DAO_DoanhNghiep.CapNhatTrangThaiDN(MaDN, TrangThai);
        }

        public static void CapNhatThongTinDN(DTO_DoanhNghiep doanhNghiep)
        {
            DAO_DoanhNghiep.CapNhatThongTinDn(doanhNghiep);
        }

        public static int KiemTraTrangThaiDN(string maDN)
        {
            return DAO_DoanhNghiep.KiemTraTrangThai(maDN);
        }

        public static void ThemDoanhNghiep(DTO_DoanhNghiep doanhNghiep)
        {
            DAO_DoanhNghiep.ThemDoanhNghiep(doanhNghiep);
        }
        public static DTO_DoanhNghiep LayThongTinDoanhNghiep(string maDoanhNghiep)
        {
            return DAO_DoanhNghiep.LayThongTinDoanhNghiep(maDoanhNghiep);
        }

        public static string LayTenDN(string Ma)
        {
            return DAO_DoanhNghiep.LayTenDoanhNghiep(Ma);
        }

        public static DTO_DoanhNghiep LayDoanhNghiep(string tenTaiKhoan)
        {
            return DAO_DoanhNghiep.LayDNBangTenTaiKhoan(tenTaiKhoan);
        }

        public static void LuuDoanhNghiepTiemNang(string maDN) => DAO_DoanhNghiep.CapNhatTrangThaiDN(maDN, "Tiềm năng");
    }
}