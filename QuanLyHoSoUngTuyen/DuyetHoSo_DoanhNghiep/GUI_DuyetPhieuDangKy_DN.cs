using Ctrler;
using Ctrler.DoanhNghiep;
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

public partial class GUI_DuyetPhieuDangKy_DN : UserControl
{
    private Ctrler_ThongTinPhieuDangKy _ctrler_ChiTietPhieuDangKy;

    public GUI_DuyetPhieuDangKy_DN()
    {
        InitializeComponent();
    }
    public void HienThi(Ctrler_ThongTinPhieuDangKy ctrler_ChiTietPhieuDangKy)
    {
        _ctrler_ChiTietPhieuDangKy = ctrler_ChiTietPhieuDangKy;
        DTO_ThongTinDangTuyen ttdt = new DTO_ThongTinDangTuyen();
        DTO_ThongTinHoSo pdk = new DTO_ThongTinHoSo();
        ctrler_ChiTietPhieuDangKy.ThongTinDuyet(ref ttdt, ref pdk);
        lbTTDT.Text = "Mã TTDT: " + ttdt.MaTTDT.ToString();
        lbTTDT.Tag = ttdt.MaTTDT.ToString();
        _MaUV.Text = pdk.MaUV;
        _viTri.Text = pdk.ViTri;
        _bangCap.Text = pdk.BangCap;
        cbxTinhTrang.Text = pdk.TrangThai.ToString();

    }

    private void lb1_Click(object sender, EventArgs e)
    {

    }

    private void lbTinhTrang_Click(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
        DTO_ThongTinHoSo ttpdk = new DTO_ThongTinHoSo
        {
            MaUV = _MaUV.Text,
            MaTTDT = Convert.ToString(lbTTDT.Tag),
            UuTien = 0,
            BangCap = "",
            TrangThai = cbxTinhTrang.Text,
        };

        try
        {
            // Cập nhật thông tin phiếu đăng ký
            Ctrler_ChiTietThongTinDangTuyen.CapNhatThongTinPhieuDangKy(ttpdk);
            GUI_DuyetPhieuDangKy_ChiTietThongTinDangTuyen.doUuTien = ttpdk.UuTien;
            MessageBox.Show("Lưu thay đổi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Lấy lại chi tiết thông tin đăng tuyển
            var ctrler = Ctrler_DuyetPhieuDangKy_DanhSachThongTinDangTuyen.HienThi_ChiTiet(ttpdk.MaTTDT);
            GUI_DanhSachPhieuDK_DN content = new();
            content.HienThi(ctrler);

            // Lấy danh sách phiếu đăng ký
            List<DTO_ThongTinHoSo> dsPhDK = new List<DTO_ThongTinHoSo>();
            foreach (DataGridViewRow row in content.dsPhieuDangKy.Rows)
            {
                dsPhDK.Add(new DTO_ThongTinHoSo
                {
                    MaUV = row.Cells["_maUV"].Value.ToString(),
                    TrangThai = row.Cells["_trangThai"].Value.ToString(),
                    UuTien = row.Cells["_uuTien"].Value != null ? Convert.ToInt32(row.Cells["_uuTien"].Value) : int.MaxValue // Gán giá trị ưu tiên cao nhất nếu null
                });
            }

            content.dsPhieuDangKy.Rows.Clear();
            foreach (var pdk in dsPhDK)
            {
                int rowId = content.dsPhieuDangKy.Rows.Add();
                DataGridViewRow row = content.dsPhieuDangKy.Rows[rowId];
                row.Cells["_maUV"].Value = pdk.MaUV;
                row.Cells["_trangThai"].Value = pdk.TrangThai;
                row.Cells["_uuTien"].Value = pdk.UuTien == int.MaxValue ? "" : pdk.UuTien.ToString(); // Hiển thị giá trị ưu tiên nếu có
            }

            // Hiển thị nội dung đã cập nhật
            GUI_DoanhNghiep.Instance.SwitchContent(content);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Đã có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnHuy_Click(object sender, EventArgs e)
    {
        string[] parts = lbTTDT.Text.Split(':');
        if (parts.Length > 1 && int.TryParse(parts[1].Trim(), out int maTTDT))
        {
            var ctrler = Ctrler_DuyetPhieuDangKy_DanhSachThongTinDangTuyen.HienThi_ChiTiet(maTTDT.ToString());
            GUI_DanhSachPhieuDK_DN content = new();
            content.HienThi(ctrler);
            GUI_DoanhNghiep.Instance.SwitchContent(content);
        }
    }
}
