namespace GUI
{
	partial class LandingPage
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

		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LandingPage));
			pictureBoxLogo = new PictureBox();
			tableLayoutPanel1 = new TableLayoutPanel();
			labelCompanyName = new Label();
			tableLayoutPanel2 = new TableLayoutPanel();
			label5 = new Label();
			label4 = new Label();
			labelWelcome = new Label();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			_tenDoanhNghiep = new Label();
			_maSoThue = new Label();
			_nguoiDaiDien = new Label();
			_diaChi = new Label();
			_email = new Label();
			_trangThai = new Label();
			((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
			tableLayoutPanel1.SuspendLayout();
			tableLayoutPanel2.SuspendLayout();
			SuspendLayout();
			// 
			// pictureBoxLogo
			// 
			pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
			pictureBoxLogo.Location = new Point(4, 5);
			pictureBoxLogo.Margin = new Padding(4, 5, 4, 5);
			pictureBoxLogo.Name = "pictureBoxLogo";
			tableLayoutPanel1.SetRowSpan(pictureBoxLogo, 3);
			pictureBoxLogo.Size = new Size(214, 235);
			pictureBoxLogo.TabIndex = 1;
			pictureBoxLogo.TabStop = false;
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.ColumnCount = 2;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			tableLayoutPanel1.Controls.Add(pictureBoxLogo, 0, 0);
			tableLayoutPanel1.Controls.Add(labelCompanyName, 1, 0);
			tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 2);
			tableLayoutPanel1.Dock = DockStyle.Fill;
			tableLayoutPanel1.Location = new Point(0, 0);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 3;
			tableLayoutPanel1.RowStyles.Add(new RowStyle());
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle());
			tableLayoutPanel1.Size = new Size(1014, 572);
			tableLayoutPanel1.TabIndex = 3;
			// 
			// labelCompanyName
			// 
			labelCompanyName.Dock = DockStyle.Fill;
			labelCompanyName.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
			labelCompanyName.Location = new Point(226, 4);
			labelCompanyName.Margin = new Padding(4);
			labelCompanyName.Name = "labelCompanyName";
			labelCompanyName.Size = new Size(784, 132);
			labelCompanyName.TabIndex = 0;
			labelCompanyName.Text = "ABC Recruitment";
			labelCompanyName.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// tableLayoutPanel2
			// 
			tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			tableLayoutPanel2.AutoSize = true;
			tableLayoutPanel2.ColumnCount = 4;
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.28571F));
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 71.42857F));
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857132F));
			tableLayoutPanel2.Controls.Add(label5, 1, 5);
			tableLayoutPanel2.Controls.Add(label4, 1, 4);
			tableLayoutPanel2.Controls.Add(labelWelcome, 1, 0);
			tableLayoutPanel2.Controls.Add(label1, 1, 1);
			tableLayoutPanel2.Controls.Add(label2, 1, 2);
			tableLayoutPanel2.Controls.Add(label3, 1, 3);
			tableLayoutPanel2.Controls.Add(_tenDoanhNghiep, 2, 0);
			tableLayoutPanel2.Controls.Add(_maSoThue, 2, 1);
			tableLayoutPanel2.Controls.Add(_nguoiDaiDien, 2, 2);
			tableLayoutPanel2.Controls.Add(_diaChi, 2, 3);
			tableLayoutPanel2.Controls.Add(_email, 2, 4);
			tableLayoutPanel2.Controls.Add(_trangThai, 2, 5);
			tableLayoutPanel2.Location = new Point(225, 193);
			tableLayoutPanel2.Name = "tableLayoutPanel2";
			tableLayoutPanel2.RowCount = 6;
			tableLayoutPanel2.RowStyles.Add(new RowStyle());
			tableLayoutPanel2.RowStyles.Add(new RowStyle());
			tableLayoutPanel2.RowStyles.Add(new RowStyle());
			tableLayoutPanel2.RowStyles.Add(new RowStyle());
			tableLayoutPanel2.RowStyles.Add(new RowStyle());
			tableLayoutPanel2.RowStyles.Add(new RowStyle());
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
			tableLayoutPanel2.Size = new Size(786, 264);
			tableLayoutPanel2.TabIndex = 4;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			label5.Location = new Point(92, 228);
			label5.Margin = new Padding(4, 8, 4, 8);
			label5.Name = "label5";
			label5.Size = new Size(113, 28);
			label5.TabIndex = 8;
			label5.Text = "Trạng thái:";
			label5.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			label4.Location = new Point(92, 184);
			label4.Margin = new Padding(4, 8, 4, 8);
			label4.Name = "label4";
			label4.Size = new Size(69, 28);
			label4.TabIndex = 7;
			label4.Text = "Email:";
			label4.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// labelWelcome
			// 
			labelWelcome.AutoSize = true;
			labelWelcome.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			labelWelcome.Location = new Point(92, 8);
			labelWelcome.Margin = new Padding(4, 8, 4, 8);
			labelWelcome.Name = "labelWelcome";
			labelWelcome.Size = new Size(150, 28);
			labelWelcome.TabIndex = 3;
			labelWelcome.Text = "Doanh nghiệp:";
			labelWelcome.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			label1.Location = new Point(92, 52);
			label1.Margin = new Padding(4, 8, 4, 8);
			label1.Name = "label1";
			label1.Size = new Size(123, 28);
			label1.TabIndex = 4;
			label1.Text = "Mã số thuế:";
			label1.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			label2.Location = new Point(92, 96);
			label2.Margin = new Padding(4, 8, 4, 8);
			label2.Name = "label2";
			label2.Size = new Size(160, 28);
			label2.TabIndex = 5;
			label2.Text = "Người đại diện:";
			label2.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			label3.Location = new Point(92, 140);
			label3.Margin = new Padding(4, 8, 4, 8);
			label3.Name = "label3";
			label3.Size = new Size(83, 28);
			label3.TabIndex = 6;
			label3.Text = "Địa chỉ:";
			label3.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// _tenDoanhNghiep
			// 
			_tenDoanhNghiep.Anchor = AnchorStyles.Left;
			_tenDoanhNghiep.AutoSize = true;
			_tenDoanhNghiep.Font = new Font("Segoe UI", 12F);
			_tenDoanhNghiep.Location = new Point(260, 8);
			_tenDoanhNghiep.Margin = new Padding(4);
			_tenDoanhNghiep.Name = "_tenDoanhNghiep";
			_tenDoanhNghiep.Size = new Size(54, 28);
			_tenDoanhNghiep.TabIndex = 9;
			_tenDoanhNghiep.Text = "label";
			_tenDoanhNghiep.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// _maSoThue
			// 
			_maSoThue.Anchor = AnchorStyles.Left;
			_maSoThue.AutoSize = true;
			_maSoThue.Font = new Font("Segoe UI", 12F);
			_maSoThue.Location = new Point(260, 52);
			_maSoThue.Margin = new Padding(4);
			_maSoThue.Name = "_maSoThue";
			_maSoThue.Size = new Size(54, 28);
			_maSoThue.TabIndex = 10;
			_maSoThue.Text = "label";
			_maSoThue.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// _nguoiDaiDien
			// 
			_nguoiDaiDien.Anchor = AnchorStyles.Left;
			_nguoiDaiDien.AutoSize = true;
			_nguoiDaiDien.Font = new Font("Segoe UI", 12F);
			_nguoiDaiDien.Location = new Point(260, 96);
			_nguoiDaiDien.Margin = new Padding(4);
			_nguoiDaiDien.Name = "_nguoiDaiDien";
			_nguoiDaiDien.Size = new Size(54, 28);
			_nguoiDaiDien.TabIndex = 11;
			_nguoiDaiDien.Text = "label";
			_nguoiDaiDien.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// _diaChi
			// 
			_diaChi.Anchor = AnchorStyles.Left;
			_diaChi.AutoSize = true;
			_diaChi.Font = new Font("Segoe UI", 12F);
			_diaChi.Location = new Point(260, 140);
			_diaChi.Margin = new Padding(4);
			_diaChi.Name = "_diaChi";
			_diaChi.Size = new Size(54, 28);
			_diaChi.TabIndex = 12;
			_diaChi.Text = "label";
			_diaChi.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// _email
			// 
			_email.Anchor = AnchorStyles.Left;
			_email.AutoSize = true;
			_email.Font = new Font("Segoe UI", 12F);
			_email.Location = new Point(260, 184);
			_email.Margin = new Padding(4);
			_email.Name = "_email";
			_email.Size = new Size(54, 28);
			_email.TabIndex = 13;
			_email.Text = "label";
			_email.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// _trangThai
			// 
			_trangThai.Anchor = AnchorStyles.Left;
			_trangThai.AutoSize = true;
			_trangThai.Font = new Font("Segoe UI", 12F);
			_trangThai.Location = new Point(260, 228);
			_trangThai.Margin = new Padding(4);
			_trangThai.Name = "_trangThai";
			_trangThai.Size = new Size(54, 28);
			_trangThai.TabIndex = 14;
			_trangThai.Text = "label";
			_trangThai.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// LandingPage
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(tableLayoutPanel1);
			Margin = new Padding(4, 5, 4, 5);
			Name = "LandingPage";
			Size = new Size(1014, 572);
			((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
			tableLayoutPanel1.ResumeLayout(false);
			tableLayoutPanel1.PerformLayout();
			tableLayoutPanel2.ResumeLayout(false);
			tableLayoutPanel2.PerformLayout();
			ResumeLayout(false);
		}

		#endregion
		private System.Windows.Forms.PictureBox pictureBoxLogo;
		private TableLayoutPanel tableLayoutPanel1;
		private Label labelCompanyName;
		private TableLayoutPanel tableLayoutPanel2;
		private Label label5;
		private Label label4;
		private Label labelWelcome;
		private Label label1;
		private Label label2;
		private Label label3;
		private Label _tenDoanhNghiep;
		private Label _maSoThue;
		private Label _nguoiDaiDien;
		private Label _diaChi;
		private Label _email;
		private Label _trangThai;
	}
}
