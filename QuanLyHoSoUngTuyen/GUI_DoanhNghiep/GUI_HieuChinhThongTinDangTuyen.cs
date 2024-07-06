using Ctrler.DoanhNghiep;
using DTO;
using GUI.GUIException;

namespace GUI.UserControls;

public partial class GUI_HieuChinhThongTinDangTuyen : UserControl
{
	private Ctrler_HieuChinhThongTinDangTuyen? _ctrler_HieuChinhThongTinDangTuyen;

	public Ctrler_HieuChinhThongTinDangTuyen Ctrler_HieuChinhThongTinDangTuyen
	{
		get { return _ctrler_HieuChinhThongTinDangTuyen ?? throw new ControllerNotFoundException(); }
		set { _ctrler_HieuChinhThongTinDangTuyen = value; }
	}

	public GUI_HieuChinhThongTinDangTuyen()
	{
		InitializeComponent();
	}

	public void HienThi(Ctrler_HieuChinhThongTinDangTuyen ctrler_HieuChinhThongTinDangTuyen)
	{
		_ctrler_HieuChinhThongTinDangTuyen = ctrler_HieuChinhThongTinDangTuyen;
		var ttdt = new DTO_ThongTinDangTuyen();
		var htdt = new DTO_HinhThucDangTuyen();
		_soNgayDangTuyen.Text = ttdt.SoNgayDangTuyen.ToString();
		_hinhThucDangTuyen.Text = htdt.TenHinhThuc;
		_thoiGianDangTuyen.Text = ttdt.ThoiGianDangTuyen.ToString();
		_tenViTri.Text = ttdt.TenViTri;
		_soLuong.Value = ttdt.SoLuong;
		_yeuCau.Text = ttdt.YeuCau;
	}

	private void btnXacNhan_Click(object sender, EventArgs e)
	{
		var errorTitle = "Thông tin không hợp lệ";
		if (string.IsNullOrEmpty(_tenViTri.Text) == true)
		{
			MessageBox.Show($"Tên vị trí không được để trống.", errorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
		else if (_soLuong.Value < 1)
		{
			MessageBox.Show("Số lượng ứng tuyển phải lớn hơn hoặc bằng 1.", errorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		else if (string.IsNullOrEmpty(_yeuCau.Text) == true)
		{
			MessageBox.Show($"Yêu cầu cho vị trí không được để trống.", errorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
		else
		{
			DTO_ThongTinDangTuyen thongTinDangTuyen = new DTO_ThongTinDangTuyen(
				tenViTri: _tenViTri.Text,
				soLuong: (int)_soLuong.Value,
				yeuCau: _yeuCau.Text
				);
			var gui = new GUI_ChiTietThongTinDangTuyen();
			var ctrler = Ctrler_HieuChinhThongTinDangTuyen.HienThi_ChiTietThongTinDangTuyen();
			gui.HienThi(ctrler);
			GUI_DoanhNghiep.Instance.SwitchContent(gui);
		}
	}

	private void btnHuy_Click(object sender, EventArgs e)
	{
		var gui = new GUI_ChiTietThongTinDangTuyen();
		var ctrler = Ctrler_HieuChinhThongTinDangTuyen.HienThi_ChiTietThongTinDangTuyen();
		gui.HienThi(ctrler);
		GUI_DoanhNghiep.Instance.SwitchContent(gui);
	}
}
