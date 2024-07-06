using Ctrler.DoanhNghiep;
using DTO;
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
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            

        }
    }
}
