namespace GUI.UserControls
{
	partial class GUI_XacNhanThanhToan
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
			flowLayoutPanel1 = new FlowLayoutPanel();
			label3 = new Label();
			_soNgayDangTuyen = new Label();
			flowLayoutPanel2 = new FlowLayoutPanel();
			label4 = new Label();
			_hinhThucDangTuyen = new Label();
			flowLayoutPanel3 = new FlowLayoutPanel();
			label7 = new Label();
			_tongChiPhi = new Label();
			label9 = new Label();
			tableLayoutPanel4 = new TableLayoutPanel();
			label10 = new Label();
			_cachThucThanhToan = new FlowLayoutPanel();
			_thanhToanThanhNhieuDot = new RadioButton();
			_thanhToanToanBo = new RadioButton();
			tableLayoutPanel5 = new TableLayoutPanel();
			btnXacNhan = new Button();
			btnHuy = new Button();
			tableLayoutPanel2.SuspendLayout();
			tableLayoutPanel3.SuspendLayout();
			flowLayoutPanel1.SuspendLayout();
			flowLayoutPanel2.SuspendLayout();
			flowLayoutPanel3.SuspendLayout();
			tableLayoutPanel4.SuspendLayout();
			_cachThucThanhToan.SuspendLayout();
			tableLayoutPanel5.SuspendLayout();
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
			label2.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label2.Location = new Point(306, 22);
			label2.Name = "label2";
			label2.Size = new Size(293, 37);
			label2.TabIndex = 0;
			label2.Text = "Xác Nhận Thanh Toán";
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
			tableLayoutPanel2.Size = new Size(905, 543);
			tableLayoutPanel2.TabIndex = 3;
			// 
			// tableLayoutPanel3
			// 
			tableLayoutPanel3.ColumnCount = 3;
			tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
			tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
			tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
			tableLayoutPanel3.Controls.Add(flowLayoutPanel1, 1, 1);
			tableLayoutPanel3.Controls.Add(flowLayoutPanel2, 1, 2);
			tableLayoutPanel3.Controls.Add(flowLayoutPanel3, 1, 3);
			tableLayoutPanel3.Controls.Add(label9, 1, 4);
			tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 1, 5);
			tableLayoutPanel3.Controls.Add(tableLayoutPanel5, 1, 7);
			tableLayoutPanel3.Location = new Point(3, 84);
			tableLayoutPanel3.Name = "tableLayoutPanel3";
			tableLayoutPanel3.RowCount = 8;
			tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
			tableLayoutPanel3.RowStyles.Add(new RowStyle());
			tableLayoutPanel3.RowStyles.Add(new RowStyle());
			tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
			tableLayoutPanel3.RowStyles.Add(new RowStyle());
			tableLayoutPanel3.RowStyles.Add(new RowStyle());
			tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
			tableLayoutPanel3.RowStyles.Add(new RowStyle());
			tableLayoutPanel3.Size = new Size(899, 456);
			tableLayoutPanel3.TabIndex = 1;
			// 
			// flowLayoutPanel1
			// 
			flowLayoutPanel1.AutoSize = true;
			flowLayoutPanel1.Controls.Add(label3);
			flowLayoutPanel1.Controls.Add(_soNgayDangTuyen);
			flowLayoutPanel1.Location = new Point(92, 47);
			flowLayoutPanel1.Name = "flowLayoutPanel1";
			flowLayoutPanel1.Size = new Size(283, 28);
			flowLayoutPanel1.TabIndex = 0;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			label3.Location = new Point(3, 0);
			label3.Name = "label3";
			label3.Size = new Size(206, 28);
			label3.TabIndex = 0;
			label3.Text = "Số ngày đăng tuyển:";
			// 
			// _soNgayDangTuyen
			// 
			_soNgayDangTuyen.AutoSize = true;
			_soNgayDangTuyen.Location = new Point(215, 0);
			_soNgayDangTuyen.Name = "_soNgayDangTuyen";
			_soNgayDangTuyen.Size = new Size(65, 28);
			_soNgayDangTuyen.TabIndex = 2;
			_soNgayDangTuyen.Text = "label5";
			// 
			// flowLayoutPanel2
			// 
			flowLayoutPanel2.AutoSize = true;
			flowLayoutPanel2.Controls.Add(label4);
			flowLayoutPanel2.Controls.Add(_hinhThucDangTuyen);
			flowLayoutPanel2.Location = new Point(92, 81);
			flowLayoutPanel2.Name = "flowLayoutPanel2";
			flowLayoutPanel2.Size = new Size(302, 28);
			flowLayoutPanel2.TabIndex = 1;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			label4.Location = new Point(3, 0);
			label4.Name = "label4";
			label4.Size = new Size(225, 28);
			label4.TabIndex = 0;
			label4.Text = "Hình thức đăng tuyển:";
			// 
			// _hinhThucDangTuyen
			// 
			_hinhThucDangTuyen.AutoSize = true;
			_hinhThucDangTuyen.Location = new Point(234, 0);
			_hinhThucDangTuyen.Name = "_hinhThucDangTuyen";
			_hinhThucDangTuyen.Size = new Size(65, 28);
			_hinhThucDangTuyen.TabIndex = 2;
			_hinhThucDangTuyen.Text = "label6";
			// 
			// flowLayoutPanel3
			// 
			flowLayoutPanel3.Anchor = AnchorStyles.Left;
			flowLayoutPanel3.AutoSize = true;
			flowLayoutPanel3.Controls.Add(label7);
			flowLayoutPanel3.Controls.Add(_tongChiPhi);
			flowLayoutPanel3.Location = new Point(92, 162);
			flowLayoutPanel3.Name = "flowLayoutPanel3";
			flowLayoutPanel3.Size = new Size(253, 32);
			flowLayoutPanel3.TabIndex = 2;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label7.Location = new Point(3, 0);
			label7.Name = "label7";
			label7.Size = new Size(163, 32);
			label7.TabIndex = 0;
			label7.Text = "Tổng chi phí:";
			// 
			// _tongChiPhi
			// 
			_tongChiPhi.AutoSize = true;
			_tongChiPhi.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
			_tongChiPhi.Location = new Point(172, 0);
			_tongChiPhi.Name = "_tongChiPhi";
			_tongChiPhi.Size = new Size(78, 32);
			_tongChiPhi.TabIndex = 2;
			_tongChiPhi.Text = "label8";
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic);
			label9.Location = new Point(92, 244);
			label9.Name = "label9";
			label9.Size = new Size(612, 25);
			label9.TabIndex = 3;
			label9.Text = "Có thể chọn cách thức thanh toán khi thời gian đăng tuyển lớn hơn 30 ngày";
			// 
			// tableLayoutPanel4
			// 
			tableLayoutPanel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			tableLayoutPanel4.ColumnCount = 2;
			tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle());
			tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle());
			tableLayoutPanel4.Controls.Add(label10, 0, 0);
			tableLayoutPanel4.Controls.Add(_cachThucThanhToan, 1, 0);
			tableLayoutPanel4.Location = new Point(92, 272);
			tableLayoutPanel4.Name = "tableLayoutPanel4";
			tableLayoutPanel4.RowCount = 1;
			tableLayoutPanel4.RowStyles.Add(new RowStyle());
			tableLayoutPanel4.Size = new Size(713, 86);
			tableLayoutPanel4.TabIndex = 4;
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.Location = new Point(0, 0);
			label10.Margin = new Padding(0);
			label10.Name = "label10";
			label10.Size = new Size(202, 28);
			label10.TabIndex = 0;
			label10.Text = "Cách thức thanh toán:";
			// 
			// _cachThucThanhToan
			// 
			_cachThucThanhToan.AutoSize = true;
			_cachThucThanhToan.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			_cachThucThanhToan.Controls.Add(_thanhToanThanhNhieuDot);
			_cachThucThanhToan.Controls.Add(_thanhToanToanBo);
			_cachThucThanhToan.FlowDirection = FlowDirection.TopDown;
			_cachThucThanhToan.Location = new Point(210, 0);
			_cachThucThanhToan.Margin = new Padding(8, 0, 3, 0);
			_cachThucThanhToan.Name = "_cachThucThanhToan";
			_cachThucThanhToan.Size = new Size(281, 76);
			_cachThucThanhToan.TabIndex = 1;
			// 
			// _thanhToanThanhNhieuDot
			// 
			_thanhToanThanhNhieuDot.AutoSize = true;
			_thanhToanThanhNhieuDot.Location = new Point(3, 3);
			_thanhToanThanhNhieuDot.Name = "_thanhToanThanhNhieuDot";
			_thanhToanThanhNhieuDot.Size = new Size(275, 32);
			_thanhToanThanhNhieuDot.TabIndex = 2;
			_thanhToanThanhNhieuDot.TabStop = true;
			_thanhToanThanhNhieuDot.Text = "Thanh toán thành nhiều đợt";
			_thanhToanThanhNhieuDot.UseVisualStyleBackColor = true;
			// 
			// _thanhToanToanBo
			// 
			_thanhToanToanBo.AutoSize = true;
			_thanhToanToanBo.Location = new Point(3, 41);
			_thanhToanToanBo.Name = "_thanhToanToanBo";
			_thanhToanToanBo.Size = new Size(205, 32);
			_thanhToanToanBo.TabIndex = 1;
			_thanhToanToanBo.TabStop = true;
			_thanhToanToanBo.Text = "Thanh toán toàn bộ";
			_thanhToanToanBo.UseVisualStyleBackColor = true;
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
			tableLayoutPanel5.Location = new Point(537, 408);
			tableLayoutPanel5.Name = "tableLayoutPanel5";
			tableLayoutPanel5.RowCount = 1;
			tableLayoutPanel5.RowStyles.Add(new RowStyle());
			tableLayoutPanel5.Size = new Size(268, 44);
			tableLayoutPanel5.TabIndex = 5;
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
			// GUI_XacNhanThanhToan
			// 
			AutoScaleDimensions = new SizeF(11F, 28F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(tableLayoutPanel2);
			Font = new Font("Segoe UI", 12F);
			Name = "GUI_XacNhanThanhToan";
			Size = new Size(905, 543);
			tableLayoutPanel2.ResumeLayout(false);
			tableLayoutPanel2.PerformLayout();
			tableLayoutPanel3.ResumeLayout(false);
			tableLayoutPanel3.PerformLayout();
			flowLayoutPanel1.ResumeLayout(false);
			flowLayoutPanel1.PerformLayout();
			flowLayoutPanel2.ResumeLayout(false);
			flowLayoutPanel2.PerformLayout();
			flowLayoutPanel3.ResumeLayout(false);
			flowLayoutPanel3.PerformLayout();
			tableLayoutPanel4.ResumeLayout(false);
			tableLayoutPanel4.PerformLayout();
			_cachThucThanhToan.ResumeLayout(false);
			_cachThucThanhToan.PerformLayout();
			tableLayoutPanel5.ResumeLayout(false);
			tableLayoutPanel5.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Label label1;
		private TableLayoutPanel tableLayoutPanel1;
		private Label label2;
		private TableLayoutPanel tableLayoutPanel2;
		private TableLayoutPanel tableLayoutPanel3;
		private FlowLayoutPanel flowLayoutPanel1;
		private Label label3;
		private Label _soNgayDangTuyen;
		private FlowLayoutPanel flowLayoutPanel2;
		private Label label4;
		private Label _hinhThucDangTuyen;
		private FlowLayoutPanel flowLayoutPanel3;
		private Label label7;
		private Label _tongChiPhi;
		private Label label9;
		private Label label10;
		private RadioButton _thanhToanToanBo;
		private TableLayoutPanel tableLayoutPanel4;
		private FlowLayoutPanel _cachThucThanhToan;
		private RadioButton _thanhToanThanhNhieuDot;
		private TableLayoutPanel tableLayoutPanel5;
		private Button btnXacNhan;
		private Button btnHuy;
	}
}
