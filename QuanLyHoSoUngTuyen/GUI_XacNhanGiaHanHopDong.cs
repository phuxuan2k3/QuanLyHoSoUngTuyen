using Ctrler;
using DTO;
using System.ComponentModel;
using System.Data;
using Utilis;

namespace GUI
{
    public partial class GUI_XacNhanGiaHanHopDong : Form
    {
        private string _maDNHienTai = string.Empty;

        public GUI_XacNhanGiaHanHopDong(string maDNHienTai)
        {
            _maDNHienTai = maDNHienTai;

            InitializeComponent();
            HienThi();
        }

        private void HienThi()
        {
            List<DTO_ChienLuocUuDai> ls_ChienLuocUuDai;
            Ctrler.Ctrler_XacNhanGiaHanHopDong.LoadChienLuocUuDai(out ls_ChienLuocUuDai);
            dsChienLuocUuDai.DataSource = ls_ChienLuocUuDai;

            List<DTO_ChienLuocUuDai> ls_ChienLuocUuDaiHienTai;
            Ctrler.Ctrler_XacNhanGiaHanHopDong.LoadChienLuocUuDaiCuaDN(_maDNHienTai, out ls_ChienLuocUuDaiHienTai);

            var bdls_ChienLuocUuDaiHienTai = new BindingList<DTO_ChienLuocUuDai>(ls_ChienLuocUuDaiHienTai);
            dsChienLuocUuDaiHienTai.DataSource = bdls_ChienLuocUuDaiHienTai;
        }

        private void btnApDung_Click(object sender, EventArgs e)
        {
            var dsChienLuocUuDaiSource = dsChienLuocUuDai.DataSource as List<DTO_ChienLuocUuDai>;
            var dsChienLuocUuDaiHienTaiSource = dsChienLuocUuDaiHienTai.DataSource as BindingList<DTO_ChienLuocUuDai>;
            var dsMaChienLuocUuDaiHienTai = dsChienLuocUuDaiHienTaiSource!.Select(cl => cl.MaChienLuoc).ToList();

            for (int i = 0; i < dsChienLuocUuDai.SelectedRows.Count; i++)
            {
                var index = dsChienLuocUuDai.SelectedRows[i].Index;
                if (!dsMaChienLuocUuDaiHienTai.Contains(dsChienLuocUuDaiSource[index].MaChienLuoc))
                {
                    dsChienLuocUuDaiHienTaiSource!.Add(dsChienLuocUuDaiSource[index]);
                }
            }
        }

        private void btnLoaiBo_Click(object sender, EventArgs e)
        {
            var indexs = new List<int>();
            for (int i = 0; i < dsChienLuocUuDaiHienTai.SelectedRows.Count; i++)
            {
                indexs.Add(dsChienLuocUuDaiHienTai.SelectedRows[i].Index);
            }
            QuickSort.quickSort(ref indexs, 0, indexs.Count - 1);
            for (int i = indexs.Count - 1; i >= 0; i--)
            {
                (dsChienLuocUuDaiHienTai.DataSource as BindingList<DTO_ChienLuocUuDai>)!.RemoveAt(dsChienLuocUuDaiHienTai.SelectedRows[i].Index);
            }
        }

        private void btnKhongGiaHan_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Rời khỏi mà không có bất kỳ thay đổi nào?", "Không gia hạn", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnLuuLai_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Gia hạn hợp đồng của doanh nghiệp với các ưu đãi này?", "Gia hạn hợp đồng", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var lsChienLuocUuDaiHienTai = dsChienLuocUuDaiHienTai.DataSource as List<DTO_ChienLuocUuDai>;
                Ctrler_XacNhanGiaHanHopDong.GiaHanDoanhNghiep(_maDNHienTai, lsChienLuocUuDaiHienTai!);
            }
        }
    }
}