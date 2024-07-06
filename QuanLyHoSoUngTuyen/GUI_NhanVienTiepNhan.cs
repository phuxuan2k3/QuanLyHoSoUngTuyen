using Ctrler;
using GUI.Styles;
using GUI.UC;
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
    public partial class GUI_NhanVienTiepNhan : Form
    {
        public GUI_NhanVienTiepNhan()
        {
            Style.ApplyStylingEventOnChildControlAdded(this,
           ButtonStyle.Apply);
           _instance = this;
           // InitializeComponent();
            InitializeComponent();
        }

       
        private static GUI_NhanVienTiepNhan? _instance = null;
        public static GUI_NhanVienTiepNhan Instance => _instance ??= new GUI_NhanVienTiepNhan();

        public void SwitchContent(UserControl content)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(content);
            content.Dock = DockStyle.Fill;
        }

        private void btnXetDuyetTTDT_Click(object sender, EventArgs e)
        {
            GUI_DanhSachTTDTCanXetDuyet content = new();
            content.HienThi(new Ctrler_DanhSachTTDTXetDuyet());
            SwitchContent(content);
        }

        private void btnXacThucDN_Click(object sender, EventArgs e)
        {
            GUI_XacThucThongTinDoanhNghiep content = new();
            content.HienThi();
            SwitchContent(content);
        }
    }
}
