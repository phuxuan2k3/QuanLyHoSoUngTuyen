namespace GUI
{
    partial class GUI_DanhSachPhieuDK_DN
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
			btnHuy = new Button();
			lb_dsTTDT = new Label();
			button1 = new Button();
			dsPhieuDangKy = new DataGridView();
			_maUV = new DataGridViewTextBoxColumn();
			_trangThai = new DataGridViewTextBoxColumn();
			_uuTien = new DataGridViewTextBoxColumn();
			lbTTDT = new Label();
			tableLayoutPanel1 = new TableLayoutPanel();
			tableLayoutPanel2 = new TableLayoutPanel();
			((System.ComponentModel.ISupportInitialize)dsPhieuDangKy).BeginInit();
			tableLayoutPanel1.SuspendLayout();
			tableLayoutPanel2.SuspendLayout();
			SuspendLayout();
			// 
			// btnHuy
			// 
			btnHuy.Anchor = AnchorStyles.Right;
			btnHuy.BackColor = Color.Red;
			btnHuy.Location = new Point(739, 40);
			btnHuy.Margin = new Padding(4, 4, 4, 4);
			btnHuy.Name = "btnHuy";
			btnHuy.Size = new Size(130, 40);
			btnHuy.TabIndex = 8;
			btnHuy.Text = "Hủy";
			btnHuy.UseVisualStyleBackColor = false;
			btnHuy.Click += btnHuy_Click;
			// 
			// lb_dsTTDT
			// 
			lb_dsTTDT.Anchor = AnchorStyles.Left;
			lb_dsTTDT.AutoSize = true;
			lb_dsTTDT.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 163);
			lb_dsTTDT.Location = new Point(113, 44);
			lb_dsTTDT.Margin = new Padding(4, 0, 4, 0);
			lb_dsTTDT.Name = "lb_dsTTDT";
			lb_dsTTDT.Size = new Size(335, 37);
			lb_dsTTDT.TabIndex = 6;
			lb_dsTTDT.Text = "Danh sách phiếu đăng ký";
			// 
			// button1
			// 
			button1.Anchor = AnchorStyles.Left;
			button1.BackColor = Color.DodgerBlue;
			button1.Location = new Point(4, 40);
			button1.Margin = new Padding(4, 4, 4, 4);
			button1.Name = "button1";
			button1.Size = new Size(282, 40);
			button1.TabIndex = 9;
			button1.Text = "Thông báo đến Ứng viên";
			button1.UseVisualStyleBackColor = false;
			button1.Click += button1_Click;
			// 
			// dsPhieuDangKy
			// 
			dsPhieuDangKy.AllowUserToAddRows = false;
			dsPhieuDangKy.AllowUserToDeleteRows = false;
			dsPhieuDangKy.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dsPhieuDangKy.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
			dsPhieuDangKy.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dsPhieuDangKy.Columns.AddRange(new DataGridViewColumn[] { _maUV, _trangThai, _uuTien });
			dsPhieuDangKy.Location = new Point(113, 129);
			dsPhieuDangKy.Margin = new Padding(4, 4, 4, 4);
			dsPhieuDangKy.Name = "dsPhieuDangKy";
			dsPhieuDangKy.ReadOnly = true;
			dsPhieuDangKy.RowHeadersWidth = 51;
			dsPhieuDangKy.Size = new Size(870, 361);
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
			// lbTTDT
			// 
			lbTTDT.AutoSize = true;
			lbTTDT.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
			lbTTDT.Location = new Point(851, 57);
			lbTTDT.Margin = new Padding(4, 0, 4, 0);
			lbTTDT.Name = "lbTTDT";
			lbTTDT.Size = new Size(0, 31);
			lbTTDT.TabIndex = 11;
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.ColumnCount = 3;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
			tableLayoutPanel1.Controls.Add(lb_dsTTDT, 1, 0);
			tableLayoutPanel1.Controls.Add(dsPhieuDangKy, 1, 1);
			tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 2);
			tableLayoutPanel1.Dock = DockStyle.Fill;
			tableLayoutPanel1.Location = new Point(0, 0);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 3;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
			tableLayoutPanel1.Size = new Size(1099, 627);
			tableLayoutPanel1.TabIndex = 12;
			// 
			// tableLayoutPanel2
			// 
			tableLayoutPanel2.ColumnCount = 2;
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel2.Controls.Add(button1, 0, 1);
			tableLayoutPanel2.Controls.Add(btnHuy, 1, 1);
			tableLayoutPanel2.Dock = DockStyle.Fill;
			tableLayoutPanel2.Location = new Point(112, 504);
			tableLayoutPanel2.Name = "tableLayoutPanel2";
			tableLayoutPanel2.RowCount = 3;
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel2.RowStyles.Add(new RowStyle());
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel2.Size = new Size(873, 120);
			tableLayoutPanel2.TabIndex = 11;
			// 
			// GUI_DanhSachPhieuDK_DN
			// 
			AutoScaleDimensions = new SizeF(11F, 28F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(lbTTDT);
			Controls.Add(tableLayoutPanel1);
			Font = new Font("Segoe UI", 12F);
			Margin = new Padding(4, 4, 4, 4);
			Name = "GUI_DanhSachPhieuDK_DN";
			Size = new Size(1099, 627);
			((System.ComponentModel.ISupportInitialize)dsPhieuDangKy).EndInit();
			tableLayoutPanel1.ResumeLayout(false);
			tableLayoutPanel1.PerformLayout();
			tableLayoutPanel2.ResumeLayout(false);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnHuy;
        private Label lb_dsTTDT;
        private Button button1;
        public DataGridView dsPhieuDangKy;
        private DataGridViewTextBoxColumn _maUV;
        private DataGridViewTextBoxColumn _trangThai;
        private DataGridViewTextBoxColumn _uuTien;
        private Label lbTTDT;
		private TableLayoutPanel tableLayoutPanel1;
		private TableLayoutPanel tableLayoutPanel2;
	}
}
