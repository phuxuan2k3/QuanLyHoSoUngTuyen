using DAO;
using DTO;

namespace BUS
{
    public class BUS_ThongTinUngVien
    {
        public static DTO_ThongTinHoSo LayTTUV(string TTDT,string MaUV)
        {
            return DAO_ThongTinHoSo.LayTTUV(TTDT,MaUV);
        }
    }
}
