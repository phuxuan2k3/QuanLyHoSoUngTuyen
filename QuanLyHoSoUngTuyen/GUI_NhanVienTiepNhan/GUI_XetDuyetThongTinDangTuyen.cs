using Ctrler.NhanVienTiepNhan;
using DTO;
using GUI.GUIException;

namespace GUI.UserControls
{
    public partial class GUI_XetDuyetThongTinDangTuyen : UserControl
    {
        public GUI_XetDuyetThongTinDangTuyen()
        {
            InitializeComponent();
        }

        private Ctrler_XetDuyetThongTinDangTuyen? _ctrler_ChiTietThongTinDangTuyen;
        public Ctrler_XetDuyetThongTinDangTuyen Ctrler_ChiTietThongTinDangTuyen
        {
            get => _ctrler_ChiTietThongTinDangTuyen ?? throw new ControllerNotFoundException();
            private set => _ctrler_ChiTietThongTinDangTuyen = value;
        }

        public void HienThi(Ctrler_XetDuyetThongTinDangTuyen ctrler_XetDuyetThongTinDangTuyen)
        {
            _ctrler_ChiTietThongTinDangTuyen = ctrler_XetDuyetThongTinDangTuyen;
            DTO_ThongTinDangTuyen ttdt = new();
            DTO_HinhThucDangTuyen hinhThucDangTuyen = new();
            DTO_DoanhNghiep doanhnghiep = new();
            Ctrler_ChiTietThongTinDangTuyen.Load(ref ttdt, ref hinhThucDangTuyen, ref doanhnghiep);
            _TenDN.Text = doanhnghiep.TenDN.ToString();
            _maTTDT.Text = ttdt.MaTTDT;
            _soNgayDangTuyen.Text = ttdt.SoNgayDangTuyen.ToString();
            _thoiGianDangTuyen.Text = ttdt.ThoiGianDangTuyen.ToString("dd/MM/yyyy") ?? "";
            _hinhThuc.Text = hinhThucDangTuyen.TenHinhThuc.ToString();
            _tenViTri.Text = ttdt.TenViTri;
            _soLuong.Text = ttdt.SoLuong.ToString();
            _yeuCau.Text = ttdt.YeuCau;
            _trangThai.Text = ttdt.TrangThai.ToString();
            _tinhTrang.Text = ttdt.TinhTrang.ToString();
        }

        private void btnHopLe_Click(object sender, EventArgs e)
        {
            Ctrler_XetDuyetThongTinDangTuyen.CapNhatTrangThai(_maTTDT.Text, TrangThaiThongTinDangTuyen.HopLe);
            GUI_DanhSachTTDTCanXetDuyet content = new();
            GUI_NhanVienTiepNhan.Instance.SwitchContent(content);
            content.HienThi(new Ctrler_DanhSachTTDTCanXetDuyet());
        }

        private void btnKhongHopLe_Click(object sender, EventArgs e)
        {
            Ctrler_XetDuyetThongTinDangTuyen.CapNhatTrangThai(_maTTDT.Text, TrangThaiThongTinDangTuyen.KhongHopLe);
            GUI_DanhSachTTDTCanXetDuyet content = new();
            GUI_NhanVienTiepNhan.Instance.SwitchContent(content);
            content.HienThi(new Ctrler_DanhSachTTDTCanXetDuyet());
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            GUI_DanhSachTTDTCanXetDuyet content = new();
            GUI_NhanVienTiepNhan.Instance.SwitchContent(content);
            content.HienThi(new Ctrler_DanhSachTTDTCanXetDuyet());
        }
    }
    //private void btnTuChoi_Click(object sender, EventArgs e)
    //{
    //    Ctrler_XetDuyetThongTinDangTuyen.CapNhatTrangThaiXetDuyet(_maTTDT.Text, "Không hợp lệ");
    //}

    //private void btnQuayLai_Click(object sender, EventArgs e)
    //{
    //    GUI_DanhSachTTDTCanXetDuyet content = new();
    //    GUINhanVienTiepNhan.Instance.SwitchContent(content);
    //    content.HienThi(new Ctrler_DanhSachTTDTCanXetDuyet());
    //}
}