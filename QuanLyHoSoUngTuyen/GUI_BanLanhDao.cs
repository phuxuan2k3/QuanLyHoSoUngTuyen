using DTO;
using GUI.UserControls;
using Utilis;

namespace GUI
{
    public partial class GUI_BanLanhDao : Form
    {
        public GUI_BanLanhDao()
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
