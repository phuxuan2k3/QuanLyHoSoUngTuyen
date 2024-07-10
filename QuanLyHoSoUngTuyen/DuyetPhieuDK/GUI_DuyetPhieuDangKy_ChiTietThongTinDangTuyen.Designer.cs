namespace GUI
{
    partial class GUI_DuyetPhieuDangKy_ChiTietThongTinDangTuyen
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
			lb2 = new Label();
			_SoLuong = new TextBox();
			_ViTri = new TextBox();
			_YeuCau = new TextBox();
			_MoTa = new TextBox();
			_MaTTDT = new TextBox();
			lb_SoLuong = new Label();
			lb_VTri = new Label();
			lb_MaTTDT = new Label();
			panel1 = new Panel();
			lb_YeuCau = new Label();
			lb_MoTa = new Label();
			lb1 = new Label();
			pageSetupDialog1 = new PageSetupDialog();
			tableLayoutPanel1 = new TableLayoutPanel();
			btnHuy = new Button();
			dsPhieuDangKy = new DataGridView();
			_maUV = new DataGridViewTextBoxColumn();
			_trangThai = new DataGridViewTextBoxColumn();
			_uuTien = new DataGridViewTextBoxColumn();
			tableLayoutPanel2 = new TableLayoutPanel();
			tableLayoutPanel3 = new TableLayoutPanel();
			tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dsPhieuDangKy).BeginInit();
			tableLayoutPanel2.SuspendLayout();
			tableLayoutPanel3.SuspendLayout();
			SuspendLayout();
			// 
			// lb2
			// 
			lb2.AutoSize = true;
			lb2.Location = new Point(115, 258);
			lb2.Margin = new Padding(4, 10, 4, 4);
			lb2.Name = "lb2";
			lb2.Size = new Size(230, 28);
			lb2.TabIndex = 9;
			lb2.Text = "Danh sách phiếu đăng ký";
			// 
			// _SoLuong
			// 
			_SoLuong.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			_SoLuong.Location = new Point(382, 4);
			_SoLuong.Margin = new Padding(4);
			_SoLuong.Name = "_SoLuong";
			_SoLuong.ReadOnly = true;
			_SoLuong.Size = new Size(54, 34);
			_SoLuong.TabIndex = 9;
			// 
			// _ViTri
			// 
			_ViTri.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			_ViTri.Location = new Point(93, 4);
			_ViTri.Margin = new Padding(4);
			_ViTri.Name = "_ViTri";
			_ViTri.ReadOnly = true;
			_ViTri.Size = new Size(177, 34);
			_ViTri.TabIndex = 8;
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
			_YeuCau.Size = new Size(343, 110);
			_YeuCau.TabIndex = 7;
			// 
			// _MoTa
			// 
			_MoTa.Dock = DockStyle.Fill;
			_MoTa.Location = new Point(104, 46);
			_MoTa.Margin = new Padding(4);
			_MoTa.Multiline = true;
			_MoTa.Name = "_MoTa";
			_MoTa.ReadOnly = true;
			_MoTa.Size = new Size(332, 110);
			_MoTa.TabIndex = 6;
			// 
			// _MaTTDT
			// 
			_MaTTDT.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			_MaTTDT.Location = new Point(104, 4);
			_MaTTDT.Margin = new Padding(4);
			_MaTTDT.Name = "_MaTTDT";
			_MaTTDT.ReadOnly = true;
			_MaTTDT.Size = new Size(332, 34);
			_MaTTDT.TabIndex = 5;
			// 
			// lb_SoLuong
			// 
			lb_SoLuong.Anchor = AnchorStyles.Left;
			lb_SoLuong.AutoSize = true;
			lb_SoLuong.Location = new Point(278, 7);
			lb_SoLuong.Margin = new Padding(4);
			lb_SoLuong.Name = "lb_SoLuong";
			lb_SoLuong.Size = new Size(96, 28);
			lb_SoLuong.TabIndex = 2;
			lb_SoLuong.Text = "Số lượng:";
			// 
			// lb_VTri
			// 
			lb_VTri.Anchor = AnchorStyles.Left;
			lb_VTri.AutoSize = true;
			lb_VTri.Location = new Point(4, 7);
			lb_VTri.Margin = new Padding(4);
			lb_VTri.Name = "lb_VTri";
			lb_VTri.Size = new Size(57, 28);
			lb_VTri.TabIndex = 1;
			lb_VTri.Text = "Vị trí:";
			// 
			// lb_MaTTDT
			// 
			lb_MaTTDT.Anchor = AnchorStyles.Left;
			lb_MaTTDT.AutoSize = true;
			lb_MaTTDT.Location = new Point(4, 7);
			lb_MaTTDT.Margin = new Padding(4);
			lb_MaTTDT.Name = "lb_MaTTDT";
			lb_MaTTDT.Size = new Size(92, 28);
			lb_MaTTDT.TabIndex = 0;
			lb_MaTTDT.Text = "Mã TTDT:";
			// 
			// panel1
			// 
			panel1.AutoSize = true;
			panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			panel1.Location = new Point(4, 86);
			panel1.Margin = new Padding(4);
			panel1.Name = "panel1";
			panel1.Size = new Size(0, 0);
			panel1.TabIndex = 6;
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
			// lb1
			// 
			lb1.Anchor = AnchorStyles.Left;
			lb1.AutoSize = true;
			lb1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 163);
			lb1.Location = new Point(115, 22);
			lb1.Margin = new Padding(4, 0, 4, 0);
			lb1.Name = "lb1";
			lb1.Size = new Size(293, 37);
			lb1.TabIndex = 5;
			lb1.Text = "Thông tin đăng tuyển";
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.ColumnCount = 4;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
			tableLayoutPanel1.Controls.Add(btnHuy, 2, 4);
			tableLayoutPanel1.Controls.Add(lb2, 1, 2);
			tableLayoutPanel1.Controls.Add(dsPhieuDangKy, 1, 3);
			tableLayoutPanel1.Controls.Add(panel1, 0, 1);
			tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 1);
			tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 2, 1);
			tableLayoutPanel1.Controls.Add(lb1, 1, 0);
			tableLayoutPanel1.Dock = DockStyle.Fill;
			tableLayoutPanel1.Location = new Point(0, 0);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 5;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle());
			tableLayoutPanel1.RowStyles.Add(new RowStyle());
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
			tableLayoutPanel1.Size = new Size(1116, 622);
			tableLayoutPanel1.TabIndex = 10;
			// 
			// btnHuy
			// 
			btnHuy.Anchor = AnchorStyles.Right;
			btnHuy.BackColor = Color.Red;
			btnHuy.Location = new Point(869, 560);
			btnHuy.Margin = new Padding(4);
			btnHuy.Name = "btnHuy";
			btnHuy.Size = new Size(130, 40);
			btnHuy.TabIndex = 8;
			btnHuy.Tag = "red";
			btnHuy.Text = "Hủy";
			btnHuy.UseVisualStyleBackColor = false;
			btnHuy.Click += btnHuy_Click;
			// 
			// dsPhieuDangKy
			// 
			dsPhieuDangKy.AllowUserToAddRows = false;
			dsPhieuDangKy.AllowUserToDeleteRows = false;
			dsPhieuDangKy.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dsPhieuDangKy.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
			dsPhieuDangKy.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dsPhieuDangKy.Columns.AddRange(new DataGridViewColumn[] { _maUV, _trangThai, _uuTien });
			tableLayoutPanel1.SetColumnSpan(dsPhieuDangKy, 2);
			dsPhieuDangKy.Dock = DockStyle.Fill;
			dsPhieuDangKy.Location = new Point(115, 294);
			dsPhieuDangKy.Margin = new Padding(4);
			dsPhieuDangKy.Name = "dsPhieuDangKy";
			dsPhieuDangKy.ReadOnly = true;
			dsPhieuDangKy.RowHeadersWidth = 51;
			dsPhieuDangKy.Size = new Size(884, 240);
			dsPhieuDangKy.TabIndex = 10;
			dsPhieuDangKy.CellContentClick += dsPhieuDangKy_CellContentClick;
			// 
			// _maUV
			// 
			_maUV.HeaderText = "Ma UV";
			_maUV.MinimumWidth = 6;
			_maUV.Name = "_maUV";
			_maUV.ReadOnly = true;
			// 
			// _trangThai
			// 
			_trangThai.HeaderText = "Trạng thái";
			_trangThai.MinimumWidth = 6;
			_trangThai.Name = "_trangThai";
			_trangThai.ReadOnly = true;
			// 
			// _uuTien
			// 
			_uuTien.HeaderText = "Ưu tiên";
			_uuTien.MinimumWidth = 6;
			_uuTien.Name = "_uuTien";
			_uuTien.ReadOnly = true;
			// 
			// tableLayoutPanel2
			// 
			tableLayoutPanel2.ColumnCount = 2;
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
			tableLayoutPanel2.Controls.Add(lb_MaTTDT, 0, 0);
			tableLayoutPanel2.Controls.Add(lb_MoTa, 0, 1);
			tableLayoutPanel2.Controls.Add(_MoTa, 1, 1);
			tableLayoutPanel2.Controls.Add(_MaTTDT, 1, 0);
			tableLayoutPanel2.Dock = DockStyle.Fill;
			tableLayoutPanel2.Location = new Point(114, 85);
			tableLayoutPanel2.Name = "tableLayoutPanel2";
			tableLayoutPanel2.RowCount = 2;
			tableLayoutPanel2.RowStyles.Add(new RowStyle());
			tableLayoutPanel2.RowStyles.Add(new RowStyle());
			tableLayoutPanel2.Size = new Size(440, 160);
			tableLayoutPanel2.TabIndex = 11;
			// 
			// tableLayoutPanel3
			// 
			tableLayoutPanel3.ColumnCount = 4;
			tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
			tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
			tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
			tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
			tableLayoutPanel3.Controls.Add(_SoLuong, 3, 0);
			tableLayoutPanel3.Controls.Add(lb_VTri, 0, 0);
			tableLayoutPanel3.Controls.Add(lb_SoLuong, 2, 0);
			tableLayoutPanel3.Controls.Add(_YeuCau, 1, 1);
			tableLayoutPanel3.Controls.Add(_ViTri, 1, 0);
			tableLayoutPanel3.Controls.Add(lb_YeuCau, 0, 1);
			tableLayoutPanel3.Dock = DockStyle.Fill;
			tableLayoutPanel3.Location = new Point(560, 85);
			tableLayoutPanel3.Name = "tableLayoutPanel3";
			tableLayoutPanel3.RowCount = 2;
			tableLayoutPanel3.RowStyles.Add(new RowStyle());
			tableLayoutPanel3.RowStyles.Add(new RowStyle());
			tableLayoutPanel3.Size = new Size(440, 160);
			tableLayoutPanel3.TabIndex = 12;
			// 
			// GUI_DuyetPhieuDangKy_ChiTietThongTinDangTuyen
			// 
			AutoScaleDimensions = new SizeF(11F, 28F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(tableLayoutPanel1);
			Font = new Font("Segoe UI", 12F);
			Margin = new Padding(4);
			Name = "GUI_DuyetPhieuDangKy_ChiTietThongTinDangTuyen";
			Size = new Size(1116, 622);
			tableLayoutPanel1.ResumeLayout(false);
			tableLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dsPhieuDangKy).EndInit();
			tableLayoutPanel2.ResumeLayout(false);
			tableLayoutPanel2.PerformLayout();
			tableLayoutPanel3.ResumeLayout(false);
			tableLayoutPanel3.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Label lb2;
        private TextBox _SoLuong;
        private TextBox _ViTri;
        private TextBox _YeuCau;
        private TextBox _MoTa;
        private TextBox _MaTTDT;
        private Label lb_SoLuong;
        private Label lb_VTri;
        public Label lb_MaTTDT;
        private Panel panel1;
        private Label lb_YeuCau;
        private Label lb_MoTa;
        private Label lb1;
        private PageSetupDialog pageSetupDialog1;
		private TableLayoutPanel tableLayoutPanel1;
		public DataGridView dsPhieuDangKy;
		private DataGridViewTextBoxColumn _maUV;
		private DataGridViewTextBoxColumn _trangThai;
		private DataGridViewTextBoxColumn _uuTien;
		private TableLayoutPanel tableLayoutPanel2;
		private Button btnHuy;
		private TableLayoutPanel tableLayoutPanel3;
	}
}
