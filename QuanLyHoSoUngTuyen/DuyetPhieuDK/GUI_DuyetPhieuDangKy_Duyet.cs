using Ctrler;
using DTO;


namespace GUI
{
    public partial class GUI_DuyetPhieuDangKy_Duyet : UserControl
    {
        private Ctrler_ThongTinPhieuDangKy _ctrler_ChiTietPhieuDangKy;
        public GUI_DuyetPhieuDangKy_Duyet()
        {
            InitializeComponent();
        }

        public void HienThi(Ctrler_ThongTinPhieuDangKy ctrler_ChiTietPhieuDangKy)
        {
            _ctrler_ChiTietPhieuDangKy = ctrler_ChiTietPhieuDangKy;
            DTO_ThongTinDangTuyen ttdt = new DTO_ThongTinDangTuyen();
            DTO_ThongTinHoSo pdk = new DTO_ThongTinHoSo();
            ctrler_ChiTietPhieuDangKy.ThongTinDuyet(ref ttdt, ref pdk);

            _MaTTDT.Text = ttdt.MaTTDT;
            _ViTri_DT.Text = ttdt.TenViTri;
            _SoLuong.Text = ttdt.SoLuong.ToString();
            _YeuCau.Text = ttdt.YeuCau;
            _MoTa.Text = ttdt.TinhTrang.ToString();

            _MaUV.Text = pdk.MaUV;
            _ViTri.Text = pdk.ViTri;
            _bangCaps.Text = pdk.BangCap;
            _uuTien.Text = pdk.UuTien.ToString();
            cbxTinhTrang.Text = pdk.TrangThai.ToString();

        }

        public static List<DTO_ThongTinHoSo> SapXepDanhSachTheoUuTien(List<DTO_ThongTinHoSo> dsPhDK)
        {
            var daXuLyList = dsPhDK.Where(p => p.TrangThai == "Đã xử lý").OrderBy(p => p.UuTien).ToList();

            var khacList = dsPhDK.Where(p => p.TrangThai != "Đã xử lý").ToList();

            return daXuLyList.Concat(khacList).ToList();
        }


        private void btnLuu_Click(object sender, EventArgs e)
        {
            DTO_ThongTinHoSo ttpdk = new DTO_ThongTinHoSo
            {
                MaUV = _MaUV.Text,
                MaTTDT = _MaTTDT.Text,
                UuTien = int.Parse(_uuTien.Text),
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
                var ctrler = Ctrler_DanhSachThongTinDangTuyen.ChiTietThongTinDangTuyen(ttpdk.MaTTDT);
                GUI_DuyetPhieuDangKy_ChiTietThongTinDangTuyen content = new();
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

                // Sắp xếp danh sách theo ưu tiên
                dsPhDK = SapXepDanhSachTheoUuTien(dsPhDK);

                // Cập nhật lại DataGridView với danh sách đã sắp xếp
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
                GUI_NhanVienNghiepVu.Instance.SwitchContent(content);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
