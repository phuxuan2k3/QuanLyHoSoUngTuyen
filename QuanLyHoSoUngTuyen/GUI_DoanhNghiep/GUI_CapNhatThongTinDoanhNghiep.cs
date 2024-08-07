﻿using BUS;
using Ctrler.DoanhNghiep;
using DTO;

namespace GUI.UserControls
{
	public partial class GUI_CapNhatThongTinDoanhNghiep : UserControl
    {
        public GUI_CapNhatThongTinDoanhNghiep()
        {
            InitializeComponent();
        }
        string maDN = "";

        public void HienThi(string MaDN)
        {
            DTO_DoanhNghiep doanhNghiep = new();
            Ctrler_CapNhatThongTinDoanhNghiep ctrler = new();
            doanhNghiep = ctrler.Load(MaDN);
            txbTenDN.Text = doanhNghiep.TenDN;
            txbMST.Text = doanhNghiep.MaSoThue;
            txbDiaChi.Text = doanhNghiep.DiaChi;
            txbDaiDien.Text = doanhNghiep.NguoiDaiDien;
            txbEmail.Text = doanhNghiep.Email;
            maDN = doanhNghiep.MaDN;
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            txbEmail.ReadOnly = false;
            txbDiaChi.ReadOnly = false;
            txbDaiDien.ReadOnly = false;
            txbTenDN.ReadOnly = false;
            txbMST.ReadOnly = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            if (Ctrler_CapNhatThongTinDoanhNghiep.KiemTraMaSothue(maDN,txbMST.Text) == 1)
            {
                DTO_DoanhNghiep doanhNghiep = new()
                {
                    TenDN = txbTenDN.Text,
                    MaSoThue = txbMST.Text,
                    DiaChi = txbDiaChi.Text,
                    NguoiDaiDien = txbDaiDien.Text,
                    Email = txbEmail.Text,
                    MaDN = maDN
                };
                Ctrler_CapNhatThongTinDoanhNghiep ctrler = new();
                ctrler.CapNhatTTDN(doanhNghiep);
                MessageBox.Show("Lưu thông tin thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else { MessageBox.Show("Mã số thuế đã tồn tại trong hệ thống.", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }


    }
}
