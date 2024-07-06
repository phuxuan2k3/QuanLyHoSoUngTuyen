namespace DTO
{

    public class DTO_DuyetPhieuDangKy_ThongTinDangTuyen(string maTTDT = "", string maDN = "", int soLuong = 1)
    {
        public string MaTTDT { get; set; } = maTTDT;
        public string MaDN { get; set; } = maDN;
        public int SoLuong { get; set; } = soLuong;
    }
}
