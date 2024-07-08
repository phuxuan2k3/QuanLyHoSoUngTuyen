using BUS;
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

namespace GUI.GUI_XacThuc
{
    public partial class GUI_DangKyTaiKhoan : UserControl
    {
        public GUI_DangKyTaiKhoan()
        {
            InitializeComponent();
        }
        public void LayThongTinTaiKhoan(out DTO_TaiKhoan? taiKhoan)
        {
            taiKhoan = null;
            if (!checkEmptyInfos() || !KiemTraTenTaiKhoan(txtTenTaiKhoan.Text) || !KiemTraNhapLaiMatKhau())
            {
                return;
            }
            taiKhoan = new DTO_TaiKhoan(txtTenTaiKhoan.Text, txtMatKhau.Text, "");
        }

        private bool KiemTraNhapLaiMatKhau()
        {
            if (!txtMatKhau.Text.Equals(txtNhapLaiMatKhau.Text))
            {
                MessageBoxHelper.ShowInformation("Nhập lại mật khẩu chưa khớp!");
                return false;
            }
            return true;
        }

        private bool KiemTraTenTaiKhoan(string tenTaiKhoan)
        {
            if (BUS_TaiKhoan.KiemTraTenTaiKhoanTonTai(tenTaiKhoan))
            {
                MessageBoxHelper.ShowInformation("Tên tài khoản đã tồn tại");
                return false;
            }
            return true;
        }


        private bool checkEmptyInfos()
        {
            if (string.IsNullOrEmpty(txtTenTaiKhoan.Text) ||
                string.IsNullOrEmpty(txtMatKhau.Text) ||
                string.IsNullOrEmpty(txtNhapLaiMatKhau.Text))
            {
                MessageBoxHelper.ShowInformation("Vui lòng điền đủ các trường.");
                return false;
            }
            return true;
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

        private void cbPasswordAgain_CheckedChanged(object sender, EventArgs e)
        {
            if (txtNhapLaiMatKhau.PasswordChar.Equals('.'))
            {
                txtNhapLaiMatKhau.PasswordChar = '\0';
            }
            else
            {
                txtNhapLaiMatKhau.PasswordChar = '.';
            }
        }
    }
}
