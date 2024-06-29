using GUI.UC;
using Utilis;

namespace GUI
{
    public partial class GUI_BanLanhDao_Base : Form
    {
        public GUI_BanLanhDao_Base()
        {
            InitializeComponent();
            KhoiTaoManHinh();

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
            GUI_XacNhanGiaHanHopDongUC ui_XacNhanGiaHanHopDong = new GUI_XacNhanGiaHanHopDongUC(new EventHandler(HuyGiaHan!), (e as StringEventAgrs)!.Message);
            SwitchContent(ui_XacNhanGiaHanHopDong);
        }

        private void HuyGiaHan(object sender, EventArgs e)
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
