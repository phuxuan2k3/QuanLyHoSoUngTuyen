using BUS;
using Ctrler.DoanhNghiep;
using Ctrler.NhanVienTiepNhan;
using DTO;
using GUI.Styles;
using GUI.UserControls;
using System.Drawing.Text;

namespace GUI;

public partial class GUI_DoanhNghiep : Form
{
	private DTO_DoanhNghiep doanhNghiep = new();
	public DTO_DoanhNghiep DoanhNghiep
	{
		get => doanhNghiep;
		set
		{
			doanhNghiep = value;
			if (doanhNghiep.TrangThai == TrangThaiDoanhNghiep.ChuaXacThuc || doanhNghiep.TrangThai == TrangThaiDoanhNghiep.KhongHopLe)
			{
				btnCapNhatTTDN.Enabled = true;
				btnDanhSachThongTinDangTuyen.Enabled = false;
				btnDuyetHoSo.Enabled = false;
				btnTaoYeuCau.Enabled = false;
			}
			else
			{
				btnCapNhatTTDN.Enabled = false;
				btnDanhSachThongTinDangTuyen.Enabled = true;
				btnDuyetHoSo.Enabled = true;
				btnTaoYeuCau.Enabled = true;
			}
		}
	}
	public string MaDN => DoanhNghiep.MaDN;

	public GUI_DoanhNghiep()
	{
		Style.ApplyStylingEventOnChildControlAdded(this, ButtonStyle.Apply);
		InitializeComponent();
		_instance = this;
	}

	public void HienThi()
	{
		if (DoanhNghiep.TrangThai == TrangThaiDoanhNghiep.ChuaXacThuc || DoanhNghiep.TrangThai == TrangThaiDoanhNghiep.KhongHopLe)
		{
			GUI_CapNhatThongTinDoanhNghiep content = new();
			content.HienThi(MaDN);
			SwitchContent(content);
		}
		else
		{
			var gui = new GUI_DanhSachThongTinDangTuyen();
			gui.HienThi(new Ctrler_DanhSachThongTinDangTuyen(MaDN));
			SwitchContent(gui);
		}
	}

	//public void GoHome()
	//{
	//	SwitchContent(new LandingPage(DoanhNghiep));
	//}

	private void btnTaoYeuCau_Click(object sender, EventArgs e)
	{
		var gui = new GUI_DienThongTinDangTuyen();
		gui.HienThi(new Ctrler_DienThongTinDangTuyen());
		SwitchContent(gui);
	}

	private void btnDanhSachThongTinDangTuyen_Click(object sender, EventArgs e)
	{
		var gui = new GUI_DanhSachThongTinDangTuyen();
		gui.HienThi(new Ctrler_DanhSachThongTinDangTuyen(MaDN));
		SwitchContent(gui);
	}

	public void SwitchContent(UserControl content)
	{
		_contentPanel.Controls.Clear();
		_contentPanel.Controls.Add(content);
		content.Dock = DockStyle.Fill;
	}

	private void btnXacThucDN_Click(object sender, EventArgs e)
	{
		GUI_XacThucThongTinDoanhNghiep content = new();
		content.HienThi();
		SwitchContent(content);
	}

	private void btnXetDuyetTTDT_Click(object sender, EventArgs e)
	{
		GUI_DanhSachTTDTCanXetDuyet content = new();
		content.HienThi(new Ctrler_DanhSachTTDTCanXetDuyet());
		SwitchContent(content);
	}

	private void btnCapNhatTTDN_Click(object sender, EventArgs e)
	{
		GUI_CapNhatThongTinDoanhNghiep content = new();
		content.HienThi(MaDN);
		SwitchContent(content);
	}

	private void btnDuyetHoSo_Click(object sender, EventArgs e)
	{
		GUI_DanhSachThongTinDangTuyen_DN content = new();
		content.HienThi(new Ctrler_DanhSachThongTinDangTuyen(""));
		SwitchContent(content);
	}

	private static GUI_DoanhNghiep? _instance = null;
	public static GUI_DoanhNghiep Instance => _instance ??= new GUI_DoanhNghiep();
}
