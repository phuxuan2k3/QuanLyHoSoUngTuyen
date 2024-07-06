using BUS;
using DAO;
using DTO;

namespace Ctrler;

public class Ctrler_ThongTinPhieuDangKy
{
    private readonly string _maUV;
    private readonly string _maTTDT;


    public Ctrler_ThongTinPhieuDangKy(string maTTDT,string maUV)
    {
        _maUV = maUV;
        _maTTDT = maTTDT;
    }

    public void ThongTinDuyet(ref DTO_ThongTinDangTuyen ttdt, ref DTO_ThongTinHoSo pdk)
    {
        pdk = DAO_PhieuDangKyUngTuyen.LayThongTinDangTuyenTheoMaUV(_maTTDT, _maUV);

        ttdt = DAO_ThongTinDangTuyen.LayThongTinDangTuyen(_maTTDT);
    }

}
