using Ctrler.NhanVienThanhToan;
using DTO;
using GUI.GUIException;
using Utilis;

namespace GUI.UserControls;

public partial class GUI_DanhSachHoaDonDangTuyen : UserControl
{
	private Ctrler_DanhSachHoaDonDangTuyen? ctrler;

	private Ctrler_DanhSachHoaDonDangTuyen Ctrler
	{
		get => ctrler ?? throw new ControllerNotFoundException();
		set => ctrler = value;
	}

	public GUI_DanhSachHoaDonDangTuyen()
	{
		InitializeComponent();
	}

	public void HienThi(Ctrler_DanhSachHoaDonDangTuyen ctrler_DanhSachHoaDonDangTuyen)
	{
		ctrler = ctrler_DanhSachHoaDonDangTuyen;
		var dsHD = new List<DTO_HoaDon>();
		Ctrler.Load(ref dsHD);
		foreach (var hd in dsHD)
		{
			int rowId = dsHoaDon.Rows.Add();
			DataGridViewRow row = dsHoaDon.Rows[rowId];
			row.Cells["_maTTDT"].Value = hd.MaTTDT;
			row.Cells["_tongTien"].Value = hd.TongTien.ToVNDString();
			row.Cells["_cachThucThanhToan"].Value = hd.CachThucThanhToan.ToDisplayString();
			row.Cells["_ngayLap"].Value = hd.NgayLap.ToDateString();
			row.Cells["_trangThai"].Value = hd.TrangThaiThanhToan.ToDisplayString();
		}
	}

	private void dsHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
	{
		if (dsHoaDon.Rows[e.RowIndex].Cells["_maTTDT"].Value is string maTTDT)
		{
			var hoaDon = Ctrler.TruyVanHoaDon(maTTDT);
			if (hoaDon == null)
			{
				MessageBox.Show($"Không tìm thấy hóa đơn \"{maTTDT}\"", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else if (hoaDon.TrangThaiThanhToan == TrangThaiThanhToan.DaThanhToanHoanTat)
			{
				MessageBox.Show($"Hóa đơn \"{maTTDT}\" đã thanh toán", "Đã thanh toán", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				DTO_ThongTinDangTuyen thongTinDangTuyen = new();
				List<DTO_ChiTietHoaDon> chiTietHoaDons = new();
				DTO_DoanhNghiep doanhNghiep = new();
				Ctrler.LoadChiTietHoaDon(maTTDT, ref thongTinDangTuyen, ref chiTietHoaDons, ref doanhNghiep);
				var gui = new GUI_DongPhiChoHoaDon();
				var ctrler = new Ctrler_DongPhiChoHoaDon(thongTinDangTuyen, hoaDon, doanhNghiep, chiTietHoaDons);
				gui.HienThi(ctrler!);
				GUI_NhanVienThanhToan.Instance.SwitchContent(gui);
			}
		}
	}

	private void btnTraCuu_Click(object sender, EventArgs e)
	{
		var maTTDT = txtMaTTDT.Text;
		var hoaDon = Ctrler.TruyVanHoaDon(maTTDT);
		if (hoaDon == null)
		{
			MessageBox.Show($"Không tìm thấy hóa đơn \"{maTTDT}\"", "Không tìm thấy", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}
		else if (hoaDon.TrangThaiThanhToan == TrangThaiThanhToan.DaThanhToanHoanTat)
		{
			MessageBox.Show($"Hóa đơn \"{maTTDT}\" đã thanh toán", "Đã thanh toán", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
		else
		{
			DTO_ThongTinDangTuyen thongTinDangTuyen = new();
			List<DTO_ChiTietHoaDon> chiTietHoaDons = new();
			DTO_DoanhNghiep doanhNghiep = new();
			Ctrler.LoadChiTietHoaDon(maTTDT, ref thongTinDangTuyen, ref chiTietHoaDons, ref doanhNghiep);
			var gui = new GUI_DongPhiChoHoaDon();
			var ctrler = new Ctrler_DongPhiChoHoaDon(thongTinDangTuyen, hoaDon, doanhNghiep, chiTietHoaDons);
			gui.HienThi(ctrler!);
			GUI_NhanVienThanhToan.Instance.SwitchContent(gui);
		}
	}
}
