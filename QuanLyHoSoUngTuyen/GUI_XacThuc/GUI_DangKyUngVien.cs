using DTO;
using GUI.Utilis;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.GUI_XacThuc
{
    public partial class GUI_DangKyUngVien : UserControl
    {
        public GUI_DangKyUngVien()
        {
            InitializeComponent();
        }
        public void LayThongTinUngVien(out DTO_UngVien? ungVien)
        {
            ungVien = null;
            if (!checkEmptyInfos() || !checkDate())
            {
                return;
            }
            ungVien = new DTO_UngVien(txtCCCD.Text, txtHoTen.Text, dtpNgaySinh.Value, txtDiaChi.Text, txtEmail.Text, txtSoDienThoai.Text, "");
        }

        private bool checkEmptyInfos()
        {
            if (string.IsNullOrEmpty(txtHoTen.Text) ||
                string.IsNullOrEmpty(txtCCCD.Text) ||
                string.IsNullOrEmpty(txtDiaChi.Text) ||
                string.IsNullOrEmpty(txtSoDienThoai.Text))
            {
                MessageBoxHelper.ShowInformation("Vui lòng điền đủ các trường.");
                return false;
            }
            return true;
        }

        private bool checkDate()
        {
            if (dtpNgaySinh.Value >= DateTime.Now)
            {
                MessageBoxHelper.ShowInformation("Ngày sinh phải trước ngày hiện tại.");
                return false;
            }
            return true;
        }
    }
}
