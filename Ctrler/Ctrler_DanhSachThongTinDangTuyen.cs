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
    public static Ctrler_ChiTietThongTinDangTuyen ChiTietThongTinDangTuyen(string maTTDT)
    {
        var ttdt = BUS_ThongTinDangTuyen.LayThongTinDangTuyen(maTTDT);

        return new Ctrler_ChiTietThongTinDangTuyen(ttdt);
    }
    
    
    //public void LoadTTDTXD(ref List<DTO_ThongTinDangTuyen> thongTinDangTuyen)
    //{
    //	thongTinDangTuyen = BUS_ThongTinDangTuyen.LayDSTTDTXD();
    //}

    //public void LoadTTDTHopLe(ref List<DTO_ThongTinDangTuyen> thongTinDangTuyen)
    //{
    //	thongTinDangTuyen = BUS_ThongTinDangTuyen.LayDSTTDTHopLe();
    //}

    public Ctrler_ChiTietThongTinDangTuyen HienThi_ChiTiet(string maTTDT)
	{
		var ttdt = BUS_ThongTinDangTuyen.Lay(maTTDT);
		var hoaDon = BUS_HoaDon.Lay(maTTDT);
		var hinhThucDangTuyen = BUS_HinhThucDangTuyen.Lay(ttdt.MaHTDT);
		return new Ctrler_ChiTietThongTinDangTuyen(ttdt, hoaDon, hinhThucDangTuyen);
	}

    //public Ctrler_XetDuyetThongTinDangTuyen ChiTietThongTinDangTuyenXD(string maTTDT)
    //{
    //	var ttdt = BUS_ThongTinDangTuyen.Lay(maTTDT);
    //	var hoaDon = BUS_HoaDon.Lay(maTTDT);
    //	var hinhThucDangTuyen = BUS_HinhThucDangTuyen.Lay(ttdt.MaHTDT);
    //	var doanhNghiep = BUS_DoanhNghiep.LoadTTDN(ttdt.MaDN);
    //	return new Ctrler_XetDuyetThongTinDangTuyen(ttdt, hoaDon, hinhThucDangTuyen, doanhNghiep, this);
    //}

    //public Ctrler_DangTuyenThongTinDangTuyen ChiTietThongTinDangTuyenHopLe(string maTTDT)
    //{
    //	var ttdt = BUS_ThongTinDangTuyen.Lay(maTTDT);
    //	var hoaDon = BUS_HoaDon.Lay(maTTDT);
    //	var hinhThucDangTuyen = BUS_HinhThucDangTuyen.Lay(ttdt.MaHTDT);
    //	var doanhNghiep = BUS.BUS_DoanhNghiep.LoadTTDN(ttdt.MaDN);
    //	return new Ctrler_DangTuyenThongTinDangTuyen(ttdt, hoaDon, hinhThucDangTuyen, doanhNghiep, this);
    //}
    public static List<DTO_DuyetPhieuDangKy_ThongTinDangTuyen> LayDSThongTinDangTuyenDuyetPDK()
    {
        return BUS_ThongTinDangTuyen.LayDSThongTinDangTuyenDuyetPDK();

    }
    public static List<DTO_DuyetPhieuDangKy_ThongTinDangTuyen> LayDSThongTinDangTuyenChoDNDuyet()
    {
        return BUS_ThongTinDangTuyen.LayDSThongTinDangTuyenChoDNDuyet();

    }
    public static Ctrler_ChiTietThongTinDangTuyen LayThongTinDangTuyen(string maTTDT)
    {
        var ttdt = BUS_ThongTinDangTuyen.LayThongTinDangTuyen(maTTDT);

        return new Ctrler_ChiTietThongTinDangTuyen(ttdt);
    }
}
