using Ctrler.DoanhNghiep;
using DTO;
using GUI.GUIException;
using Utilis;

namespace GUI.UserControls
{
	public partial class GUI_XacNhanThanhToan : UserControl
	{
		private Ctrler_XacNhanThanhToan? ctrler;

		private Ctrler_XacNhanThanhToan Ctrler
		{
			get => ctrler ?? throw new ControllerNotFoundException();
			set => ctrler = value;
		}

		public GUI_XacNhanThanhToan()
		{
			InitializeComponent();
		}

		public void HienThi(Ctrler_XacNhanThanhToan ctrler_XacNhanThanhToan)
		{
			ctrler = ctrler_XacNhanThanhToan;
			DTO_ThongTinDangTuyen thongTinDangTuyen = new();
			DTO_HinhThucDangTuyen hinhThucDangTuyen = new();
			float tongTien = -1;
			bool coTheThanhToanNhieuDot = true;
			_thanhToanToanBo.Checked = true;
			ctrler_XacNhanThanhToan.Load(ref thongTinDangTuyen, ref hinhThucDangTuyen, ref tongTien, ref coTheThanhToanNhieuDot);
			_soNgayDangTuyen.Text = thongTinDangTuyen.SoNgayDangTuyen.ToString();
			_hinhThucDangTuyen.Text = hinhThucDangTuyen.TenHinhThuc;
			_tongChiPhi.Text = tongTien.ToVNDString();
			if (!coTheThanhToanNhieuDot)
			{
				_thanhToanThanhNhieuDot.Hide();
			}
		}

		private void btnXacNhan_Click(object sender, EventArgs e)
		{
			if (_thanhToanThanhNhieuDot.Checked || _thanhToanToanBo.Checked)
			{
				if (_thanhToanThanhNhieuDot.Checked)
				{
					Ctrler.XacNhanThanhToan(CachThucThanhToan.NhieuDot);
				}
				else if (_thanhToanToanBo.Checked)
				{
					Ctrler.XacNhanThanhToan(CachThucThanhToan.ToanBo);
				}
				MessageBox.Show($"Yêu cầu đăng tuyển đã tạo thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
				var gui = new GUI_DanhSachThongTinDangTuyen();
				gui.HienThi(new Ctrler_DanhSachThongTinDangTuyen(GUI_DoanhNghiep.Instance.MaDN));
				GUI_DoanhNghiep.Instance.SwitchContent(gui);
			}
			else
			{
				MessageBox.Show($"Chưa chọn cách thức thanh toán.", "Xác nhận thanh toán", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnHuy_Click(object sender, EventArgs e)
		{
			var gui = new GUI_DienThongTinDangTuyen();
			var ctrler = new Ctrler_DienThongTinDangTuyen(Ctrler.ThongTinDangTuyen);
			gui.HienThi(ctrler);
			GUI_DoanhNghiep.Instance.SwitchContent(gui);
		}
	}
}
