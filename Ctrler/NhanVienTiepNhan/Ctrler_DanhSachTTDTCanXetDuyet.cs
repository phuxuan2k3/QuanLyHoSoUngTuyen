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

		public void LoadChiTiet(string maTTDT, ref DTO_ThongTinDangTuyen thongTinDangTuyen, ref DTO_DoanhNghiep doanhNghiep, ref DTO_HinhThucDangTuyen hinhThucDangTuyen)
		{
			thongTinDangTuyen = BUS_ThongTinDangTuyen.Lay(maTTDT);
			hinhThucDangTuyen = BUS_HinhThucDangTuyen.Lay(thongTinDangTuyen.MaHTDT);
			doanhNghiep = BUS_DoanhNghiep.Lay(thongTinDangTuyen.MaDN);
		}
	}
}
