namespace GUI.UserControls
{
    partial class GUI_CapNhatThongTinDoanhNghiep
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
            txbEmail = new TextBox();
            txbDiaChi = new TextBox();
            txbDaiDien = new TextBox();
            txbMST = new TextBox();
            txbTenDN = new TextBox();
            label2 = new Label();
            label6 = new Label();
            label3 = new Label();
            label5 = new Label();
            label4 = new Label();
            btnChinhSua = new Button();
            btnLuu = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(33, 27);
            label1.Name = "label1";
            label1.Size = new Size(265, 38);
            label1.TabIndex = 0;
            label1.Text = "Cập nhật thông tin";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.9266567F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 72.07334F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 211F));
            tableLayoutPanel1.Controls.Add(txbEmail, 1, 4);
            tableLayoutPanel1.Controls.Add(txbDiaChi, 1, 3);
            tableLayoutPanel1.Controls.Add(txbDaiDien, 1, 2);
            tableLayoutPanel1.Controls.Add(txbMST, 1, 1);
            tableLayoutPanel1.Controls.Add(txbTenDN, 1, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(label6, 0, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(label5, 0, 4);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Controls.Add(btnChinhSua, 1, 5);
            tableLayoutPanel1.Controls.Add(btnLuu, 0, 5);
            tableLayoutPanel1.Location = new Point(27, 98);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.Size = new Size(921, 243);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // txbEmail
            // 
            txbEmail.Location = new Point(201, 163);
            txbEmail.Name = "txbEmail";
            txbEmail.ReadOnly = true;
            txbEmail.Size = new Size(505, 27);
            txbEmail.TabIndex = 8;
            // 
            // txbDiaChi
            // 
            txbDiaChi.Location = new Point(201, 123);
            txbDiaChi.Name = "txbDiaChi";
            txbDiaChi.ReadOnly = true;
            txbDiaChi.Size = new Size(505, 27);
            txbDiaChi.TabIndex = 7;
            // 
            // txbDaiDien
            // 
            txbDaiDien.Location = new Point(201, 83);
            txbDaiDien.Name = "txbDaiDien";
            txbDaiDien.ReadOnly = true;
            txbDaiDien.Size = new Size(505, 27);
            txbDaiDien.TabIndex = 6;
            // 
            // txbMST
            // 
            txbMST.Location = new Point(201, 43);
            txbMST.Name = "txbMST";
            txbMST.ReadOnly = true;
            txbMST.Size = new Size(505, 27);
            txbMST.TabIndex = 5;
            // 
            // txbTenDN
            // 
            txbTenDN.Location = new Point(201, 3);
            txbTenDN.Name = "txbTenDN";
            txbTenDN.ReadOnly = true;
            txbTenDN.Size = new Size(505, 27);
            txbTenDN.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(186, 28);
            label2.TabIndex = 0;
            label2.Text = "Tên doanh nghiệp:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(3, 40);
            label6.Name = "label6";
            label6.Size = new Size(123, 28);
            label6.TabIndex = 4;
            label6.Text = "Mã số thuế:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 80);
            label3.Name = "label3";
            label3.Size = new Size(160, 28);
            label3.TabIndex = 1;
            label3.Text = "Người đại diện:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(3, 160);
            label5.Name = "label5";
            label5.Size = new Size(69, 28);
            label5.TabIndex = 3;
            label5.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 120);
            label4.Name = "label4";
            label4.Size = new Size(83, 28);
            label4.TabIndex = 2;
            label4.Text = "Địa chỉ:";
            // 
            // btnChinhSua
            // 
            btnChinhSua.Location = new Point(201, 203);
            btnChinhSua.Name = "btnChinhSua";
            btnChinhSua.Size = new Size(94, 29);
            btnChinhSua.TabIndex = 9;
            btnChinhSua.Text = "Chỉnh sửa";
            btnChinhSua.UseVisualStyleBackColor = true;
            btnChinhSua.Click += btnChinhSua_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(3, 203);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 29);
            btnLuu.TabIndex = 11;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // GUI_CapNhatThongTinDoanhNghiep
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label1);
            Name = "GUI_CapNhatThongTinDoanhNghiep";
            Size = new Size(966, 488);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private TextBox txbEmail;
        private TextBox txbDiaChi;
        private TextBox txbDaiDien;
        private TextBox txbMST;
        private TextBox txbTenDN;
        private Label label6;
        private Label label3;
        private Label label5;
        private Label label4;
        private Button btnChinhSua;
        private Button btnLuu;
    }
}
