using BUS;
using DTO;

namespace Ctrler.DoanhNghiep;

public class Ctrler_DienThongTinDangTuyen
{
    private DTO_ThongTinDangTuyen thongTinDangTuyen;

    public Ctrler_DienThongTinDangTuyen(DTO_ThongTinDangTuyen? thongTinDangTuyen = null)
    {
        this.thongTinDangTuyen = thongTinDangTuyen ?? new DTO_ThongTinDangTuyen();
    }

    public void Load(ref DTO_ThongTinDangTuyen thongTinDangTuyen, ref List<DTO_HinhThucDangTuyen> dsHinhThucDangTuyen)
    {
        thongTinDangTuyen = this.thongTinDangTuyen;
        dsHinhThucDangTuyen = BUS_HinhThucDangTuyen.LayTatCa();
    }
}
