using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO;

public class DAO_PhieuDangKyUngTuyen
{
    public static List<DTO_PhieuDangKyUngTuyen> LayPDKUT(string maTTDT)
    {
        return new List<DTO_PhieuDangKyUngTuyen>
        {
            new DTO_PhieuDangKyUngTuyen(TrangThaiPhieuDangKyUngTuyen.KhongHopLe),
            new DTO_PhieuDangKyUngTuyen(TrangThaiPhieuDangKyUngTuyen.HopLe),
            new DTO_PhieuDangKyUngTuyen(TrangThaiPhieuDangKyUngTuyen.ChuaXetDuyet),
        };
    }

public static DTO_ThongTinHoSo LayThongTinDangTuyenTheoMaUV(string maTTDT, string maUV)
{
    string query = @"
            SELECT 
                p.MAUV,
                p.TRANGTHAI,
                STRING_AGG(b.TENCTBC, ', ') AS BangCap,
                t.TENVITRI
            FROM 
                PHIEUDANGKYUNGTUYEN p
            JOIN 
                UNGVIEN u ON p.MAUV = u.MaUngVien
            JOIN 
                THONGTINDANGTUYEN t ON t.MATTDT = p.MATTDT
            LEFT JOIN 
                HS_CT_BC b ON p.MAUV = b.MAUngVien
            WHERE 
                p.MATTDT = @maTTDT AND p.MAUV = @maUV
            GROUP BY 
                p.MAUV,
                p.TRANGTHAI,
                t.TENVITRI";


    DataTable dataTable = new DataTable();
    using (SqlCommand cmd = new SqlCommand(query, SqlSingleton.Instance.Connection))
    {
        cmd.Parameters.AddWithValue("@maTTDT", maTTDT);
        cmd.Parameters.AddWithValue("@maUV", maUV);
        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        adapter.Fill(dataTable);
    }

    DataRow row = dataTable.Rows[0];

    DTO_ThongTinHoSo phDK = new DTO_ThongTinHoSo(
        row["MAUV"].ToString(),
        maTTDT,
        0,
        row["TENVITRI"].ToString(),
        row["BangCap"].ToString(),
        row["TrangThai"].ToString());

    return phDK;
}
    public static void CapNhatThongTinPhieuDangKy(DTO_ThongTinHoSo ttpdk)
    {
        string query = "UPDATE PHIEUDANGKYUNGTUYEN SET TRANGTHAI = @TrangThai WHERE MATTDT = @MaTTDT AND MAUV = @MaUV";

        using (SqlCommand cmd = new SqlCommand(query, SqlSingleton.Instance.Connection))
        {
            cmd.Parameters.AddWithValue("@TrangThai", ttpdk.TrangThai.ToString());
            cmd.Parameters.AddWithValue("@MaTTDT", ttpdk.MaTTDT);
            cmd.Parameters.AddWithValue("@MaUV", ttpdk.MaUV);

            SqlSingleton.Instance.Connection.Open();
            cmd.ExecuteNonQuery();
            SqlSingleton.Instance.Connection.Close();

        }
    }
}
