using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_UngVien(string maUV = "", string tenUV = "", DateTime? ngaySinh = null, string diaChi = "", string email = "", string soDienThoai = "", string tenTaiKhoan = "")
    {
        public string MaUV = maUV;
        public string TenUV = tenUV;
        public DateTime? NgaySinh = ngaySinh;
        public string DiaChi = diaChi;
        public string Email = email;
        public string SoDienThoai = soDienThoai;
        public string TenTaiKhoan = tenTaiKhoan;
    }
}
