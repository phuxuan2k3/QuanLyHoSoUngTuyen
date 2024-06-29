namespace GUI
{
	partial class GUI_Base
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
			btnTaoYeuCau = new Button();
			btnDanhSachThongTinDangTuyen = new Button();
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
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 2;
			tableLayoutPanel1.RowStyles.Add(new RowStyle());
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			tableLayoutPanel1.Size = new Size(800, 450);
			tableLayoutPanel1.TabIndex = 0;
			// 
			// tableLayoutPanel2
			// 
			tableLayoutPanel2.ColumnCount = 2;
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
			tableLayoutPanel2.Controls.Add(btnTaoYeuCau, 0, 0);
			tableLayoutPanel2.Controls.Add(btnDanhSachThongTinDangTuyen, 1, 0);
			tableLayoutPanel2.Dock = DockStyle.Fill;
			tableLayoutPanel2.Location = new Point(3, 3);
			tableLayoutPanel2.Name = "tableLayoutPanel2";
			tableLayoutPanel2.RowCount = 1;
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
			tableLayoutPanel2.Size = new Size(794, 44);
			tableLayoutPanel2.TabIndex = 2;
			// 
			// btnTaoYeuCau
			// 
			btnTaoYeuCau.AutoSize = true;
			btnTaoYeuCau.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			btnTaoYeuCau.Location = new Point(3, 3);
			btnTaoYeuCau.Name = "btnTaoYeuCau";
			btnTaoYeuCau.Size = new Size(211, 35);
			btnTaoYeuCau.TabIndex = 0;
			btnTaoYeuCau.Text = "Tạo yêu cầu đăng tuyển";
			btnTaoYeuCau.UseVisualStyleBackColor = true;
			btnTaoYeuCau.Click += btnTaoYeuCau_Click;
			// 
			// btnDanhSachThongTinDangTuyen
			// 
			btnDanhSachThongTinDangTuyen.AutoSize = true;
			btnDanhSachThongTinDangTuyen.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			btnDanhSachThongTinDangTuyen.Location = new Point(220, 3);
			btnDanhSachThongTinDangTuyen.Name = "btnDanhSachThongTinDangTuyen";
			btnDanhSachThongTinDangTuyen.Size = new Size(277, 35);
			btnDanhSachThongTinDangTuyen.TabIndex = 1;
			btnDanhSachThongTinDangTuyen.Text = "Danh sách thông tin đăng tuyển";
			btnDanhSachThongTinDangTuyen.UseVisualStyleBackColor = true;
			btnDanhSachThongTinDangTuyen.Click += btnDanhSachThongTinDangTuyen_Click;
			// 
			// _contentPanel
			// 
			_contentPanel.BackColor = SystemColors.ControlLight;
			_contentPanel.Dock = DockStyle.Fill;
			_contentPanel.Location = new Point(3, 53);
			_contentPanel.Name = "_contentPanel";
			_contentPanel.Size = new Size(794, 394);
			_contentPanel.TabIndex = 0;
			// 
			// GUI_Base
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(tableLayoutPanel1);
			Name = "GUI_Base";
			Text = "GUI_Base";
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
	}
}