namespace GUI.GUI_XacThuc
{
    partial class GUI_DangKyUngVien
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
            label5 = new Label();
            txtSoDienThoai = new TextBox();
            label4 = new Label();
            txtDiaChi = new TextBox();
            label3 = new Label();
            txtCCCD = new TextBox();
            label1 = new Label();
            txtHoTen = new TextBox();
            lb = new Label();
            dtpNgaySinh = new DateTimePicker();
            tableLayoutPanel1 = new TableLayoutPanel();
            txtEmail = new TextBox();
            label2 = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(3, 145);
            label5.Name = "label5";
            label5.Size = new Size(107, 28);
            label5.TabIndex = 31;
            label5.Text = "Ngày sinh";
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Location = new Point(292, 112);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(281, 27);
            txtSoDienThoai.TabIndex = 30;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 109);
            label4.Name = "label4";
            label4.Size = new Size(138, 28);
            label4.TabIndex = 29;
            label4.Text = "Số điện thoại";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(292, 76);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(281, 27);
            txtDiaChi.TabIndex = 28;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 73);
            label3.Name = "label3";
            label3.Size = new Size(78, 28);
            label3.TabIndex = 27;
            label3.Text = "Địa chỉ";
            // 
            // txtCCCD
            // 
            txtCCCD.Location = new Point(292, 40);
            txtCCCD.Name = "txtCCCD";
            txtCCCD.Size = new Size(281, 27);
            txtCCCD.TabIndex = 26;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 37);
            label1.Name = "label1";
            label1.Size = new Size(61, 28);
            label1.TabIndex = 25;
            label1.Text = "CCCD";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(292, 3);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(281, 27);
            txtHoTen.TabIndex = 24;
            // 
            // lb
            // 
            lb.AutoSize = true;
            lb.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb.Location = new Point(3, 0);
            lb.Name = "lb";
            lb.Size = new Size(104, 28);
            lb.TabIndex = 23;
            lb.Text = "Họ và tên";
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Location = new Point(292, 148);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(281, 27);
            dtpNgaySinh.TabIndex = 33;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(txtEmail, 1, 5);
            tableLayoutPanel1.Controls.Add(label2, 0, 5);
            tableLayoutPanel1.Controls.Add(lb, 0, 0);
            tableLayoutPanel1.Controls.Add(dtpNgaySinh, 1, 4);
            tableLayoutPanel1.Controls.Add(txtHoTen, 1, 0);
            tableLayoutPanel1.Controls.Add(label5, 0, 4);
            tableLayoutPanel1.Controls.Add(label1, 0, 1);
            tableLayoutPanel1.Controls.Add(txtSoDienThoai, 1, 3);
            tableLayoutPanel1.Controls.Add(txtCCCD, 1, 1);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(txtDiaChi, 1, 2);
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666718F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.Size = new Size(578, 222);
            tableLayoutPanel1.TabIndex = 34;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(292, 184);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(281, 27);
            txtEmail.TabIndex = 35;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 181);
            label2.Name = "label2";
            label2.Size = new Size(64, 28);
            label2.TabIndex = 34;
            label2.Text = "Email";
            // 
            // GUI_DangKyUngVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "GUI_DangKyUngVien";
            Size = new Size(590, 240);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label5;
        private TextBox txtSoDienThoai;
        private Label label4;
        private TextBox txtDiaChi;
        private Label label3;
        private TextBox txtCCCD;
        private Label label1;
        private TextBox txtHoTen;
        private Label lb;
        private DateTimePicker dtpNgaySinh;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox txtEmail;
        private Label label2;
    }
}
