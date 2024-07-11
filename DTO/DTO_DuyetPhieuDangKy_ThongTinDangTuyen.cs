namespace DTO
{

    public class DTO_DuyetPhieuDangKy_ThongTinDangTuyen(string maTTDT = "", string tenDN = "",string tenViTri = "", int soLuong = 1)
    {
        public string MaTTDT { get; set; } = maTTDT;
        public string TenDoanhNghiep { get; set; } = tenDN;
        public string TenViTri { get; set; } = tenViTri;
        public int SoLuong { get; set; } = soLuong;
    }
}
