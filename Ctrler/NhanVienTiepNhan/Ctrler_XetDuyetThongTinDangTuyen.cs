using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ctrler.NhanVienTiepNhan
{
	public class Ctrler_XetDuyetThongTinDangTuyen
	{
		private readonly DTO_ThongTinDangTuyen thongTinDangTuyen;
		private readonly DTO_HinhThucDangTuyen hinhThucDangTuyen;
		private readonly DTO_DoanhNghiep doanhNghiep;

		public Ctrler_XetDuyetThongTinDangTuyen(DTO_ThongTinDangTuyen ttdt, DTO_HinhThucDangTuyen hinhThucDangTuyen, DTO_DoanhNghiep doanhNghiep)
		{
			thongTinDangTuyen = ttdt;
			this.hinhThucDangTuyen = hinhThucDangTuyen;
			this.doanhNghiep = doanhNghiep;
		}

		public void Load(ref DTO_ThongTinDangTuyen thongTinDangTuyen, ref DTO_HinhThucDangTuyen hinhThucDangTuyen, ref DTO_DoanhNghiep doanhNghiep)
		{
			thongTinDangTuyen = this.thongTinDangTuyen;
			hinhThucDangTuyen = this.hinhThucDangTuyen;
			doanhNghiep = this.doanhNghiep;
		}

		public static void CapNhatTrangThai(string MaTTDT, TrangThaiThongTinDangTuyen trangThai)
		{
			BUS_ThongTinDangTuyen.CapNhatTrangThai(MaTTDT, trangThai);
		}
	}
}
