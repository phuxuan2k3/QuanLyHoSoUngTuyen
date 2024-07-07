using Ctrler.NhanVienTiepNhan;
using GUI.Styles;
using GUI.UserControls;
using GUI;
using GUI.GUI_NhanVienTiepNhan;

namespace GUI
{
    public partial class GUINhanVienTiepNhan : Form
    {
        public GUINhanVienTiepNhan()
        {
            Style.ApplyStylingEventOnChildControlAdded(this,
           ButtonStyle.Apply);
            _instance = this;
            // InitializeComponent();
            InitializeComponent();
        }


        private static GUINhanVienTiepNhan? _instance = null;
        public static GUINhanVienTiepNhan Instance => _instance ??= new GUINhanVienTiepNhan();

        public void SwitchContent(UserControl content)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(content);
            content.Dock = DockStyle.Fill;
        }

        private void btnXetDuyetTTDT_Click(object sender, EventArgs e)
        {
            GUI_DanhSachTTDTCanXetDuyet content = new();
            content.HienThi(new Ctrler_DanhSachTTDTCanXetDuyet());
            SwitchContent(content);
        }

        private void btnXacThucDN_Click(object sender, EventArgs e)
        {
            GUI_XacThucThongTinDoanhNghiep content = new();
            content.HienThi();
            SwitchContent(content);
        }

        private void btn_ThemHS_Click(object sender, EventArgs e)
        {
            UC_ThemHSCTBC uc = new UC_ThemHSCTBC();
            SwitchContent(uc);
        }
    }
}
