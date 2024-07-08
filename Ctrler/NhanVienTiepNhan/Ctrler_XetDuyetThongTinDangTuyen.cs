using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ctrler.NhanVienTiepNhan
{
    public class Ctrler_XetDuyetThongTinDangTuyen
    {
        private readonly DTO_ThongTinDangTuyen _ttdt;
        private readonly DTO_HinhThucDangTuyen _hinhThucDangTuyen;
        private readonly DTO_DoanhNghiep _DoanhNghiep;

        public Ctrler_XetDuyetThongTinDangTuyen(DTO_ThongTinDangTuyen ttdt, DTO_HinhThucDangTuyen hinhThucDangTuyen, DTO_DoanhNghiep doanhNghiep)
        {
            _ttdt = ttdt;
            _hinhThucDangTuyen = hinhThucDangTuyen;
            _DoanhNghiep = doanhNghiep;
        }

        public void Load(ref DTO_ThongTinDangTuyen thongTinDangTuyen, ref DTO_HinhThucDangTuyen hinhThucDangTuyen, ref DTO_DoanhNghiep doanhNghiep)
        {
            thongTinDangTuyen = _ttdt;
            hinhThucDangTuyen = _hinhThucDangTuyen;
            doanhNghiep = _DoanhNghiep;
        }

        public static void CapNhatTrangThai(string MaTTDT, TrangThaiThongTinDangTuyen trangThai)
        {
            BUS_ThongTinDangTuyen.CapNhatTrangThai(MaTTDT, trangThai);
        }
    }
}
