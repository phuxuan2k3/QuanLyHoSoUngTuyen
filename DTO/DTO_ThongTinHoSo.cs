namespace DTO
{
    public class DTO_ThongTinHoSo(string maUV = "", string maTTDT = "", int uuTien = 0, string viTri = "", string bangCap = "", string trangThai = "")
    {
        public string MaUV { get; set; } = maUV;
        public string MaTTDT { get; set; } = maTTDT;
        public int UuTien { get; set; } = uuTien;
        public string ViTri { get; set; } = viTri;
        public string BangCap { get; set; } = bangCap;
        public string TrangThai { get; set; } = trangThai;
    }
}
