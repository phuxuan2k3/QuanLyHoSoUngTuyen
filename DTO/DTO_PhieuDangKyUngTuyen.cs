namespace DTO
{
    public enum TrangThaiPhieuDangKyUngTuyen
    {
        ChuaXetDuyet,
        KhongHopLe,
        HopLe,
        DaXuLy,
        Dat,
    }

    public class DTO_PhieuDangKyUngTuyen(TrangThaiPhieuDangKyUngTuyen trangThai, string maTTDT = "", string maUV = "" )
    {
        public string MaTTDT { get; set; } = maTTDT;
        public string MaUV { get; set; } = maUV;
        public TrangThaiPhieuDangKyUngTuyen TrangThai { get; set; } = trangThai;
    }
}

