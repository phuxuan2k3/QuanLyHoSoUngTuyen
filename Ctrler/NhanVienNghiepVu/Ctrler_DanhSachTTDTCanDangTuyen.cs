using BUS;
using DTO;

namespace Ctrler.NhanVienNghiepVu
{
    public class Ctrler_DanhSachTTDTCanDangTuyen
    {
        public void Load(ref List<DTO_ThongTinDangTuyen> thongTinDangTuyen)
        {
            thongTinDangTuyen = BUS_ThongTinDangTuyen.LayDSTTDTHopLe();
        }

        public Ctrler_XacNhanDangTuyen HienThi_XacNhanDangTuyen(string maTTDT)
        {
            var ttdt = BUS_ThongTinDangTuyen.Lay(maTTDT);
            var hinhThucDangTuyen = BUS_HinhThucDangTuyen.Lay(ttdt.MaHTDT);
            var doanhNghiep = BUS_DoanhNghiep.Lay(ttdt.MaDN);
            return new Ctrler_XacNhanDangTuyen(ttdt, hinhThucDangTuyen, doanhNghiep);
        }
    }
}
