using BUS;
using Ctrler;
using DTO;
using GUI.Utilis;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.GUI_XacThuc
{
    public partial class GUI_DangKy : UserControl
    {
        public event EventHandler? BackToDangNhap;
        public GUI_DangKy(EventHandler backToDangNhap)
        {
            BackToDangNhap += backToDangNhap;
            InitializeComponent();
        }
        private void SwitchContent(UserControl content)
        {
            pnDangKyContent.Controls.Clear();
            pnDangKyContent.Controls.Add(content);
            content.Dock = DockStyle.Fill;

            GUI_DangKyTaiKhoan gUI_DangKyTaiKhoan = new GUI_DangKyTaiKhoan();
            pnTaiKhoanContent.Controls.Clear();
            pnTaiKhoanContent.Controls.Add(gUI_DangKyTaiKhoan);
            gUI_DangKyTaiKhoan.Dock = DockStyle.Fill;
        }

        private void rdbUngVien_CheckedChanged(object sender, EventArgs e)
        {
            GUI_DangKyUngVien gui_DangKyUngVien = new GUI_DangKyUngVien();
            SwitchContent(gui_DangKyUngVien);
            btnDangky.Visible = true;
        }
        private void rdbDoanhNghiep_CheckedChanged(object sender, EventArgs e)
        {
            GUI_DangKyDoanhNghiep gui_DangKyDoanhNghiep = new GUI_DangKyDoanhNghiep();
            SwitchContent(gui_DangKyDoanhNghiep);
            btnDangky.Visible = true;
        }

        private void btnDangky_Click(object sender, EventArgs e)
        {
            DTO_TaiKhoan? taiKhoan = null;
            if (!LayThongTinTaiKhoan(ref taiKhoan))
            {
                return;
            }


            if (rdbUngVien.Checked)
            {
                DTO_UngVien? ungVien = null;
                if (!LayThongTinUngVien(ref ungVien))
                {
                    return;
                }

                ungVien!.TenTaiKhoan = taiKhoan!.TenTaiKhoan;
                taiKhoan.VaiTro = "Ứng viên";

                Ctrler_DangKy.DangKyUngVien(taiKhoan, ungVien);
            }
            else
            {
                DTO_DoanhNghiep? doanhNghiep = null;
                if (!LayThongTinDoanhNghiep(ref doanhNghiep))
                {
                    return;
                }

                doanhNghiep!.TenTaiKhoan = taiKhoan!.TenTaiKhoan;
                taiKhoan.VaiTro = "Doanh nghiệp";

                Ctrler_DangKy.DangKyDoanhNghiep(taiKhoan, doanhNghiep);
            }

            MessageBoxHelper.ShowInformation("Đăng ký thành công!");
            BackToDangNhap?.Invoke(this, EventArgs.Empty);
        }

        private bool LayThongTinUngVien(ref DTO_UngVien? ungVien)
        {
            var match = pnDangKyContent.Controls.Find("gui_DangKyUngVien", true);
            var gui_DangKyUngVien = match.ElementAt(0) as GUI_DangKyUngVien;
            gui_DangKyUngVien?.LayThongTinUngVien(out ungVien);
            if (ungVien != null)
            {
                return true;
            }
            return false;
        }
        private bool LayThongTinDoanhNghiep(ref DTO_DoanhNghiep? doanhNghiep)
        {
            var match = pnDangKyContent.Controls.Find("gui_DangKyDoanhNghiep", true);
            var gui_DangKyDoanhNghiep = match.ElementAt(0) as GUI_DangKyDoanhNghiep;
            gui_DangKyDoanhNghiep?.LayThongTinDoanhNghiep(out doanhNghiep);
            if (doanhNghiep != null)
            {
                return true;
            }
            return false;
        }
        private bool LayThongTinTaiKhoan(ref DTO_TaiKhoan? taiKhoan)
        {
            var match = pnTaiKhoanContent.Controls.Find("gui_DangKyTaiKhoan", true);
            var gui_DangKyTaiKhoan = match.ElementAt(0) as GUI_DangKyTaiKhoan;
            gui_DangKyTaiKhoan?.LayThongTinTaiKhoan(out taiKhoan);
            if (taiKhoan != null)
            {
                return true;
            }
            return false;
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            BackToDangNhap?.Invoke(this, EventArgs.Empty);
        }
    }
}
