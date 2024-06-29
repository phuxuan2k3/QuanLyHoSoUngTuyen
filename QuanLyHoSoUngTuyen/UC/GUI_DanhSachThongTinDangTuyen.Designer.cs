namespace GUI.UC
{
	partial class GUI_DanhSachThongTinDangTuyen
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
			tableLayoutPanel1 = new TableLayoutPanel();
			label1 = new Label();
			dsThongTinDangTuyen = new DataGridView();
			viTri = new DataGridViewTextBoxColumn();
			_soLuong = new DataGridViewTextBoxColumn();
			_thoiGianDang = new DataGridViewTextBoxColumn();
			_soNgayDang = new DataGridViewTextBoxColumn();
			_trangThai = new DataGridViewTextBoxColumn();
			_tinhTrang = new DataGridViewTextBoxColumn();
			tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dsThongTinDangTuyen).BeginInit();
			SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.ColumnCount = 1;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			tableLayoutPanel1.Controls.Add(label1, 0, 0);
			tableLayoutPanel1.Controls.Add(dsThongTinDangTuyen, 0, 1);
			tableLayoutPanel1.Dock = DockStyle.Fill;
			tableLayoutPanel1.Location = new Point(0, 0);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 2;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 85F));
			tableLayoutPanel1.Size = new Size(800, 484);
			tableLayoutPanel1.TabIndex = 0;
			// 
			// label1
			// 
			label1.Anchor = AnchorStyles.None;
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.Location = new Point(213, 20);
			label1.Name = "label1";
			label1.Size = new Size(374, 31);
			label1.TabIndex = 0;
			label1.Text = "Danh Sách Thông Tin Đăng Tuyển";
			// 
			// dsThongTinDangTuyen
			// 
			dsThongTinDangTuyen.AllowUserToAddRows = false;
			dsThongTinDangTuyen.AllowUserToDeleteRows = false;
			dsThongTinDangTuyen.Anchor = AnchorStyles.None;
			dsThongTinDangTuyen.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
			dsThongTinDangTuyen.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dsThongTinDangTuyen.Columns.AddRange(new DataGridViewColumn[] { viTri, _soLuong, _thoiGianDang, _soNgayDang, _trangThai, _tinhTrang });
			dsThongTinDangTuyen.Location = new Point(30, 102);
			dsThongTinDangTuyen.Margin = new Padding(30);
			dsThongTinDangTuyen.Name = "dsThongTinDangTuyen";
			dsThongTinDangTuyen.ReadOnly = true;
			dsThongTinDangTuyen.RowHeadersWidth = 51;
			dsThongTinDangTuyen.Size = new Size(740, 352);
			dsThongTinDangTuyen.TabIndex = 1;
			// 
			// viTri
			// 
			viTri.Frozen = true;
			viTri.HeaderText = "Vị trí";
			viTri.MinimumWidth = 6;
			viTri.Name = "viTri";
			viTri.ReadOnly = true;
			viTri.Width = 77;
			// 
			// _soLuong
			// 
			_soLuong.HeaderText = "Số lượng";
			_soLuong.MinimumWidth = 6;
			_soLuong.Name = "_soLuong";
			_soLuong.ReadOnly = true;
			_soLuong.Width = 114;
			// 
			// _thoiGianDang
			// 
			_thoiGianDang.HeaderText = "Thời gian đăng";
			_thoiGianDang.MinimumWidth = 6;
			_thoiGianDang.Name = "_thoiGianDang";
			_thoiGianDang.ReadOnly = true;
			_thoiGianDang.Width = 160;
			// 
			// _soNgayDang
			// 
			_soNgayDang.HeaderText = "Số ngày đăng";
			_soNgayDang.MinimumWidth = 6;
			_soNgayDang.Name = "_soNgayDang";
			_soNgayDang.ReadOnly = true;
			_soNgayDang.Width = 152;
			// 
			// _trangThai
			// 
			_trangThai.HeaderText = "Trạng thái";
			_trangThai.MinimumWidth = 6;
			_trangThai.Name = "_trangThai";
			_trangThai.ReadOnly = true;
			_trangThai.Width = 118;
			// 
			// _tinhTrang
			// 
			_tinhTrang.HeaderText = "Tình trạng";
			_tinhTrang.MinimumWidth = 6;
			_tinhTrang.Name = "_tinhTrang";
			_tinhTrang.ReadOnly = true;
			_tinhTrang.Width = 121;
			// 
			// GUI_DanhSachThongTinDangTuyen
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(tableLayoutPanel1);
			Name = "GUI_DanhSachThongTinDangTuyen";
			Size = new Size(800, 484);
			tableLayoutPanel1.ResumeLayout(false);
			tableLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dsThongTinDangTuyen).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private TableLayoutPanel tableLayoutPanel1;
		private Label label1;
		private DataGridView dsThongTinDangTuyen;
		private DataGridViewTextBoxColumn viTri;
		private DataGridViewTextBoxColumn _soLuong;
		private DataGridViewTextBoxColumn _thoiGianDang;
		private DataGridViewTextBoxColumn _soNgayDang;
		private DataGridViewTextBoxColumn _trangThai;
		private DataGridViewTextBoxColumn _tinhTrang;
	}
}
