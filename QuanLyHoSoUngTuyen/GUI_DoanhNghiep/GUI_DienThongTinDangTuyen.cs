using Ctrler.DoanhNghiep;
using DTO;
using GUI.GUIException;

namespace GUI.UserControls
{
    public partial class GUI_DienThongTinDangTuyen : UserControl
	{
		private Ctrler_DienThongTinDangTuyen? _ctrler_DienThongTinDangTuyen;

		private Ctrler_DienThongTinDangTuyen Ctrler_DienThongTinDangTuyen
		{
			get => _ctrler_DienThongTinDangTuyen ?? throw new ControllerNotFoundException();
			set => _ctrler_DienThongTinDangTuyen = value;
		}

		public GUI_DienThongTinDangTuyen()
		{
			InitializeComponent();
		}

		public void HienThi(Ctrler_DienThongTinDangTuyen ctrler_DienThongTinDangTuyen)
		{
			_ctrler_DienThongTinDangTuyen = ctrler_DienThongTinDangTuyen;
			var thongTinDangTuyen = new DTO_ThongTinDangTuyen();
			var hinhThucDangTuyen = new List<DTO_HinhThucDangTuyen>();
			Ctrler_DienThongTinDangTuyen.Load(ref thongTinDangTuyen, ref hinhThucDangTuyen);
			_soNgayDangTuyen.Value = thongTinDangTuyen.SoNgayDangTuyen;
			_hinhThucDangTuyen.DataSource = hinhThucDangTuyen;
			_hinhThucDangTuyen.ValueMember = "MaHTDT";
			_hinhThucDangTuyen.DisplayMember = "TenHinhThuc";
			_hinhThucDangTuyen.SelectedIndex = hinhThucDangTuyen.FindIndex(x => x.MaHTDT == thongTinDangTuyen.MaHTDT);
			_hinhThucDangTuyen.DropDownStyle = ComboBoxStyle.DropDownList;
			_hinhThucDangTuyen.SelectedIndex = 0;
			_thoiGianDangTuyen.Value = thongTinDangTuyen.ThoiGianDangTuyen;
			_tenViTri.Text = thongTinDangTuyen.TenViTri;
			_soLuong.Value = thongTinDangTuyen.SoLuong;
			_yeuCau.Text = thongTinDangTuyen.YeuCau;
		}

		private void btnXacNhan_Click(object sender, EventArgs e)
		{
			var errorTitle = "Thông tin không hợp lệ";
			if (_soNgayDangTuyen.Value < 1)
			{
				MessageBox.Show("Số ngày đăng tuyển phải lớn hơn hoặc bằng 1.", errorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else if (_soLuong.Value < 1)
			{
				MessageBox.Show("Số lượng ứng tuyển phải lớn hơn hoặc bằng 1.", errorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else if (_thoiGianDangTuyen.Value < DateTime.Now.AddDays(1).Date)
			{
				MessageBox.Show($"Thời gian đăng tuyển ít nhất là từ ngày mai. ({DateTime.Now.AddDays(1).Date:dd/MM/yyyy})", errorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else if (_hinhThucDangTuyen.SelectedValue == null)
			{
				MessageBox.Show($"Chưa chọn hình thức đăng tuyển.", errorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else if (string.IsNullOrEmpty(_tenViTri.Text) == true)
			{
				MessageBox.Show($"Tên vị trí không được để trống.", errorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else if (string.IsNullOrEmpty(_yeuCau.Text) == true)
			{
				MessageBox.Show($"Yêu cầu cho vị trí không được để trống.", errorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				DTO_ThongTinDangTuyen thongTinDangTuyen = new DTO_ThongTinDangTuyen(
					"",
					GUI_DoanhNghiep.Instance.MaDN,
					(int)_soNgayDangTuyen.Value,
					_hinhThucDangTuyen.SelectedValue.ToString() ?? throw new Exception("Invalid HinhThucDangTuyen"),
					_thoiGianDangTuyen.Value,
					_tenViTri.Text,
					(int)_soLuong.Value,
					_yeuCau.Text
					);
				var gui = new GUI_XacNhanThanhToan();
				var ctrler = Ctrler_DienThongTinDangTuyen.HienThi_XacNhanThanhToan(thongTinDangTuyen);
				gui.HienThi(ctrler);
				GUI_DoanhNghiep.Instance.SwitchContent(gui);
			}
		}

		private void btnHuy_Click(object sender, EventArgs e)
		{
			var gui = new GUI_DanhSachThongTinDangTuyen();
			var ctrler = new Ctrler_DanhSachThongTinDangTuyen(GUI_DoanhNghiep.Instance.MaDN);
			gui.HienThi(ctrler);
			GUI_DoanhNghiep.Instance.SwitchContent(gui);
		}
	}
}
