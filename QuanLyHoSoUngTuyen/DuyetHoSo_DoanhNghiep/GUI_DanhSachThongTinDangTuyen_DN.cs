﻿using Ctrler;
using Ctrler.DoanhNghiep;
using DTO;
using GUI.GUIException;
using Org.BouncyCastle.Asn1.Crmf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI;

public partial class GUI_DanhSachThongTinDangTuyen_DN : UserControl
{
    private Ctrler_DanhSachThongTinDangTuyen? _ctrler_DanhSachThongTinDangTuyen;

    private Ctrler_DanhSachThongTinDangTuyen Ctrler_DanhSachThongTinDangTuyen
    {
        get => _ctrler_DanhSachThongTinDangTuyen ?? throw new ControllerNotFoundException();
        set => _ctrler_DanhSachThongTinDangTuyen = value;
    }
    public GUI_DanhSachThongTinDangTuyen_DN()
    {
        InitializeComponent();
    }
    public void HienThi(Ctrler_DanhSachThongTinDangTuyen ctrler_DanhSachThongTinDangTuyen)
    {
        _ctrler_DanhSachThongTinDangTuyen = ctrler_DanhSachThongTinDangTuyen;
        var dsTTDT = new List<DTO_DuyetPhieuDangKy_ThongTinDangTuyen>();
        dsTTDT = Ctrler_DanhSachThongTinDangTuyen.LayDSThongTinDangTuyenChoDNDuyet();
        foreach (var ttdt in dsTTDT)
        {
            int rowId = dsThongTinDangTuyen.Rows.Add();
            DataGridViewRow row = dsThongTinDangTuyen.Rows[rowId];
            row.Cells["_maTTDT"].Value = ttdt.MaTTDT;
            row.Cells["_maDN"].Value = ttdt.MaDN;
            row.Cells["_soLuong"].Value = ttdt.SoLuong;
        }
    }

    private void dsThongTinDangTuyen_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        if (dsThongTinDangTuyen.Rows[e.RowIndex].Cells["_maTTDT"].Value is string maTTDT)
        {
            var ctrler = Ctrler_DanhSachThongTinDangTuyen.ChiTietThongTinDangTuyen(maTTDT);
            GUI_DanhSachPhieuDK_DN content = new();
            content.HienThi(ctrler);
            GUI_NhanVienNghiepVu.Instance.SwitchContent(content);

        }
    }
}