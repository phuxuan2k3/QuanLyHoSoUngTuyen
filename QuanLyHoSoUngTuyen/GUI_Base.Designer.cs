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
			_contentPanel = new Panel();
			guI_DanhSachThongTinDangTuyen1 = new UC.GUI_DanhSachThongTinDangTuyen();
			tableLayoutPanel2 = new TableLayoutPanel();
			btnTaoYeuCau = new Button();
			btnDanhSachThongTinDangTuyen = new Button();
			tableLayoutPanel1.SuspendLayout();
			_contentPanel.SuspendLayout();
			tableLayoutPanel2.SuspendLayout();
			SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.ColumnCount = 2;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
			tableLayoutPanel1.Controls.Add(_contentPanel, 1, 0);
			tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
			tableLayoutPanel1.Dock = DockStyle.Fill;
			tableLayoutPanel1.Location = new Point(0, 0);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 1;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			tableLayoutPanel1.Size = new Size(800, 450);
			tableLayoutPanel1.TabIndex = 0;
			// 
			// _contentPanel
			// 
			_contentPanel.BackColor = SystemColors.ActiveCaption;
			_contentPanel.Controls.Add(guI_DanhSachThongTinDangTuyen1);
			_contentPanel.Dock = DockStyle.Fill;
			_contentPanel.Location = new Point(203, 3);
			_contentPanel.Name = "_contentPanel";
			_contentPanel.Size = new Size(594, 444);
			_contentPanel.TabIndex = 0;
			// 
			// guI_DanhSachThongTinDangTuyen1
			// 
			guI_DanhSachThongTinDangTuyen1.Dock = DockStyle.Fill;
			guI_DanhSachThongTinDangTuyen1.Location = new Point(0, 0);
			guI_DanhSachThongTinDangTuyen1.Name = "guI_DanhSachThongTinDangTuyen1";
			guI_DanhSachThongTinDangTuyen1.Size = new Size(594, 444);
			guI_DanhSachThongTinDangTuyen1.TabIndex = 0;
			// 
			// tableLayoutPanel2
			// 
			tableLayoutPanel2.ColumnCount = 1;
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel2.Controls.Add(btnTaoYeuCau, 0, 0);
			tableLayoutPanel2.Controls.Add(btnDanhSachThongTinDangTuyen, 0, 1);
			tableLayoutPanel2.Location = new Point(3, 3);
			tableLayoutPanel2.Name = "tableLayoutPanel2";
			tableLayoutPanel2.RowCount = 2;
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel2.Size = new Size(194, 125);
			tableLayoutPanel2.TabIndex = 1;
			// 
			// btnTaoYeuCau
			// 
			btnTaoYeuCau.Dock = DockStyle.Fill;
			btnTaoYeuCau.Location = new Point(3, 3);
			btnTaoYeuCau.Name = "btnTaoYeuCau";
			btnTaoYeuCau.Size = new Size(188, 56);
			btnTaoYeuCau.TabIndex = 0;
			btnTaoYeuCau.Text = "Tạo yêu cầu đăng tuyển";
			btnTaoYeuCau.UseVisualStyleBackColor = true;
			btnTaoYeuCau.Click += btnTaoYeuCau_Click;
			// 
			// btnDanhSachThongTinDangTuyen
			// 
			btnDanhSachThongTinDangTuyen.Dock = DockStyle.Fill;
			btnDanhSachThongTinDangTuyen.Location = new Point(3, 65);
			btnDanhSachThongTinDangTuyen.Name = "btnDanhSachThongTinDangTuyen";
			btnDanhSachThongTinDangTuyen.Size = new Size(188, 57);
			btnDanhSachThongTinDangTuyen.TabIndex = 1;
			btnDanhSachThongTinDangTuyen.Text = "Danh sách thông tin đăng tuyển";
			btnDanhSachThongTinDangTuyen.UseVisualStyleBackColor = true;
			btnDanhSachThongTinDangTuyen.Click += btnDanhSachThongTinDangTuyen_Click;
			// 
			// GUI_Base
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(tableLayoutPanel1);
			Name = "GUI_Base";
			Text = "GUI_Base";
			tableLayoutPanel1.ResumeLayout(false);
			_contentPanel.ResumeLayout(false);
			tableLayoutPanel2.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private TableLayoutPanel tableLayoutPanel1;
		private Panel _contentPanel;
		private UC.GUI_DanhSachThongTinDangTuyen guI_DanhSachThongTinDangTuyen1;
		private TableLayoutPanel tableLayoutPanel2;
		private Button btnTaoYeuCau;
		private Button btnDanhSachThongTinDangTuyen;
	}
}