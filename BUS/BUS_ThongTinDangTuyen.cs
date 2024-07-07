﻿using DAO;
using DAO.Exceptions;
using DTO;
using System.Data.SqlClient;

namespace BUS;

public class BUS_ThongTinDangTuyen
{
	public static List<DTO_ThongTinDangTuyen> LayDanhSachTTDTSapHetHan()
	{
		var lsTTDT = DAO_ThongTinDangTuyen.LayDSTTDT();
		var lsTTDTSapHetHan = lsTTDT.Where(ttdt =>
		{
			var ngayHetHan = ttdt.ThoiGianDangTuyen.AddDays(ttdt.SoNgayDangTuyen);
			return (ngayHetHan - DateTime.Now).TotalDays < 3.0;
		}).ToList();
		return lsTTDTSapHetHan;
	}

	public static List<DTO_ThongTinDangTuyen> LayDanhSachTTDT(string maDN)
	{
		return DAO_ThongTinDangTuyen.LayTatCaCuaDoanhNghiep(maDN);
	}

	public static DTO_ThongTinDangTuyen Lay(string maTTDT)
	{
		return DAO_ThongTinDangTuyen.Lay(maTTDT);
	}

	public static List<DTO_ThongTinDangTuyen> LayTatCaCuaDoanhNghiep(string maDN)
	{
		return DAO_ThongTinDangTuyen.LayTatCaCuaDoanhNghiep(maDN);
	}

	public static List<DTO_ThongTinDangTuyen> LayDSTTDTCanXetDuyet()
	{
		return DAO_ThongTinDangTuyen.LayTTDTCanXetDuyet();
	}

	public static List<DTO_ThongTinDangTuyen> LayDSTTDTHopLe()
	{
		return DAO_ThongTinDangTuyen.LoadTTDTHopLe();
	}

	private static bool KiemTra(DTO_ThongTinDangTuyen thongTinDangTuyen)
	{
		if (thongTinDangTuyen.SoNgayDangTuyen < 1 ||
			string.IsNullOrEmpty(thongTinDangTuyen.TenViTri) == true ||
			thongTinDangTuyen.SoLuong < 1 ||
			string.IsNullOrEmpty(thongTinDangTuyen.YeuCau) == true)
		{
			return false;
		}
		try
		{
			DAO_HinhThucDangTuyen.Lay(thongTinDangTuyen.MaHTDT);
		}
		catch (NullDatarowException)
		{
			return false;
		}
		return true;
	}

	public static int Them(DTO_ThongTinDangTuyen thongTinDangTuyen)
	{
		if (KiemTra(thongTinDangTuyen) == false)
		{
			return -1;
		}
		return DAO_ThongTinDangTuyen.Them(thongTinDangTuyen);
	}
	
	public static void CapNhat(DTO_ThongTinDangTuyen thongTinDangTuyen)
	{
		if (KiemTra(thongTinDangTuyen) == false)
		{
			return;
		}
		DAO_ThongTinDangTuyen.CapNhat(thongTinDangTuyen);
	}

	public static void CapNhatTrangThaiXetDuyet(string MaTTDT, string tinhTrang)
	{
		DAO_ThongTinDangTuyen.CapNhatTrangThaiTTDT(MaTTDT, tinhTrang);

	}

	public static void CapNhatTinhTrangDangTuyen(string MaTTDT)
	{
		DAO_ThongTinDangTuyen.CapNhatTrangThaiDangTuyen(MaTTDT);
	}

    public static int KiemTraViTriUngTuyen(string value)
    {
        Boolean check = DAO_ThongTinDangTuyen.check_Vitri(value);
        if (check == true)
        {
            return 1;
        }
        else
        {
            return 0;
        }

    }
    public static SqlDataReader viewList_ViTri(string value)
    {
        SqlDataReader reader = DAO_ThongTinDangTuyen.getList(value);
        return reader;
    }

    public static int check_Dienphieu(string value)
    {
        if (value == "") return 0;
        return 1;
    }
}
