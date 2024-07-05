using Ctrler;
using DTO;
using GUI.GUIException;

namespace GUI.UC;

public partial class GUI_DanhSachThongTinDangTuyen : UserControl
{
    private Ctrler_DanhSachThongTinDangTuyen? _ctrler_DanhSachThongTinDangTuyen;

    public Ctrler_DanhSachThongTinDangTuyen Ctrler_DanhSachThongTinDangTuyen
    {
        get => _ctrler_DanhSachThongTinDangTuyen ?? throw new ControllerNotFoundException();
        set => _ctrler_DanhSachThongTinDangTuyen = value;
    }

    public GUI_DanhSachThongTinDangTuyen()
    {
        InitializeComponent();
    }

    public void HienThi(Ctrler_DanhSachThongTinDangTuyen ctrler_DanhSachThongTinDangTuyen)
    {
        _ctrler_DanhSachThongTinDangTuyen = ctrler_DanhSachThongTinDangTuyen;
        var dsTTDT = new List<DTO_ThongTinDangTuyen>();
        Ctrler_DanhSachThongTinDangTuyen.Load(ref dsTTDT);
        foreach (var ttdt in dsTTDT)
        {
            int rowId = dsThongTinDangTuyen.Rows.Add();
            DataGridViewRow row = dsThongTinDangTuyen.Rows[rowId];
            row.Cells["_id"].Value = ttdt.MaTTDT;
            row.Cells["_viTri"].Value = ttdt.TenViTri;
            row.Cells["_soLuong"].Value = ttdt.SoLuong;
            row.Cells["_thoiGianDang"].Value = ttdt.ThoiGianDangTuyen;
            row.Cells["_soNgayDang"].Value = ttdt.SoNgayDangTuyen;
            row.Cells["_trangThai"].Value = ttdt.TrangThai;
            row.Cells["_tinhTrang"].Value = ttdt.TinhTrang;
        }
    }

	private void dsThongTinDangTuyen_CellClick(object sender, DataGridViewCellEventArgs e)
	{
		if (dsThongTinDangTuyen.Rows[e.RowIndex].Cells["_id"].Value is string maTTDT)
		{
			var ctrler = Ctrler_DanhSachThongTinDangTuyen.ChiTietThongTinDangTuyen(maTTDT);
			GUI_DuyetPhDK_ChiTietThongTinDangTuyen content = new();
			content.HienThi(ctrler);
			GUI_Base.Instance.SwitchContent(content);
		}
	}
}
