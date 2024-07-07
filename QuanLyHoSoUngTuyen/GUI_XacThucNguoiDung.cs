using Ctrler;
using DTO;
using GUI.GUI_XacThuc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilis;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
namespace GUI
{
    public partial class GUI_XacThucNguoiDung : Form
    {
        private Size oldSize;

        public GUI_XacThucNguoiDung()
        {
            InitializeComponent();
            KhoiTaoManHinh();
        }

        private void KhoiTaoManHinh()
        {
            GUI_DangNhap gui_DangNhap = new(DangNhapThanhCong!, DangKy!);
            SwitchContent(gui_DangNhap);
        }

        private void GUI_XacThucNguoiDung_Load(object sender, EventArgs e)
        {
            oldSize = Size;
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            foreach (Control cnt in Controls)
            {
                ResizeAll(cnt, Size);
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

        private void DangNhapThanhCong(object sender, EventArgs e)
        {
            switch ((e as EventArgs<DTO_TaiKhoan>)!.Value.VaiTro)
            {
                case "Doanh nghiệp":
                    GUI_DoanhNghiep gUI_DoanhNghiep = new GUI_DoanhNghiep();
                    Hide();
                    gUI_DoanhNghiep.ShowDialog();
                    //todo: them logout xoa cac truong cua textbox
                    Show();
                    break;
                case "Nhân viên":
                    GUI_BanLanhDao gui_BanLanhDao = new GUI_BanLanhDao();
                    Hide();
                    gui_BanLanhDao.ShowDialog();
                    Show();
                    break;
                    //case "Ứng viên":
                    //    GUI_BanLanhDao gui_BanLanhDao = new GUI_BanLanhDao();
                    //    gui_BanLanhDao.ShowDialog();
                    //    Close();
                    //    break;
            }
        }
        private void DangKy(object sender, EventArgs e)
        {
            GUI_DangKy gUI_DangKy = new GUI_DangKy(BackToDangNhap!);
            SwitchContent(gUI_DangKy);
        }

        private void BackToDangNhap(object sender, EventArgs e)
        {
            GUI_DangNhap gui_DangNhap = new(DangNhapThanhCong!, DangKy!);
            SwitchContent(gui_DangNhap);
        }

        private void SwitchContent(UserControl content)
        {
            pnContent.Controls.Clear();
            pnContent.Controls.Add(content);
            content.Dock = DockStyle.Fill;
        }
    }
}
