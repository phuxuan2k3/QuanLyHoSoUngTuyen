using BUS;
using DTO;

namespace Ctrler.NhanVienTiepNhan
{
	public class Ctrler_DanhSachTTDTCanXetDuyet
    {
        public void Load(ref List<DTO_ThongTinDangTuyen> thongTinDangTuyen)
        {
            thongTinDangTuyen = BUS_ThongTinDangTuyen.LayDSTTDTCanXetDuyet();
        }

        public Ctrler_XetDuyetThongTinDangTuyen HienThi_XetDuyetThongTinDangTuyen(string maTTDT)
        {
            var ttdt = BUS_ThongTinDangTuyen.Lay(maTTDT);
            var hinhThucDangTuyen = BUS_HinhThucDangTuyen.Lay(ttdt.MaHTDT);
            var doanhNghiep = BUS_DoanhNghiep.Lay(ttdt.MaDN);
            return new Ctrler_XetDuyetThongTinDangTuyen(ttdt, hinhThucDangTuyen, doanhNghiep);
        }
    }
}
