using BUS;
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
    public partial class GUI_DoanhNghiep : Form
    {
        public string _maDN;
        public GUI_DoanhNghiep(string maDN)
        {
            Style.ApplyStylingEventOnChildControlAdded(this,
            ButtonStyle.Apply);
            _instance = this;
            _maDN = maDN;
            InitializeComponent();
        }

        public void SwitchContent(UserControl content)
        {
            _contentPanel.Controls.Clear();
            _contentPanel.Controls.Add(content);
            content.Dock = DockStyle.Fill;
        }

        private static GUI_DoanhNghiep? _instance = null;
      //  public static GUI_DoanhNghiep Instance => _instance ??= new GUI_DoanhNghiep();


        private void btnCapNhatTTDN_Click(object sender, EventArgs e)
        {
            GUI_CapNhatThongTinDoanhNghiep content = new();
            content.HienThi(_maDN);
            SwitchContent(content);
        }

        private void GUI_DoanhNghiep_Load(object sender, EventArgs e)
        {
            if (BUS_DoanhNghiep.KiemTraTrangThaiDN(_maDN) == 0) { lbThongBao.Visible = true; }
            else { lbThongBao.Visible=false; }
        }
    }
}
