namespace GUI.GUI_XacThuc
{
    partial class GUI_DangNhap
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
			label2 = new Label();
			label1 = new Label();
			label3 = new Label();
			btnDangNhap = new Button();
			btnDangKy = new Button();
			label4 = new Label();
			txtTenTaiKhoan = new TextBox();
			txtMatKhau = new TextBox();
			cbPassword = new CheckBox();
			tableLayoutPanel1 = new TableLayoutPanel();
			flowLayoutPanel1 = new FlowLayoutPanel();
			tableLayoutPanel1.SuspendLayout();
			flowLayoutPanel1.SuspendLayout();
			SuspendLayout();
			// 
			// label2
			// 
			label2.Anchor = AnchorStyles.Right;
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label2.Location = new Point(290, 209);
			label2.Margin = new Padding(4, 0, 4, 0);
			label2.Name = "label2";
			label2.Size = new Size(103, 28);
			label2.TabIndex = 3;
			label2.Text = "Tài khoản";
			// 
			// label1
			// 
			label1.Anchor = AnchorStyles.None;
			label1.AutoSize = true;
			tableLayoutPanel1.SetColumnSpan(label1, 2);
			label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.Location = new Point(118, 30);
			label1.Margin = new Padding(4, 0, 4, 0);
			label1.Name = "label1";
			label1.Size = new Size(161, 38);
			label1.TabIndex = 5;
			label1.Text = "Đăng nhập";
			// 
			// label3
			// 
			label3.Anchor = AnchorStyles.Right;
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label3.Location = new Point(291, 264);
			label3.Margin = new Padding(4, 0, 4, 0);
			label3.Name = "label3";
			label3.Size = new Size(102, 28);
			label3.TabIndex = 6;
			label3.Text = "Mật khẩu";
			// 
			// btnDangNhap
			// 
			btnDangNhap.Location = new Point(401, 310);
			btnDangNhap.Margin = new Padding(4);
			btnDangNhap.Name = "btnDangNhap";
			btnDangNhap.Size = new Size(118, 36);
			btnDangNhap.TabIndex = 9;
			btnDangNhap.Text = "Đăng nhập";
			btnDangNhap.UseVisualStyleBackColor = true;
			btnDangNhap.Click += btnDangNhap_Click;
			// 
			// btnDangKy
			// 
			btnDangKy.Anchor = AnchorStyles.Left;
			btnDangKy.FlatAppearance.BorderSize = 0;
			btnDangKy.FlatStyle = FlatStyle.Flat;
			btnDangKy.ForeColor = SystemColors.Highlight;
			btnDangKy.Location = new Point(296, 4);
			btnDangKy.Margin = new Padding(4);
			btnDangKy.Name = "btnDangKy";
			btnDangKy.Size = new Size(91, 36);
			btnDangKy.TabIndex = 10;
			btnDangKy.Text = "Đăng ký";
			btnDangKy.UseVisualStyleBackColor = true;
			btnDangKy.Click += btnDangKy_Click;
			// 
			// label4
			// 
			label4.Anchor = AnchorStyles.Left;
			label4.AutoSize = true;
			label4.Location = new Point(4, 9);
			label4.Margin = new Padding(4, 0, 4, 0);
			label4.Name = "label4";
			label4.Size = new Size(284, 25);
			label4.TabIndex = 11;
			label4.Text = "Chưa có tài khoản? Đăng ký ở đây";
			label4.Click += label4_Click;
			// 
			// txtTenTaiKhoan
			// 
			txtTenTaiKhoan.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			txtTenTaiKhoan.Location = new Point(401, 208);
			txtTenTaiKhoan.Margin = new Padding(4, 12, 4, 12);
			txtTenTaiKhoan.Name = "txtTenTaiKhoan";
			txtTenTaiKhoan.Size = new Size(320, 31);
			txtTenTaiKhoan.TabIndex = 12;
			txtTenTaiKhoan.KeyDown += txtTenTaiKhoan_KeyDown;
			// 
			// txtMatKhau
			// 
			txtMatKhau.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			txtMatKhau.Location = new Point(401, 263);
			txtMatKhau.Margin = new Padding(4, 12, 4, 12);
			txtMatKhau.Name = "txtMatKhau";
			txtMatKhau.PasswordChar = '.';
			txtMatKhau.Size = new Size(320, 31);
			txtMatKhau.TabIndex = 13;
			txtMatKhau.KeyDown += txtMatKhau_KeyDown;
			// 
			// cbPassword
			// 
			cbPassword.AutoSize = true;
			cbPassword.Location = new Point(729, 255);
			cbPassword.Margin = new Padding(4);
			cbPassword.Name = "cbPassword";
			cbPassword.Size = new Size(76, 29);
			cbPassword.TabIndex = 14;
			cbPassword.Text = "show";
			cbPassword.UseVisualStyleBackColor = true;
			cbPassword.CheckedChanged += cbPassword_CheckedChanged;
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.ColumnCount = 4;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
			tableLayoutPanel1.Controls.Add(cbPassword, 3, 3);
			tableLayoutPanel1.Controls.Add(label1, 0, 0);
			tableLayoutPanel1.Controls.Add(btnDangNhap, 2, 4);
			tableLayoutPanel1.Controls.Add(txtMatKhau, 2, 3);
			tableLayoutPanel1.Controls.Add(label2, 1, 2);
			tableLayoutPanel1.Controls.Add(txtTenTaiKhoan, 2, 2);
			tableLayoutPanel1.Controls.Add(label3, 1, 3);
			tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 6);
			tableLayoutPanel1.Dock = DockStyle.Fill;
			tableLayoutPanel1.Location = new Point(0, 0);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 7;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 30.0000019F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle());
			tableLayoutPanel1.RowStyles.Add(new RowStyle());
			tableLayoutPanel1.RowStyles.Add(new RowStyle());
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 39.9999962F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle());
			tableLayoutPanel1.Size = new Size(866, 531);
			tableLayoutPanel1.TabIndex = 15;
			// 
			// flowLayoutPanel1
			// 
			flowLayoutPanel1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			flowLayoutPanel1.AutoSize = true;
			tableLayoutPanel1.SetColumnSpan(flowLayoutPanel1, 2);
			flowLayoutPanel1.Controls.Add(label4);
			flowLayoutPanel1.Controls.Add(btnDangKy);
			flowLayoutPanel1.Location = new Point(3, 483);
			flowLayoutPanel1.Name = "flowLayoutPanel1";
			flowLayoutPanel1.Size = new Size(391, 44);
			flowLayoutPanel1.TabIndex = 15;
			flowLayoutPanel1.WrapContents = false;
			// 
			// GUI_DangNhap
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(tableLayoutPanel1);
			Margin = new Padding(4);
			Name = "GUI_DangNhap";
			Size = new Size(866, 531);
			KeyDown += GUI_DangNhap_KeyDown;
			tableLayoutPanel1.ResumeLayout(false);
			tableLayoutPanel1.PerformLayout();
			flowLayoutPanel1.ResumeLayout(false);
			flowLayoutPanel1.PerformLayout();
			ResumeLayout(false);
		}

		#endregion
		private Label label2;
        private Label label1;
        private Label label3;
        private Button btnDangNhap;
        private Button btnDangKy;
        private Label label4;
        private TextBox txtTenTaiKhoan;
        private TextBox txtMatKhau;
        private CheckBox cbPassword;
		private TableLayoutPanel tableLayoutPanel1;
		private FlowLayoutPanel flowLayoutPanel1;
	}
}
