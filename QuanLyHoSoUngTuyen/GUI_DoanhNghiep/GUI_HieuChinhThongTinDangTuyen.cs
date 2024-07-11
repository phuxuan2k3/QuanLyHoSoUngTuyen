using Ctrler.DoanhNghiep;
using DTO;
using GUI.GUIException;
using Utilis;

namespace GUI.UserControls;

public partial class GUI_HieuChinhThongTinDangTuyen : UserControl
{
	private Ctrler_HieuChinhThongTinDangTuyen? ctrler;

	public Ctrler_HieuChinhThongTinDangTuyen Ctrler
	{
		get { return ctrler ?? throw new ControllerNotFoundException(); }
		set { ctrler = value; }
	}

	public GUI_HieuChinhThongTinDangTuyen()
	{
		InitializeComponent();
	}

	public void HienThi(Ctrler_HieuChinhThongTinDangTuyen ctrler_HieuChinhThongTinDangTuyen)
	{
		ctrler = ctrler_HieuChinhThongTinDangTuyen;
		var ttdt = new DTO_ThongTinDangTuyen();
		var htdt = new DTO_HinhThucDangTuyen();
		Ctrler.Load(ref ttdt, ref htdt);
		_soNgayDangTuyen.Text = ttdt.SoNgayDangTuyen.ToString();
		_hinhThucDangTuyen.Text = htdt.TenHinhThuc;
		_thoiGianDangTuyen.Text = ttdt.ThoiGianDangTuyen.ToDateString();
		txtTenViTri.Text = ttdt.TenViTri;
		nudSoLuong.Value = ttdt.SoLuong;
		txtYeuCau.Text = ttdt.YeuCau;
		if (ttdt.ThoiGianDangTuyen.AddDays(3) < DateTime.Today)
		{
			MessageBox.Show($@"Thông tin đăng tuyển đã quá hạn hiệu chỉnh ({ttdt.ThoiGianDangTuyen.ToDateString()} - {ttdt.ThoiGianDangTuyen.AddDays(3).ToDateString()})", "Quá hạn hiệu chỉnh", MessageBoxButtons.OK, MessageBoxIcon.Error);
			var hd = new DTO_HoaDon();
			Ctrler.LoadChiTiet(ref ttdt, ref hd, ref htdt);
			var gui = new GUI_ChiTietThongTinDangTuyen();
			var ctrler = new Ctrler_ChiTietThongTinDangTuyen(ttdt, hd, htdt);
			gui.HienThi(ctrler);
			GUI_DoanhNghiep.Instance.SwitchContent(gui);
		}
	}

	private void btnXacNhan_Click(object sender, EventArgs e)
	{
		var errorTitle = "Thông tin không hợp lệ";
		if (string.IsNullOrEmpty(txtTenViTri.Text) == true)
		{
			MessageBox.Show($"Tên vị trí không được để trống.", errorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
		else if (nudSoLuong.Value < 1)
		{
			MessageBox.Show("Số lượng ứng tuyển phải lớn hơn hoặc bằng 1.", errorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
		else if (string.IsNullOrEmpty(txtYeuCau.Text) == true)
		{
			MessageBox.Show($"Yêu cầu cho vị trí không được để trống.", errorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
		else
		{
			var res = MessageBox.Show($"Bạn có chắc chắn muốn gửi lại yêu cầu hiệu chỉnh? Thông tin đăng tuyển của bạn sẽ cần được xác thực lại.", "Xác nhận hiệu chỉnh", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (res == DialogResult.Yes)
			{
				DTO_ThongTinDangTuyen thongTinDangTuyen = new DTO_ThongTinDangTuyen(
					tenViTri: txtTenViTri.Text,
					soLuong: (int)nudSoLuong.Value,
					yeuCau: txtYeuCau.Text
					);
				Ctrler.XacNhanHieuChinh(thongTinDangTuyen);
				MessageBox.Show($"Đã gửi yêu cầu hiệu chỉnh đến hệ thống.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
				var ttdt = new DTO_ThongTinDangTuyen();
				var htdt = new DTO_HinhThucDangTuyen();
				var hd = new DTO_HoaDon();
				Ctrler.LoadChiTiet(ref ttdt, ref hd, ref htdt);
				var gui = new GUI_ChiTietThongTinDangTuyen();
				var ctrler = new Ctrler_ChiTietThongTinDangTuyen(ttdt, hd, htdt);
				gui.HienThi(ctrler);
				GUI_DoanhNghiep.Instance.SwitchContent(gui);
			}
		}
	}

	private void btnHuy_Click(object sender, EventArgs e)
	{
		var ttdt = new DTO_ThongTinDangTuyen();
		var htdt = new DTO_HinhThucDangTuyen();
		var hd = new DTO_HoaDon();
		Ctrler.LoadChiTiet(ref ttdt, ref hd, ref htdt);
		var gui = new GUI_ChiTietThongTinDangTuyen();
		var ctrler = new Ctrler_ChiTietThongTinDangTuyen(ttdt, hd, htdt);
		gui.HienThi(ctrler);
		GUI_DoanhNghiep.Instance.SwitchContent(gui);
	}
}
