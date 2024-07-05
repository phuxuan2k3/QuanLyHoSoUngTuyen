using Ctrler;
using DAO;
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
    public partial class GUI_DanhSachTTDTCanXetDuyet : UserControl
    {
        public GUI_DanhSachTTDTCanXetDuyet()
        {
            InitializeComponent();
        }



        private Ctrler_DanhSachThongTinDangTuyen? _ctrler_DanhSachThongTinDangTuyen;


        public Ctrler_DanhSachThongTinDangTuyen Ctrler_DanhSachThongTinDangTuyen
        {
            get => _ctrler_DanhSachThongTinDangTuyen ?? throw new ControllerNotFoundException();
            set => _ctrler_DanhSachThongTinDangTuyen = value;
        }


        public void HienThi(Ctrler_DanhSachThongTinDangTuyen ctrler_DanhSachThongTinDangTuyen)
        {
            _ctrler_DanhSachThongTinDangTuyen = ctrler_DanhSachThongTinDangTuyen;
            var dsTTDT = new List<DTO_ThongTinDangTuyen>();
            Ctrler_DanhSachThongTinDangTuyen.LoadTTDTXD(ref dsTTDT);
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
                var ctrler = Ctrler_DanhSachThongTinDangTuyen.ChiTietThongTinDangTuyenXD(maTTDT);
                GUI_XetDuyetThongTinDangTuyen content = new();
                content.HienThi(ctrler);
                GUI_Base.Instance.SwitchContent(content);
            }
        }


    }



    
}
