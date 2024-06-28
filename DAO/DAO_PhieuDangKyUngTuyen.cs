using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
