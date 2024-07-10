using Ctrler.NhanVienNghiepVu;
using DTO;
using GUI.GUIException;

namespace GUI.UserControls
{
	public partial class GUI_XacNhanDangTuyen : UserControl
	{
		public GUI_XacNhanDangTuyen()
		{
			InitializeComponent();
		}
		private Ctrler_XacNhanDangTuyen? _ctrler_ChiTietThongTinDangTuyen;


		public Ctrler_XacNhanDangTuyen Ctrler_ChiTietThongTinDangTuyen
		{
			get => _ctrler_ChiTietThongTinDangTuyen ?? throw new ControllerNotFoundException();
			private set => _ctrler_ChiTietThongTinDangTuyen = value;
		}

		public void HienThi(Ctrler_XacNhanDangTuyen ctrler_ChiTietThongTinDangTuyen)
		{
			_ctrler_ChiTietThongTinDangTuyen = ctrler_ChiTietThongTinDangTuyen;
			DTO_ThongTinDangTuyen thongTinDangTuyen = new();
			DTO_HinhThucDangTuyen hinhThucDangTuyen = new();
			DTO_DoanhNghiep doanhnghiep = new();
			Ctrler_ChiTietThongTinDangTuyen.Load(ref thongTinDangTuyen, ref hinhThucDangTuyen, ref doanhnghiep);
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

		private void btnQuayLai_Click(object sender, EventArgs e)
		{
			var gui = new GUI_DanhSachTTDTCanDangTuyen();
			gui.HienThi(new Ctrler_DanhSachTTDTCanDangTuyen());
			GUI_NhanVienNghiepVu.Instance.SwitchContent(gui);
		}

		private void btnXacNhan_Click(object sender, EventArgs e)
		{
			DialogResult dialogResult = MessageBox.Show("Xác nhận tình trạng đăng tuyển cho thông tin đăng tuyển?", "Thông báo", MessageBoxButtons.YesNo);
			if (dialogResult == DialogResult.Yes)
			{
				Ctrler_XacNhanDangTuyen.XacNhanDangTuyen(_maTTDT.Text);
				MessageBox.Show("Đã cập nhật tình trạng đăng tuyển cho\r\n\t thông tin đăng tuyển");
			}
		}
	}
}
