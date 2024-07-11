using System.Runtime.CompilerServices;

namespace DTO
{
    public enum TrangThaiPhieuDangKyUngTuyen
    {
        ChuaXetDuyet,
        KhongHopLe,
        HopLe,
        DaXuLy,
        Dat,
        KhongDat
    }

    public static class TrangThaiPDKUTConvert
    {
        public static string GetString(this TrangThaiPhieuDangKyUngTuyen tt)
        {
            switch (tt)
            {
                case TrangThaiPhieuDangKyUngTuyen.KhongHopLe:
                    return "Không hợp lệ";
                case TrangThaiPhieuDangKyUngTuyen.HopLe:
                    return "Hợp lệ";
                case TrangThaiPhieuDangKyUngTuyen.DaXuLy:
                    return "Đã xử lý";
                case TrangThaiPhieuDangKyUngTuyen.Dat:
                    return "Đạt";
                case TrangThaiPhieuDangKyUngTuyen.KhongDat:
                    return "Không đạt";
                default:
                    return "Chưa xét duyệt";
            }
        }

        public static TrangThaiPhieuDangKyUngTuyen GetTrangThaiEnum(string ttdn)
        {
            switch (ttdn)
            {
                case "Không hợp lệ":
                    return TrangThaiPhieuDangKyUngTuyen.KhongHopLe;
                case "Hợp lệ":
                    return TrangThaiPhieuDangKyUngTuyen.HopLe;
                case "Đã xử lý":
                    return TrangThaiPhieuDangKyUngTuyen.DaXuLy;
                case "Đạt":
                    return TrangThaiPhieuDangKyUngTuyen.Dat;
                case "Không đạt":
                    return TrangThaiPhieuDangKyUngTuyen.KhongDat;
                default:
                    return TrangThaiPhieuDangKyUngTuyen.ChuaXetDuyet;
            }
        }
    }

    public class DTO_PhieuDangKyUngTuyen(TrangThaiPhieuDangKyUngTuyen trangThai, string maTTDT = "", string maUV = "")
    {
        public string MaTTDT { get; set; } = maTTDT;
        public string MaUV { get; set; } = maUV;
        public TrangThaiPhieuDangKyUngTuyen TrangThai { get; set; } = trangThai;
    }
}

