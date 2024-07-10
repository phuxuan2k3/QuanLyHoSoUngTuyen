using BUS;
using DTO;

namespace Ctrler.NhanVienNghiepVu
{
	public class Ctrler_DanhSachTTDTCanDangTuyen
	{
		public void Load(ref List<DTO_ThongTinDangTuyen> thongTinDangTuyen)
		{
			thongTinDangTuyen = BUS_ThongTinDangTuyen.LayDSTTDTCanDangTuyen();
		}

		public void LoadChiTiet(string maTTDT, ref DTO_ThongTinDangTuyen thongTinDangTuyen, ref DTO_HinhThucDangTuyen hinhThucDangTuyen, ref DTO_DoanhNghiep doanhNghiep)
		{
			thongTinDangTuyen = BUS_ThongTinDangTuyen.Lay(maTTDT);
			hinhThucDangTuyen = BUS_HinhThucDangTuyen.Lay(thongTinDangTuyen.MaHTDT);
			doanhNghiep = BUS_DoanhNghiep.Lay(thongTinDangTuyen.MaDN);
		}
	}
}
