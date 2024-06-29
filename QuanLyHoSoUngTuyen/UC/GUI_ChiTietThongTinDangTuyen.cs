using Ctrler;

namespace GUI.UC;

public partial class GUI_ChiTietThongTinDangTuyen : UserControl
{
	private Ctrler_ChiTietThongTinDangTuyen? _ctrler_ChiTietThongTinDangTuyen;

	public GUI_ChiTietThongTinDangTuyen()
	{
		InitializeComponent();
	}

	public Ctrler_ChiTietThongTinDangTuyen Ctrler_ChiTietThongTinDangTuyen
	{
		get => _ctrler_ChiTietThongTinDangTuyen ?? throw new Exception("Can't initialize empty Controller");
		set => _ctrler_ChiTietThongTinDangTuyen = value;
	}

	public void HienThi()
	{

	}
}
