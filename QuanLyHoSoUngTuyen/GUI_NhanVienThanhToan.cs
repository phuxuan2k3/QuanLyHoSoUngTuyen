using Ctrler.NhanVienThanhToan;
using GUI.Styles;
using GUI.UserControls;

namespace GUI
{
	public partial class GUI_NhanVienThanhToan : Form
	{
		public GUI_NhanVienThanhToan()
		{
			_instance = this;
			Style.ApplyStylingEventOnChildControlAdded(this, ButtonStyle.Apply);
			InitializeComponent();
			var gui = new GUI_DanhSachHoaDonDangTuyen();
			gui.HienThi(new Ctrler_DanhSachHoaDonDangTuyen());
			SwitchContent(gui);
		}

		private static GUI_NhanVienThanhToan? _instance;
		public static GUI_NhanVienThanhToan Instance => _instance ?? new();

		public void SwitchContent(UserControl content)
		{
			panel1.Controls.Clear();
			panel1.Controls.Add(content);
			content.Dock = DockStyle.Fill;
		}
	}
}
