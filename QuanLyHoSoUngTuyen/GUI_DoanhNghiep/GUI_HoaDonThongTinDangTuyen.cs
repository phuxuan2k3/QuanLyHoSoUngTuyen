using Ctrler;
using Ctrler.DoanhNghiep;
using DTO;
using GUI.GUIException;
using Utilis;

namespace GUI.UserControls
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
			_trangThaiThanhToan.Text = hoaDon.TrangThaiThanhToan.ToDisplayString();
			_cachThucThanhToan.Text = hoaDon.CachThucThanhToan.ToDisplayString();
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
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Filter = "PDF Files|*.pdf";
			saveFileDialog.Title = "Save a PDF File";
			saveFileDialog.FileName = "document.pdf";

			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				string filePath = saveFileDialog.FileName;
				try
				{
					Ctrler_HoaDonThongTinDangTuyen.XuatPDF(filePath);
					MessageBox.Show("PDF file saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				catch (Exception ex)
				{
					MessageBox.Show($"An error occurred while saving the file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
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
