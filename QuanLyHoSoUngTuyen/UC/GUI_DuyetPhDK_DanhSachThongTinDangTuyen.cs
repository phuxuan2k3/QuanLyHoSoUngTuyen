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

namespace GUI.UC
{
    public partial class GUI_DuyetPhDK_DanhSachThongTinDangTuyen : UserControl
    {
        private Ctrler_DanhSachThongTinDangTuyen? _ctrler_DanhSachThongTinDangTuyen;

        private Ctrler_DanhSachThongTinDangTuyen Ctrler_DanhSachThongTinDangTuyen
        {
            get => _ctrler_DanhSachThongTinDangTuyen ?? throw new ControllerNotFoundException();
            set => _ctrler_DanhSachThongTinDangTuyen = value;
        }
        public GUI_DuyetPhDK_DanhSachThongTinDangTuyen()
        {
            InitializeComponent();
        }
        public void HienThi(Ctrler_DanhSachThongTinDangTuyen ctrler_DanhSachThongTinDangTuyen)
        {
            _ctrler_DanhSachThongTinDangTuyen = ctrler_DanhSachThongTinDangTuyen;
            var dsTTDT = new List<DTO_ThongTinDangTuyen>();
            Ctrler_DanhSachThongTinDangTuyen.LoadTTDTDuyet(ref dsTTDT);
            foreach (var ttdt in dsTTDT)
            {
                int rowId = dsThongTinDangTuyen.Rows.Add();
                DataGridViewRow row = dsThongTinDangTuyen.Rows[rowId];
                row.Cells["_id"].Value = ttdt.MaTTDT;
                row.Cells["_thoiGianDang"].Value = ttdt.ThoiGianDangTuyen;
                row.Cells["_soNgayDang"].Value = ttdt.SoNgayDangTuyen;
            }
        }


        /*private void dsThongTinDangTuyen_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dsThongTinDangTuyen.Rows[e.RowIndex].Cells["_id"].Value is string maTTDT)
            {
                var ctrler = Ctrler_DanhSachThongTinDangTuyen.ChiTietThongTinDangTuyen(maTTDT);
                GUI_DuyetPhDK_ChiTietThongTinDangTuyen content = new();
                content.HienThi(ctrler);
                GUI_Base.Instance.SwitchContent(content);
            }
        }*/

        private void dsThongTinDangTuyen_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
}
