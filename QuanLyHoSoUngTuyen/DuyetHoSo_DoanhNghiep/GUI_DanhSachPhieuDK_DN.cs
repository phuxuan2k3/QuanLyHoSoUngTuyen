using Ctrler;
using DTO;
using GUI.GUIException;
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

public partial class GUI_DanhSachPhieuDK_DN : UserControl
{
    private Ctrler_ChiTietThongTinDangTuyen? _ctrler_ChiTietThongTinDangTuyen;

    public GUI_DanhSachPhieuDK_DN()
    {
        InitializeComponent();
    }
    public Ctrler_ChiTietThongTinDangTuyen Ctrler_ChiTietThongTinDangTuyen
    {
        get => _ctrler_ChiTietThongTinDangTuyen ?? throw new ControllerNotFoundException();
        private set => _ctrler_ChiTietThongTinDangTuyen = value;
    }
    public void HienThi(Ctrler_ChiTietThongTinDangTuyen ctrler_ChiTietThongTinDangTuyen)
    {
        _ctrler_ChiTietThongTinDangTuyen = ctrler_ChiTietThongTinDangTuyen;
        DTO_ThongTinDangTuyen ttdt = new();
        List<DTO_ThongTinHoSo> ttpdk = new();
        ctrler_ChiTietThongTinDangTuyen.DanhSachHoSo(ref ttdt, ref ttpdk);
       
        lbTTDT.Text = "Mã TTDT: " + ttdt.MaTTDT.ToString();
        foreach (var pdk in ttpdk)
        {
            int rowId = dsPhieuDangKy.Rows.Add();
            DataGridViewRow row = dsPhieuDangKy.Rows[rowId];
            row.Cells["_maUV"].Value = pdk.MaUV;
            row.Cells["_trangThai"].Value = pdk.TrangThai;
            row.Cells["_uuTien"].Value = 0;
        }

    }

    private void dsPhieuDangKy_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        if (dsPhieuDangKy.Rows[e.RowIndex].Cells["_maUV"].Value is string maUV)
        {
            string[] parts = lbTTDT.Text.Split(':');
            if (parts.Length > 1 && int.TryParse(parts[1].Trim(), out int maTTDT))
            {
                var ctrler = new Ctrler_ThongTinPhieuDangKy(maTTDT.ToString(), maUV);
                GUI_DuyetPhieuDangKy_DN content = new();
                content.HienThi(ctrler);
                GUI_NhanVienNghiepVu.Instance.SwitchContent(content);
            }


        }
    }
}
