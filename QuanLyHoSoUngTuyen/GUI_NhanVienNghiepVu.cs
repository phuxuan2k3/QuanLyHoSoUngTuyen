using Ctrler.DoanhNghiep;
using Ctrler.NhanVienNghiepVu;
using GUI.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class GUI_NhanVienNghiepVu : Form
    {
        public GUI_NhanVienNghiepVu()
        {
            InitializeComponent();
        }

        private void btnDangTuyenTTDT_Click(object sender, EventArgs e)
        {
            GUI_DanhSachTTDTCanDangTuyen content = new();
            content.HienThi(new Ctrler_DanhSachTTDTCanDangTuyen());
            SwitchContent(content);
        }
        private static GUI_DoanhNghiep? _instance = null;
        public static GUI_DoanhNghiep Instance => _instance ??= new GUI_DoanhNghiep();

        public void SwitchContent(UserControl content)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(content);
            content.Dock = DockStyle.Fill;
        }
    }
}
