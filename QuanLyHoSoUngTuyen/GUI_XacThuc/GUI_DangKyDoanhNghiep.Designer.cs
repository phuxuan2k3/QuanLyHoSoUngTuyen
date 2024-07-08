namespace GUI.GUI_XacThuc
{
    partial class GUI_DangKyDoanhNghiep
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
            txtTenCongTy = new TextBox();
            txtMaSoThue = new TextBox();
            label1 = new Label();
            txtNguoiDaiDien = new TextBox();
            label3 = new Label();
            txtEmail = new TextBox();
            label4 = new Label();
            txtDiaChi = new TextBox();
            label5 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(122, 28);
            label2.TabIndex = 13;
            label2.Text = "Tên công ty";
            // 
            // txtTenCongTy
            // 
            txtTenCongTy.Location = new Point(292, 3);
            txtTenCongTy.Name = "txtTenCongTy";
            txtTenCongTy.Size = new Size(283, 27);
            txtTenCongTy.TabIndex = 14;
            // 
            // txtMaSoThue
            // 
            txtMaSoThue.Location = new Point(292, 41);
            txtMaSoThue.Name = "txtMaSoThue";
            txtMaSoThue.Size = new Size(283, 27);
            txtMaSoThue.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 38);
            label1.Name = "label1";
            label1.Size = new Size(118, 28);
            label1.TabIndex = 15;
            label1.Text = "Mã số thuế";
            // 
            // txtNguoiDaiDien
            // 
            txtNguoiDaiDien.Location = new Point(292, 79);
            txtNguoiDaiDien.Name = "txtNguoiDaiDien";
            txtNguoiDaiDien.Size = new Size(283, 27);
            txtNguoiDaiDien.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 76);
            label3.Name = "label3";
            label3.Size = new Size(155, 28);
            label3.TabIndex = 17;
            label3.Text = "Người đại diện";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(292, 117);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(283, 27);
            txtEmail.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 114);
            label4.Name = "label4";
            label4.Size = new Size(134, 28);
            label4.TabIndex = 19;
            label4.Text = "Email liên hệ";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(292, 155);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(283, 27);
            txtDiaChi.TabIndex = 22;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(3, 152);
            label5.Name = "label5";
            label5.Size = new Size(78, 28);
            label5.TabIndex = 21;
            label5.Text = "Địa chỉ";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Controls.Add(label5, 0, 4);
            tableLayoutPanel2.Controls.Add(txtDiaChi, 1, 4);
            tableLayoutPanel2.Controls.Add(label4, 0, 3);
            tableLayoutPanel2.Controls.Add(label1, 0, 1);
            tableLayoutPanel2.Controls.Add(label3, 0, 2);
            tableLayoutPanel2.Controls.Add(label2, 0, 0);
            tableLayoutPanel2.Controls.Add(txtTenCongTy, 1, 0);
            tableLayoutPanel2.Controls.Add(txtMaSoThue, 1, 1);
            tableLayoutPanel2.Controls.Add(txtEmail, 1, 3);
            tableLayoutPanel2.Controls.Add(txtNguoiDaiDien, 1, 2);
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.Size = new Size(578, 194);
            tableLayoutPanel2.TabIndex = 35;
            // 
            // GUI_DangKyDoanhNghiep
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel2);
            Name = "GUI_DangKyDoanhNghiep";
            Size = new Size(585, 204);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label2;
        private TextBox txtTenCongTy;
        private TextBox txtMaSoThue;
        private Label label1;
        private TextBox txtNguoiDaiDien;
        private Label label3;
        private TextBox txtEmail;
        private Label label4;
        private TextBox txtDiaChi;
        private Label label5;
        private TableLayoutPanel tableLayoutPanel2;
    }
}
