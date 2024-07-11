using Ctrler;
using DTO;
using Utilis;

namespace GUI.UserControls
{
    public partial class GUI_DoanhNghiepSapHetHan : UserControl
    {
        public DTO_DoanhNghiep DNHienTai { get; set; } = null!;
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

            HideSomeField();
        }

        private void RenameHeaders()
        {
            Utilis.QuickTryCatch.ExecuteWithoutResolve(() => dsKetQuaUngTuyen.Columns["SoLuongUVNop"].HeaderText = "Số lượng nộp");
            Utilis.QuickTryCatch.ExecuteWithoutResolve(() => dsKetQuaUngTuyen.Columns["SoLuongUVHopLe"].HeaderText = "Số lượng hợp lệ");
            Utilis.QuickTryCatch.ExecuteWithoutResolve(() => dsKetQuaUngTuyen.Columns["SoLuongUVDat"].HeaderText = "Số lượng đạt");
        }

        private void HideSomeField()
        {
            Utilis.QuickTryCatch.ExecuteWithoutResolve(() => dsDNHetHan.Columns["MaDN"].Visible = false);
            Utilis.QuickTryCatch.ExecuteWithoutResolve(() => dsDNHetHan.Columns["DiaChi"].Visible = false);
            Utilis.QuickTryCatch.ExecuteWithoutResolve(() => dsDNHetHan.Columns["Email"].Visible = false);
            Utilis.QuickTryCatch.ExecuteWithoutResolve(() => dsDNHetHan.Columns["NgayDangKy"].Visible = false);
            Utilis.QuickTryCatch.ExecuteWithoutResolve(() => dsDNHetHan.Columns["TenTaiKhoan"].Visible = false);
        }

        private void dsDNHetHan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DNHienTai = (dsDNHetHan.DataSource as List<DTO_DoanhNghiep>)![e.RowIndex];
                lbTenDoanhNghiep.Text = DNHienTai.TenDN;
                List<DTO_KetQuaUngTuyen> lsKetQuaUngTuyen;
                Ctrler_DoanhNghiepHetHan.LoadKetQuaUngTuyenCuaDN(dsDNHetHan.Rows[e.RowIndex].Cells[0].Value.ToString()!, out lsKetQuaUngTuyen);
                dsKetQuaUngTuyen.DataSource = lsKetQuaUngTuyen;

                Utilis.QuickTryCatch.ExecuteWithoutResolve(() => dsKetQuaUngTuyen.Columns["MaTTDT"].Visible = false);
                RenameHeaders();
            }
        }


        private void btnGiaHan_Click(object sender, EventArgs e)
        {
            if (DNHienTai == null)
            {
                MessageBox.Show("Vui lòng chọn doanh nghiệp để gia hạn.");
                return;
            }

            GiaHanHopDong?.Invoke(this, new EventArgs<DTO_DoanhNghiep>(DNHienTai));
        }
    }
}
