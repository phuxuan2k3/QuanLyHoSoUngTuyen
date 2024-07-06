namespace DTO
{
    public enum TrangThaiDoanhNghiep
    {
        ChuaXacThuc,
        KhongHopLe,
        HopLe,
        TiemNang
    }

    public static class TrangThaiDoanhNghiepConvert
    {
        public static string GetString(this TrangThaiDoanhNghiep ttdn)
        {
            switch (ttdn)
            {
                case TrangThaiDoanhNghiep.KhongHopLe:
                    return "Không hợp lệ";
                case TrangThaiDoanhNghiep.HopLe:
                    return "Hợp lệ";
                case TrangThaiDoanhNghiep.TiemNang:
                    return "Tiềm năng";
                default:
                    return "Chưa xác thực";
            }
        }

        public static TrangThaiDoanhNghiep GetTrangThaiEnum(string ttdn)
        {
            switch (ttdn)
            {
                case "Không hợp lệ":
                    return TrangThaiDoanhNghiep.KhongHopLe;
                case "Hợp lệ":
                    return TrangThaiDoanhNghiep.HopLe;
                case "Tiềm năng":
                    return TrangThaiDoanhNghiep.TiemNang;
                default:
                    return TrangThaiDoanhNghiep.ChuaXacThuc;
            }
        }
    }

    public class DTO_DoanhNghiep(string maDN = "", string tenDN = "", string maSoThue = "", string nguoiDaiDien = "", string diaChi = "", string email = "", TrangThaiDoanhNghiep trangThai = TrangThaiDoanhNghiep.ChuaXacThuc, DateTime? ngayDangKy = null, string tenTaiKhoan = "")
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
