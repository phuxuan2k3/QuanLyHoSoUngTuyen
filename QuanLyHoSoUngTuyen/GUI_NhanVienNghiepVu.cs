using Ctrler.DoanhNghiep;
using Ctrler.NhanVienNghiepVu;
using GUI.UserControls;
using GUI.Styles;

namespace GUI
{
	public partial class GUI_NhanVienNghiepVu : Form
    {
        public GUI_NhanVienNghiepVu()
        {
            Style.ApplyStylingEventOnChildControlAdded(this,
            ButtonStyle.Apply);
            _instance = this;
            InitializeComponent();
        }

        private void btnDangTuyenTTDT_Click(object sender, EventArgs e)
        {
            GUI_DanhSachTTDTCanDangTuyen content = new();
            content.HienThi(new Ctrler_DanhSachTTDTCanDangTuyen());
            SwitchContent(content);
        }
        private static GUI_NhanVienNghiepVu? _instance = null;
        public static GUI_NhanVienNghiepVu Instance => _instance ??= new GUI_NhanVienNghiepVu();

        public void SwitchContent(UserControl content)
        {
            _container.Controls.Clear();
            _container.Controls.Add(content);
            content.Dock = DockStyle.Fill;
        }

        private void btnDuyetPhieuDangKy_Click(object sender, EventArgs e)
        {
            GUI_DuyetPhieuDangKy_DanhSachThongTinDangTuyen content = new();
            content.HienThi();
            SwitchContent(content);
        }

        private void btnDuyet_DoanhNghiep_Click(object sender, EventArgs e)
        {
            GUI_DanhSachThongTinDangTuyen_DN content = new();
            content.HienThi(new Ctrler_DanhSachThongTinDangTuyen(""));
            SwitchContent(content);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GUI_XemThongTinDoanhNghiep gui_XemThongTinDoanhNghiep = new();
            SwitchContent(gui_XemThongTinDoanhNghiep);
        }
    }
}
