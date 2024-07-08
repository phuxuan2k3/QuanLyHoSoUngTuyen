using Ctrler;
using Ctrler.DoanhNghiep;
using DTO;
using GUI.GUIException;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class GUI_DuyetPhieuDangKy_DanhSachThongTinDangTuyen : UserControl
    {
        private Ctrler_DanhSachThongTinDangTuyen? _ctrler_DanhSachThongTinDangTuyen;

        private Ctrler_DanhSachThongTinDangTuyen Ctrler_DanhSachThongTinDangTuyen
        {
            get => _ctrler_DanhSachThongTinDangTuyen ?? throw new ControllerNotFoundException();
            set => _ctrler_DanhSachThongTinDangTuyen = value;
        }

        public GUI_DuyetPhieuDangKy_DanhSachThongTinDangTuyen()
        {
            InitializeComponent();
        }

        private void dsThongTinDangTuyen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dsThongTinDangTuyen.Rows[e.RowIndex].Cells["_maTTDT"].Value is string maTTDT)
            {
                var ctrler = Ctrler_DuyetPhieuDangKy_DanhSachThongTinDangTuyen.HienThi_ChiTiet(maTTDT);
                GUI_DuyetPhieuDangKy_ChiTietThongTinDangTuyen content = new();
                content.HienThi(ctrler);
                GUI_NhanVienNghiepVu.Instance.SwitchContent(content);
                //GUI_NhanVienNghiepVu.Instance.SwitchContent(content);

            }
        }
        public void HienThi(Ctrler_DanhSachThongTinDangTuyen ctrler_DanhSachThongTinDangTuyen)
        {
            _ctrler_DanhSachThongTinDangTuyen = ctrler_DanhSachThongTinDangTuyen;
            var dsTTDT = new List<DTO_DuyetPhieuDangKy_ThongTinDangTuyen>();
            dsTTDT = Ctrler_DanhSachThongTinDangTuyen.LayDSThongTinDangTuyenDuyetPDK();
            foreach (var ttdt in dsTTDT)
            {
                int rowId = dsThongTinDangTuyen.Rows.Add();
                DataGridViewRow row = dsThongTinDangTuyen.Rows[rowId];
                row.Cells["_maTTDT"].Value = ttdt.MaTTDT;
                row.Cells["_maDN"].Value = ttdt.MaDN;
                row.Cells["_soLuong"].Value = ttdt.SoLuong;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            GUI_DuyetPhieuDangKy_DanhSachThongTinDangTuyen content = new();
            content.HienThi(new Ctrler_DanhSachThongTinDangTuyen(""));
            GUI_NhanVienNghiepVu.Instance.SwitchContent(content);
        }
    }
}
