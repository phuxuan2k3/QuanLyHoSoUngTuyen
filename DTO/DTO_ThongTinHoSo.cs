namespace DTO
{
    public class DTO_ThongTinHoSo(string maUV="",string maTTDT="", int uuTien = 0, string viTri = "", string bangCap = "", TrangThaiPhieuDangKyUngTuyen trangThai = TrangThaiPhieuDangKyUngTuyen.HopLe)
    {
        public string MaUV { get; set; } = maUV;
        public string MaTTDT { get; set; } = maTTDT;
        public int UuTien { get; set; } = uuTien;
        public string BangCap { get; set; } = bangCap;
        public TrangThaiPhieuDangKyUngTuyen TrangThai { get; set; } = trangThai;
    }
}
