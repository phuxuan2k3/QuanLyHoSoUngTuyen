using Ctrler;
using DTO;
using Utilis;

namespace GUI.UC
{
    public partial class GUI_DoanhNghiepSapHetHan : UserControl
    {
        public string MaDNHienTai { get; set; } = string.Empty;
        public event EventHandler GiaHanHopDong;

        public GUI_DoanhNghiepSapHetHan(EventHandler giaHanHopDong)
        {
            GiaHanHopDong += giaHanHopDong;
            InitializeComponent();

            HienThi();
        }

        private void HienThi()
        {
            List<DTO_DoanhNghiep> lsDoanhNghiepHetHan;
            Ctrler_DoanhNghiepHetHan.LoadDanhSachDNHetHan(out lsDoanhNghiepHetHan);

            dsDNHetHan.DataSource = lsDoanhNghiepHetHan;
        }

        private void dsDNHetHan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                MaDNHienTai = dsDNHetHan.Rows[e.RowIndex].Cells[0].Value.ToString()!;
                lbMaDoanhNghiep.Text = MaDNHienTai;
                List<DTO_KetQuaUngTuyen> lsKetQuaUngTuyen;
                Ctrler_DoanhNghiepHetHan.LoadKetQuaUngTuyenCuaDN(dsDNHetHan.Rows[e.RowIndex].Cells[0].Value.ToString()!, out lsKetQuaUngTuyen);
                dsKetQuaUngTuyen.DataSource = lsKetQuaUngTuyen;
            }
        }


        private void btnGiaHan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MaDNHienTai))
            {
                MessageBox.Show("Vui lòng chọn doanh nghiệp để gia hạn.");
                return;
            }

            GiaHanHopDong?.Invoke(this, new StringEventAgrs(MaDNHienTai));
        }
    }
}
