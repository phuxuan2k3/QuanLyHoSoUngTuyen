using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.UC
{
    public partial class UC_TraCuuViTriUngTuyen : UserControl
    {
        public static string dsViTriTimDuoc_MaViTri = "";
        public static string dsViTriTimDuoc_TenViTri = "";
        public static string yeucau = "";
        public UC_TraCuuViTriUngTuyen()
        {
            InitializeComponent();
            dsCacViTriTimDuoc.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void Btn_TimKiem_Click(object sender, EventArgs e)
        {
            if (BUS_ThongTinDangTuyen.check_Dienphieu(Txt_TimKiem.Text) == 0)
            {
                MessageBox.Show("Hãy điền tên vị trí bạn muốn tìm!");
            }
            else if (BUS_ThongTinDangTuyen.KiemTraViTriUngTuyen(Txt_TimKiem.Text) == 1)
            {
                SqlDataReader reader = BUS_ThongTinDangTuyen.viewList_ViTri(Txt_TimKiem.Text);
                DataTable dt = new DataTable();
                dt.Load(reader);
                if (dt.Rows.Count > 0) dsCacViTriTimDuoc.DataSource = dt;
                else MessageBox.Show("Không có vị trí nào tìm được!");
            }
            else
            {
                MessageBox.Show("Không có vị trí nào tìm được!");
            }
        }

        private void Btn_DienPhieu_Click(object sender, EventArgs e)
        {
            if (BUS_ThongTinDangTuyen.check_Dienphieu(txt_ViTriUngTuyen.Text.ToString()) == 1)
            {
                UC_DienPhieuDangKyUngTuyen uc = new UC_DienPhieuDangKyUngTuyen();
                uc.Dock = DockStyle.Fill;
                this.Controls.Clear();
                this.Controls.Add(uc);
                uc.BringToFront();
            }
            else
            {
                MessageBox.Show("Hãy chọn một vị trí ứng tuyển!");
            }
        }

        private void dsCacViTriTimDuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex >= 0 && e.RowIndex < dsCacViTriTimDuoc.Rows.Count)
            {
                DataGridViewRow row = dsCacViTriTimDuoc.Rows[e.RowIndex];

                txt_ViTriUngTuyen.Text = row.Cells[7].Value?.ToString() ?? string.Empty;
                txt_SoLuongTuyen.Text = row.Cells[8].Value?.ToString() ?? string.Empty;
                rTxt_YeuCau.Text = row.Cells[9].Value?.ToString() ?? string.Empty;
                txt_CongTy.Text = BUS_DoanhNghiep.LayTenDN(row.Cells[1].Value?.ToString() ?? string.Empty).ToString();
                dsViTriTimDuoc_MaViTri = row.Cells[0].Value?.ToString() ?? string.Empty.ToString();
                dsViTriTimDuoc_TenViTri = txt_ViTriUngTuyen.Text.ToString();
                yeucau = rTxt_YeuCau.Text;
            }
        }
    }
}
