using GUI.UC;

namespace GUI;

public partial class GUI_Base : Form
{
	public GUI_Base()
	{
		InitializeComponent();
	}

	private void btnTaoYeuCau_Click(object sender, EventArgs e)
	{
		SwitchContent(new GUI_TaoYeuCauDangTuyen());
	}

	private void btnDanhSachThongTinDangTuyen_Click(object sender, EventArgs e)
	{
		SwitchContent(new GUI_DanhSachThongTinDangTuyen());
	}

	private void SwitchContent(UserControl content)
	{
		_contentPanel.Controls.Clear();
		_contentPanel.Controls.Add(content);
		content.Dock = DockStyle.Fill;
	}
}
