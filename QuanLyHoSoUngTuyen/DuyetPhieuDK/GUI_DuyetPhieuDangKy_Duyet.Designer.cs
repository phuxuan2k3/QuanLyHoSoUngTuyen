namespace GUI
{
    partial class GUI_DuyetPhieuDangKy_Duyet
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			pageSetupDialog1 = new PageSetupDialog();
			tableLayoutPanel1 = new TableLayoutPanel();
			lb1 = new Label();
			tableLayoutPanel2 = new TableLayoutPanel();
			lb_MaTTDT = new Label();
			_MaTTDT = new TextBox();
			lb_MoTa = new Label();
			_MoTa = new TextBox();
			tableLayoutPanel3 = new TableLayoutPanel();
			_YeuCau = new TextBox();
			_SoLuong = new TextBox();
			lb_VTri = new Label();
			_ViTri_DT = new TextBox();
			lb_YeuCau = new Label();
			lb_SoLuong = new Label();
			tableLayoutPanel4 = new TableLayoutPanel();
			_uuTien = new TextBox();
			lbUuTien = new Label();
			cbxTinhTrang = new ComboBox();
			lbTinhTrang = new Label();
			lb2 = new Label();
			tableLayoutPanel5 = new TableLayoutPanel();
			lb_BangCap = new Label();
			_bangCaps = new TextBox();
			_ViTri = new TextBox();
			lbMaPhieuDK = new Label();
			_MaUV = new TextBox();
			lbVtriUV = new Label();
			tableLayoutPanel6 = new TableLayoutPanel();
			btnHuy = new Button();
			btnLuu = new Button();
			tableLayoutPanel1.SuspendLayout();
			tableLayoutPanel2.SuspendLayout();
			tableLayoutPanel3.SuspendLayout();
			tableLayoutPanel4.SuspendLayout();
			tableLayoutPanel5.SuspendLayout();
			tableLayoutPanel6.SuspendLayout();
			SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.ColumnCount = 4;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
			tableLayoutPanel1.Controls.Add(lb1, 1, 0);
			tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 1);
			tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 2, 1);
			tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 1, 2);
			tableLayoutPanel1.Controls.Add(tableLayoutPanel5, 1, 3);
			tableLayoutPanel1.Controls.Add(tableLayoutPanel6, 2, 4);
			tableLayoutPanel1.Dock = DockStyle.Fill;
			tableLayoutPanel1.Location = new Point(0, 0);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 5;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 32F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle());
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 32F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16F));
			tableLayoutPanel1.Size = new Size(1100, 577);
			tableLayoutPanel1.TabIndex = 0;
			// 
			// lb1
			// 
			lb1.Anchor = AnchorStyles.Left;
			lb1.AutoSize = true;
			lb1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
			lb1.Location = new Point(114, 33);
			lb1.Margin = new Padding(4, 0, 4, 0);
			lb1.Name = "lb1";
			lb1.Size = new Size(293, 37);
			lb1.TabIndex = 29;
			lb1.Text = "Thông tin đăng tuyển";
			// 
			// tableLayoutPanel2
			// 
			tableLayoutPanel2.ColumnCount = 2;
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
			tableLayoutPanel2.Controls.Add(lb_MaTTDT, 0, 0);
			tableLayoutPanel2.Controls.Add(_MaTTDT, 1, 0);
			tableLayoutPanel2.Controls.Add(lb_MoTa, 0, 1);
			tableLayoutPanel2.Controls.Add(_MoTa, 1, 1);
			tableLayoutPanel2.Dock = DockStyle.Fill;
			tableLayoutPanel2.Location = new Point(113, 107);
			tableLayoutPanel2.Name = "tableLayoutPanel2";
			tableLayoutPanel2.RowCount = 2;
			tableLayoutPanel2.RowStyles.Add(new RowStyle());
			tableLayoutPanel2.RowStyles.Add(new RowStyle());
			tableLayoutPanel2.Size = new Size(434, 160);
			tableLayoutPanel2.TabIndex = 31;
			// 
			// lb_MaTTDT
			// 
			lb_MaTTDT.Anchor = AnchorStyles.Left;
			lb_MaTTDT.AutoSize = true;
			lb_MaTTDT.Location = new Point(4, 7);
			lb_MaTTDT.Margin = new Padding(4, 0, 4, 0);
			lb_MaTTDT.Name = "lb_MaTTDT";
			lb_MaTTDT.Size = new Size(92, 28);
			lb_MaTTDT.TabIndex = 0;
			lb_MaTTDT.Text = "Mã TTDT:";
			// 
			// _MaTTDT
			// 
			_MaTTDT.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			_MaTTDT.ForeColor = Color.Transparent;
			_MaTTDT.Location = new Point(104, 4);
			_MaTTDT.Margin = new Padding(4);
			_MaTTDT.Name = "_MaTTDT";
			_MaTTDT.ReadOnly = true;
			_MaTTDT.Size = new Size(326, 34);
			_MaTTDT.TabIndex = 5;
			// 
			// lb_MoTa
			// 
			lb_MoTa.AutoSize = true;
			lb_MoTa.Location = new Point(4, 46);
			lb_MoTa.Margin = new Padding(4);
			lb_MoTa.Name = "lb_MoTa";
			lb_MoTa.Size = new Size(68, 28);
			lb_MoTa.TabIndex = 3;
			lb_MoTa.Text = "Mô tả:";
			// 
			// _MoTa
			// 
			_MoTa.Dock = DockStyle.Fill;
			_MoTa.Location = new Point(104, 46);
			_MoTa.Margin = new Padding(4);
			_MoTa.Multiline = true;
			_MoTa.Name = "_MoTa";
			_MoTa.ReadOnly = true;
			_MoTa.Size = new Size(326, 110);
			_MoTa.TabIndex = 6;
			// 
			// tableLayoutPanel3
			// 
			tableLayoutPanel3.ColumnCount = 4;
			tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
			tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
			tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
			tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
			tableLayoutPanel3.Controls.Add(_YeuCau, 1, 1);
			tableLayoutPanel3.Controls.Add(_SoLuong, 3, 0);
			tableLayoutPanel3.Controls.Add(lb_VTri, 0, 0);
			tableLayoutPanel3.Controls.Add(_ViTri_DT, 1, 0);
			tableLayoutPanel3.Controls.Add(lb_YeuCau, 0, 1);
			tableLayoutPanel3.Controls.Add(lb_SoLuong, 2, 0);
			tableLayoutPanel3.Dock = DockStyle.Fill;
			tableLayoutPanel3.Location = new Point(553, 107);
			tableLayoutPanel3.Name = "tableLayoutPanel3";
			tableLayoutPanel3.RowCount = 2;
			tableLayoutPanel3.RowStyles.Add(new RowStyle());
			tableLayoutPanel3.RowStyles.Add(new RowStyle());
			tableLayoutPanel3.Size = new Size(434, 160);
			tableLayoutPanel3.TabIndex = 32;
			// 
			// _YeuCau
			// 
			tableLayoutPanel3.SetColumnSpan(_YeuCau, 3);
			_YeuCau.Dock = DockStyle.Fill;
			_YeuCau.Location = new Point(93, 46);
			_YeuCau.Margin = new Padding(4);
			_YeuCau.Multiline = true;
			_YeuCau.Name = "_YeuCau";
			_YeuCau.ReadOnly = true;
			_YeuCau.Size = new Size(337, 110);
			_YeuCau.TabIndex = 7;
			// 
			// _SoLuong
			// 
			_SoLuong.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			_SoLuong.Location = new Point(365, 4);
			_SoLuong.Margin = new Padding(4);
			_SoLuong.Name = "_SoLuong";
			_SoLuong.ReadOnly = true;
			_SoLuong.Size = new Size(65, 34);
			_SoLuong.TabIndex = 9;
			// 
			// lb_VTri
			// 
			lb_VTri.Anchor = AnchorStyles.Left;
			lb_VTri.AutoSize = true;
			lb_VTri.Location = new Point(4, 7);
			lb_VTri.Margin = new Padding(4, 0, 4, 0);
			lb_VTri.Name = "lb_VTri";
			lb_VTri.Size = new Size(57, 28);
			lb_VTri.TabIndex = 1;
			lb_VTri.Text = "Vị trí:";
			// 
			// _ViTri_DT
			// 
			_ViTri_DT.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			_ViTri_DT.Location = new Point(93, 4);
			_ViTri_DT.Margin = new Padding(4);
			_ViTri_DT.Name = "_ViTri_DT";
			_ViTri_DT.ReadOnly = true;
			_ViTri_DT.Size = new Size(160, 34);
			_ViTri_DT.TabIndex = 8;
			// 
			// lb_YeuCau
			// 
			lb_YeuCau.AutoSize = true;
			lb_YeuCau.Location = new Point(4, 46);
			lb_YeuCau.Margin = new Padding(4);
			lb_YeuCau.Name = "lb_YeuCau";
			lb_YeuCau.Size = new Size(81, 28);
			lb_YeuCau.TabIndex = 4;
			lb_YeuCau.Text = "Yêu cầu:";
			// 
			// lb_SoLuong
			// 
			lb_SoLuong.Anchor = AnchorStyles.Left;
			lb_SoLuong.AutoSize = true;
			lb_SoLuong.Location = new Point(261, 7);
			lb_SoLuong.Margin = new Padding(4, 0, 4, 0);
			lb_SoLuong.Name = "lb_SoLuong";
			lb_SoLuong.Size = new Size(96, 28);
			lb_SoLuong.TabIndex = 2;
			lb_SoLuong.Text = "Số lượng:";
			// 
			// tableLayoutPanel4
			// 
			tableLayoutPanel4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			tableLayoutPanel4.AutoSize = true;
			tableLayoutPanel4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			tableLayoutPanel4.ColumnCount = 6;
			tableLayoutPanel1.SetColumnSpan(tableLayoutPanel4, 2);
			tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle());
			tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
			tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle());
			tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle());
			tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
			tableLayoutPanel4.Controls.Add(_uuTien, 5, 0);
			tableLayoutPanel4.Controls.Add(lbUuTien, 4, 0);
			tableLayoutPanel4.Controls.Add(cbxTinhTrang, 3, 0);
			tableLayoutPanel4.Controls.Add(lbTinhTrang, 2, 0);
			tableLayoutPanel4.Controls.Add(lb2, 0, 0);
			tableLayoutPanel4.Location = new Point(113, 273);
			tableLayoutPanel4.Name = "tableLayoutPanel4";
			tableLayoutPanel4.RowCount = 1;
			tableLayoutPanel4.RowStyles.Add(new RowStyle());
			tableLayoutPanel4.Size = new Size(874, 50);
			tableLayoutPanel4.TabIndex = 33;
			// 
			// _uuTien
			// 
			_uuTien.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			_uuTien.Location = new Point(790, 8);
			_uuTien.Margin = new Padding(4);
			_uuTien.Name = "_uuTien";
			_uuTien.Size = new Size(80, 34);
			_uuTien.TabIndex = 38;
			// 
			// lbUuTien
			// 
			lbUuTien.Anchor = AnchorStyles.Left;
			lbUuTien.AutoSize = true;
			lbUuTien.Location = new Point(703, 11);
			lbUuTien.Margin = new Padding(4);
			lbUuTien.Name = "lbUuTien";
			lbUuTien.Size = new Size(79, 28);
			lbUuTien.TabIndex = 37;
			lbUuTien.Text = "Ưu tiên:";
			// 
			// cbxTinhTrang
			// 
			cbxTinhTrang.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			cbxTinhTrang.DropDownWidth = 135;
			cbxTinhTrang.FormattingEnabled = true;
			cbxTinhTrang.Items.AddRange(new object[] { "Chưa xét duyệt", "Không hợp lệ", "Hợp lệ", "Đã xử lý", "Đạt", "Không đạt" });
			cbxTinhTrang.Location = new Point(485, 8);
			cbxTinhTrang.Margin = new Padding(4);
			cbxTinhTrang.Name = "cbxTinhTrang";
			cbxTinhTrang.Size = new Size(210, 36);
			cbxTinhTrang.TabIndex = 36;
			// 
			// lbTinhTrang
			// 
			lbTinhTrang.Anchor = AnchorStyles.Left;
			lbTinhTrang.AutoSize = true;
			lbTinhTrang.Location = new Point(372, 11);
			lbTinhTrang.Margin = new Padding(4);
			lbTinhTrang.Name = "lbTinhTrang";
			lbTinhTrang.Size = new Size(105, 28);
			lbTinhTrang.TabIndex = 35;
			lbTinhTrang.Text = "Tình trạng:";
			// 
			// lb2
			// 
			lb2.Anchor = AnchorStyles.Left;
			lb2.AutoSize = true;
			lb2.Location = new Point(4, 11);
			lb2.Margin = new Padding(4, 11, 4, 11);
			lb2.Name = "lb2";
			lb2.Size = new Size(230, 28);
			lb2.TabIndex = 34;
			lb2.Text = "Danh sách phiếu đăng ký";
			// 
			// tableLayoutPanel5
			// 
			tableLayoutPanel5.ColumnCount = 4;
			tableLayoutPanel1.SetColumnSpan(tableLayoutPanel5, 2);
			tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle());
			tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
			tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle());
			tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
			tableLayoutPanel5.Controls.Add(lb_BangCap, 0, 1);
			tableLayoutPanel5.Controls.Add(_bangCaps, 1, 1);
			tableLayoutPanel5.Controls.Add(_ViTri, 3, 0);
			tableLayoutPanel5.Controls.Add(lbMaPhieuDK, 0, 0);
			tableLayoutPanel5.Controls.Add(_MaUV, 1, 0);
			tableLayoutPanel5.Controls.Add(lbVtriUV, 2, 0);
			tableLayoutPanel5.Dock = DockStyle.Fill;
			tableLayoutPanel5.Location = new Point(113, 329);
			tableLayoutPanel5.Name = "tableLayoutPanel5";
			tableLayoutPanel5.RowCount = 2;
			tableLayoutPanel5.RowStyles.Add(new RowStyle());
			tableLayoutPanel5.RowStyles.Add(new RowStyle());
			tableLayoutPanel5.Size = new Size(874, 160);
			tableLayoutPanel5.TabIndex = 35;
			// 
			// lb_BangCap
			// 
			lb_BangCap.AutoSize = true;
			lb_BangCap.Location = new Point(4, 46);
			lb_BangCap.Margin = new Padding(4);
			lb_BangCap.Name = "lb_BangCap";
			lb_BangCap.Size = new Size(96, 28);
			lb_BangCap.TabIndex = 11;
			lb_BangCap.Text = "Bằng cấp:";
			// 
			// _bangCaps
			// 
			tableLayoutPanel5.SetColumnSpan(_bangCaps, 3);
			_bangCaps.Dock = DockStyle.Fill;
			_bangCaps.Location = new Point(139, 46);
			_bangCaps.Margin = new Padding(4);
			_bangCaps.Multiline = true;
			_bangCaps.Name = "_bangCaps";
			_bangCaps.ReadOnly = true;
			_bangCaps.Size = new Size(731, 110);
			_bangCaps.TabIndex = 10;
			// 
			// _ViTri
			// 
			_ViTri.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			_ViTri.Location = new Point(406, 4);
			_ViTri.Margin = new Padding(4);
			_ViTri.Name = "_ViTri";
			_ViTri.ReadOnly = true;
			_ViTri.Size = new Size(464, 34);
			_ViTri.TabIndex = 12;
			// 
			// lbMaPhieuDK
			// 
			lbMaPhieuDK.Anchor = AnchorStyles.Left;
			lbMaPhieuDK.AutoSize = true;
			lbMaPhieuDK.Location = new Point(4, 7);
			lbMaPhieuDK.Margin = new Padding(4, 0, 4, 0);
			lbMaPhieuDK.Name = "lbMaPhieuDK";
			lbMaPhieuDK.Size = new Size(127, 28);
			lbMaPhieuDK.TabIndex = 10;
			lbMaPhieuDK.Text = "Mã Ứng viên:";
			// 
			// _MaUV
			// 
			_MaUV.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			_MaUV.Location = new Point(139, 4);
			_MaUV.Margin = new Padding(4);
			_MaUV.Name = "_MaUV";
			_MaUV.ReadOnly = true;
			_MaUV.Size = new Size(194, 34);
			_MaUV.TabIndex = 10;
			// 
			// lbVtriUV
			// 
			lbVtriUV.Anchor = AnchorStyles.Left;
			lbVtriUV.AutoSize = true;
			lbVtriUV.Location = new Point(341, 7);
			lbVtriUV.Margin = new Padding(4, 0, 4, 0);
			lbVtriUV.Name = "lbVtriUV";
			lbVtriUV.Size = new Size(57, 28);
			lbVtriUV.TabIndex = 10;
			lbVtriUV.Text = "Vị trí:";
			// 
			// tableLayoutPanel6
			// 
			tableLayoutPanel6.ColumnCount = 3;
			tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
			tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
			tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
			tableLayoutPanel6.Controls.Add(btnHuy, 2, 0);
			tableLayoutPanel6.Controls.Add(btnLuu, 0, 0);
			tableLayoutPanel6.Dock = DockStyle.Fill;
			tableLayoutPanel6.Location = new Point(553, 495);
			tableLayoutPanel6.Name = "tableLayoutPanel6";
			tableLayoutPanel6.RowCount = 1;
			tableLayoutPanel6.RowStyles.Add(new RowStyle());
			tableLayoutPanel6.Size = new Size(434, 79);
			tableLayoutPanel6.TabIndex = 36;
			// 
			// btnHuy
			// 
			btnHuy.Anchor = AnchorStyles.Right;
			btnHuy.BackColor = Color.Red;
			btnHuy.Location = new Point(294, 17);
			btnHuy.Margin = new Padding(4);
			btnHuy.Name = "btnHuy";
			btnHuy.Size = new Size(136, 45);
			btnHuy.TabIndex = 39;
			btnHuy.Tag = "red";
			btnHuy.Text = "Hủy";
			btnHuy.UseVisualStyleBackColor = false;
			btnHuy.Click += btnHuy_Click;
			// 
			// btnLuu
			// 
			btnLuu.Anchor = AnchorStyles.Right;
			btnLuu.BackColor = Color.DodgerBlue;
			btnLuu.Location = new Point(5, 17);
			btnLuu.Margin = new Padding(4);
			btnLuu.Name = "btnLuu";
			btnLuu.Size = new Size(164, 45);
			btnLuu.TabIndex = 38;
			btnLuu.Tag = "blue";
			btnLuu.Text = "Lưu thay đổi";
			btnLuu.UseVisualStyleBackColor = false;
			btnLuu.Click += btnLuu_Click;
			// 
			// GUI_DuyetPhieuDangKy_Duyet
			// 
			AutoScaleDimensions = new SizeF(11F, 28F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(tableLayoutPanel1);
			Font = new Font("Segoe UI", 12F);
			Margin = new Padding(4);
			Name = "GUI_DuyetPhieuDangKy_Duyet";
			Size = new Size(1100, 577);
			tableLayoutPanel1.ResumeLayout(false);
			tableLayoutPanel1.PerformLayout();
			tableLayoutPanel2.ResumeLayout(false);
			tableLayoutPanel2.PerformLayout();
			tableLayoutPanel3.ResumeLayout(false);
			tableLayoutPanel3.PerformLayout();
			tableLayoutPanel4.ResumeLayout(false);
			tableLayoutPanel4.PerformLayout();
			tableLayoutPanel5.ResumeLayout(false);
			tableLayoutPanel5.PerformLayout();
			tableLayoutPanel6.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion
		private PageSetupDialog pageSetupDialog1;
		private TableLayoutPanel tableLayoutPanel1;
		private Label lb1;
		private TableLayoutPanel tableLayoutPanel2;
		private Label lb_MaTTDT;
		private TextBox _MaTTDT;
		private Label lb_MoTa;
		private TextBox _MoTa;
		private TableLayoutPanel tableLayoutPanel3;
		private TextBox _SoLuong;
		private Label lb_VTri;
		private TextBox _ViTri_DT;
		private Label lb_YeuCau;
		private Label lb_SoLuong;
		private TextBox _YeuCau;
		private TableLayoutPanel tableLayoutPanel4;
		private Label lb2;
		private Label lbTinhTrang;
		private ComboBox cbxTinhTrang;
		private Label lbUuTien;
		private TextBox _uuTien;
		private TextBox _ViTri;
		private TextBox _MaUV;
		private TextBox _bangCaps;
		private Label lbVtriUV;
		private Label lb_BangCap;
		private Label lbMaPhieuDK;
		private TableLayoutPanel tableLayoutPanel5;
		private TableLayoutPanel tableLayoutPanel6;
		private Button btnLuu;
		private Button btnHuy;
	}
}
