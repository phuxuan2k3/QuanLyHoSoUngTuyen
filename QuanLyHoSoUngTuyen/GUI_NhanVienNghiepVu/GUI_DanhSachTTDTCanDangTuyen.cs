using Ctrler.DoanhNghiep;
using Ctrler.NhanVienNghiepVu;
using DTO;
using GUI.GUIException;

namespace GUI.UserControls
{
	public partial class GUI_DanhSachTTDTCanDangTuyen : UserControl
	{
		public GUI_DanhSachTTDTCanDangTuyen()
		{
			InitializeComponent();
		}

		private Ctrler_DanhSachTTDTCanDangTuyen? ctrler;

		public Ctrler_DanhSachTTDTCanDangTuyen Ctrler
		{
			get => ctrler ?? throw new ControllerNotFoundException();
			set => ctrler = value;
		}

		public void HienThi(Ctrler_DanhSachTTDTCanDangTuyen ctrler_DanhSachThongTinDangTuyen)
		{
			ctrler = ctrler_DanhSachThongTinDangTuyen;
			var dsTTDT = new List<DTO_ThongTinDangTuyen>();
			Ctrler.Load(ref dsTTDT);
			foreach (var ttdt in dsTTDT)
			{
				int rowId = dsThongTinDangTuyen.Rows.Add();
				DataGridViewRow row = dsThongTinDangTuyen.Rows[rowId];
				row.Cells["_id"].Value = ttdt.MaTTDT;
				row.Cells["_viTri"].Value = ttdt.TenViTri;
				row.Cells["_soLuong"].Value = ttdt.SoLuong;
				row.Cells["_thoiGianDang"].Value = ttdt.ThoiGianDangTuyen.Date.ToShortDateString();
				row.Cells["_soNgayDang"].Value = ttdt.SoNgayDangTuyen;
				row.Cells["_trangThai"].Value = ttdt.TrangThai.ToDisplayString();
				row.Cells["_tinhTrang"].Value = ttdt.TinhTrang.ToDisplayString();
			}
		}

		private void dsThongTinDangTuyen_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (dsThongTinDangTuyen.Rows[e.RowIndex].Cells["_id"].Value is string maTTDT)
			{
				var thongTinDangTuyen = new DTO_ThongTinDangTuyen();
				var hinhThucDangTuyen = new DTO_HinhThucDangTuyen();
				var doanhNghiep = new DTO_DoanhNghiep();
				Ctrler.LoadChiTiet(maTTDT, ref thongTinDangTuyen, ref hinhThucDangTuyen, ref doanhNghiep);
				var gui = new GUI_XacNhanDangTuyen();
				var ctrler = new Ctrler_XacNhanDangTuyen(thongTinDangTuyen, hinhThucDangTuyen, doanhNghiep);
				gui.HienThi(ctrler);
				GUI_NhanVienNghiepVu.Instance.SwitchContent(gui);
			}
		}
	}
}
