using BUS;
using DTO;

namespace Ctrler.NhanVienNghiepVu
{
	public class Ctrler_XacNhanDangTuyen
    {
        private readonly DTO_ThongTinDangTuyen thongTinDangTuyen;
        private readonly DTO_HinhThucDangTuyen hinhThucDangTuyen;
        private readonly DTO_DoanhNghiep doanhNghiep;

        public Ctrler_XacNhanDangTuyen(DTO_ThongTinDangTuyen thongTinDangTuyen, DTO_HinhThucDangTuyen hinhThucDangTuyen, DTO_DoanhNghiep doanhNghiep)
        {
            this.thongTinDangTuyen = thongTinDangTuyen;
            this.hinhThucDangTuyen = hinhThucDangTuyen;
            this.doanhNghiep = doanhNghiep;
        }

        public void Load(ref DTO_ThongTinDangTuyen thongTinDangTuyen, ref DTO_HinhThucDangTuyen hinhThucDangTuyen, ref DTO_DoanhNghiep doanhNghiep)
        {
            thongTinDangTuyen = this.thongTinDangTuyen;
            hinhThucDangTuyen = this.hinhThucDangTuyen;
            doanhNghiep = this.doanhNghiep;
        }

        public static void XacNhanDangTuyen(string MaTTDT)
        {
            BUS_ThongTinDangTuyen.CapNhatDaDangTuyen(MaTTDT);
        }
    }
}
