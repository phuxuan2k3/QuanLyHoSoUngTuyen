using Ctrler.DoanhNghiep;
using DTO;
using GUI.GUIException;

namespace GUI.UserControls;

public partial class GUI_DanhSachThongTinDangTuyen : UserControl
{
    private Ctrler_DanhSachThongTinDangTuyen? ctrler;

	private Ctrler_DanhSachThongTinDangTuyen Ctrler
	{
		get => ctrler ?? throw new ControllerNotFoundException();
		set => ctrler = value;
	}

    public GUI_DanhSachThongTinDangTuyen()
    {
        InitializeComponent();
    }

    public void HienThi(Ctrler_DanhSachThongTinDangTuyen ctrler_DanhSachThongTinDangTuyen)
    {
        ctrler = ctrler_DanhSachThongTinDangTuyen;
        var dsTTDT = new List<DTO_ThongTinDangTuyen>();
        Ctrler.Load(ref dsTTDT);
        foreach (var ttdt in dsTTDT)
        {
            int rowId = dsThongTinDangTuyen.Rows.Add();
            DataGridViewRow row = dsThongTinDangTuyen.Rows[rowId];
            row.Cells["_id"].Value = ttdt.MaTTDT;
            row.Cells["_viTri"].Value = ttdt.TenViTri;
            row.Cells["_soLuong"].Value = ttdt.SoLuong;
            row.Cells["_thoiGianDang"].Value = ttdt.ThoiGianDangTuyen;
            row.Cells["_soNgayDang"].Value = ttdt.SoNgayDangTuyen;
            row.Cells["_trangThai"].Value = ttdt.TrangThai.ToDisplayString();
            row.Cells["_tinhTrang"].Value = ttdt.TinhTrang.ToDisplayString();
        }
    }

	private void dsThongTinDangTuyen_CellClick(object sender, DataGridViewCellEventArgs e)
	{
		if (dsThongTinDangTuyen.Rows[e.RowIndex].Cells["_id"].Value is string maTTDT)
		{
			var ctrler = Ctrler.HienThi_ChiTiet(maTTDT);
			GUI_ChiTietThongTinDangTuyen content = new ();
			content.HienThi(ctrler);
			GUI_DoanhNghiep.Instance.SwitchContent(content);
		}
	}
}
