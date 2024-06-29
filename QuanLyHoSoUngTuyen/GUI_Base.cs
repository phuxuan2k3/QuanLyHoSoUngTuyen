using Ctrler;
using GUI.UC;

namespace GUI;

public partial class GUI_Base : Form
{
	// Thay bang tai khoan duoc dang nhap
	private string maDN = "1";

	public GUI_Base()
	{
		InitializeComponent();
		_instance = this;
	}

	private void btnTaoYeuCau_Click(object sender, EventArgs e)
	{
		SwitchContent(new GUI_DienThongTinDangTuyen());
	}

	private void btnDanhSachThongTinDangTuyen_Click(object sender, EventArgs e)
	{
		GUI_DanhSachThongTinDangTuyen content = new()
		{
			Ctrler_DanhSachThongTinDangTuyen = new Ctrler_DanhSachThongTinDangTuyen(maDN)
		};
		SwitchContent(content);
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
