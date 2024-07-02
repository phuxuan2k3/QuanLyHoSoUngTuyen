using Ctrler;
using GUI.GUIException;

namespace GUI.UC
{
	public partial class GUI_XacNhanThanhToan : UserControl
	{
		private Ctrler_XacNhanThanhToan? _ctrler_XacNhanThanhToan;

		private Ctrler_XacNhanThanhToan Ctrler_XacNhanThanhToan
		{
			get => _ctrler_XacNhanThanhToan ?? throw new ControllerNotFoundException();
			set => _ctrler_XacNhanThanhToan = value;
		}

		public GUI_XacNhanThanhToan()
		{
			InitializeComponent();
		}

		public void HienThi(Ctrler_XacNhanThanhToan ctrler_XacNhanThanhToan)
		{
			_ctrler_XacNhanThanhToan = ctrler_XacNhanThanhToan;
		}
	}
}
