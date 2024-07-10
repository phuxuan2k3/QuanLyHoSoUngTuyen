using Ctrler.DoanhNghiep;
using DTO;
using GUI.GUIException;

namespace GUI.UserControls;

public partial class GUI_ChiTietThongTinDangTuyen : UserControl
{
	private Ctrler_ChiTietThongTinDangTuyen? ctrler;

	public GUI_ChiTietThongTinDangTuyen()
	{
		InitializeComponent();
	}

	public Ctrler_ChiTietThongTinDangTuyen Ctrler
	{
		get => ctrler ?? throw new ControllerNotFoundException();
		private set => ctrler = value;
	}

	public void HienThi(Ctrler_ChiTietThongTinDangTuyen ctrler_ChiTietThongTinDangTuyen)
	{
		ctrler = ctrler_ChiTietThongTinDangTuyen;
		DTO_ThongTinDangTuyen thongTinDangTuyen = new();
		DTO_HoaDon hoaDon = new();
		DTO_HinhThucDangTuyen hinhThucDangTuyen = new();
		Ctrler.Load(ref thongTinDangTuyen, ref hoaDon, ref hinhThucDangTuyen);
		_maTTDT.Text = thongTinDangTuyen.MaTTDT;
		_soNgayDangTuyen.Text = thongTinDangTuyen.SoNgayDangTuyen.ToString();
		_thoiGianDangTuyen.Text = thongTinDangTuyen.ThoiGianDangTuyen.ToString("dd/MM/yyyy");
		_hinhThuc.Text = hinhThucDangTuyen.TenHinhThuc.ToString();
		_tenViTri.Text = thongTinDangTuyen.TenViTri;
		_soLuong.Text = thongTinDangTuyen.SoLuong.ToString();
		_yeuCau.Text = thongTinDangTuyen.YeuCau;
		_trangThai.Text = thongTinDangTuyen.TrangThai.ToDisplayString();
		_trangThaiThanhToan.Text = hoaDon.TrangThaiThanhToan.ToDisplayString();
		_tinhTrang.Text = thongTinDangTuyen.TinhTrang.ToDisplayString();
	}

	private void btnXemHoaDon_Click(object sender, EventArgs e)
	{
		DTO_ThongTinDangTuyen thongTinDangTuyen = new();
		DTO_HoaDon hoaDon = new();
		DTO_HinhThucDangTuyen hinhThucDangTuyen = new();
		Ctrler.Load(ref thongTinDangTuyen, ref hoaDon, ref hinhThucDangTuyen);
		var gui = new GUI_HoaDonThongTinDangTuyen();
		var ctrler = new Ctrler_HoaDonThongTinDangTuyen(thongTinDangTuyen, hoaDon, hinhThucDangTuyen);
		gui.HienThi(ctrler);
		GUI_DoanhNghiep.Instance.SwitchContent(gui);
	}

	private void btnHieuChinh_Click(object sender, EventArgs e)
	{
		DTO_ThongTinDangTuyen thongTinDangTuyen = new();
		DTO_HoaDon hoaDon = new();
		DTO_HinhThucDangTuyen hinhThucDangTuyen = new();
		Ctrler.Load(ref thongTinDangTuyen, ref hoaDon, ref hinhThucDangTuyen);
		var gui = new GUI_HieuChinhThongTinDangTuyen();
		var ctrler = new Ctrler_HieuChinhThongTinDangTuyen(thongTinDangTuyen, hoaDon, hinhThucDangTuyen);
		GUI_DoanhNghiep.Instance.SwitchContent(gui);
		gui.HienThi(ctrler);
	}

	private void btnQuayLai_Click(object sender, EventArgs e)
	{
		var gui = new GUI_DanhSachThongTinDangTuyen();
		var maDN = GUI_DoanhNghiep.Instance.MaDN;
		gui.HienThi(new Ctrler_DanhSachThongTinDangTuyen(maDN));
		GUI_DoanhNghiep.Instance.SwitchContent(gui);
	}
}
