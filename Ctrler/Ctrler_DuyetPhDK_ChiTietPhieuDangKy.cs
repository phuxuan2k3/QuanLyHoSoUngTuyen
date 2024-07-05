using BUS;
using DTO;

namespace Ctrler;
public class Ctrler_DuyetPhDk_ChiTietPhieuDangKy
{

    private readonly DTO_ThongTinDangTuyen _thongTinDangTuyen;
    private readonly DTO_ThongTinHoSo _thongTinHoSo;

    public Ctrler_DuyetPhDk_ChiTietPhieuDangKy(DTO_ThongTinDangTuyen thongTinDangTuyen, DTO_ThongTinHoSo thongTinHoSo)
    {
        _thongTinHoSo = thongTinHoSo;
        _thongTinDangTuyen = thongTinDangTuyen;
    }
    public void Load(ref DTO_ThongTinDangTuyen thongTinDangTuyen, ref DTO_ThongTinHoSo thongTinHoSo)
    {
        thongTinDangTuyen = _thongTinDangTuyen;
        thongTinHoSo = _thongTinHoSo;
    }
    
}
