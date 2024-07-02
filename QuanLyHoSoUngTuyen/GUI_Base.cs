using Ctrler;
using GUI.Styles;
using GUI.UC;

namespace GUI;

public partial class GUI_Base : Form
{
	// todo: Thay bang tai khoan duoc dang nhap
	private string _maDN = "1";
	public string MaDN { get => _maDN; set => _maDN = value; }

	public GUI_Base()
	{
		Style.ApplyStylingEventOnChildControlAdded(this,
			ButtonStyle.Apply);
		_instance = this;
		InitializeComponent();
	}

	private void btnTaoYeuCau_Click(object sender, EventArgs e)
	{
		var gui = new GUI_DienThongTinDangTuyen();
		gui.HienThi(new Ctrler_DienThongTinDangTuyen());
		SwitchContent(gui);
	}

	private void btnDanhSachThongTinDangTuyen_Click(object sender, EventArgs e)
	{
		var gui = new GUI_DanhSachThongTinDangTuyen();
		gui.HienThi(new Ctrler_DanhSachThongTinDangTuyen(_maDN));
		SwitchContent(gui);
	}

	public void SwitchContent(UserControl content)
	{
		_contentPanel.Controls.Clear();
		_contentPanel.Controls.Add(content);
		content.Dock = DockStyle.Fill;
	}

	private static GUI_Base? _instance = null;
	public static GUI_Base Instance => _instance ??= new GUI_Base();
}
