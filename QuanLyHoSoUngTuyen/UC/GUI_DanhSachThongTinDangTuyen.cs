using Ctrler;
using DTO;

namespace GUI.UC;

public partial class GUI_DanhSachThongTinDangTuyen : UserControl
{

	private readonly Ctrler_DanhSachThongTinDangTuyen _ctrler_DanhSachThongTinDangTuyen;

	public GUI_DanhSachThongTinDangTuyen()
	{

		InitializeComponent();
		_ctrler_DanhSachThongTinDangTuyen = new Ctrler_DanhSachThongTinDangTuyen();
	}

	public void HienThi()
	{
		var dsTTDT = new List<DTO_ThongTinDangTuyen>();
		_ctrler_DanhSachThongTinDangTuyen.Load("1", ref dsTTDT);
		dsThongTinDangTuyen.DataSource = dsTTDT;
	}
}
