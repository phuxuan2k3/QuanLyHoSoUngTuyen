﻿using Ctrler.DoanhNghiep;
using Ctrler.NhanVienThanhToan;
using DTO;
using GUI.GUIException;
using Utilis;

namespace GUI.UserControls;

public partial class GUI_DanhSachHoaDonDangTuyen : UserControl
{
	private Ctrler_DanhSachHoaDonDangTuyen? _ctrler_DanhSachHoaDonDangTuyen;

	private Ctrler_DanhSachHoaDonDangTuyen Ctrler_DanhSachHoaDonDangTuyen
	{
		get => _ctrler_DanhSachHoaDonDangTuyen ?? throw new ControllerNotFoundException();
		set => _ctrler_DanhSachHoaDonDangTuyen = value;
	}

	public GUI_DanhSachHoaDonDangTuyen()
	{
		InitializeComponent();
	}

	public void HienThi(Ctrler_DanhSachHoaDonDangTuyen ctrler_DanhSachHoaDonDangTuyen)
	{
		_ctrler_DanhSachHoaDonDangTuyen = ctrler_DanhSachHoaDonDangTuyen;
		var dsHD = new List<DTO_HoaDon>();
		Ctrler_DanhSachHoaDonDangTuyen.Load(ref dsHD);
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
			var hoaDon = Ctrler_DanhSachHoaDonDangTuyen.TruyVanHoaDon(maTTDT);
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
				var ctrler = Ctrler_DanhSachHoaDonDangTuyen.HienThi_DongPhiChoHoaDon(hoaDon);
				var gui = new GUI_DongPhiChoHoaDon();
				gui.HienThi(ctrler!);
				GUI_NhanVienThanhToan.Instance.SwitchContent(gui);
			}
		}
	}

	private void btnTraCuu_Click(object sender, EventArgs e)
	{
		var maTTDT = txtMaTTDT.Text;
		var hoaDon = Ctrler_DanhSachHoaDonDangTuyen.TruyVanHoaDon(maTTDT);
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
			var ctrler = Ctrler_DanhSachHoaDonDangTuyen.HienThi_DongPhiChoHoaDon(hoaDon);
			var gui = new GUI_DongPhiChoHoaDon();
			GUI_NhanVienThanhToan.Instance.SwitchContent(gui);
			gui.HienThi(ctrler);
		}
	}
}