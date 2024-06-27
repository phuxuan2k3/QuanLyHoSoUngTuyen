using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_KetQuaUngTuyen(string maTTDT, string tenViTri, int soLuongUVNop, int soLuongUVHopLe, int soLuongUVDat)
    {
        public string MaTTDT { get; set; } = maTTDT;
        public string TenViTri { get; set; } = tenViTri;
        public int SoLuongUVNop { get; set; } = soLuongUVNop;
        public int SoLuongUVHopLe { get; set; } = soLuongUVHopLe;
        public int SoLuongUVDat { get; set; } = soLuongUVDat;
    }
}
