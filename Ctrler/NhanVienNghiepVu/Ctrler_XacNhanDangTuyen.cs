using BUS;
using DTO;

namespace Ctrler.NhanVienNghiepVu
{
	public class Ctrler_XacNhanDangTuyen
    {
        private readonly DTO_ThongTinDangTuyen _ttdt;
        private readonly DTO_HinhThucDangTuyen _hinhThucDangTuyen;
        private readonly DTO_DoanhNghiep _DoanhNghiep;

        public Ctrler_XacNhanDangTuyen(DTO_ThongTinDangTuyen ttdt, DTO_HinhThucDangTuyen hinhThucDangTuyen, DTO_DoanhNghiep doanhNghiep)
        {
            _ttdt = ttdt;
            _hinhThucDangTuyen = hinhThucDangTuyen;
            _DoanhNghiep = doanhNghiep;
        }

        public void Load(ref DTO_ThongTinDangTuyen thongTinDangTuyen, ref DTO_HinhThucDangTuyen hinhThucDangTuyen, ref DTO_DoanhNghiep doanhNghiep)
        {
            thongTinDangTuyen = _ttdt;
            hinhThucDangTuyen = _hinhThucDangTuyen;
            doanhNghiep = _DoanhNghiep;
        }

        public static void XacNhanDangTuyen(string MaTTDT)
        {
            BUS_ThongTinDangTuyen.CapNhatTinhTrangDangTuyen(MaTTDT);
        }
    }
}
