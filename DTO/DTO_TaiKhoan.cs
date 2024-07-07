using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_TaiKhoan(string tenTaiKhoan = "", string matKhau = "", string vaiTro = "")
    {
        public string TenTaiKhoan = tenTaiKhoan;
        public string MatKhau = matKhau;
        public string VaiTro = vaiTro;
    }
}
