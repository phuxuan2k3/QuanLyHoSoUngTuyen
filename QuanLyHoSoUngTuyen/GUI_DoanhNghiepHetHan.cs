using Ctrler;
using DTO;
using System.Windows.Forms;

namespace QuanLyHoSoUngTuyen
{
    public partial class GUI_DoanhNghiepHetHan : Form
    {
        public GUI_DoanhNghiepHetHan()
        {
            InitializeComponent();
            HienThi();
        }

        public void HienThi()
        {
            List<DTO_DoanhNghiep> lsDoanhNghiepHetHan;
            Ctrler_DoanhNghiepHetHan.LoadDanhSachDNHetHan(out lsDoanhNghiepHetHan);

            dsDNHetHan.DataSource = lsDoanhNghiepHetHan;
        }

        private void dsDNHetHan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                List<DTO_KetQuaUngTuyen> lsKetQuaUngTuyen;
                Ctrler_DoanhNghiepHetHan.LoadKetQuaUngTuyenCuaDN(dsDNHetHan.SelectedRows[0].Cells[0].Value.ToString()!, out lsKetQuaUngTuyen);
                dsKetQuaUngTuyen.DataSource = lsKetQuaUngTuyen;
            }
        }
    }
}