using Ctrler;
using GUI.GUIException;

namespace GUI.UC;

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
	}
}
