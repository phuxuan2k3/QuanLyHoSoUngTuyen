using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ctrler
{
    public class Ctrler_XetDuyetThongTinDangTuyen
    {
        private readonly DTO_ThongTinDangTuyen _ttdt;
        private readonly DTO_HoaDon _hoaDon;
        private readonly DTO_HinhThucDangTuyen _hinhThucDangTuyen;
        private readonly DTO_DoanhNghiep _DoanhNghiep;

        public Ctrler_DanhSachTTDTXetDuyet Owner { get; set; }

        public Ctrler_XetDuyetThongTinDangTuyen(DTO_ThongTinDangTuyen ttdt, DTO_HinhThucDangTuyen hinhThucDangTuyen,DTO_DoanhNghiep doanhNghiep , Ctrler_DanhSachTTDTXetDuyet owner)
        {
            _ttdt = ttdt;
           
            _hinhThucDangTuyen = hinhThucDangTuyen;
            _DoanhNghiep = doanhNghiep;
            Owner = owner;
        }

        public void LoadTTDTXD(ref List<DTO_ThongTinDangTuyen> thongTinDangTuyen)
        {
            thongTinDangTuyen = BUS_ThongTinDangTuyen.LayDSTTDTXD();
        }

        public void Load2(ref DTO_ThongTinDangTuyen thongTinDangTuyen, ref DTO_HoaDon hoaDon, ref DTO_HinhThucDangTuyen hinhThucDangTuyen, ref DTO_DoanhNghiep doanhNghiep)
        {
            thongTinDangTuyen = _ttdt;
            hinhThucDangTuyen = _hinhThucDangTuyen;
            hoaDon = _hoaDon;
            doanhNghiep = _DoanhNghiep;
        }

        public static void CapNhatTrangThaiTTDT(string MaTTDT,string TrangThai)
        {
            BUS_ThongTinDangTuyen.CapNhatTrangThaiTTDT(MaTTDT, TrangThai);
        }

    }

}
