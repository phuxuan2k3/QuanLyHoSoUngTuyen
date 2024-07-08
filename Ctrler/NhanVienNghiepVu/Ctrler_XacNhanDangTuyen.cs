using BUS;
using DTO;

namespace Ctrler.NhanVienNghiepVu
{
	public class Ctrler_XacNhanDangTuyen
    {
        private readonly DTO_ThongTinDangTuyen _thongTinDangTuyen;
        private readonly DTO_HinhThucDangTuyen _hinhThucDangTuyen;
        private readonly DTO_DoanhNghiep _doanhNghiep;

        public Ctrler_XacNhanDangTuyen(DTO_ThongTinDangTuyen ttdt, DTO_HinhThucDangTuyen hinhThucDangTuyen, DTO_DoanhNghiep doanhNghiep)
        {
            _thongTinDangTuyen = ttdt;
            _hinhThucDangTuyen = hinhThucDangTuyen;
            _doanhNghiep = doanhNghiep;
        }

        public void Load(ref DTO_ThongTinDangTuyen thongTinDangTuyen, ref DTO_HinhThucDangTuyen hinhThucDangTuyen, ref DTO_DoanhNghiep doanhNghiep)
        {
            thongTinDangTuyen = _thongTinDangTuyen;
            hinhThucDangTuyen = _hinhThucDangTuyen;
            doanhNghiep = _doanhNghiep;
        }

        public static void XacNhanDangTuyen(string MaTTDT)
        {
            BUS_ThongTinDangTuyen.CapNhatDaDangTuyen(MaTTDT);
        }
    }
}
