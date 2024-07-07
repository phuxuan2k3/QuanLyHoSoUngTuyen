namespace GUI
{
	partial class GUI_DoanhNghiep
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnDuyetHoSo = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            _contentPanel = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnCapNhatTTDN = new Button();
            btnDanhSachThongTinDangTuyen = new Button();
            btnXacThucDN = new Button();
            btnTaoYeuCau = new Button();
            btnDangTuyenTTDT = new Button();
            btnXetDuyetTTDT = new Button();
            button2 = new Button();
            button3 = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            button1 = new Button();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnDuyetHoSo
            // 
            btnDuyetHoSo.Location = new Point(1075, -5);
            btnDuyetHoSo.Name = "btnDuyetHoSo";
            btnDuyetHoSo.Size = new Size(85, 95);
            btnDuyetHoSo.TabIndex = 9;
            btnDuyetHoSo.Text = "Duyệt";
            btnDuyetHoSo.UseVisualStyleBackColor = true;
            // 
            // _contentPanel
            // 
            _contentPanel.BackColor = SystemColors.ControlLight;
            _contentPanel.Dock = DockStyle.Fill;
            _contentPanel.Location = new Point(2, 41);
            _contentPanel.Margin = new Padding(2);
            _contentPanel.Name = "_contentPanel";
            _contentPanel.Size = new Size(1232, 367);
            _contentPanel.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 6;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.Controls.Add(button3, 0, 1);
            tableLayoutPanel2.Controls.Add(button2, 0, 1);
            tableLayoutPanel2.Controls.Add(button1, 0, 1);
            tableLayoutPanel2.Controls.Add(btnXetDuyetTTDT, 4, 0);
            tableLayoutPanel2.Controls.Add(btnDangTuyenTTDT, 3, 0);
            tableLayoutPanel2.Controls.Add(btnTaoYeuCau, 0, 0);
            tableLayoutPanel2.Controls.Add(btnXacThucDN, 2, 0);
            tableLayoutPanel2.Controls.Add(btnDanhSachThongTinDangTuyen, 1, 0);
            tableLayoutPanel2.Controls.Add(btnCapNhatTTDN, 5, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(2, 2);
            tableLayoutPanel2.Margin = new Padding(2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            tableLayoutPanel2.Size = new Size(1232, 35);
            tableLayoutPanel2.TabIndex = 2;
            tableLayoutPanel2.Paint += tableLayoutPanel2_Paint;
            // 
            // btnCapNhatTTDN
            // 
            btnCapNhatTTDN.Location = new Point(913, 3);
            btnCapNhatTTDN.Name = "btnCapNhatTTDN";
            btnCapNhatTTDN.Size = new Size(85, 21);
            btnCapNhatTTDN.TabIndex = 5;
            btnCapNhatTTDN.Text = "Cập nhật TT DN";
            btnCapNhatTTDN.UseVisualStyleBackColor = true;
            btnCapNhatTTDN.Click += btnCapNhatTTDN_Click;
            // 
            // btnDanhSachThongTinDangTuyen
            // 
            btnDanhSachThongTinDangTuyen.AutoSize = true;
            btnDanhSachThongTinDangTuyen.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnDanhSachThongTinDangTuyen.Location = new Point(182, 2);
            btnDanhSachThongTinDangTuyen.Margin = new Padding(2);
            btnDanhSachThongTinDangTuyen.Name = "btnDanhSachThongTinDangTuyen";
            btnDanhSachThongTinDangTuyen.Size = new Size(229, 23);
            btnDanhSachThongTinDangTuyen.TabIndex = 1;
            btnDanhSachThongTinDangTuyen.Text = "Danh sách thông tin đăng tuyển";
            btnDanhSachThongTinDangTuyen.UseVisualStyleBackColor = true;
            btnDanhSachThongTinDangTuyen.Click += btnDanhSachThongTinDangTuyen_Click;
            // 
            // btnXacThucDN
            // 
            btnXacThucDN.AutoSize = true;
            btnXacThucDN.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnXacThucDN.Location = new Point(415, 2);
            btnXacThucDN.Margin = new Padding(2);
            btnXacThucDN.Name = "btnXacThucDN";
            btnXacThucDN.Size = new Size(172, 23);
            btnXacThucDN.TabIndex = 2;
            btnXacThucDN.Text = "Xác thực doanh nghiệp";
            btnXacThucDN.UseVisualStyleBackColor = true;
            btnXacThucDN.Click += btnXacThucDN_Click;
            // 
            // btnTaoYeuCau
            // 
            btnTaoYeuCau.AutoSize = true;
            btnTaoYeuCau.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnTaoYeuCau.Location = new Point(2, 2);
            btnTaoYeuCau.Margin = new Padding(2);
            btnTaoYeuCau.Name = "btnTaoYeuCau";
            btnTaoYeuCau.Size = new Size(176, 23);
            btnTaoYeuCau.TabIndex = 0;
            btnTaoYeuCau.Text = "Tạo yêu cầu đăng tuyển";
            btnTaoYeuCau.UseVisualStyleBackColor = true;
            btnTaoYeuCau.Click += btnTaoYeuCau_Click;
            // 
            // btnDangTuyenTTDT
            // 
            btnDangTuyenTTDT.AutoSize = true;
            btnDangTuyenTTDT.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnDangTuyenTTDT.Location = new Point(591, 2);
            btnDangTuyenTTDT.Margin = new Padding(2);
            btnDangTuyenTTDT.Name = "btnDangTuyenTTDT";
            btnDangTuyenTTDT.Size = new Size(95, 23);
            btnDangTuyenTTDT.TabIndex = 4;
            btnDangTuyenTTDT.Text = "Đăng tuyển";
            btnDangTuyenTTDT.UseVisualStyleBackColor = true;
            btnDangTuyenTTDT.Click += btnDangTuyenTTDT_Click;
            // 
            // btnXetDuyetTTDT
            // 
            btnXetDuyetTTDT.AutoSize = true;
            btnXetDuyetTTDT.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnXetDuyetTTDT.Location = new Point(690, 2);
            btnXetDuyetTTDT.Margin = new Padding(2);
            btnXetDuyetTTDT.Name = "btnXetDuyetTTDT";
            btnXetDuyetTTDT.Size = new Size(218, 23);
            btnXetDuyetTTDT.TabIndex = 3;
            btnXetDuyetTTDT.Text = "Xác thực thông tin đăng tuyển";
            btnXetDuyetTTDT.UseVisualStyleBackColor = true;
            btnXetDuyetTTDT.Click += btnXetDuyetTTDT_Click;
            // 
            // button2
            // 
            button2.Location = new Point(183, 30);
            button2.Name = "button2";
            button2.Size = new Size(85, 2);
            button2.TabIndex = 7;
            button2.Text = "Cập nhật TT DN";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(3, 30);
            button3.Name = "button3";
            button3.Size = new Size(85, 2);
            button3.TabIndex = 8;
            button3.Text = "Cập nhật TT DN";
            button3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 0);
            tableLayoutPanel1.Controls.Add(_contentPanel, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1236, 410);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(416, 30);
            button1.Name = "button1";
            button1.Size = new Size(85, 2);
            button1.TabIndex = 6;
            button1.Text = "Cập nhật TT DN";
            button1.UseVisualStyleBackColor = true;
            // 
            // GUI_DoanhNghiep
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1236, 410);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(2);
            Name = "GUI_DoanhNghiep";
            Text = "GUI_Base";
            Click += btnTaoYeuCau_Click;
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnDuyetHoSo;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel _contentPanel;
        private TableLayoutPanel tableLayoutPanel2;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button btnXetDuyetTTDT;
        private Button btnDangTuyenTTDT;
        private Button btnTaoYeuCau;
        private Button btnXacThucDN;
        private Button btnDanhSachThongTinDangTuyen;
        private Button btnCapNhatTTDN;
        private TableLayoutPanel tableLayoutPanel1;
    }
}