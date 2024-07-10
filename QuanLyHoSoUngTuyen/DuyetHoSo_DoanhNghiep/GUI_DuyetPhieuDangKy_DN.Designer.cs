namespace GUI
{
    partial class GUI_DuyetPhieuDangKy_DN
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
			pageSetupDialog1 = new PageSetupDialog();
			lb1 = new Label();
			button1 = new Button();
			cbxTinhTrang = new ComboBox();
			lbTinhTrang = new Label();
			_viTri = new TextBox();
			_MaUV = new TextBox();
			_bangCap = new TextBox();
			lbVtriUV = new Label();
			lb_BangCap = new Label();
			lbMaPhieuDK = new Label();
			btnHuy = new Button();
			lbTTDT = new Label();
			tableLayoutPanel1 = new TableLayoutPanel();
			tableLayoutPanel2 = new TableLayoutPanel();
			tableLayoutPanel3 = new TableLayoutPanel();
			tableLayoutPanel4 = new TableLayoutPanel();
			tableLayoutPanel1.SuspendLayout();
			tableLayoutPanel2.SuspendLayout();
			tableLayoutPanel3.SuspendLayout();
			tableLayoutPanel4.SuspendLayout();
			SuspendLayout();
			// 
			// lb1
			// 
			lb1.Anchor = AnchorStyles.Left;
			lb1.AutoSize = true;
			lb1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 163);
			lb1.Location = new Point(113, 39);
			lb1.Margin = new Padding(4, 0, 4, 0);
			lb1.Name = "lb1";
			lb1.Size = new Size(329, 37);
			lb1.TabIndex = 5;
			lb1.Text = "Thông tin phiếu đăng ký";
			lb1.Click += lb1_Click;
			// 
			// button1
			// 
			button1.Anchor = AnchorStyles.Left;
			button1.BackColor = Color.Lime;
			button1.Location = new Point(4, 93);
			button1.Margin = new Padding(4);
			button1.Name = "button1";
			button1.Size = new Size(134, 40);
			button1.TabIndex = 25;
			button1.Text = "Hoàn tất";
			button1.UseVisualStyleBackColor = false;
			button1.Click += button1_Click;
			// 
			// cbxTinhTrang
			// 
			cbxTinhTrang.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			cbxTinhTrang.DropDownWidth = 135;
			cbxTinhTrang.FormattingEnabled = true;
			cbxTinhTrang.Items.AddRange(new object[] { "Đạt", "Không Đạt" });
			cbxTinhTrang.Location = new Point(117, 4);
			cbxTinhTrang.Margin = new Padding(4);
			cbxTinhTrang.Name = "cbxTinhTrang";
			cbxTinhTrang.Size = new Size(312, 36);
			cbxTinhTrang.TabIndex = 23;
			// 
			// lbTinhTrang
			// 
			lbTinhTrang.Anchor = AnchorStyles.Left;
			lbTinhTrang.AutoSize = true;
			lbTinhTrang.Location = new Point(4, 8);
			lbTinhTrang.Margin = new Padding(4, 0, 4, 0);
			lbTinhTrang.Name = "lbTinhTrang";
			lbTinhTrang.Size = new Size(105, 28);
			lbTinhTrang.TabIndex = 21;
			lbTinhTrang.Text = "Tình trạng:";
			lbTinhTrang.Click += lbTinhTrang_Click;
			// 
			// _viTri
			// 
			_viTri.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			_viTri.Location = new Point(540, 4);
			_viTri.Margin = new Padding(4);
			_viTri.Name = "_viTri";
			_viTri.ReadOnly = true;
			_viTri.Size = new Size(328, 34);
			_viTri.TabIndex = 12;
			// 
			// _MaUV
			// 
			_MaUV.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			_MaUV.Location = new Point(139, 4);
			_MaUV.Margin = new Padding(4);
			_MaUV.Name = "_MaUV";
			_MaUV.ReadOnly = true;
			_MaUV.Size = new Size(328, 34);
			_MaUV.TabIndex = 10;
			// 
			// _bangCap
			// 
			tableLayoutPanel2.SetColumnSpan(_bangCap, 3);
			_bangCap.Dock = DockStyle.Fill;
			_bangCap.Location = new Point(139, 46);
			_bangCap.Margin = new Padding(4);
			_bangCap.Multiline = true;
			_bangCap.Name = "_bangCap";
			_bangCap.ReadOnly = true;
			_bangCap.Size = new Size(729, 143);
			_bangCap.TabIndex = 10;
			// 
			// lbVtriUV
			// 
			lbVtriUV.Anchor = AnchorStyles.Left;
			lbVtriUV.AutoSize = true;
			lbVtriUV.Location = new Point(475, 7);
			lbVtriUV.Margin = new Padding(4, 0, 4, 0);
			lbVtriUV.Name = "lbVtriUV";
			lbVtriUV.Size = new Size(57, 28);
			lbVtriUV.TabIndex = 10;
			lbVtriUV.Text = "Vị trí:";
			// 
			// lb_BangCap
			// 
			lb_BangCap.AutoSize = true;
			lb_BangCap.Location = new Point(4, 46);
			lb_BangCap.Margin = new Padding(4);
			lb_BangCap.Name = "lb_BangCap";
			lb_BangCap.Size = new Size(96, 28);
			lb_BangCap.TabIndex = 11;
			lb_BangCap.Text = "Bằng cấp:";
			// 
			// lbMaPhieuDK
			// 
			lbMaPhieuDK.Anchor = AnchorStyles.Left;
			lbMaPhieuDK.AutoSize = true;
			lbMaPhieuDK.Location = new Point(4, 7);
			lbMaPhieuDK.Margin = new Padding(4, 0, 4, 0);
			lbMaPhieuDK.Name = "lbMaPhieuDK";
			lbMaPhieuDK.Size = new Size(127, 28);
			lbMaPhieuDK.TabIndex = 10;
			lbMaPhieuDK.Text = "Mã Ứng viên:";
			// 
			// btnHuy
			// 
			btnHuy.Anchor = AnchorStyles.Right;
			btnHuy.BackColor = Color.Red;
			btnHuy.Location = new Point(295, 93);
			btnHuy.Margin = new Padding(4);
			btnHuy.Name = "btnHuy";
			btnHuy.Size = new Size(134, 40);
			btnHuy.TabIndex = 19;
			btnHuy.Text = "Hủy";
			btnHuy.UseVisualStyleBackColor = false;
			btnHuy.Click += btnHuy_Click;
			// 
			// lbTTDT
			// 
			lbTTDT.AutoSize = true;
			lbTTDT.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
			lbTTDT.Location = new Point(836, 57);
			lbTTDT.Margin = new Padding(4, 0, 4, 0);
			lbTTDT.Name = "lbTTDT";
			lbTTDT.Size = new Size(0, 31);
			lbTTDT.TabIndex = 26;
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.ColumnCount = 4;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
			tableLayoutPanel1.Controls.Add(lb1, 1, 0);
			tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 2);
			tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 2, 3);
			tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 2, 1);
			tableLayoutPanel1.Dock = DockStyle.Fill;
			tableLayoutPanel1.Location = new Point(0, 0);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 4;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle());
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
			tableLayoutPanel1.Size = new Size(1099, 627);
			tableLayoutPanel1.TabIndex = 27;
			// 
			// tableLayoutPanel2
			// 
			tableLayoutPanel2.ColumnCount = 4;
			tableLayoutPanel1.SetColumnSpan(tableLayoutPanel2, 2);
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel2.Controls.Add(_bangCap, 1, 1);
			tableLayoutPanel2.Controls.Add(_viTri, 3, 0);
			tableLayoutPanel2.Controls.Add(lb_BangCap, 0, 1);
			tableLayoutPanel2.Controls.Add(lbMaPhieuDK, 0, 0);
			tableLayoutPanel2.Controls.Add(_MaUV, 1, 0);
			tableLayoutPanel2.Controls.Add(lbVtriUV, 2, 0);
			tableLayoutPanel2.Dock = DockStyle.Fill;
			tableLayoutPanel2.Location = new Point(112, 199);
			tableLayoutPanel2.Margin = new Padding(3, 34, 3, 3);
			tableLayoutPanel2.Name = "tableLayoutPanel2";
			tableLayoutPanel2.RowCount = 2;
			tableLayoutPanel2.RowStyles.Add(new RowStyle());
			tableLayoutPanel2.RowStyles.Add(new RowStyle());
			tableLayoutPanel2.Size = new Size(872, 193);
			tableLayoutPanel2.TabIndex = 20;
			// 
			// tableLayoutPanel3
			// 
			tableLayoutPanel3.ColumnCount = 3;
			tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
			tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
			tableLayoutPanel3.Controls.Add(button1, 0, 0);
			tableLayoutPanel3.Controls.Add(btnHuy, 2, 0);
			tableLayoutPanel3.Dock = DockStyle.Fill;
			tableLayoutPanel3.Location = new Point(551, 398);
			tableLayoutPanel3.Name = "tableLayoutPanel3";
			tableLayoutPanel3.RowCount = 1;
			tableLayoutPanel3.RowStyles.Add(new RowStyle());
			tableLayoutPanel3.Size = new Size(433, 226);
			tableLayoutPanel3.TabIndex = 21;
			// 
			// tableLayoutPanel4
			// 
			tableLayoutPanel4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			tableLayoutPanel4.AutoSize = true;
			tableLayoutPanel4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			tableLayoutPanel4.ColumnCount = 2;
			tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle());
			tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle());
			tableLayoutPanel4.Controls.Add(lbTinhTrang, 0, 0);
			tableLayoutPanel4.Controls.Add(cbxTinhTrang, 1, 0);
			tableLayoutPanel4.Location = new Point(551, 118);
			tableLayoutPanel4.Name = "tableLayoutPanel4";
			tableLayoutPanel4.RowCount = 1;
			tableLayoutPanel4.RowStyles.Add(new RowStyle());
			tableLayoutPanel4.Size = new Size(433, 44);
			tableLayoutPanel4.TabIndex = 24;
			// 
			// GUI_DuyetPhieuDangKy_DN
			// 
			AutoScaleDimensions = new SizeF(11F, 28F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(lbTTDT);
			Controls.Add(tableLayoutPanel1);
			Font = new Font("Segoe UI", 12F);
			Margin = new Padding(4);
			Name = "GUI_DuyetPhieuDangKy_DN";
			Size = new Size(1099, 627);
			tableLayoutPanel1.ResumeLayout(false);
			tableLayoutPanel1.PerformLayout();
			tableLayoutPanel2.ResumeLayout(false);
			tableLayoutPanel2.PerformLayout();
			tableLayoutPanel3.ResumeLayout(false);
			tableLayoutPanel4.ResumeLayout(false);
			tableLayoutPanel4.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private PageSetupDialog pageSetupDialog1;
        private Label lb1;
        private Button button1;
        private ComboBox cbxTinhTrang;
        private Label lbTinhTrang;
        private TextBox _viTri;
        private TextBox _MaUV;
        private TextBox _bangCap;
        private Label lbVtriUV;
        private Label lb_BangCap;
        private Label lbMaPhieuDK;
        private Button btnHuy;
        private Label lbTTDT;
		private TableLayoutPanel tableLayoutPanel1;
		private TableLayoutPanel tableLayoutPanel2;
		private TableLayoutPanel tableLayoutPanel3;
		private TableLayoutPanel tableLayoutPanel4;
	}
}
