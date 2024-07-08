﻿using Ctrler.DoanhNghiep;
using Ctrler.NhanVienTiepNhan;
using GUI.Styles;
using GUI.UserControls;

namespace GUI;

public partial class GUI_DoanhNghiep : Form
{
    // todo: Thay bang tai khoan duoc dang nhap
    private string _maDN = "1";
    public string MaDN { get => _maDN; set => _maDN = value; }

    public GUI_DoanhNghiep()
    {
        Style.ApplyStylingEventOnChildControlAdded(this, ButtonStyle.Apply);
        _instance = this;
        InitializeComponent();
    }

    private void btnTaoYeuCau_Click(object sender, EventArgs e)
    {
        var gui = new GUI_DienThongTinDangTuyen();
        gui.HienThi(new Ctrler_DienThongTinDangTuyen());
        SwitchContent(gui);
    }

    private void btnDanhSachThongTinDangTuyen_Click(object sender, EventArgs e)
    {
        var gui = new GUI_DanhSachThongTinDangTuyen();
        gui.HienThi(new Ctrler_DanhSachThongTinDangTuyen(_maDN));
        SwitchContent(gui);
    }

    public void SwitchContent(UserControl content)
    {
        _contentPanel.Controls.Clear();
        _contentPanel.Controls.Add(content);
        content.Dock = DockStyle.Fill;
    }

    private static GUI_DoanhNghiep? _instance = null;



    private void btnXacThucDN_Click(object sender, EventArgs e)
    {
        GUI_XacThucThongTinDoanhNghiep content = new();
        content.HienThi();
        SwitchContent(content);
    }

    private void btnXetDuyetTTDT_Click(object sender, EventArgs e)
    {
        GUI_DanhSachTTDTCanXetDuyet content = new();
        content.HienThi(new Ctrler_DanhSachTTDTCanXetDuyet());
        SwitchContent(content);
    }



    private void btnCapNhatTTDN_Click(object sender, EventArgs e)
    {
        GUI_CapNhatThongTinDoanhNghiep content = new();
        content.HienThi("123568");
        SwitchContent(content);
    }

    private void btnDuyetHoSo_Click(object sender, EventArgs e)
    {
        GUI_DanhSachThongTinDangTuyen_DN content = new();
        content.HienThi(new Ctrler_DanhSachThongTinDangTuyen(""));
        SwitchContent(content);
    }

    public static GUI_DoanhNghiep Instance => _instance ??= new GUI_DoanhNghiep();
}
