namespace GUI.UserControls
{
	partial class GUI_DienThongTinDangTuyen
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
            label2 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel6 = new TableLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            tableLayoutPanel5 = new TableLayoutPanel();
            btnXacNhan = new Button();
            btnHuy = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtTenViTri = new TextBox();
            txtYeuCau = new TextBox();
            dtpThoiGianDangTuyen = new DateTimePicker();
            nudSoNgayDangTuyen = new NumericUpDown();
            cbbHinhThucDangTuyen = new ComboBox();
            nudSoLuong = new NumericUpDown();
            tableLayoutPanel4 = new TableLayoutPanel();
            flowLayoutPanel10 = new FlowLayoutPanel();
            btnXemHoaDon = new Button();
            btnHieuChinh = new Button();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudSoNgayDangTuyen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudSoLuong).BeginInit();
            flowLayoutPanel10.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(10, 0);
            label1.Name = "label1";
            label1.Size = new Size(180, 62);
            label1.TabIndex = 0;
            label1.Text = "Chi Tiết Thông Tin Đăng Tuyển";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(200, 100);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label2.Location = new Point(327, 24);
            label2.Name = "label2";
            label2.Size = new Size(377, 37);
            label2.TabIndex = 0;
            label2.Text = "Điền Thông Tin Đăng Tuyển ";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(label2, 0, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 85F));
            tableLayoutPanel2.Size = new Size(1032, 577);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 4;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel3.Controls.Add(tableLayoutPanel6, 2, 7);
            tableLayoutPanel3.Controls.Add(label3, 1, 1);
            tableLayoutPanel3.Controls.Add(label4, 1, 2);
            tableLayoutPanel3.Controls.Add(label5, 1, 3);
            tableLayoutPanel3.Controls.Add(label6, 1, 4);
            tableLayoutPanel3.Controls.Add(label7, 1, 5);
            tableLayoutPanel3.Controls.Add(label8, 1, 6);
            tableLayoutPanel3.Controls.Add(txtTenViTri, 2, 4);
            tableLayoutPanel3.Controls.Add(txtYeuCau, 2, 6);
            tableLayoutPanel3.Controls.Add(dtpThoiGianDangTuyen, 2, 2);
            tableLayoutPanel3.Controls.Add(nudSoNgayDangTuyen, 2, 1);
            tableLayoutPanel3.Controls.Add(cbbHinhThucDangTuyen, 2, 3);
            tableLayoutPanel3.Controls.Add(nudSoLuong, 2, 5);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 89);
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
            tableLayoutPanel3.Size = new Size(1026, 485);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Controls.Add(flowLayoutPanel2, 0, 0);
            tableLayoutPanel6.Controls.Add(tableLayoutPanel5, 0, 1);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(361, 378);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 3;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle());
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel6.Size = new Size(558, 104);
            tableLayoutPanel6.TabIndex = 7;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Anchor = AnchorStyles.Right;
            flowLayoutPanel2.AutoSize = true;
            flowLayoutPanel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel2.Location = new Point(555, 21);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(0, 0);
            flowLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.Anchor = AnchorStyles.Right;
            tableLayoutPanel5.AutoSize = true;
            tableLayoutPanel5.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel5.ColumnCount = 3;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel5.Controls.Add(btnXacNhan, 0, 0);
            tableLayoutPanel5.Controls.Add(btnHuy, 2, 0);
            tableLayoutPanel5.Location = new Point(287, 46);
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
            btnXacNhan.TabIndex = 7;
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
            btnHuy.TabIndex = 8;
            btnHuy.Tag = "red";
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(108, 55);
            label3.Margin = new Padding(6);
            label3.Name = "label3";
            label3.Size = new Size(244, 28);
            label3.TabIndex = 8;
            label3.Text = "Số ngày đăng tuyển:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(108, 101);
            label4.Margin = new Padding(6);
            label4.Name = "label4";
            label4.Size = new Size(244, 28);
            label4.TabIndex = 10;
            label4.Text = "Thời gian đăng tuyển:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(108, 148);
            label5.Margin = new Padding(6);
            label5.Name = "label5";
            label5.Size = new Size(244, 28);
            label5.TabIndex = 12;
            label5.Text = "Hình thức đăng tuyển:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(108, 195);
            label6.Margin = new Padding(6);
            label6.Name = "label6";
            label6.Size = new Size(244, 28);
            label6.TabIndex = 13;
            label6.Text = "Tên vị trí:";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(108, 241);
            label7.Margin = new Padding(6);
            label7.Name = "label7";
            label7.Size = new Size(244, 28);
            label7.TabIndex = 14;
            label7.Text = "Số lượng:";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Location = new Point(108, 284);
            label8.Margin = new Padding(6);
            label8.Name = "label8";
            label8.Size = new Size(244, 28);
            label8.TabIndex = 15;
            label8.Text = "Yêu cầu:";
            // 
            // txtTenViTri
            // 
            txtTenViTri.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtTenViTri.Location = new Point(364, 192);
            txtTenViTri.Margin = new Padding(6);
            txtTenViTri.Name = "txtTenViTri";
            txtTenViTri.Size = new Size(552, 34);
            txtTenViTri.TabIndex = 4;
            // 
            // txtYeuCau
            // 
            txtYeuCau.Dock = DockStyle.Fill;
            txtYeuCau.Location = new Point(364, 284);
            txtYeuCau.Margin = new Padding(6);
            txtYeuCau.Multiline = true;
            txtYeuCau.Name = "txtYeuCau";
            txtYeuCau.Size = new Size(552, 85);
            txtYeuCau.TabIndex = 6;
            // 
            // dtpThoiGianDangTuyen
            // 
            dtpThoiGianDangTuyen.CustomFormat = "dd/MM/yyyy";
            dtpThoiGianDangTuyen.Dock = DockStyle.Fill;
            dtpThoiGianDangTuyen.Format = DateTimePickerFormat.Custom;
            dtpThoiGianDangTuyen.Location = new Point(364, 98);
            dtpThoiGianDangTuyen.Margin = new Padding(6);
            dtpThoiGianDangTuyen.MinDate = new DateTime(2024, 6, 30, 11, 18, 56, 0);
            dtpThoiGianDangTuyen.Name = "dtpThoiGianDangTuyen";
            dtpThoiGianDangTuyen.Size = new Size(552, 34);
            dtpThoiGianDangTuyen.TabIndex = 2;
            dtpThoiGianDangTuyen.Value = new DateTime(2024, 6, 30, 11, 18, 56, 0);
            // 
            // nudSoNgayDangTuyen
            // 
            nudSoNgayDangTuyen.Dock = DockStyle.Fill;
            nudSoNgayDangTuyen.Location = new Point(364, 52);
            nudSoNgayDangTuyen.Margin = new Padding(6);
            nudSoNgayDangTuyen.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudSoNgayDangTuyen.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudSoNgayDangTuyen.Name = "nudSoNgayDangTuyen";
            nudSoNgayDangTuyen.Size = new Size(552, 34);
            nudSoNgayDangTuyen.TabIndex = 1;
            nudSoNgayDangTuyen.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // cbbHinhThucDangTuyen
            // 
            cbbHinhThucDangTuyen.Dock = DockStyle.Fill;
            cbbHinhThucDangTuyen.FormattingEnabled = true;
            cbbHinhThucDangTuyen.Location = new Point(364, 144);
            cbbHinhThucDangTuyen.Margin = new Padding(6);
            cbbHinhThucDangTuyen.Name = "cbbHinhThucDangTuyen";
            cbbHinhThucDangTuyen.Size = new Size(552, 36);
            cbbHinhThucDangTuyen.TabIndex = 3;
            // 
            // nudSoLuong
            // 
            nudSoLuong.Dock = DockStyle.Fill;
            nudSoLuong.Location = new Point(364, 238);
            nudSoLuong.Margin = new Padding(6);
            nudSoLuong.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudSoLuong.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudSoLuong.Name = "nudSoLuong";
            nudSoLuong.Size = new Size(552, 34);
            nudSoLuong.TabIndex = 5;
            nudSoLuong.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 3;
            tableLayoutPanel4.Size = new Size(200, 100);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // flowLayoutPanel10
            // 
            flowLayoutPanel10.Anchor = AnchorStyles.Left;
            flowLayoutPanel10.AutoSize = true;
            flowLayoutPanel10.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel10.Controls.Add(btnXemHoaDon);
            flowLayoutPanel10.Controls.Add(btnHieuChinh);
            flowLayoutPanel10.Location = new Point(3, 3);
            flowLayoutPanel10.Name = "flowLayoutPanel10";
            flowLayoutPanel10.Size = new Size(136, 82);
            flowLayoutPanel10.TabIndex = 0;
            // 
            // btnXemHoaDon
            // 
            btnXemHoaDon.AutoSize = true;
            btnXemHoaDon.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnXemHoaDon.Location = new Point(3, 3);
            btnXemHoaDon.Name = "btnXemHoaDon";
            btnXemHoaDon.Size = new Size(130, 35);
            btnXemHoaDon.TabIndex = 0;
            btnXemHoaDon.Tag = "blue";
            btnXemHoaDon.Text = "Xem hóa đơn";
            btnXemHoaDon.UseVisualStyleBackColor = true;
            // 
            // btnHieuChinh
            // 
            btnHieuChinh.AutoSize = true;
            btnHieuChinh.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnHieuChinh.Location = new Point(3, 44);
            btnHieuChinh.Name = "btnHieuChinh";
            btnHieuChinh.Size = new Size(105, 35);
            btnHieuChinh.TabIndex = 1;
            btnHieuChinh.Tag = "blue";
            btnHieuChinh.Text = "Hiệu chỉnh";
            btnHieuChinh.UseVisualStyleBackColor = true;
            // 
            // GUI_DienThongTinDangTuyen
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel2);
            Font = new Font("Segoe UI", 12F);
            Name = "GUI_DienThongTinDangTuyen";
            Size = new Size(1032, 577);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudSoNgayDangTuyen).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudSoLuong).EndInit();
            flowLayoutPanel10.ResumeLayout(false);
            flowLayoutPanel10.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
		private TableLayoutPanel tableLayoutPanel1;
		private Label label2;
		private TableLayoutPanel tableLayoutPanel2;
		private TableLayoutPanel tableLayoutPanel3;
		private TableLayoutPanel tableLayoutPanel4;
		private FlowLayoutPanel flowLayoutPanel10;
		private Button btnXemHoaDon;
		private Button btnHieuChinh;
		private TableLayoutPanel tableLayoutPanel6;
		private FlowLayoutPanel flowLayoutPanel2;
		private Button btnXacNhan;
		private Button btnHuy;
		private Label label3;
		private Label label4;
		private TableLayoutPanel tableLayoutPanel5;
		private Label label5;
		private Label label6;
		private Label label7;
		private Label label8;
		private TextBox txtTenViTri;
		private TextBox txtYeuCau;
		private DateTimePicker dtpThoiGianDangTuyen;
		private NumericUpDown nudSoNgayDangTuyen;
		private ComboBox cbbHinhThucDangTuyen;
		private NumericUpDown nudSoLuong;
	}
}
