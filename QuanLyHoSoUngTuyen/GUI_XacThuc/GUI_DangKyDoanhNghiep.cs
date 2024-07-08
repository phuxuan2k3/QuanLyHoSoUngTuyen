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
    public partial class GUI_DangKyDoanhNghiep : UserControl
    {
        public GUI_DangKyDoanhNghiep()
        {
            InitializeComponent();
        }
        public void LayThongTinDoanhNghiep(out DTO_DoanhNghiep? doanhNghiep)
        {
            doanhNghiep = null;
            if (!checkEmptyInfos())
            {
                return;
            }
            doanhNghiep = new DTO_DoanhNghiep("", txtTenCongTy.Text, txtMaSoThue.Text, txtNguoiDaiDien.Text, txtDiaChi.Text, txtEmail.Text);
        }

        private bool checkEmptyInfos()
        {
            if (string.IsNullOrEmpty(txtTenCongTy.Text) ||
                string.IsNullOrEmpty(txtNguoiDaiDien.Text) ||
                string.IsNullOrEmpty(txtMaSoThue.Text) ||
                string.IsNullOrEmpty(txtEmail.Text) ||
                string.IsNullOrEmpty(txtDiaChi.Text))
            {
                MessageBoxHelper.ShowInformation("Vui lòng điền đủ các trường.");
                return false;
            }
            return true;
        }
    }
}
