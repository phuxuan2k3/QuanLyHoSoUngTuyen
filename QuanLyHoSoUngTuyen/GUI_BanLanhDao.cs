using DTO;
using GUI.UserControls;
using Utilis;

namespace GUI
{
    public partial class GUI_BanLanhDao : Form
    {
        private Size oldSize;

        public GUI_BanLanhDao()
        {
            InitializeComponent();
            KhoiTaoManHinh();
        }

        private void GUI_BanLanhDao_Load(object sender, EventArgs e) => oldSize = Size;

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            foreach (Control cnt in this.Controls)
            {
                ResizeAll(cnt, this.Size);
            }

            oldSize = this.Size;
        }

        private void ResizeAll(Control control, Size newSize)
        {
            if (oldSize.Width == 0 || oldSize.Height == 0)
            {
                return;
            }
            int widthChange = newSize.Width - oldSize.Width;
            control.Left += (control.Left * widthChange) / oldSize.Width;
            control.Width += (control.Width * widthChange) / oldSize.Width;

            int heightChange = newSize.Height - oldSize.Height;
            control.Top += (control.Top * heightChange) / oldSize.Height;
            control.Height += (control.Height * heightChange) / oldSize.Height;
        }

        void KhoiTaoManHinh()
        {
            GUI_DoanhNghiepSapHetHan ui_DoanhNghiepSapHetHan = new GUI_DoanhNghiepSapHetHan(new EventHandler(TienHanhGiaHanHopDong!));
            SwitchContent(ui_DoanhNghiepSapHetHan);
        }

        private void btnGiaHanHopDong_Click(object sender, EventArgs e)
        {
            GUI_DoanhNghiepSapHetHan ui_DoanhNghiepSapHetHan = new GUI_DoanhNghiepSapHetHan(new EventHandler(TienHanhGiaHanHopDong!));
            SwitchContent(ui_DoanhNghiepSapHetHan);
        }

        private void btnChienLuocUuDai_Click(object sender, EventArgs e)
        {
            GUI_ChienLuocUuDai ui_ChienLuocUuDai = new GUI_ChienLuocUuDai();
            SwitchContent(ui_ChienLuocUuDai);
        }

        private void TienHanhGiaHanHopDong(object sender, EventArgs e)
        {
            GUI_XacNhanGiaHanHopDongUC ui_XacNhanGiaHanHopDong = new GUI_XacNhanGiaHanHopDongUC(new EventHandler(ThoatKhoiTrangGiaHan!), (e as EventArgs<DTO_DoanhNghiep>)!.Value);
            SwitchContent(ui_XacNhanGiaHanHopDong);
        }

        private void ThoatKhoiTrangGiaHan(object sender, EventArgs e)
        {
            GUI_DoanhNghiepSapHetHan ui_DoanhNghiepSapHetHan = new GUI_DoanhNghiepSapHetHan(new EventHandler(TienHanhGiaHanHopDong!));
            SwitchContent(ui_DoanhNghiepSapHetHan);

        }
        private void SwitchContent(UserControl content)
        {
            pnContent.Controls.Clear();
            pnContent.Controls.Add(content);
            content.Dock = DockStyle.Fill;
        }
    }
}
