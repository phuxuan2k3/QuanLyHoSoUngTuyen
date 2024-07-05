using BUS;
using DTO;

namespace Ctrler;

public class Ctrler_DanhSachThongTinDangTuyen
{
	private readonly string _maDN;

	public Ctrler_DanhSachThongTinDangTuyen(string maDN)
	{
		_maDN = maDN;
	}

	public void Load(ref List<DTO_ThongTinDangTuyen> thongTinDangTuyen)
	{
		thongTinDangTuyen = BUS_ThongTinDangTuyen.LayTatCaCuaDoanhNghiep(_maDN);
	}
    public void LoadTTDTDuyet(ref List<DTO_ThongTinDangTuyen> thongTinDangTuyen)
    {
        thongTinDangTuyen = BUS_ThongTinDangTuyen.LayDSTTDTDuyet();
    }
    public Ctrler_DuyetPhDk_ChiTietThongTinDangTuyen ChiTietThongTinDangTuyen(string maTTDT)
    {
        var ttdt = BUS_ThongTinDangTuyen.LayCTTTDT(maTTDT);

        return new Ctrler_DuyetPhDk_ChiTietThongTinDangTuyen(ttdt);
    }
}
