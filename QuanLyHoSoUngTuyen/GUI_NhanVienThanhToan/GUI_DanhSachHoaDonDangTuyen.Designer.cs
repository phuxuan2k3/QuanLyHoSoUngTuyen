namespace GUI.UserControls
{
	partial class GUI_DanhSachHoaDonDangTuyen
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
			tableLayoutPanel2 = new TableLayoutPanel();
			dsHoaDon = new DataGridView();
			_maTTDT = new DataGridViewTextBoxColumn();
			_tongTien = new DataGridViewTextBoxColumn();
			_cachThucThanhToan = new DataGridViewTextBoxColumn();
			_ngayLap = new DataGridViewTextBoxColumn();
			_trangThai = new DataGridViewTextBoxColumn();
			label2 = new Label();
			txtMaTTDT = new TextBox();
			btnTraCuu = new Button();
			label3 = new Label();
			tableLayoutPanel1.SuspendLayout();
			tableLayoutPanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dsHoaDon).BeginInit();
			SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.ColumnCount = 1;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			tableLayoutPanel1.Controls.Add(label1, 0, 0);
			tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
			tableLayoutPanel1.Dock = DockStyle.Fill;
			tableLayoutPanel1.Location = new Point(0, 0);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 2;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 85F));
			tableLayoutPanel1.Size = new Size(955, 565);
			tableLayoutPanel1.TabIndex = 0;
			// 
			// label1
			// 
			label1.Anchor = AnchorStyles.None;
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.Location = new Point(290, 26);
			label1.Name = "label1";
			label1.Size = new Size(374, 31);
			label1.TabIndex = 0;
			label1.Text = "Danh Sách Thông Tin Đăng Tuyển";
			// 
			// tableLayoutPanel2
			// 
			tableLayoutPanel2.ColumnCount = 3;
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
			tableLayoutPanel2.Controls.Add(dsHoaDon, 0, 1);
			tableLayoutPanel2.Controls.Add(label2, 0, 0);
			tableLayoutPanel2.Controls.Add(txtMaTTDT, 1, 0);
			tableLayoutPanel2.Controls.Add(btnTraCuu, 2, 0);
			tableLayoutPanel2.Controls.Add(label3, 2, 2);
			tableLayoutPanel2.Dock = DockStyle.Fill;
			tableLayoutPanel2.Location = new Point(30, 114);
			tableLayoutPanel2.Margin = new Padding(30);
			tableLayoutPanel2.Name = "tableLayoutPanel2";
			tableLayoutPanel2.RowCount = 3;
			tableLayoutPanel2.RowStyles.Add(new RowStyle());
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			tableLayoutPanel2.RowStyles.Add(new RowStyle());
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
			tableLayoutPanel2.Size = new Size(895, 421);
			tableLayoutPanel2.TabIndex = 1;
			// 
			// dsHoaDon
			// 
			dsHoaDon.AllowUserToAddRows = false;
			dsHoaDon.AllowUserToDeleteRows = false;
			dsHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dsHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dsHoaDon.Columns.AddRange(new DataGridViewColumn[] { _maTTDT, _tongTien, _cachThucThanhToan, _ngayLap, _trangThai });
			tableLayoutPanel2.SetColumnSpan(dsHoaDon, 3);
			dsHoaDon.Dock = DockStyle.Fill;
			dsHoaDon.Location = new Point(0, 57);
			dsHoaDon.Margin = new Padding(0, 20, 0, 10);
			dsHoaDon.Name = "dsHoaDon";
			dsHoaDon.ReadOnly = true;
			dsHoaDon.RowHeadersWidth = 51;
			dsHoaDon.Size = new Size(895, 329);
			dsHoaDon.TabIndex = 2;
			dsHoaDon.CellClick += dsHoaDon_CellClick;
			// 
			// _maTTDT
			// 
			_maTTDT.HeaderText = "Mã TTDT";
			_maTTDT.MinimumWidth = 6;
			_maTTDT.Name = "_maTTDT";
			_maTTDT.ReadOnly = true;
			// 
			// _tongTien
			// 
			_tongTien.HeaderText = "Tổng tiền";
			_tongTien.MinimumWidth = 6;
			_tongTien.Name = "_tongTien";
			_tongTien.ReadOnly = true;
			// 
			// _cachThucThanhToan
			// 
			_cachThucThanhToan.HeaderText = "Cách thức thanh toán";
			_cachThucThanhToan.MinimumWidth = 6;
			_cachThucThanhToan.Name = "_cachThucThanhToan";
			_cachThucThanhToan.ReadOnly = true;
			// 
			// _ngayLap
			// 
			_ngayLap.HeaderText = "Ngày lập";
			_ngayLap.MinimumWidth = 6;
			_ngayLap.Name = "_ngayLap";
			_ngayLap.ReadOnly = true;
			// 
			// _trangThai
			// 
			_trangThai.HeaderText = "Trạng thái";
			_trangThai.MinimumWidth = 6;
			_trangThai.Name = "_trangThai";
			_trangThai.ReadOnly = true;
			// 
			// label2
			// 
			label2.Anchor = AnchorStyles.Left;
			label2.AutoSize = true;
			label2.Location = new Point(3, 6);
			label2.Name = "label2";
			label2.Size = new Size(214, 25);
			label2.TabIndex = 3;
			label2.Text = "Mã thông tin đăng tuyển:";
			// 
			// txtMaTTDT
			// 
			txtMaTTDT.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			txtMaTTDT.Location = new Point(223, 3);
			txtMaTTDT.Name = "txtMaTTDT";
			txtMaTTDT.Size = new Size(552, 31);
			txtMaTTDT.TabIndex = 4;
			txtMaTTDT.KeyDown += txtMaTTDT_KeyDown;
			// 
			// btnTraCuu
			// 
			btnTraCuu.Anchor = AnchorStyles.Right;
			btnTraCuu.AutoSize = true;
			btnTraCuu.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			btnTraCuu.Location = new Point(817, 1);
			btnTraCuu.Margin = new Padding(5, 0, 0, 0);
			btnTraCuu.Name = "btnTraCuu";
			btnTraCuu.Size = new Size(78, 35);
			btnTraCuu.TabIndex = 5;
			btnTraCuu.Tag = "blue";
			btnTraCuu.Text = "Tra cứu";
			btnTraCuu.UseVisualStyleBackColor = true;
			btnTraCuu.Click += btnTraCuu_Click;
			// 
			// label3
			// 
			label3.Anchor = AnchorStyles.Right;
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic);
			label3.Location = new Point(781, 396);
			label3.Name = "label3";
			label3.Size = new Size(111, 25);
			label3.TabIndex = 6;
			label3.Text = "Đơn vị: VND";
			// 
			// GUI_DanhSachHoaDonDangTuyen
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(tableLayoutPanel1);
			Name = "GUI_DanhSachHoaDonDangTuyen";
			Size = new Size(955, 565);
			tableLayoutPanel1.ResumeLayout(false);
			tableLayoutPanel1.PerformLayout();
			tableLayoutPanel2.ResumeLayout(false);
			tableLayoutPanel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dsHoaDon).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private TableLayoutPanel tableLayoutPanel1;
		private Label label1;
		private TableLayoutPanel tableLayoutPanel2;
		private DataGridView dsHoaDon;
		private Label label2;
		private TextBox txtMaTTDT;
		private Button btnTraCuu;
		private Label label3;
		private DataGridViewTextBoxColumn _maTTDT;
		private DataGridViewTextBoxColumn _tongTien;
		private DataGridViewTextBoxColumn _cachThucThanhToan;
		private DataGridViewTextBoxColumn _ngayLap;
		private DataGridViewTextBoxColumn _trangThai;
	}
}
