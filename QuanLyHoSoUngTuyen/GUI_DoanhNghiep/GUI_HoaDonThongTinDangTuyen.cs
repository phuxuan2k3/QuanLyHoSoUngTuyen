using Ctrler;
using Ctrler.DoanhNghiep;
using DTO;
using GUI.GUIException;
using Utilis;

namespace GUI.UserControls
{
	public partial class GUI_HoaDonThongTinDangTuyen : UserControl
	{
		private Ctrler_HoaDonThongTinDangTuyen? ctrler;
		public Ctrler_HoaDonThongTinDangTuyen Ctrler
		{
			get => ctrler ?? throw new ControllerNotFoundException();
			set => ctrler = value;
		}

		public GUI_HoaDonThongTinDangTuyen()
		{
			InitializeComponent();
		}

		public void HienThi(Ctrler_HoaDonThongTinDangTuyen ctrler_HoaDonThongTinDangTuyen)
		{
			ctrler = ctrler_HoaDonThongTinDangTuyen;
			DTO_ThongTinDangTuyen thongTinDangTuyen = new DTO_ThongTinDangTuyen();
			DTO_HinhThucDangTuyen hinhThucDangTuyen = new DTO_HinhThucDangTuyen();
			DTO_HoaDon hoaDon = new DTO_HoaDon();
			List<DTO_ChiTietHoaDon> dsChiTietHoaDon = new List<DTO_ChiTietHoaDon>();
			ctrler.Load(ref thongTinDangTuyen, ref hoaDon, ref hinhThucDangTuyen, ref dsChiTietHoaDon);
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
					Ctrler.XuatPDF(filePath);
					MessageBox.Show(@$"Xuất hóa đơn thành công. Địa chỉ thư mục đến hóa đơn là: {filePath}", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				catch (Exception ex)
				{
					MessageBox.Show($"Xuất hóa đơn thất bại: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void btnQuayLai_Click(object sender, EventArgs e)
		{
			DTO_ThongTinDangTuyen thongTinDangTuyen = new DTO_ThongTinDangTuyen();
			DTO_HinhThucDangTuyen hinhThucDangTuyen = new DTO_HinhThucDangTuyen();
			DTO_HoaDon hoaDon = new DTO_HoaDon();
			Ctrler.LoadChiTiet(ref thongTinDangTuyen, ref hoaDon, ref hinhThucDangTuyen);
			GUI_ChiTietThongTinDangTuyen gui = new();
			var ctrler = new Ctrler_ChiTietThongTinDangTuyen(thongTinDangTuyen, hoaDon, hinhThucDangTuyen);
			gui.HienThi(ctrler);
			GUI_DoanhNghiep.Instance.SwitchContent(gui);
		}
	}
}
