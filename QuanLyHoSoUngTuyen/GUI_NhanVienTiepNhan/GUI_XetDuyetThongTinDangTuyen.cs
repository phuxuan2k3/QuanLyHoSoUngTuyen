using Ctrler.NhanVienTiepNhan;
using DTO;
using GUI.GUIException;

namespace GUI.UserControls
{
	public partial class GUI_XetDuyetThongTinDangTuyen : UserControl
	{
		public GUI_XetDuyetThongTinDangTuyen()
		{
			InitializeComponent();
		}

		private Ctrler_XetDuyetThongTinDangTuyen? ctrler;
		public Ctrler_XetDuyetThongTinDangTuyen Ctrler
		{
			get => ctrler ?? throw new ControllerNotFoundException();
			private set => ctrler = value;
		}

		public void HienThi(Ctrler_XetDuyetThongTinDangTuyen ctrler_XetDuyetThongTinDangTuyen)
		{
			ctrler = ctrler_XetDuyetThongTinDangTuyen;
			DTO_ThongTinDangTuyen thongTinDangTuyen = new();
			DTO_HinhThucDangTuyen hinhThucDangTuyen = new();
			DTO_DoanhNghiep doanhnghiep = new();
			Ctrler.Load(ref thongTinDangTuyen, ref hinhThucDangTuyen, ref doanhnghiep);
			_TenDN.Text = doanhnghiep.TenDN.ToString();
			_maTTDT.Text = thongTinDangTuyen.MaTTDT;
			_soNgayDangTuyen.Text = thongTinDangTuyen.SoNgayDangTuyen.ToString();
			_thoiGianDangTuyen.Text = thongTinDangTuyen.ThoiGianDangTuyen.ToString("dd/MM/yyyy") ?? "";
			_hinhThuc.Text = hinhThucDangTuyen.TenHinhThuc.ToString();
			_tenViTri.Text = thongTinDangTuyen.TenViTri;
			_soLuong.Text = thongTinDangTuyen.SoLuong.ToString();
			_yeuCau.Text = thongTinDangTuyen.YeuCau;
			_trangThai.Text = thongTinDangTuyen.TrangThai.ToDisplayString();
			_tinhTrang.Text = thongTinDangTuyen.TinhTrang.ToDisplayString();
		}

		private void btnHopLe_Click(object sender, EventArgs e)
		{
			var res = MessageBox.Show($"Bạn có chắc chắn chọn kết quả xét duyệt \"Hợp lệ\"?", "Xét duyệt cho thông tin đăng tuyển", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (res == DialogResult.Yes)
			{
				Ctrler_XetDuyetThongTinDangTuyen.CapNhatTrangThai(_maTTDT.Text, TrangThaiThongTinDangTuyen.HopLe);
				var gui = new GUI_DanhSachTTDTCanXetDuyet();
				gui.HienThi(new Ctrler_DanhSachTTDTCanXetDuyet());
				GUI_NhanVienTiepNhan.Instance.SwitchContent(gui);
			}
		}

		private void btnKhongHopLe_Click(object sender, EventArgs e)
		{
			var res = MessageBox.Show($"Bạn có chắc chắn chọn kết quả xét duyệt \"Không hợp lệ\"?", "Xét duyệt cho thông tin đăng tuyển", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (res == DialogResult.Yes)
			{
				Ctrler_XetDuyetThongTinDangTuyen.CapNhatTrangThai(_maTTDT.Text, TrangThaiThongTinDangTuyen.KhongHopLe);
				var gui = new GUI_DanhSachTTDTCanXetDuyet();
				gui.HienThi(new Ctrler_DanhSachTTDTCanXetDuyet());
				GUI_NhanVienTiepNhan.Instance.SwitchContent(gui);
			}
		}

		private void btnQuayLai_Click(object sender, EventArgs e)
		{
			var gui = new GUI_DanhSachTTDTCanXetDuyet();
			gui.HienThi(new Ctrler_DanhSachTTDTCanXetDuyet());
			GUI_NhanVienTiepNhan.Instance.SwitchContent(gui);
		}
	}
}