﻿namespace GUI
{
	partial class GUI_Base
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
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnXacThucDN = new Button();
            btnTaoYeuCau = new Button();
            btnDanhSachThongTinDangTuyen = new Button();
            _contentPanel = new Panel();
            btnXetDuyetTTDT = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
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
            tableLayoutPanel1.Size = new Size(819, 360);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 175F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 30F));
            tableLayoutPanel2.Controls.Add(btnTaoYeuCau, 0, 0);
            tableLayoutPanel2.Controls.Add(btnXacThucDN, 2, 0);
            tableLayoutPanel2.Controls.Add(btnDanhSachThongTinDangTuyen, 1, 0);
            tableLayoutPanel2.Controls.Add(btnXetDuyetTTDT, 3, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(2, 2);
            tableLayoutPanel2.Margin = new Padding(2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel2.Size = new Size(815, 35);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // btnXacThucDN
            // 
            btnXacThucDN.AutoSize = true;
            btnXacThucDN.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnXacThucDN.Location = new Point(415, 2);
            btnXacThucDN.Margin = new Padding(2);
            btnXacThucDN.Name = "btnXacThucDN";
            btnXacThucDN.Size = new Size(171, 30);
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
            btnTaoYeuCau.Size = new Size(176, 30);
            btnTaoYeuCau.TabIndex = 0;
            btnTaoYeuCau.Text = "Tạo yêu cầu đăng tuyển";
            btnTaoYeuCau.UseVisualStyleBackColor = true;
            btnTaoYeuCau.Click += btnTaoYeuCau_Click;
            // 
            // btnDanhSachThongTinDangTuyen
            // 
            btnDanhSachThongTinDangTuyen.AutoSize = true;
            btnDanhSachThongTinDangTuyen.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnDanhSachThongTinDangTuyen.Location = new Point(182, 2);
            btnDanhSachThongTinDangTuyen.Margin = new Padding(2);
            btnDanhSachThongTinDangTuyen.Name = "btnDanhSachThongTinDangTuyen";
            btnDanhSachThongTinDangTuyen.Size = new Size(229, 30);
            btnDanhSachThongTinDangTuyen.TabIndex = 1;
            btnDanhSachThongTinDangTuyen.Text = "Danh sách thông tin đăng tuyển";
            btnDanhSachThongTinDangTuyen.UseVisualStyleBackColor = true;
            btnDanhSachThongTinDangTuyen.Click += btnDanhSachThongTinDangTuyen_Click;
            // 
            // _contentPanel
            // 
            _contentPanel.BackColor = SystemColors.ControlLight;
            _contentPanel.Dock = DockStyle.Fill;
            _contentPanel.Location = new Point(2, 41);
            _contentPanel.Margin = new Padding(2);
            _contentPanel.Name = "_contentPanel";
            _contentPanel.Size = new Size(815, 317);
            _contentPanel.TabIndex = 0;
            // 
            // btnXetDuyetTTDT
            // 
            btnXetDuyetTTDT.AutoSize = true;
            btnXetDuyetTTDT.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnXetDuyetTTDT.Location = new Point(590, 2);
            btnXetDuyetTTDT.Margin = new Padding(2);
            btnXetDuyetTTDT.Name = "btnXetDuyetTTDT";
            btnXetDuyetTTDT.Size = new Size(218, 30);
            btnXetDuyetTTDT.TabIndex = 3;
            btnXetDuyetTTDT.Text = "Xác thực thông tin đăng tuyển";
            btnXetDuyetTTDT.UseVisualStyleBackColor = true;
            btnXetDuyetTTDT.Click += btnXetDuyetTTDT_Click;
            // 
            // GUI_Base
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(819, 360);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(2);
            Name = "GUI_Base";
            Text = "GUI_Base";
            Click += btnTaoYeuCau_Click;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
		private Panel _contentPanel;
		private TableLayoutPanel tableLayoutPanel2;
		private Button btnTaoYeuCau;
		private Button btnDanhSachThongTinDangTuyen;
        private Button btnXacThucDN;
        private Button btnXetDuyetTTDT;
    }
}