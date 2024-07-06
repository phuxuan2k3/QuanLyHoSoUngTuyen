using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ctrler
{
    public class Ctrler_DanhSachTTDTXetDuyet
    {

        private readonly DTO_ThongTinDangTuyen _ttdt;
        private readonly DTO_HinhThucDangTuyen _hinhThucDangTuyen;
        private readonly DTO_DoanhNghiep _DoanhNghiep;
        public void LoadTTDTXD(ref List<DTO_ThongTinDangTuyen> thongTinDangTuyen)
        {
            thongTinDangTuyen = BUS_ThongTinDangTuyen.LayDSTTDTXD();
        }

        public void LoadTTDTHopLe(ref List<DTO_ThongTinDangTuyen> thongTinDangTuyen)
        {
            thongTinDangTuyen = BUS_ThongTinDangTuyen.LayDSTTDTHopLe();
        }
        public Ctrler_XetDuyetThongTinDangTuyen ChiTietThongTinDangTuyenXD(string maTTDT)
        {
            var ttdt = BUS_ThongTinDangTuyen.Lay(maTTDT);

            var hinhThucDangTuyen = BUS_HinhThucDangTuyen.Lay(ttdt.MaHTDT);
            var doanhNghiep = BUS_DoanhNghiep.LoadTTDN(ttdt.MaDN);
            return new Ctrler_XetDuyetThongTinDangTuyen(ttdt, hinhThucDangTuyen, doanhNghiep, this);
        }


    }
}
