using Ctrler.NhanVienTiepNhan;
using GUI.Styles;
using GUI.UC;

namespace GUI
{
	public partial class GUI_NhanVienTiepNhan : Form
    {
        public GUI_NhanVienTiepNhan()
        {
            Style.ApplyStylingEventOnChildControlAdded(this,
           ButtonStyle.Apply);
           _instance = this;
           // InitializeComponent();
            InitializeComponent();
        }

       
        private static GUI_NhanVienTiepNhan? _instance = null;
        public static GUI_NhanVienTiepNhan Instance => _instance ??= new GUI_NhanVienTiepNhan();

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
    }
}
