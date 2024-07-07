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
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(145, 139);
            label2.Name = "label2";
            label2.Size = new Size(103, 28);
            label2.TabIndex = 3;
            label2.Text = "Tài khoản";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(15, 20);
            label1.Name = "label1";
            label1.Size = new Size(161, 38);
            label1.TabIndex = 5;
            label1.Text = "Đăng nhập";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(145, 200);
            label3.Name = "label3";
            label3.Size = new Size(102, 28);
            label3.TabIndex = 6;
            label3.Text = "Mật khẩu";
            // 
            // btnDangNhap
            // 
            btnDangNhap.Location = new Point(310, 278);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(94, 29);
            btnDangNhap.TabIndex = 9;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = true;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // btnDangKy
            // 
            btnDangKy.FlatAppearance.BorderSize = 0;
            btnDangKy.FlatStyle = FlatStyle.Flat;
            btnDangKy.ForeColor = SystemColors.Highlight;
            btnDangKy.Location = new Point(244, 374);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(73, 29);
            btnDangKy.TabIndex = 10;
            btnDangKy.Text = "Đăng ký";
            btnDangKy.UseVisualStyleBackColor = true;
            btnDangKy.Click += btnDangKy_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 378);
            label4.Name = "label4";
            label4.Size = new Size(234, 20);
            label4.TabIndex = 11;
            label4.Text = "Chưa có tài khoản? Đăng ký ở đây";
            label4.Click += label4_Click;
            // 
            // txtTenTaiKhoan
            // 
            txtTenTaiKhoan.Location = new Point(254, 143);
            txtTenTaiKhoan.Name = "txtTenTaiKhoan";
            txtTenTaiKhoan.Size = new Size(320, 27);
            txtTenTaiKhoan.TabIndex = 12;
            txtTenTaiKhoan.KeyDown += txtTenTaiKhoan_KeyDown;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(253, 201);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '.';
            txtMatKhau.Size = new Size(320, 27);
            txtMatKhau.TabIndex = 13;
            txtMatKhau.KeyDown += txtMatKhau_KeyDown;
            // 
            // cbPassword
            // 
            cbPassword.AutoSize = true;
            cbPassword.Location = new Point(579, 203);
            cbPassword.Name = "cbPassword";
            cbPassword.Size = new Size(65, 24);
            cbPassword.TabIndex = 14;
            cbPassword.Text = "show";
            cbPassword.UseVisualStyleBackColor = true;
            cbPassword.CheckedChanged += cbPassword_CheckedChanged;
            // 
            // GUI_DangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(cbPassword);
            Controls.Add(txtMatKhau);
            Controls.Add(txtTenTaiKhoan);
            Controls.Add(btnDangKy);
            Controls.Add(label4);
            Controls.Add(btnDangNhap);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Name = "GUI_DangNhap";
            Size = new Size(693, 425);
            Load += GUI_DangNhap_Load;
            KeyDown += GUI_DangNhap_KeyDown;
            ResumeLayout(false);
            PerformLayout();
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
    }
}
