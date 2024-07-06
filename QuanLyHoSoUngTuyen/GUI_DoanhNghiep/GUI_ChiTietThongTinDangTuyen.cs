using Ctrler;
using DTO;
using GUI.GUIException;

namespace GUI.UserControls;

public partial class GUI_ChiTietThongTinDangTuyen : UserControl
{
	private Ctrler_ChiTietThongTinDangTuyen? _ctrler_ChiTietThongTinDangTuyen;

	public GUI_ChiTietThongTinDangTuyen()
	{
		InitializeComponent();
	}

	public Ctrler_ChiTietThongTinDangTuyen Ctrler_ChiTietThongTinDangTuyen
	{
		get => _ctrler_ChiTietThongTinDangTuyen ?? throw new ControllerNotFoundException();
		private set => _ctrler_ChiTietThongTinDangTuyen = value;
	}

	public void HienThi(Ctrler_ChiTietThongTinDangTuyen ctrler_ChiTietThongTinDangTuyen)
	{
		_ctrler_ChiTietThongTinDangTuyen = ctrler_ChiTietThongTinDangTuyen;
		DTO_ThongTinDangTuyen ttdt = new();
		DTO_HoaDon hoaDon = new();
		DTO_HinhThucDangTuyen hinhThucDangTuyen = new();
		Ctrler_ChiTietThongTinDangTuyen.Load(ref ttdt, ref hoaDon, ref hinhThucDangTuyen);
		_maTTDT.Text = ttdt.MaTTDT;
		_soNgayDangTuyen.Text = ttdt.SoNgayDangTuyen.ToString();
		_thoiGianDangTuyen.Text = ttdt.ThoiGianDangTuyen.ToString("dd/MM/yyyy");
		_hinhThuc.Text = hinhThucDangTuyen.TenHinhThuc.ToString();
		_tenViTri.Text = ttdt.TenViTri;
		_soLuong.Text = ttdt.SoLuong.ToString();
		_yeuCau.Text = ttdt.YeuCau;
		_trangThai.Text = ttdt.TrangThai.ToString();
		_trangThaiThanhToan.Text = hoaDon.TrangThaiThanhToan.ToString();
		_tinhTrang.Text = ttdt.TinhTrang.ToString();
	}

	private void btnXemHoaDon_Click(object sender, EventArgs e)
	{
		var ctrler = Ctrler_ChiTietThongTinDangTuyen.HienThi_HoaDon();
		var gui = new GUI_HoaDonThongTinDangTuyen();
		gui.HienThi(ctrler);
		GUI_DoanhNghiep.Instance.SwitchContent(gui);
	}

	private void btnHieuChinh_Click(object sender, EventArgs e)
	{
		var ctrler = Ctrler_ChiTietThongTinDangTuyen.HienThi_HieuChinh();
		var gui = new GUI_HieuChinhThongTinDangTuyen();
		gui.HienThi(ctrler);
		GUI_DoanhNghiep.Instance.SwitchContent(gui);
	}

	private void btnQuayLai_Click(object sender, EventArgs e)
	{
		var gui = new GUI_DanhSachThongTinDangTuyen();
		var maDN = GUI_DoanhNghiep.Instance.MaDN;
		gui.HienThi(new Ctrler_DanhSachThongTinDangTuyen(maDN));
		GUI_DoanhNghiep.Instance.SwitchContent(gui);
	}
}
