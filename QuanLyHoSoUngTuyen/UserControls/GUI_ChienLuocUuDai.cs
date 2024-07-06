using Ctrler;
using DTO;
using GUI.Utilis;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.UserControls
{
    public partial class GUI_ChienLuocUuDai : UserControl
    {
        private string? _maChienLuocHienTai = string.Empty;

        public GUI_ChienLuocUuDai()
        {
            InitializeComponent();

            HienThi();
        }

        private void HienThi()
        {
            List<DTO_ChienLuocUuDai> lsChienLuocUuDai;
            Ctrler_ChienLuocUuDai.LoadChienLuocUuDai(out lsChienLuocUuDai);

            dsChienLuocUuDai.DataSource = lsChienLuocUuDai;
        }

        private void dsChienLuocUuDai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                _maChienLuocHienTai = dsChienLuocUuDai.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTenUuDai.Text = dsChienLuocUuDai.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtMoTaUuDai.Text = dsChienLuocUuDai.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
        }

        private void btnThemUuDai_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMoTaUuDai.Text) || string.IsNullOrEmpty(txtTenUuDai.Text))
            {
                MessageBoxHelper.ShowInformation("Điền đủ các trường thông tin!");
                return;
            }
            var ud = new DTO_ChienLuocUuDai("", txtTenUuDai.Text, txtMoTaUuDai.Text);
            Ctrler_ChienLuocUuDai.ThemCLUD(ud);
        }

        private void btnSuaUuDai_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_maChienLuocHienTai))
            {
                MessageBoxHelper.ShowInformation("Chọn một chiến lược ưu đãi để chỉnh sửa!");
                return;
            }
            if (string.IsNullOrEmpty(txtMoTaUuDai.Text) || string.IsNullOrEmpty(txtTenUuDai.Text))
            {
                MessageBoxHelper.ShowInformation("Điền đủ các trường thông tin!");
                return;
            }
            var ud = new DTO_ChienLuocUuDai(_maChienLuocHienTai, txtTenUuDai.Text, txtMoTaUuDai.Text);
            Ctrler_ChienLuocUuDai.ThemCLUD(ud);
        }

        private void btnXoaUuDai_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_maChienLuocHienTai))
            {
                MessageBoxHelper.ShowInformation("Chọn một chiến lược ưu đãi để xoá!");
                return;
            }
            else
            {
                if (MessageBoxHelper.ShowQuestion("Chắn chắn xoá chiến lược này?") == DialogResult.Yes)
                {
                    Ctrler_ChienLuocUuDai.XoaCLUD(_maChienLuocHienTai);
                }
            }
        }
    }
}
