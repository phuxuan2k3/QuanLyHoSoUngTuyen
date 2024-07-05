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
    public partial class GUI_XetDuyetThongTinDangTuyen : UserControl
    {
        private Ctrler_XetDuyetThongTinDangTuyen? _ctrler_ChiTietThongTinDangTuyen;

        public GUI_XetDuyetThongTinDangTuyen()
        {
            InitializeComponent();
        }

        public Ctrler_XetDuyetThongTinDangTuyen Ctrler_ChiTietThongTinDangTuyen
        {
            get => _ctrler_ChiTietThongTinDangTuyen ?? throw new ControllerNotFoundException();
            private set => _ctrler_ChiTietThongTinDangTuyen = value;
        }

        public void HienThi(Ctrler_XetDuyetThongTinDangTuyen ctrler_ChiTietThongTinDangTuyen)
        {
            _ctrler_ChiTietThongTinDangTuyen = ctrler_ChiTietThongTinDangTuyen;
            DTO_ThongTinDangTuyen ttdt = new();
            DTO_HoaDon hoaDon = new();
            DTO_HinhThucDangTuyen hinhThucDangTuyen = new();
            DTO_DoanhNghiep doanhnghiep = new();
            Ctrler_ChiTietThongTinDangTuyen.Load2(ref ttdt,ref hoaDon, ref hinhThucDangTuyen, ref doanhnghiep);
            _TenDN.Text = doanhnghiep.TenDN.ToString();
            _maTTDT.Text = ttdt.MaTTDT;
            _soNgayDangTuyen.Text = ttdt.SoNgayDangTuyen.ToString();
            _thoiGianDangTuyen.Text = ttdt.ThoiGianDangTuyen.ToString("dd/MM/yyyy") ?? "";
            _hinhThuc.Text = hinhThucDangTuyen.TenHinhThuc.ToString();
            _tenViTri.Text = ttdt.TenViTri;
            _soLuong.Text = ttdt.SoLuong.ToString();
            _yeuCau.Text = ttdt.YeuCau;
            _trangThai.Text = ttdt.TrangThai.ToString();
            _hoaDon.Text = hoaDon.TrangThaiThanhToan.ToString();
            _tinhTrang.Text = ttdt.TinhTrang.ToString();
        }

        private void btnXetDuyet_Click(object sender, EventArgs e)
        {
            Ctrler_XetDuyetThongTinDangTuyen.CapNhatTrangThaiTTDT(_maTTDT.Text, "Hợp lệ");
        }

        private void btnTuChoi_Click(object sender, EventArgs e)
        {
            Ctrler_XetDuyetThongTinDangTuyen.CapNhatTrangThaiTTDT(_maTTDT.Text, "Không hợp lệ");
        }
    

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            GUI_DanhSachTTDTCanXetDuyet content = new();
            GUI_Base.Instance.SwitchContent(content);
            content.HienThi(Ctrler_ChiTietThongTinDangTuyen.Owner);
        }
    }
}
