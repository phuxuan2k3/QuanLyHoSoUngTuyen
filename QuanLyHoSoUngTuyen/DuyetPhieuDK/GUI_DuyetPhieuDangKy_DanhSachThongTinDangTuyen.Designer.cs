namespace GUI
{
    partial class GUI_DuyetPhieuDangKy_DanhSachThongTinDangTuyen
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
			dsThongTinDangTuyen = new DataGridView();
			_maTTDT = new DataGridViewTextBoxColumn();
			_maDN = new DataGridViewTextBoxColumn();
			_soLuong = new DataGridViewTextBoxColumn();
			lb_dsTTDT = new Label();
			tableLayoutPanel1 = new TableLayoutPanel();
			((System.ComponentModel.ISupportInitialize)dsThongTinDangTuyen).BeginInit();
			tableLayoutPanel1.SuspendLayout();
			SuspendLayout();
			// 
			// dsThongTinDangTuyen
			// 
			dsThongTinDangTuyen.AllowUserToAddRows = false;
			dsThongTinDangTuyen.AllowUserToDeleteRows = false;
			dsThongTinDangTuyen.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dsThongTinDangTuyen.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
			dsThongTinDangTuyen.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dsThongTinDangTuyen.Columns.AddRange(new DataGridViewColumn[] { _maTTDT, _maDN, _soLuong });
			tableLayoutPanel1.SetColumnSpan(dsThongTinDangTuyen, 2);
			dsThongTinDangTuyen.Location = new Point(114, 90);
			dsThongTinDangTuyen.Margin = new Padding(4);
			dsThongTinDangTuyen.Name = "dsThongTinDangTuyen";
			dsThongTinDangTuyen.ReadOnly = true;
			dsThongTinDangTuyen.RowHeadersWidth = 51;
			dsThongTinDangTuyen.Size = new Size(872, 395);
			dsThongTinDangTuyen.TabIndex = 7;
			dsThongTinDangTuyen.CellContentClick += dsThongTinDangTuyen_CellContentClick;
			// 
			// _maTTDT
			// 
			_maTTDT.HeaderText = "Ma TTDT";
			_maTTDT.MinimumWidth = 6;
			_maTTDT.Name = "_maTTDT";
			_maTTDT.ReadOnly = true;
			// 
			// _maDN
			// 
			_maDN.HeaderText = "Ma DN";
			_maDN.MinimumWidth = 6;
			_maDN.Name = "_maDN";
			_maDN.ReadOnly = true;
			// 
			// _soLuong
			// 
			_soLuong.HeaderText = "So Luong";
			_soLuong.MinimumWidth = 6;
			_soLuong.Name = "_soLuong";
			_soLuong.ReadOnly = true;
			// 
			// lb_dsTTDT
			// 
			lb_dsTTDT.Anchor = AnchorStyles.Left;
			lb_dsTTDT.AutoSize = true;
			lb_dsTTDT.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 163);
			lb_dsTTDT.Location = new Point(114, 24);
			lb_dsTTDT.Margin = new Padding(4, 0, 4, 0);
			lb_dsTTDT.Name = "lb_dsTTDT";
			lb_dsTTDT.Size = new Size(300, 37);
			lb_dsTTDT.TabIndex = 6;
			lb_dsTTDT.Text = " Thông tin đăng tuyển";
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.ColumnCount = 4;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
			tableLayoutPanel1.Controls.Add(dsThongTinDangTuyen, 1, 1);
			tableLayoutPanel1.Controls.Add(lb_dsTTDT, 1, 0);
			tableLayoutPanel1.Dock = DockStyle.Fill;
			tableLayoutPanel1.Location = new Point(0, 0);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 3;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
			tableLayoutPanel1.Size = new Size(1100, 577);
			tableLayoutPanel1.TabIndex = 9;
			// 
			// GUI_DuyetPhieuDangKy_DanhSachThongTinDangTuyen
			// 
			AutoScaleDimensions = new SizeF(11F, 28F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(tableLayoutPanel1);
			Font = new Font("Segoe UI", 12F);
			Margin = new Padding(4);
			Name = "GUI_DuyetPhieuDangKy_DanhSachThongTinDangTuyen";
			Size = new Size(1100, 577);
			((System.ComponentModel.ISupportInitialize)dsThongTinDangTuyen).EndInit();
			tableLayoutPanel1.ResumeLayout(false);
			tableLayoutPanel1.PerformLayout();
			ResumeLayout(false);
		}

		#endregion
		private DataGridView dsThongTinDangTuyen;
        private Label lb_dsTTDT;
        private DataGridViewTextBoxColumn _maTTDT;
        private DataGridViewTextBoxColumn _maDN;
        private DataGridViewTextBoxColumn _soLuong;
		private TableLayoutPanel tableLayoutPanel1;
	}
}
