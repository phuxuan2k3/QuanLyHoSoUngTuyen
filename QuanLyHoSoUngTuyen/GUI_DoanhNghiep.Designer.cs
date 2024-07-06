namespace GUI
{
	partial class GUI_DoanhNghiep
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			tableLayoutPanel1 = new TableLayoutPanel();
			tableLayoutPanel2 = new TableLayoutPanel();
			btnXetDuyetTTDT = new Button();
			btnDangTuyenTTDT = new Button();
			btnTaoYeuCau = new Button();
			btnXacThucDN = new Button();
			btnDanhSachThongTinDangTuyen = new Button();
			btnCapNhatTTDN = new Button();
			_contentPanel = new Panel();
			tableLayoutPanel1.SuspendLayout();
			tableLayoutPanel2.SuspendLayout();
			SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.ColumnCount = 1;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 0);
			tableLayoutPanel1.Controls.Add(_contentPanel, 0, 1);
			tableLayoutPanel1.Dock = DockStyle.Fill;
			tableLayoutPanel1.Location = new Point(0, 0);
			tableLayoutPanel1.Margin = new Padding(2);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 2;
			tableLayoutPanel1.RowStyles.Add(new RowStyle());
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			tableLayoutPanel1.Size = new Size(882, 553);
			tableLayoutPanel1.TabIndex = 0;
			// 
			// tableLayoutPanel2
			// 
			tableLayoutPanel2.ColumnCount = 6;
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
			tableLayoutPanel2.Controls.Add(btnXetDuyetTTDT, 4, 0);
			tableLayoutPanel2.Controls.Add(btnDangTuyenTTDT, 3, 0);
			tableLayoutPanel2.Controls.Add(btnTaoYeuCau, 0, 0);
			tableLayoutPanel2.Controls.Add(btnXacThucDN, 2, 0);
			tableLayoutPanel2.Controls.Add(btnDanhSachThongTinDangTuyen, 1, 0);
			tableLayoutPanel2.Controls.Add(btnCapNhatTTDN, 5, 0);
			tableLayoutPanel2.Dock = DockStyle.Fill;
			tableLayoutPanel2.Location = new Point(2, 2);
			tableLayoutPanel2.Margin = new Padding(2);
			tableLayoutPanel2.Name = "tableLayoutPanel2";
			tableLayoutPanel2.RowCount = 1;
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			tableLayoutPanel2.Size = new Size(878, 44);
			tableLayoutPanel2.TabIndex = 2;
			// 
			// btnXetDuyetTTDT
			// 
			btnXetDuyetTTDT.AutoSize = true;
			btnXetDuyetTTDT.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			btnXetDuyetTTDT.Location = new Point(826, 2);
			btnXetDuyetTTDT.Margin = new Padding(2);
			btnXetDuyetTTDT.Name = "btnXetDuyetTTDT";
			btnXetDuyetTTDT.Size = new Size(263, 35);
			btnXetDuyetTTDT.TabIndex = 3;
			btnXetDuyetTTDT.Text = "Xác thực thông tin đăng tuyển";
			btnXetDuyetTTDT.UseVisualStyleBackColor = true;
			btnXetDuyetTTDT.Click += btnXetDuyetTTDT_Click;
			// 
			// btnDangTuyenTTDT
			// 
			btnDangTuyenTTDT.AutoSize = true;
			btnDangTuyenTTDT.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			btnDangTuyenTTDT.Location = new Point(708, 2);
			btnDangTuyenTTDT.Margin = new Padding(2);
			btnDangTuyenTTDT.Name = "btnDangTuyenTTDT";
			btnDangTuyenTTDT.Size = new Size(114, 35);
			btnDangTuyenTTDT.TabIndex = 4;
			btnDangTuyenTTDT.Text = "Đăng tuyển";
			btnDangTuyenTTDT.UseVisualStyleBackColor = true;
			btnDangTuyenTTDT.Click += btnDangTuyenTTDT_Click;
			// 
			// btnTaoYeuCau
			// 
			btnTaoYeuCau.AutoSize = true;
			btnTaoYeuCau.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			btnTaoYeuCau.Location = new Point(2, 2);
			btnTaoYeuCau.Margin = new Padding(2);
			btnTaoYeuCau.Name = "btnTaoYeuCau";
			btnTaoYeuCau.Size = new Size(211, 35);
			btnTaoYeuCau.TabIndex = 0;
			btnTaoYeuCau.Text = "Tạo yêu cầu đăng tuyển";
			btnTaoYeuCau.UseVisualStyleBackColor = true;
			btnTaoYeuCau.Click += btnTaoYeuCau_Click;
			// 
			// btnXacThucDN
			// 
			btnXacThucDN.AutoSize = true;
			btnXacThucDN.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			btnXacThucDN.Location = new Point(498, 2);
			btnXacThucDN.Margin = new Padding(2);
			btnXacThucDN.Name = "btnXacThucDN";
			btnXacThucDN.Size = new Size(206, 35);
			btnXacThucDN.TabIndex = 2;
			btnXacThucDN.Text = "Xác thực doanh nghiệp";
			btnXacThucDN.UseVisualStyleBackColor = true;
			btnXacThucDN.Click += btnXacThucDN_Click;
			// 
			// btnDanhSachThongTinDangTuyen
			// 
			btnDanhSachThongTinDangTuyen.AutoSize = true;
			btnDanhSachThongTinDangTuyen.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			btnDanhSachThongTinDangTuyen.Location = new Point(217, 2);
			btnDanhSachThongTinDangTuyen.Margin = new Padding(2);
			btnDanhSachThongTinDangTuyen.Name = "btnDanhSachThongTinDangTuyen";
			btnDanhSachThongTinDangTuyen.Size = new Size(277, 35);
			btnDanhSachThongTinDangTuyen.TabIndex = 1;
			btnDanhSachThongTinDangTuyen.Text = "Danh sách thông tin đăng tuyển";
			btnDanhSachThongTinDangTuyen.UseVisualStyleBackColor = true;
			btnDanhSachThongTinDangTuyen.Click += btnDanhSachThongTinDangTuyen_Click;
			// 
			// btnCapNhatTTDN
			// 
			btnCapNhatTTDN.Location = new Point(1095, 4);
			btnCapNhatTTDN.Margin = new Padding(4);
			btnCapNhatTTDN.Name = "btnCapNhatTTDN";
			btnCapNhatTTDN.Size = new Size(199, 36);
			btnCapNhatTTDN.TabIndex = 5;
			btnCapNhatTTDN.Text = "Cập nhật TT DN";
			btnCapNhatTTDN.UseVisualStyleBackColor = true;
			btnCapNhatTTDN.Click += btnCapNhatTTDN_Click;
			// 
			// _contentPanel
			// 
			_contentPanel.BackColor = SystemColors.ControlLight;
			_contentPanel.Dock = DockStyle.Fill;
			_contentPanel.Location = new Point(2, 50);
			_contentPanel.Margin = new Padding(2);
			_contentPanel.Name = "_contentPanel";
			_contentPanel.Size = new Size(878, 501);
			_contentPanel.TabIndex = 0;
			// 
			// GUI_DoanhNghiep
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(882, 553);
			Controls.Add(tableLayoutPanel1);
			Margin = new Padding(2);
			Name = "GUI_DoanhNghiep";
			Text = "Doanh nghiệp";
			Click += btnTaoYeuCau_Click;
			tableLayoutPanel1.ResumeLayout(false);
			tableLayoutPanel2.ResumeLayout(false);
			tableLayoutPanel2.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private TableLayoutPanel tableLayoutPanel1;
		private Panel _contentPanel;
		private TableLayoutPanel tableLayoutPanel2;
		private Button btnTaoYeuCau;
		private Button btnDanhSachThongTinDangTuyen;
        private Button btnXacThucDN;
        private Button btnXetDuyetTTDT;
        private Button btnDangTuyenTTDT;
        private Button btnCapNhatTTDN;
    }
}