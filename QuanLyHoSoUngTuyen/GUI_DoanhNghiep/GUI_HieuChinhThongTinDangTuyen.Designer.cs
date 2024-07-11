namespace GUI.UserControls
{
	partial class GUI_HieuChinhThongTinDangTuyen
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
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            _thoiGianDangTuyen = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtTenViTri = new TextBox();
            txtYeuCau = new TextBox();
            nudSoLuong = new NumericUpDown();
            tableLayoutPanel5 = new TableLayoutPanel();
            btnXacNhan = new Button();
            btnHuy = new Button();
            _soNgayDangTuyen = new Label();
            _hinhThucDangTuyen = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudSoLuong).BeginInit();
            tableLayoutPanel5.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(285, 25);
            label1.Name = "label1";
            label1.Size = new Size(451, 37);
            label1.TabIndex = 0;
            label1.Text = "Hiệu Chỉnh Thông Tin Đăng Tuyển";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 85F));
            tableLayoutPanel1.Size = new Size(1021, 580);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 4;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel3.Controls.Add(_thoiGianDangTuyen, 2, 2);
            tableLayoutPanel3.Controls.Add(label3, 1, 1);
            tableLayoutPanel3.Controls.Add(label4, 1, 2);
            tableLayoutPanel3.Controls.Add(label5, 1, 3);
            tableLayoutPanel3.Controls.Add(label6, 1, 4);
            tableLayoutPanel3.Controls.Add(label7, 1, 5);
            tableLayoutPanel3.Controls.Add(label8, 1, 6);
            tableLayoutPanel3.Controls.Add(txtTenViTri, 2, 4);
            tableLayoutPanel3.Controls.Add(txtYeuCau, 2, 6);
            tableLayoutPanel3.Controls.Add(nudSoLuong, 2, 5);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel5, 2, 7);
            tableLayoutPanel3.Controls.Add(_soNgayDangTuyen, 2, 1);
            tableLayoutPanel3.Controls.Add(_hinhThucDangTuyen, 2, 3);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 90);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 8;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tableLayoutPanel3.Size = new Size(1015, 487);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // _thoiGianDangTuyen
            // 
            _thoiGianDangTuyen.Anchor = AnchorStyles.Left;
            _thoiGianDangTuyen.AutoSize = true;
            _thoiGianDangTuyen.Location = new Point(357, 99);
            _thoiGianDangTuyen.Name = "_thoiGianDangTuyen";
            _thoiGianDangTuyen.Size = new Size(65, 28);
            _thoiGianDangTuyen.TabIndex = 2;
            _thoiGianDangTuyen.Text = "label2";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(107, 59);
            label3.Margin = new Padding(6);
            label3.Name = "label3";
            label3.Size = new Size(241, 28);
            label3.TabIndex = 8;
            label3.Text = "Số ngày đăng tuyển:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(107, 99);
            label4.Margin = new Padding(6);
            label4.Name = "label4";
            label4.Size = new Size(241, 28);
            label4.TabIndex = 10;
            label4.Text = "Thời gian đăng tuyển:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(107, 139);
            label5.Margin = new Padding(6);
            label5.Name = "label5";
            label5.Size = new Size(241, 28);
            label5.TabIndex = 12;
            label5.Text = "Hình thức đăng tuyển:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(107, 182);
            label6.Margin = new Padding(6);
            label6.Name = "label6";
            label6.Size = new Size(241, 28);
            label6.TabIndex = 13;
            label6.Text = "Tên vị trí:";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(107, 228);
            label7.Margin = new Padding(6);
            label7.Name = "label7";
            label7.Size = new Size(241, 28);
            label7.TabIndex = 14;
            label7.Text = "Số lượng:";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Location = new Point(107, 271);
            label8.Margin = new Padding(6);
            label8.Name = "label8";
            label8.Size = new Size(241, 28);
            label8.TabIndex = 15;
            label8.Text = "Yêu cầu:";
            // 
            // txtTenViTri
            // 
            txtTenViTri.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtTenViTri.Location = new Point(360, 179);
            txtTenViTri.Margin = new Padding(6);
            txtTenViTri.Name = "txtTenViTri";
            txtTenViTri.Size = new Size(546, 34);
            txtTenViTri.TabIndex = 17;
            // 
            // txtYeuCau
            // 
            txtYeuCau.Dock = DockStyle.Fill;
            txtYeuCau.Location = new Point(360, 271);
            txtYeuCau.Margin = new Padding(6);
            txtYeuCau.Multiline = true;
            txtYeuCau.Name = "txtYeuCau";
            txtYeuCau.Size = new Size(546, 85);
            txtYeuCau.TabIndex = 19;
            // 
            // nudSoLuong
            // 
            nudSoLuong.Dock = DockStyle.Fill;
            nudSoLuong.Location = new Point(360, 225);
            nudSoLuong.Margin = new Padding(6);
            nudSoLuong.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudSoLuong.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudSoLuong.Name = "nudSoLuong";
            nudSoLuong.Size = new Size(546, 34);
            nudSoLuong.TabIndex = 23;
            nudSoLuong.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            tableLayoutPanel5.AutoSize = true;
            tableLayoutPanel5.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel5.ColumnCount = 3;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel5.Controls.Add(btnXacNhan, 0, 0);
            tableLayoutPanel5.Controls.Add(btnHuy, 2, 0);
            tableLayoutPanel5.Location = new Point(641, 440);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle());
            tableLayoutPanel5.Size = new Size(268, 44);
            tableLayoutPanel5.TabIndex = 1;
            // 
            // btnXacNhan
            // 
            btnXacNhan.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnXacNhan.AutoSize = true;
            btnXacNhan.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnXacNhan.Location = new Point(3, 3);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(101, 38);
            btnXacNhan.TabIndex = 0;
            btnXacNhan.Tag = "green";
            btnXacNhan.Text = "Xác nhận";
            btnXacNhan.UseVisualStyleBackColor = true;
            btnXacNhan.Click += btnXacNhan_Click;
            // 
            // btnHuy
            // 
            btnHuy.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnHuy.AutoSize = true;
            btnHuy.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnHuy.Location = new Point(163, 3);
            btnHuy.MinimumSize = new Size(77, 0);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(102, 38);
            btnHuy.TabIndex = 1;
            btnHuy.Tag = "red";
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // _soNgayDangTuyen
            // 
            _soNgayDangTuyen.Anchor = AnchorStyles.Left;
            _soNgayDangTuyen.AutoSize = true;
            _soNgayDangTuyen.Location = new Point(357, 59);
            _soNgayDangTuyen.Name = "_soNgayDangTuyen";
            _soNgayDangTuyen.Size = new Size(65, 28);
            _soNgayDangTuyen.TabIndex = 24;
            _soNgayDangTuyen.Text = "label9";
            // 
            // _hinhThucDangTuyen
            // 
            _hinhThucDangTuyen.Anchor = AnchorStyles.Left;
            _hinhThucDangTuyen.AutoSize = true;
            _hinhThucDangTuyen.Location = new Point(357, 139);
            _hinhThucDangTuyen.Name = "_hinhThucDangTuyen";
            _hinhThucDangTuyen.Size = new Size(76, 28);
            _hinhThucDangTuyen.TabIndex = 25;
            _hinhThucDangTuyen.Text = "label10";
            // 
            // GUI_HieuChinhThongTinDangTuyen
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Segoe UI", 12F);
            Name = "GUI_HieuChinhThongTinDangTuyen";
            Size = new Size(1021, 580);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudSoLuong).EndInit();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
		private TableLayoutPanel tableLayoutPanel1;
		private TableLayoutPanel tableLayoutPanel3;
		private Label label3;
		private Label label4;
		private Label label5;
		private Label label6;
		private Label label7;
		private Label label8;
		private TextBox txtTenViTri;
		private TextBox txtYeuCau;
		private NumericUpDown nudSoLuong;
		private TableLayoutPanel tableLayoutPanel5;
		private Button btnXacNhan;
		private Button btnHuy;
		private Label _thoiGianDangTuyen;
		private Label _soNgayDangTuyen;
		private Label _hinhThucDangTuyen;
	}
}
