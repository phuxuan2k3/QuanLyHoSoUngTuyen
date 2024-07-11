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
            label2 = new Label();
            label4 = new Label();
            txtTenViTri = new TextBox();
            txtTenDoanhNghiep = new TextBox();
            dsHoaDon = new DataGridView();
            label3 = new Label();
            txtMaTTDT = new TextBox();
            btnTraCuu = new Button();
            _maTTDT = new DataGridViewTextBoxColumn();
            _tenViTri = new DataGridViewTextBoxColumn();
            _tenDoanhNghiep = new DataGridViewTextBoxColumn();
            _tongTien = new DataGridViewTextBoxColumn();
            _cachThucThanhToan = new DataGridViewTextBoxColumn();
            _ngayLap = new DataGridViewTextBoxColumn();
            _trangThai = new DataGridViewTextBoxColumn();
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
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(label2, 0, 0);
            tableLayoutPanel2.Controls.Add(label4, 0, 1);
            tableLayoutPanel2.Controls.Add(txtTenViTri, 1, 0);
            tableLayoutPanel2.Controls.Add(txtTenDoanhNghiep, 1, 1);
            tableLayoutPanel2.Controls.Add(dsHoaDon, 0, 2);
            tableLayoutPanel2.Controls.Add(label3, 2, 0);
            tableLayoutPanel2.Controls.Add(txtMaTTDT, 3, 0);
            tableLayoutPanel2.Controls.Add(btnTraCuu, 3, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(30, 114);
            tableLayoutPanel2.Margin = new Padding(30);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(895, 421);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(3, 6);
            label2.Name = "label2";
            label2.Size = new Size(81, 25);
            label2.TabIndex = 3;
            label2.Text = "Tên vị trí:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(3, 45);
            label4.Name = "label4";
            label4.Size = new Size(158, 25);
            label4.TabIndex = 5;
            label4.Text = "Tên doanh nghiệp:";
            // 
            // txtTenViTri
            // 
            txtTenViTri.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtTenViTri.Location = new Point(167, 3);
            txtTenViTri.Name = "txtTenViTri";
            txtTenViTri.Size = new Size(314, 31);
            txtTenViTri.TabIndex = 6;
            txtTenViTri.TextChanged += txtTenViTri_TextChanged;
            // 
            // txtTenDoanhNghiep
            // 
            txtTenDoanhNghiep.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtTenDoanhNghiep.Location = new Point(167, 42);
            txtTenDoanhNghiep.Name = "txtTenDoanhNghiep";
            txtTenDoanhNghiep.Size = new Size(314, 31);
            txtTenDoanhNghiep.TabIndex = 7;
            txtTenDoanhNghiep.TextChanged += txtTenDoanhNghiep_TextChanged;
            // 
            // dsHoaDon
            // 
            dsHoaDon.AllowUserToAddRows = false;
            dsHoaDon.AllowUserToDeleteRows = false;
            dsHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dsHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dsHoaDon.Columns.AddRange(new DataGridViewColumn[] { _maTTDT, _tenViTri, _tenDoanhNghiep, _tongTien, _cachThucThanhToan, _ngayLap, _trangThai });
            tableLayoutPanel2.SetColumnSpan(dsHoaDon, 4);
            dsHoaDon.Dock = DockStyle.Fill;
            dsHoaDon.Location = new Point(0, 88);
            dsHoaDon.Margin = new Padding(0, 10, 0, 0);
            dsHoaDon.Name = "dsHoaDon";
            dsHoaDon.ReadOnly = true;
            dsHoaDon.RowHeadersWidth = 51;
            dsHoaDon.Size = new Size(895, 337);
            dsHoaDon.TabIndex = 2;
            dsHoaDon.CellClick += dsHoaDon_CellClick;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(487, 6);
            label3.Name = "label3";
            label3.Size = new Size(85, 25);
            label3.TabIndex = 4;
            label3.Text = "Mã TTDT:";
            // 
            // txtMaTTDT
            // 
            txtMaTTDT.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtMaTTDT.Location = new Point(578, 3);
            txtMaTTDT.Name = "txtMaTTDT";
            txtMaTTDT.Size = new Size(314, 31);
            txtMaTTDT.TabIndex = 8;
            txtMaTTDT.KeyDown += txtMaTTDT_KeyDown;
            // 
            // btnTraCuu
            // 
            btnTraCuu.Anchor = AnchorStyles.Right;
            btnTraCuu.AutoSize = true;
            btnTraCuu.Location = new Point(798, 40);
            btnTraCuu.Name = "btnTraCuu";
            btnTraCuu.Size = new Size(94, 35);
            btnTraCuu.TabIndex = 10;
            btnTraCuu.Tag = "blue";
            btnTraCuu.Text = "Tra cứu";
            btnTraCuu.UseVisualStyleBackColor = true;
            btnTraCuu.Click += btnTraCuu_Click;
            // 
            // _maTTDT
            // 
            _maTTDT.HeaderText = "Mã TTDT";
            _maTTDT.MinimumWidth = 6;
            _maTTDT.Name = "_maTTDT";
            _maTTDT.ReadOnly = true;
            _maTTDT.Width = 110;
            // 
            // _tenViTri
            // 
            _tenViTri.HeaderText = "Tên vị trí";
            _tenViTri.MinimumWidth = 6;
            _tenViTri.Name = "_tenViTri";
            _tenViTri.ReadOnly = true;
            _tenViTri.Width = 106;
            // 
            // _tenDoanhNghiep
            // 
            _tenDoanhNghiep.HeaderText = "Tên doanh nghiệp";
            _tenDoanhNghiep.MinimumWidth = 6;
            _tenDoanhNghiep.Name = "_tenDoanhNghiep";
            _tenDoanhNghiep.ReadOnly = true;
            _tenDoanhNghiep.Width = 167;
            // 
            // _tongTien
            // 
            _tongTien.HeaderText = "Tổng tiền";
            _tongTien.MinimumWidth = 6;
            _tongTien.Name = "_tongTien";
            _tongTien.ReadOnly = true;
            _tongTien.Width = 107;
            // 
            // _cachThucThanhToan
            // 
            _cachThucThanhToan.HeaderText = "Cách thức thanh toán";
            _cachThucThanhToan.MinimumWidth = 6;
            _cachThucThanhToan.Name = "_cachThucThanhToan";
            _cachThucThanhToan.ReadOnly = true;
            _cachThucThanhToan.Width = 159;
            // 
            // _ngayLap
            // 
            _ngayLap.HeaderText = "Ngày lập";
            _ngayLap.MinimumWidth = 6;
            _ngayLap.Name = "_ngayLap";
            _ngayLap.ReadOnly = true;
            _ngayLap.Width = 103;
            // 
            // _trangThai
            // 
            _trangThai.HeaderText = "Trạng thái";
            _trangThai.MinimumWidth = 6;
            _trangThai.Name = "_trangThai";
            _trangThai.ReadOnly = true;
            _trangThai.Width = 109;
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
        private Label label4;
        private TextBox txtTenViTri;
        private TextBox txtTenDoanhNghiep;
        private Label label3;
        private TextBox txtMaTTDT;
        private Button btnTraCuu;
        private DataGridViewTextBoxColumn _maTTDT;
        private DataGridViewTextBoxColumn _tenViTri;
        private DataGridViewTextBoxColumn _tenDoanhNghiep;
        private DataGridViewTextBoxColumn _tongTien;
        private DataGridViewTextBoxColumn _cachThucThanhToan;
        private DataGridViewTextBoxColumn _ngayLap;
        private DataGridViewTextBoxColumn _trangThai;
    }
}
