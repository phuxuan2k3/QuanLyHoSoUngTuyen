using Ctrler;
using DTO;
using GUI.GUIException;
using GUI.Styles;
using GUI.UC;
using System.Diagnostics;

namespace GUI;

public partial class GUI_NhanVienNghiepVu : Form
{
<<<<<<< Updated upstream:QuanLyHoSoUngTuyen/UC/GUI_DanhSachPhieuDK_DN.cs
    public partial class GUI_DanhSachPhieuDK_DN : UserControl
    {
        public GUI_DanhSachPhieuDK_DN()
        {
            InitializeComponent();
        }
=======


    public GUI_NhanVienNghiepVu()
    {
        Style.ApplyStylingEventOnChildControlAdded(this,
           ButtonStyle.Apply);
        _instance = this;
        InitializeComponent();
>>>>>>> Stashed changes:QuanLyHoSoUngTuyen/GUI_NhanVienNghiepVu.cs
    }
    public static GUI_NhanVienNghiepVu? _instance = null;
  
private void btnDuyetPhieuDangKy_Click(object sender, EventArgs e)
        {
            GUI_DuyetPhieuDangKy_DanhSachThongTinDangTuyen content = new();
            content.HienThi(new Ctrler_DanhSachThongTinDangTuyen("1"));
            SwitchContent(content);
        }
    public void SwitchContent(UserControl content)
    {
        _contentPanel.Controls.Clear();
        _contentPanel.Controls.Add(content);
        content.Dock = DockStyle.Fill;
        content.BringToFront();
    }
    public static GUI_NhanVienNghiepVu Instance => _instance ??= new GUI_NhanVienNghiepVu();

    }

