using Ctrler;
using DTO;
using GUI.GUIException;

namespace GUI.UC;

public partial class GUI_DuyetPhDK_ChiTietThongTinDangTuyen : UserControl
{
    private Ctrler_DuyetPhDk_ChiTietThongTinDangTuyen? _ctrler_ChiTietThongTinDangTuyen;

    public GUI_DuyetPhDK_ChiTietThongTinDangTuyen()
    {
        InitializeComponent();
    }

    public Ctrler_DuyetPhDk_ChiTietThongTinDangTuyen Ctrler_ChiTietThongTinDangTuyen
    {
        get => _ctrler_ChiTietThongTinDangTuyen ?? throw new ControllerNotFoundException();
        private set => _ctrler_ChiTietThongTinDangTuyen = value;
    }
    public void HienThi(Ctrler_DuyetPhDk_ChiTietThongTinDangTuyen ctrler_ChiTietThongTinDangTuyen)
    {
        _ctrler_ChiTietThongTinDangTuyen = ctrler_ChiTietThongTinDangTuyen;
        DTO_ThongTinDangTuyen ttdt = new();
        List<DTO_PhieuDangKyUngTuyen> ttpdk = new();
        ctrler_ChiTietThongTinDangTuyen.Load(ref ttdt, ref ttpdk);
        _MaTTDT.Text = ttdt.MaTTDT;
        _ViTri.Text = ttdt.TenViTri;
        _SoLuong.Text = ttdt.SoLuong.ToString();
        _YeuCau.Text = ttdt.YeuCau;
        _MoTa.Text = ttdt.TinhTrang.ToString();
        foreach (var pdk in ttpdk)
        {
            int rowId = dsPhieuDangKy.Rows.Add();
            DataGridViewRow row = dsPhieuDangKy.Rows[rowId];
            row.Cells["_id"].Value = pdk.MaUV;
            row.Cells["_trangThai"].Value = pdk.TrangThai;

            //row.Cells["_hoTen"].Value;

        }
    }

    private void dsPhieuDangKy_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
       if (dsPhieuDangKy.Rows[e.RowIndex].Cells["_id"].Value is string maUV)
        {
            var ctrler = Ctrler_DuyetPhDk_ChiTietThongTinDangTuyen.ChiTietThongTinPhieuDangKy(_MaTTDT,maUV);
            GUI_DuyetPhDK_ChiTietThongTinDangTuyen content = new();
            content.HienThi(ctrler);
            GUI_Base.Instance.SwitchContent(content);
        }
    }
}