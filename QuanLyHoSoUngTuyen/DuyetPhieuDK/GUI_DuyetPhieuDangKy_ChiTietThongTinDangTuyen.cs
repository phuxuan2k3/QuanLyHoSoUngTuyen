﻿using Ctrler;
using Ctrler.DoanhNghiep;
using DTO;
using GUI.GUIException;
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
	public partial class GUI_DuyetPhieuDangKy_ChiTietThongTinDangTuyen : UserControl
	{
		private Ctrler_DuyetPhieuDangKy_ChiTietThongTinDangTuyen? _ctrler_ChiTietThongTinDangTuyen;


		public GUI_DuyetPhieuDangKy_ChiTietThongTinDangTuyen()
		{
			InitializeComponent();
		}

		public Ctrler_DuyetPhieuDangKy_ChiTietThongTinDangTuyen Ctrler_ChiTietThongTinDangTuyen
		{
			get => _ctrler_ChiTietThongTinDangTuyen ?? throw new ControllerNotFoundException();
			private set => _ctrler_ChiTietThongTinDangTuyen = value;
		}
		public void HienThi(Ctrler_DuyetPhieuDangKy_ChiTietThongTinDangTuyen ctrler_ChiTietThongTinDangTuyen)
		{
			_ctrler_ChiTietThongTinDangTuyen = ctrler_ChiTietThongTinDangTuyen;
			DTO_ThongTinDangTuyen ttdt = new();
			List<DTO_ThongTinHoSo> ttpdk = new();
			ctrler_ChiTietThongTinDangTuyen.ThongTinDangTuyenvaDSPDk(ref ttdt, ref ttpdk);
			_MaTTDT.Text = ttdt.MaTTDT;
			_ViTri.Text = ttdt.TenViTri;
			_SoLuong.Text = ttdt.SoLuong.ToString();
			_YeuCau.Text = ttdt.YeuCau;
			_MoTa.Text = ttdt.TinhTrang.ToString();
           
			foreach (var pdk in ttpdk)
			{
				int rowId = dsPhieuDangKy.Rows.Add();
				DataGridViewRow row = dsPhieuDangKy.Rows[rowId];
				row.Cells["_maUV"].Value = pdk.MaUV;
				row.Cells["_trangThai"].Value = pdk.TrangThai;
				row.Cells["_uuTien"].Value = pdk.UuTien;
			}

		}

		private void dsPhieuDangKy_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (dsPhieuDangKy.Rows[e.RowIndex].Cells["_maUV"].Value is string maUV)
			{
				var ctrler = new Ctrler_ThongTinPhieuDangKy(_MaTTDT.Text, maUV);
				GUI_DuyetPhieuDangKy_Duyet content = new();
				content.HienThi(ctrler);
				GUI_NhanVienNghiepVu.Instance.SwitchContent(content);

			}
		}

		private void btnHuy_Click(object sender, EventArgs e)
		{
			GUI_DuyetPhieuDangKy_DanhSachThongTinDangTuyen content = new();
			content.HienThi();
			GUI_NhanVienNghiepVu.Instance.SwitchContent(content);
		}
	}
}
