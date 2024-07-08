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
using Utilis;

namespace GUI.GUI_XacThuc
{
    public partial class GUI_DangNhap : UserControl
    {
        public event EventHandler? DangNhapThanhCong;
        public event EventHandler? DangKy;
        private Size oldSize;

        public GUI_DangNhap(EventHandler dangNhapThanhCong, EventHandler dangKy)
        {
            DangNhapThanhCong += dangNhapThanhCong;
            DangKy += dangKy;
            InitializeComponent();
        }
        private void GUI_DangNhap_Load(object sender, EventArgs e)
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

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            DangKy?.Invoke(this, EventArgs.Empty);
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            xuLyDangNhap();
        }

        private void xuLyDangNhap()
        {
            var tenTaiKhoan = txtTenTaiKhoan.Text;
            var matKhau = txtMatKhau.Text;
            var taiKhoan = Ctrler_DangNhap.XacThuc(tenTaiKhoan, matKhau);
            if (taiKhoan != null)
            {
                MessageBoxHelper.ShowInformation("Đăng nhập thành công!");
                DangNhapThanhCong?.Invoke(this, new EventArgs<DTO_TaiKhoan>(taiKhoan));
            }
            else
            {
                MessageBoxHelper.ShowInformation("Thông tin đăng nhập chưa đúng!");
            }
        }

        private void GUI_DangNhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                xuLyDangNhap();
        }

        private void txtTenTaiKhoan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                xuLyDangNhap();
        }

        private void txtMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                xuLyDangNhap();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            DangKy?.Invoke(this, EventArgs.Empty);
        }

        private void cbPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (txtMatKhau.PasswordChar.Equals('.'))
            {
                txtMatKhau.PasswordChar = '\0';
            }
            else
            {
                txtMatKhau.PasswordChar = '.';
            }
        }
    }
}
