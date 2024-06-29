using Ctrler;
using DTO;
using GUI;
using GUI.Utilis;

namespace QuanLyHoSoUngTuyen
{
    public partial class GUI_DoanhNghiepHetHan : Form
    {
        private string _maDNHienTai = string.Empty;


        public GUI_DoanhNghiepHetHan()
        {
            InitializeComponent();

            HienThiDoanhNghiepHetHan();
            HienThiChienLuocUuDai();
        }

        private void HienThiDoanhNghiepHetHan()
        {
            List<DTO_DoanhNghiep> lsDoanhNghiepHetHan;
            Ctrler_DoanhNghiepHetHan.LoadDanhSachDNHetHan(out lsDoanhNghiepHetHan);

            dsDNHetHan.DataSource = lsDoanhNghiepHetHan;
        }

        private void HienThiChienLuocUuDai()
        {
            List<DTO_ChienLuocUuDai> lsChienLuocUuDai;
            Ctrler_ChienLuocUuDai.LoadChienLuocUuDai(out lsChienLuocUuDai);

            dsChienLuocUuDai.DataSource = lsChienLuocUuDai;
        }

        private void dsDNHetHan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                _maDNHienTai = dsDNHetHan.Rows[e.RowIndex].Cells[0].Value.ToString()!;
                lbTenDoanhNghiep.Text = dsDNHetHan.Rows[e.RowIndex].Cells[1].Value.ToString();
                List<DTO_KetQuaUngTuyen> lsKetQuaUngTuyen;
                Ctrler_DoanhNghiepHetHan.LoadKetQuaUngTuyenCuaDN(dsDNHetHan.Rows[e.RowIndex].Cells[0].Value.ToString()!, out lsKetQuaUngTuyen);
                dsKetQuaUngTuyen.DataSource = lsKetQuaUngTuyen;
            }
        }

        private void btnGiaHan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_maDNHienTai))
            {
                MessageBox.Show("Vui lòng chọn doanh nghiệp để gia hạn.");
                return;
            }
            GUI_XacNhanGiaHanHopDong ui_XacNhanGiaHanHopDong = new GUI_XacNhanGiaHanHopDong(_maDNHienTai);
            ui_XacNhanGiaHanHopDong.ShowDialog();
        }

        private void btnThemUuDai_Click(object sender, EventArgs e)
        {
            var ud = new DTO_ChienLuocUuDai("", txtTenUuDai.Text, txtMoTaUuDai.Text);

            TryCatchShowMessageBox.ExecuteWithTryCatch(
                () =>
                { Ctrler_ChienLuocUuDai.ThemCLUD(ud); }
                 );
        }

        private void btnSuaUuDai_Click(object sender, EventArgs e)
        {

        }

        private void btnXoaUuDai_Click(object sender, EventArgs e)
        {

        }

        private void dsChienLuocUuDai_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}