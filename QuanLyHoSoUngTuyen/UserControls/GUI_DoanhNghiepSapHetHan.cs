using Ctrler;
using DTO;
using Utilis;

namespace GUI.UserControls
{
    public partial class GUI_DoanhNghiepSapHetHan : UserControl
    {
        public DTO_DoanhNghiep DNHienTai { get; set; } = null!;
        public event EventHandler GiaHanHopDong;
        private Size oldSize;
        private void GUI_DoanhNghiepSapHetHan_Load(object sender, EventArgs e) => oldSize = Size;

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            foreach (Control cnt in Controls)
            {
                ResizeAll(cnt, Size);
                if (cnt is TableLayoutPanel)
                {
                    foreach (Control cnt2 in cnt.Controls)
                    {
                        ResizeAll(cnt2, Size);
                    }
                }
            }
            oldSize = Size;
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
                DNHienTai = (dsDNHetHan.DataSource as List<DTO_DoanhNghiep>)![e.RowIndex];
                lbMaDoanhNghiep.Text = DNHienTai.TenDN;
                List<DTO_KetQuaUngTuyen> lsKetQuaUngTuyen;
                Ctrler_DoanhNghiepHetHan.LoadKetQuaUngTuyenCuaDN(dsDNHetHan.Rows[e.RowIndex].Cells[0].Value.ToString()!, out lsKetQuaUngTuyen);
                dsKetQuaUngTuyen.DataSource = lsKetQuaUngTuyen;
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
