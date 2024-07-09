using Ctrler.NhanVienTiepNhan;
using DTO;
using GUI.GUIException;

namespace GUI.UserControls
{
	public partial class GUI_DanhSachTTDTCanXetDuyet : UserControl
	{
		public GUI_DanhSachTTDTCanXetDuyet()
		{
			InitializeComponent();
		}

		private Ctrler_DanhSachTTDTCanXetDuyet? ctrler;

		public Ctrler_DanhSachTTDTCanXetDuyet Ctrler
		{
			get => ctrler ?? throw new ControllerNotFoundException();
			set => ctrler = value;
		}

		public void HienThi(Ctrler_DanhSachTTDTCanXetDuyet ctrler_DanhSachThongTinDangTuyen)
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
				row.Cells["_thoiGianDang"].Value = ttdt.ThoiGianDangTuyen;
				row.Cells["_soNgayDang"].Value = ttdt.SoNgayDangTuyen;
				row.Cells["_trangThai"].Value = ttdt.TrangThai.ToDisplayString();
				row.Cells["_tinhTrang"].Value = ttdt.TinhTrang.ToDisplayString();
			}
		}

		private void dsThongTinDangTuyen_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (dsThongTinDangTuyen.Rows[e.RowIndex].Cells["_id"].Value is string maTTDT)
			{
				DTO_ThongTinDangTuyen thongTinDangTuyen = new();
				DTO_DoanhNghiep doanhNghiep = new();
				DTO_HinhThucDangTuyen hinhThucDangTuyen = new();
				Ctrler.LoadChiTiet(maTTDT, ref thongTinDangTuyen, ref doanhNghiep, ref hinhThucDangTuyen);
				var gui = new GUI_XetDuyetThongTinDangTuyen();
				var ctrler = new Ctrler_XetDuyetThongTinDangTuyen(thongTinDangTuyen, hinhThucDangTuyen, doanhNghiep);
				gui.HienThi(ctrler);
				GUI_NhanVienTiepNhan.Instance.SwitchContent(gui);
			}
		}
	}
}
