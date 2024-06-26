using Ctrler;
using DTO;

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
    }
}
