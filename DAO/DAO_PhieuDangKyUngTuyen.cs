using DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace DAO
{
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
<<<<<<< Updated upstream
        public static DTO_ThongTinHoSo LayTTPDK(string maTTDT,string MaUV)
=======
        public static DTO_ThongTinHoSo LayThongTinDangTuyenTheoMaUV(string maTTDT, string maUV)
>>>>>>> Stashed changes
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
<<<<<<< Updated upstream
                p.MATTDT = @maTTDT
=======
                p.MATTDT = @maTTDT AND p.MAUV = @maUV
>>>>>>> Stashed changes
            GROUP BY 
                p.MAUV,
                p.TRANGTHAI,
                t.TENVITRI";
<<<<<<< Updated upstream

=======
>>>>>>> Stashed changes
            DataTable dataTable = new DataTable();
            using (SqlCommand cmd = new SqlCommand(query, SqlSingleton.Instance.Connection))
            {
                cmd.Parameters.AddWithValue("@maTTDT", maTTDT);
<<<<<<< Updated upstream
=======
                    cmd.Parameters.AddWithValue("@maUV", maUV);
>>>>>>> Stashed changes
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dataTable);
            }

            DataRow row = dataTable.Rows[0];
<<<<<<< Updated upstream
            TrangThaiPhieuDangKyUngTuyen trangThai = (TrangThaiPhieuDangKyUngTuyen)Enum.Parse(typeof(TrangThaiPhieuDangKyUngTuyen), row["TRANGTHAI"].ToString());

            DTO_ThongTinHoSo phDK = new DTO_ThongTinHoSo(
                row["MAUV"].ToString(),
                row["MATTDT"].ToString(),
=======

            DTO_ThongTinHoSo phDK = new DTO_ThongTinHoSo(
                row["MAUV"].ToString(),
                maTTDT,
>>>>>>> Stashed changes
                0,
                row["TENVITRI"].ToString(),

                row["BangCap"].ToString(),
<<<<<<< Updated upstream
                trangThai);
                
            return phDK;
        }
=======
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
>>>>>>> Stashed changes
    }
}
