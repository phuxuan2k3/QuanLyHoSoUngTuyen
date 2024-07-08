﻿using BUS;
using Ctrler;
using DTO;
using GUI.GUI_XacThuc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilis;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
namespace GUI
{
	public partial class GUI_XacThucNguoiDung : Form
	{
		public GUI_XacThucNguoiDung()
		{
			InitializeComponent();
			KhoiTaoManHinh();
		}

		private void KhoiTaoManHinh()
		{
			GUI_DangNhap gui_DangNhap = new(DangNhapThanhCong!, DangKy!);
			SwitchContent(gui_DangNhap);
		}

		private void DangNhapThanhCong(object sender, EventArgs e)
		{
			switch ((e as EventArgs<DTO_TaiKhoan>)!.Value.VaiTro)
			{
				case "Doanh nghiệp":
                    string tenTaiKhoan = (e as EventArgs<DTO_TaiKhoan>)!.Value.TenTaiKhoan;
                    var dn = BUS_DoanhNghiep.LayDoanhNghiep(tenTaiKhoan);
					GUI_DoanhNghiep gUI_DoanhNghiep = new GUI_DoanhNghiep();
					gUI_DoanhNghiep.MaDN = dn.MaDN;
					gUI_DoanhNghiep.TrangThaiDoanhNghiep = dn.TrangThai;
					Hide();
					gUI_DoanhNghiep.ShowDialog();
					Show();
					break;
				case "Ban lãnh đạo":
					GUI_BanLanhDao gui_BanLanhDao = new GUI_BanLanhDao();
					Hide();
					gui_BanLanhDao.ShowDialog();
					Show();
					break;
				case "Nhân viên nghiệp vụ":
					GUI_NhanVienNghiepVu gui_NhanVienNghiepVu = new GUI_NhanVienNghiepVu();
					Hide();
					gui_NhanVienNghiepVu.ShowDialog();
					Show();
					break;
				case "Nhân viên tiếp nhận":
					GUI_NhanVienTiepNhan gui_NhanVienTiepNhan = new GUI_NhanVienTiepNhan();
					Hide();
					gui_NhanVienTiepNhan.ShowDialog();
					Show();
					break;
				case "Nhân viên thanh toán":
					GUI_NhanVienThanhToan gui_NhanVienThanhToan = new GUI_NhanVienThanhToan();
					Hide();
					gui_NhanVienThanhToan.ShowDialog();
					Show();
					break;
				case "Ứng viên":
					GUI_UngVien gui_UngVien = new GUI_UngVien();
					Hide();
					gui_UngVien.ShowDialog();
					Show();
					break;
			}
		}
		private void DangKy(object sender, EventArgs e)
		{
			GUI_DangKy gUI_DangKy = new GUI_DangKy(BackToDangNhap!);
			SwitchContent(gUI_DangKy);
		}

		private void BackToDangNhap(object sender, EventArgs e)
		{
			GUI_DangNhap gui_DangNhap = new(DangNhapThanhCong!, DangKy!);
			SwitchContent(gui_DangNhap);
		}

		private void SwitchContent(UserControl content)
		{
			pnContent.Controls.Clear();
			pnContent.Controls.Add(content);
			content.Dock = DockStyle.Fill;
		}
	}
}
