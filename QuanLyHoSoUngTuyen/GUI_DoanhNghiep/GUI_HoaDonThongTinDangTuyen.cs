using Ctrler;
using DTO;
using GUI.GUIException;
using Utilis;

namespace GUI.UC
{
	public partial class GUI_HoaDonThongTinDangTuyen : UserControl
	{
		private Ctrler_HoaDonThongTinDangTuyen? _ctrler_HoaDonThongTinDangTuyen;
		public Ctrler_HoaDonThongTinDangTuyen Ctrler_HoaDonThongTinDangTuyen
		{
			get => _ctrler_HoaDonThongTinDangTuyen ?? throw new ControllerNotFoundException();
			set => _ctrler_HoaDonThongTinDangTuyen = value;
		}

		public GUI_HoaDonThongTinDangTuyen()
		{
			InitializeComponent();
		}

		public void HienThi(Ctrler_HoaDonThongTinDangTuyen ctrler_HoaDonThongTinDangTuyen)
		{
			_ctrler_HoaDonThongTinDangTuyen = ctrler_HoaDonThongTinDangTuyen;
			DTO_ThongTinDangTuyen thongTinDangTuyen = new DTO_ThongTinDangTuyen();
			DTO_HinhThucDangTuyen hinhThucDangTuyen = new DTO_HinhThucDangTuyen();
			DTO_HoaDon hoaDon = new DTO_HoaDon();
			List<DTO_ChiTietHoaDon> dsChiTietHoaDon = new List<DTO_ChiTietHoaDon>();
			_ctrler_HoaDonThongTinDangTuyen.Load(ref thongTinDangTuyen, ref hoaDon, ref hinhThucDangTuyen, ref dsChiTietHoaDon);
			_maTTDT.Text = thongTinDangTuyen.MaTTDT;
			_soNgayDangTuyen.Text = thongTinDangTuyen.SoNgayDangTuyen.ToString();
			_thoiGianDangTuyen.Text = thongTinDangTuyen.ThoiGianDangTuyen.ToDateString();
			_hinhThuc.Text = hinhThucDangTuyen.TenHinhThuc;
			_trangThaiThanhToan.Text = hoaDon.TrangThaiThanhToan.ToString();
			_cachThucThanhToan.Text = hoaDon.CachThucThanhToan.ToString();
			_ngayLapHoaDon.Text = hoaDon.NgayLap.ToDateString();
			_tongChiPhi.Text = hoaDon.TongTien.ToVNDString();
			foreach (var chiTietHoaDon in dsChiTietHoaDon)
			{
				int rowId = this.dsChiTietHoaDon.Rows.Add();
				DataGridViewRow row = this.dsChiTietHoaDon.Rows[rowId];
				row.Cells[_lanThanhToan.Name].Value = chiTietHoaDon.LanThanhToan;
				row.Cells[_soTienThanhToan.Name].Value = chiTietHoaDon.SoTienCanThanhToan;
				row.Cells[_ngayThanhToan.Name].Value = chiTietHoaDon.NgayThanhToan;
			}
		}

		private void btnXuatHoaDon_Click(object sender, EventArgs e)
		{
			using SaveFileDialog saveFileDialog1 = new SaveFileDialog();
			saveFileDialog1.InitialDirectory = @"C:\";
			saveFileDialog1.Title = "Save PDF";
			saveFileDialog1.CheckFileExists = true;
			saveFileDialog1.CheckPathExists = true;
			saveFileDialog1.DefaultExt = "pdf";
			saveFileDialog1.RestoreDirectory = true;
			if (saveFileDialog1.ShowDialog() == DialogResult.OK)
			{
				var outPath = saveFileDialog1.FileName;
				Ctrler_HoaDonThongTinDangTuyen.XuatPDF(outPath);
			}
		}

		private void btnQuayLai_Click(object sender, EventArgs e)
		{
			GUI_ChiTietThongTinDangTuyen content = new();
			var ctrler = Ctrler_HoaDonThongTinDangTuyen.HienThi_ChiTiet();
			content.HienThi(ctrler);
			GUI_DoanhNghiep.Instance.SwitchContent(content);
		}
	}
}
