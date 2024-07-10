namespace GUI
{
    partial class GUI_DanhSachThongTinDangTuyen_DN
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
			dsThongTinDangTuyen = new DataGridView();
			_maTTDT = new DataGridViewTextBoxColumn();
			_maDN = new DataGridViewTextBoxColumn();
			_soLuong = new DataGridViewTextBoxColumn();
			tableLayoutPanel1 = new TableLayoutPanel();
			button1 = new Button();
			dataGridView1 = new DataGridView();
			dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
			dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
			dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
			tableLayoutPanel2 = new TableLayoutPanel();
			((System.ComponentModel.ISupportInitialize)dsThongTinDangTuyen).BeginInit();
			tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			tableLayoutPanel2.SuspendLayout();
			SuspendLayout();
			// 
			// btnHuy
			// 
			btnHuy.Anchor = AnchorStyles.Right;
			btnHuy.BackColor = SystemColors.ScrollBar;
			btnHuy.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
			btnHuy.Location = new Point(853, 561);
			btnHuy.Margin = new Padding(4);
			btnHuy.Name = "btnHuy";
			btnHuy.Size = new Size(130, 40);
			btnHuy.TabIndex = 5;
			btnHuy.Tag = "red";
			btnHuy.Text = "Hủy";
			btnHuy.UseVisualStyleBackColor = false;
			btnHuy.Click += btnHuy_Click;
			// 
			// lb_dsTTDT
			// 
			lb_dsTTDT.Anchor = AnchorStyles.Left;
			lb_dsTTDT.AutoSize = true;
			lb_dsTTDT.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 163);
			lb_dsTTDT.Location = new Point(113, 26);
			lb_dsTTDT.Margin = new Padding(4, 0, 4, 0);
			lb_dsTTDT.Name = "lb_dsTTDT";
			lb_dsTTDT.Size = new Size(293, 37);
			lb_dsTTDT.TabIndex = 3;
			lb_dsTTDT.Text = "Thông tin đăng tuyển";
			// 
			// dsThongTinDangTuyen
			// 
			dsThongTinDangTuyen.AllowUserToAddRows = false;
			dsThongTinDangTuyen.AllowUserToDeleteRows = false;
			dsThongTinDangTuyen.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dsThongTinDangTuyen.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
			dsThongTinDangTuyen.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dsThongTinDangTuyen.Columns.AddRange(new DataGridViewColumn[] { _maTTDT, _maDN, _soLuong });
			tableLayoutPanel2.SetColumnSpan(dsThongTinDangTuyen, 2);
			dsThongTinDangTuyen.Dock = DockStyle.Fill;
			dsThongTinDangTuyen.Location = new Point(113, 93);
			dsThongTinDangTuyen.Margin = new Padding(4);
			dsThongTinDangTuyen.Name = "dsThongTinDangTuyen";
			dsThongTinDangTuyen.ReadOnly = true;
			dsThongTinDangTuyen.RowHeadersWidth = 51;
			dsThongTinDangTuyen.Size = new Size(870, 439);
			dsThongTinDangTuyen.TabIndex = 8;
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
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.ColumnCount = 4;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
			tableLayoutPanel1.Controls.Add(button1, 2, 2);
			tableLayoutPanel1.Location = new Point(0, 0);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 3;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
			tableLayoutPanel1.Size = new Size(200, 100);
			tableLayoutPanel1.TabIndex = 0;
			// 
			// button1
			// 
			button1.Anchor = AnchorStyles.Right;
			button1.BackColor = Color.LimeGreen;
			button1.FlatAppearance.BorderColor = Color.Black;
			button1.FlatStyle = FlatStyle.Flat;
			button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
			button1.ForeColor = Color.Black;
			button1.Location = new Point(104, 50);
			button1.Margin = new Padding(4);
			button1.Name = "button1";
			button1.Size = new Size(72, 40);
			button1.TabIndex = 8;
			button1.Tag = "red";
			button1.Text = "Hủy";
			button1.UseVisualStyleBackColor = false;
			// 
			// dataGridView1
			// 
			dataGridView1.AllowUserToAddRows = false;
			dataGridView1.AllowUserToDeleteRows = false;
			dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3 });
			dataGridView1.Location = new Point(24, 4);
			dataGridView1.Margin = new Padding(4);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.ReadOnly = true;
			dataGridView1.RowHeadersWidth = 51;
			dataGridView1.Size = new Size(152, 395);
			dataGridView1.TabIndex = 7;
			// 
			// dataGridViewTextBoxColumn1
			// 
			dataGridViewTextBoxColumn1.HeaderText = "Ma TTDT";
			dataGridViewTextBoxColumn1.MinimumWidth = 6;
			dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			dataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn2
			// 
			dataGridViewTextBoxColumn2.HeaderText = "Ma DN";
			dataGridViewTextBoxColumn2.MinimumWidth = 6;
			dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			dataGridViewTextBoxColumn2.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn3
			// 
			dataGridViewTextBoxColumn3.HeaderText = "So Luong";
			dataGridViewTextBoxColumn3.MinimumWidth = 6;
			dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			dataGridViewTextBoxColumn3.ReadOnly = true;
			// 
			// tableLayoutPanel2
			// 
			tableLayoutPanel2.ColumnCount = 4;
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
			tableLayoutPanel2.Controls.Add(btnHuy, 2, 2);
			tableLayoutPanel2.Controls.Add(dsThongTinDangTuyen, 1, 1);
			tableLayoutPanel2.Controls.Add(lb_dsTTDT, 1, 0);
			tableLayoutPanel2.Dock = DockStyle.Fill;
			tableLayoutPanel2.Location = new Point(0, 0);
			tableLayoutPanel2.Name = "tableLayoutPanel2";
			tableLayoutPanel2.RowCount = 3;
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 71.42857F));
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
			tableLayoutPanel2.Size = new Size(1099, 627);
			tableLayoutPanel2.TabIndex = 9;
			// 
			// GUI_DanhSachThongTinDangTuyen_DN
			// 
			AutoScaleDimensions = new SizeF(11F, 28F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(tableLayoutPanel2);
			Font = new Font("Segoe UI", 12F);
			Margin = new Padding(4);
			Name = "GUI_DanhSachThongTinDangTuyen_DN";
			Size = new Size(1099, 627);
			((System.ComponentModel.ISupportInitialize)dsThongTinDangTuyen).EndInit();
			tableLayoutPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			tableLayoutPanel2.ResumeLayout(false);
			tableLayoutPanel2.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Button btnHuy;
        private Label lb_dsTTDT;
        public DataGridView dsThongTinDangTuyen;
        private DataGridViewTextBoxColumn _maTTDT;
        private DataGridViewTextBoxColumn _maDN;
        private DataGridViewTextBoxColumn _soLuong;
		private TableLayoutPanel tableLayoutPanel1;
		private Button button1;
		private DataGridView dataGridView1;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private TableLayoutPanel tableLayoutPanel2;
	}
}
