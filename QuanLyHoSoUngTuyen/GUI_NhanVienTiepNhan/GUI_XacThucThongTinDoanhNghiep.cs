﻿using Ctrler.NhanVienTiepNhan;
using DTO;
using GUI.Utilis;

namespace GUI.UserControls
{
    public partial class GUI_XacThucThongTinDoanhNghiep : UserControl
    {
        string MaDN = "";
        public GUI_XacThucThongTinDoanhNghiep()
        {
            InitializeComponent();
        }

        public Ctrler_XacThucThongTinDoanhNghiep _Ctrler_XacThucThongTinDoanhNghiep;

        public void HienThiTTDN(DTO_DoanhNghiep DN)
        {
            lbTenDN.Text = DN.TenDN.ToString();
            lbMST.Text = DN.MaSoThue.ToString();
            MaDN = DN.MaDN.ToString();
            lbDiaChi.Text = DN.DiaChi.ToString();
            lbNgDaiDien.Text = DN.NguoiDaiDien.ToString();
        }

        public void HienThi()
        {
            var dsDNXT = new List<DTO_DoanhNghiep>();
            Ctrler_XacThucThongTinDoanhNghiep.Load(ref dsDNXT);
            foreach (var dn in dsDNXT)
            {
                int rowId = dsDoanhNghiep.Rows.Add();
                DataGridViewRow row = dsDoanhNghiep.Rows[rowId];
                row.Cells["ColumnMaDN"].Value = dn.MaDN;
                row.Cells["ColumnMST"].Value = dn.MaSoThue;
                row.Cells["ColumnTenDN"].Value = dn.TenDN;
                row.Cells["ColumnDaiDienDN"].Value = dn.NguoiDaiDien;
                row.Cells["ColumnTrangThai"].Value = dn.TrangThai.GetString();
                TimeSpan ngayconlai = DateTime.Now.Date - Convert.ToDateTime(dn.NgayDangKy).Date;
                row.Cells["ColumnNgayConLai"].Value = 7 - ngayconlai.Days + " ngày";
                if (7 - ngayconlai.Days <= 3)
                { dsDoanhNghiep.Rows[rowId].DefaultCellStyle.ForeColor = Color.Red; }

            }
        }

        private void btnTuChoi_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MaDN))
            {
                MessageBoxHelper.ShowInformation("Vui lòng chọn doanh nghiệp!");
                return;
            }
            dsDoanhNghiep.DataSource = null;
            dsDoanhNghiep.Rows.Clear();
            Ctrler_XacThucThongTinDoanhNghiep.CapNhatTrangThaiDoanhNghiep(MaDN, "Không hợp lệ");
            HienThi();
        }


        private void btnXacThuc_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MaDN))
            {
                MessageBoxHelper.ShowInformation("Vui lòng chọn doanh nghiệp!");
                return;
            }
            dsDoanhNghiep.DataSource = null;
            dsDoanhNghiep.Rows.Clear();

            Ctrler_XacThucThongTinDoanhNghiep.CapNhatTrangThaiDoanhNghiep(MaDN, "Hợp lệ");
            HienThi();
        }

        private void dsDoanhNghiep_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dsDoanhNghiep.Rows[e.RowIndex].Cells["ColumnMaDN"].Value is string MaDN)
            {
                string thoihan = dsDoanhNghiep.Rows[e.RowIndex].Cells["ColumnNgayConLai"].Value.ToString();
                if (thoihan[0] != '-')
                {
                    var ctrler = Ctrler_XacThucThongTinDoanhNghiep.LayThongTinDoanhNghiep(MaDN);
                    HienThiTTDN(ctrler);
                }
                else
                {
                    MessageBox.Show("Doanh nghiệp đã quá hạn xác thực!");
                    Ctrler_XacThucThongTinDoanhNghiep.CapNhatTrangThaiDoanhNghiep(MaDN, "Không hợp lệ");
                    dsDoanhNghiep.Rows.Clear();
                    HienThi();
                }
            }
        }
    }
}
