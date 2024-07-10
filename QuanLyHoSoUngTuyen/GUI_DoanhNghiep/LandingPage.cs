using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
	public partial class LandingPage : UserControl
	{

		public LandingPage(DTO_DoanhNghiep doanhNghiep)
		{
			InitializeComponent();
			_tenDoanhNghiep.Text = doanhNghiep.TenDN;
			_maSoThue.Text = doanhNghiep.MaSoThue;
			_nguoiDaiDien.Text = doanhNghiep.NguoiDaiDien;
			_diaChi.Text = doanhNghiep.DiaChi;
			_email.Text = doanhNghiep.Email;
			_trangThai.Text = doanhNghiep.TrangThai.GetString();
			switch (doanhNghiep.TrangThai)
			{
				case TrangThaiDoanhNghiep.ChuaXacThuc:
					_trangThai.ForeColor = Color.Gold;
					break;
				case TrangThaiDoanhNghiep.KhongHopLe:
					_trangThai.ForeColor = Color.Red;
					break;
				case TrangThaiDoanhNghiep.HopLe:
					_trangThai.ForeColor = Color.Green;
					break;
				case TrangThaiDoanhNghiep.TiemNang:
					_trangThai.ForeColor = Color.Purple;
					break;
			}
		}
	}
}
