using Ctrler;
using GUI.Styles;
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
            Style.ApplyStylingEventOnChildControlAdded(this,
            ButtonStyle.Apply);
            _instance = this;
            InitializeComponent();
        }
        public void SwitchContent(UserControl content)
        {
            _container.Controls.Clear();
            _container.Controls.Add(content);
            content.Dock = DockStyle.Fill;
        }

        private static GUI_NhanVienNghiepVu? _instance = null;

        private void btnDuyetPhieuDangKy_Click(object sender, EventArgs e)
        {
            GUI_DuyetPhieuDangKy_DanhSachThongTinDangTuyen content = new();
            content.HienThi(new Ctrler_DanhSachThongTinDangTuyen(""));
            SwitchContent(content);
        }

        private void btnDuyet_DoanhNghiep_Click(object sender, EventArgs e)
        {
            GUI_DanhSachThongTinDangTuyen_DN content = new();
            content.HienThi(new Ctrler_DanhSachThongTinDangTuyen(""));
            SwitchContent(content);
        }

        public static GUI_NhanVienNghiepVu Instance => _instance ??= new GUI_NhanVienNghiepVu();

    }
}
