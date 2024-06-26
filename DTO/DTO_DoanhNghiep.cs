namespace DTO
{
    public enum TrangThaiDoanhNghiep
    {
        ChuaXacThuc,
        KhongHopLe,
        HopLe,
        TiemNang
    }

    public class DTO_DoanhNghiep(string maDN = "", string tenDN = "", string maSoThue = "", string nguoiDaiDien = "", string diaChi = "", string email = "", TrangThaiDoanhNghiep trangThai = TrangThaiDoanhNghiep.ChuaXacThuc, DateTime? ngayDangKy = null, string tenTaiKhoan ="")
    {
        public string MaDN { get; set; } = maDN;
        public string TenDN { get; set; } = tenDN;
        public string MaSoThue { get; set; } = maSoThue;
        public string NguoiDaiDien { get; set; } = nguoiDaiDien;
        public string DiaChi { get; set; } = diaChi;
        public string Email { get; set; } = email;
        public TrangThaiDoanhNghiep TrangThai { get; set; } = trangThai;
        public DateTime? NgayDangKy { get; set; } = ngayDangKy;
        public string TenTaiKhoan { get; set; } = tenTaiKhoan;
    }
}
