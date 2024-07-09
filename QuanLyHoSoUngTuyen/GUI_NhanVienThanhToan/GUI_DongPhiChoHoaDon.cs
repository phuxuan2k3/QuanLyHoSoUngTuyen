using Ctrler.NhanVienThanhToan;
using DTO;
using GUI.GUIException;
using Utilis;

namespace GUI.UserControls
{
	public partial class GUI_DongPhiChoHoaDon : UserControl
	{
		private Ctrler_DongPhiChoHoaDon? ctrler;
		public Ctrler_DongPhiChoHoaDon Ctrler
		{
			get => ctrler ?? throw new ControllerNotFoundException();
			set => ctrler = value;
		}

		public GUI_DongPhiChoHoaDon()
		{
			InitializeComponent();
		}

		public void HienThi(Ctrler_DongPhiChoHoaDon ctrler_HoaDonThongTinDangTuyen)
		{
			ctrler = ctrler_HoaDonThongTinDangTuyen;
			DTO_DoanhNghiep doanhNghiep = new DTO_DoanhNghiep();
			DTO_ThongTinDangTuyen thongTinDangTuyen = new DTO_ThongTinDangTuyen();
			DTO_HoaDon hoaDon = new DTO_HoaDon();
			DTO_ChiTietHoaDon? lanDongHienTai = new DTO_ChiTietHoaDon();
			List<DTO_ChiTietHoaDon> dsChiTietHoaDon = new List<DTO_ChiTietHoaDon>();
			ctrler.Load(ref thongTinDangTuyen, ref hoaDon, ref doanhNghiep, ref dsChiTietHoaDon, ref lanDongHienTai);
			_maTTDT.Text = thongTinDangTuyen.MaTTDT;
			_doanhNghiep.Text = doanhNghiep.TenDN;
			_tongChiPhi.Text = hoaDon.TongTien.ToVNDString();
			_trangThai.Text = hoaDon.TrangThaiThanhToan.ToDisplayString();
			_cachThuc.Text = hoaDon.CachThucThanhToan.ToDisplayString();
			_ngayLap.Text = hoaDon.NgayLap.ToDateString();
			foreach (var chiTietHoaDon in dsChiTietHoaDon)
			{
				int rowId = this.dsChiTietHoaDon.Rows.Add();
				DataGridViewRow row = this.dsChiTietHoaDon.Rows[rowId];
				row.Cells[_lanThanhToan.Name].Value = chiTietHoaDon.LanThanhToan;
				row.Cells[_soTienThanhToan.Name].Value = chiTietHoaDon.SoTienCanThanhToan;
				row.Cells[_ngayThanhToan.Name].Value = chiTietHoaDon.NgayThanhToan;
			}
			if (lanDongHienTai == null)
			{
				GUI_DanhSachHoaDonDangTuyen content = new();
				content.HienThi(new Ctrler_DanhSachHoaDonDangTuyen());
				GUI_NhanVienThanhToan.Instance.SwitchContent(content);
				return;
			}
			_lanDongHienTai.Text = lanDongHienTai.LanThanhToan.ToString();
			_soTienCanDong.Text = lanDongHienTai.SoTienCanThanhToan.ToVNDString();
		}

		private void btnThanhToan_Click(object sender, EventArgs e)
		{
			DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn cập nhật lần thanh toán cho thông tin đăng tuyển?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (dialogResult == DialogResult.Yes)
			{
				Ctrler.DongPhiChoHoaDon();
				GUI_DanhSachHoaDonDangTuyen content = new();
				content.HienThi(new Ctrler_DanhSachHoaDonDangTuyen());
				GUI_NhanVienThanhToan.Instance.SwitchContent(content);
			}
		}

		private void btnQuayLai_Click(object sender, EventArgs e)
		{
			GUI_DanhSachHoaDonDangTuyen content = new();
			content.HienThi(new Ctrler_DanhSachHoaDonDangTuyen());
			GUI_NhanVienThanhToan.Instance.SwitchContent(content);
		}
	}
}
