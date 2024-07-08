namespace GUI.GUI_XacThuc
{
    partial class GUI_DangKyTaiKhoan
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
            tableLayoutPanel1 = new TableLayoutPanel();
            lb = new Label();
            txtTenTaiKhoan = new TextBox();
            label1 = new Label();
            txtMatKhau = new TextBox();
            label3 = new Label();
            txtNhapLaiMatKhau = new TextBox();
            cbPassword = new CheckBox();
            cbPasswordAgain = new CheckBox();   
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(lb, 0, 0);
            tableLayoutPanel1.Controls.Add(txtTenTaiKhoan, 1, 0);
            tableLayoutPanel1.Controls.Add(label1, 0, 1);
            tableLayoutPanel1.Controls.Add(txtMatKhau, 1, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(txtNhapLaiMatKhau, 1, 2);
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(578, 102);
            tableLayoutPanel1.TabIndex = 35;
            // 
            // lb
            // 
            lb.AutoSize = true;
            lb.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb.Location = new Point(3, 0);
            lb.Name = "lb";
            lb.Size = new Size(140, 28);
            lb.TabIndex = 23;
            lb.Text = "Tên tài khoản";
            // 
            // txtTenTaiKhoan
            // 
            txtTenTaiKhoan.Location = new Point(292, 3);
            txtTenTaiKhoan.Name = "txtTenTaiKhoan";
            txtTenTaiKhoan.Size = new Size(281, 27);
            txtTenTaiKhoan.TabIndex = 24;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 34);
            label1.Name = "label1";
            label1.Size = new Size(102, 28);
            label1.TabIndex = 25;
            label1.Text = "Mật khẩu";
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(292, 37);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '.';
            txtMatKhau.Size = new Size(281, 27);
            txtMatKhau.TabIndex = 26;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 68);
            label3.Name = "label3";
            label3.Size = new Size(187, 28);
            label3.TabIndex = 27;
            label3.Text = "Nhập lại mật khẩu";
            // 
            // txtNhapLaiMatKhau
            // 
            txtNhapLaiMatKhau.Location = new Point(292, 71);
            txtNhapLaiMatKhau.Name = "txtNhapLaiMatKhau";
            txtNhapLaiMatKhau.PasswordChar = '.';
            txtNhapLaiMatKhau.Size = new Size(281, 27);
            txtNhapLaiMatKhau.TabIndex = 28;
            // 
            // cbPassword
            // 
            cbPassword.AutoSize = true;
            cbPassword.Location = new Point(587, 41);
            cbPassword.Name = "cbPassword";
            cbPassword.Size = new Size(65, 24);
            cbPassword.TabIndex = 38;
            cbPassword.Text = "show";
            cbPassword.UseVisualStyleBackColor = true;
            cbPassword.CheckedChanged += cbPassword_CheckedChanged;
            // 
            // cbPasswordAgain
            // 
            cbPasswordAgain.AutoSize = true;
            cbPasswordAgain.Location = new Point(587, 77);
            cbPasswordAgain.Name = "cbPasswordAgain";
            cbPasswordAgain.Size = new Size(65, 24);
            cbPasswordAgain.TabIndex = 39;
            cbPasswordAgain.Text = "show";
            cbPasswordAgain.UseVisualStyleBackColor = true;
            cbPasswordAgain.CheckedChanged += cbPasswordAgain_CheckedChanged;
            // 
            // GUI_DangKyTaiKhoan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(cbPasswordAgain);
            Controls.Add(cbPassword);
            Controls.Add(tableLayoutPanel1);
            Name = "GUI_DangKyTaiKhoan";
            Size = new Size(682, 111);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label lb;
        private TextBox txtTenTaiKhoan;
        private Label label1;
        private TextBox txtMatKhau;
        private Label label3;
        private TextBox txtNhapLaiMatKhau;
        private CheckBox cbPassword;
        private CheckBox cbPasswordAgain;
    }
}
