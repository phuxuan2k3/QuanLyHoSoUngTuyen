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
			tableLayoutPanel2 = new TableLayoutPanel();
			tableLayoutPanel2.SuspendLayout();
			SuspendLayout();
			// 
			// label1
			// 
			label1.Anchor = AnchorStyles.Left;
			label1.AutoSize = true;
			tableLayoutPanel2.SetColumnSpan(label1, 2);
			label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.Location = new Point(148, 108);
			label1.Margin = new Padding(4, 30, 4, 50);
			label1.Name = "label1";
			label1.Size = new Size(265, 38);
			label1.TabIndex = 0;
			label1.Text = "Cập nhật thông tin";
			// 
			// txbEmail
			// 
			txbEmail.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			txbEmail.Location = new Point(346, 392);
			txbEmail.Margin = new Padding(8);
			txbEmail.Name = "txbEmail";
			txbEmail.ReadOnly = true;
			txbEmail.Size = new Size(708, 31);
			txbEmail.TabIndex = 8;
			// 
			// txbDiaChi
			// 
			txbDiaChi.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			txbDiaChi.Location = new Point(346, 345);
			txbDiaChi.Margin = new Padding(8);
			txbDiaChi.Name = "txbDiaChi";
			txbDiaChi.ReadOnly = true;
			txbDiaChi.Size = new Size(708, 31);
			txbDiaChi.TabIndex = 7;
			// 
			// txbDaiDien
			// 
			txbDaiDien.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			txbDaiDien.Location = new Point(346, 298);
			txbDaiDien.Margin = new Padding(8);
			txbDaiDien.Name = "txbDaiDien";
			txbDaiDien.ReadOnly = true;
			txbDaiDien.Size = new Size(708, 31);
			txbDaiDien.TabIndex = 6;
			// 
			// txbMST
			// 
			txbMST.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			txbMST.Location = new Point(346, 251);
			txbMST.Margin = new Padding(8);
			txbMST.Name = "txbMST";
			txbMST.ReadOnly = true;
			txbMST.Size = new Size(708, 31);
			txbMST.TabIndex = 5;
			// 
			// txbTenDN
			// 
			txbTenDN.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			txbTenDN.Location = new Point(346, 204);
			txbTenDN.Margin = new Padding(8);
			txbTenDN.Name = "txbTenDN";
			txbTenDN.ReadOnly = true;
			txbTenDN.Size = new Size(708, 31);
			txbTenDN.TabIndex = 2;
			// 
			// label2
			// 
			label2.Anchor = AnchorStyles.Left;
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label2.Location = new Point(148, 205);
			label2.Margin = new Padding(4, 0, 4, 0);
			label2.Name = "label2";
			label2.Size = new Size(186, 28);
			label2.TabIndex = 0;
			label2.Text = "Tên doanh nghiệp:";
			// 
			// label6
			// 
			label6.Anchor = AnchorStyles.Left;
			label6.AutoSize = true;
			label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label6.Location = new Point(148, 252);
			label6.Margin = new Padding(4, 0, 4, 0);
			label6.Name = "label6";
			label6.Size = new Size(123, 28);
			label6.TabIndex = 4;
			label6.Text = "Mã số thuế:";
			// 
			// label3
			// 
			label3.Anchor = AnchorStyles.Left;
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label3.Location = new Point(148, 299);
			label3.Margin = new Padding(4, 0, 4, 0);
			label3.Name = "label3";
			label3.Size = new Size(160, 28);
			label3.TabIndex = 1;
			label3.Text = "Người đại diện:";
			// 
			// label5
			// 
			label5.Anchor = AnchorStyles.Left;
			label5.AutoSize = true;
			label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label5.Location = new Point(148, 393);
			label5.Margin = new Padding(4, 0, 4, 0);
			label5.Name = "label5";
			label5.Size = new Size(69, 28);
			label5.TabIndex = 3;
			label5.Text = "Email:";
			// 
			// label4
			// 
			label4.Anchor = AnchorStyles.Left;
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label4.Location = new Point(148, 346);
			label4.Margin = new Padding(4, 0, 4, 0);
			label4.Name = "label4";
			label4.Size = new Size(83, 28);
			label4.TabIndex = 2;
			label4.Text = "Địa chỉ:";
			// 
			// btnChinhSua
			// 
			btnChinhSua.Location = new Point(342, 451);
			btnChinhSua.Margin = new Padding(4, 20, 4, 4);
			btnChinhSua.Name = "btnChinhSua";
			btnChinhSua.Size = new Size(118, 36);
			btnChinhSua.TabIndex = 9;
			btnChinhSua.Tag = "blue";
			btnChinhSua.Text = "Chỉnh sửa";
			btnChinhSua.UseVisualStyleBackColor = true;
			btnChinhSua.Click += btnChinhSua_Click;
			// 
			// btnLuu
			// 
			btnLuu.Location = new Point(148, 451);
			btnLuu.Margin = new Padding(4, 20, 4, 4);
			btnLuu.Name = "btnLuu";
			btnLuu.Size = new Size(118, 36);
			btnLuu.TabIndex = 11;
			btnLuu.Tag = "blue";
			btnLuu.Text = "Lưu";
			btnLuu.UseVisualStyleBackColor = true;
			btnLuu.Click += btnLuu_Click;
			// 
			// tableLayoutPanel2
			// 
			tableLayoutPanel2.ColumnCount = 4;
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.28571F));
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 71.42857F));
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
			tableLayoutPanel2.Controls.Add(txbDaiDien, 2, 4);
			tableLayoutPanel2.Controls.Add(label3, 1, 4);
			tableLayoutPanel2.Controls.Add(txbMST, 2, 3);
			tableLayoutPanel2.Controls.Add(label6, 1, 3);
			tableLayoutPanel2.Controls.Add(label1, 1, 1);
			tableLayoutPanel2.Controls.Add(label2, 1, 2);
			tableLayoutPanel2.Controls.Add(txbTenDN, 2, 2);
			tableLayoutPanel2.Controls.Add(label4, 1, 5);
			tableLayoutPanel2.Controls.Add(label5, 1, 6);
			tableLayoutPanel2.Controls.Add(txbDiaChi, 2, 5);
			tableLayoutPanel2.Controls.Add(txbEmail, 2, 6);
			tableLayoutPanel2.Controls.Add(btnLuu, 1, 7);
			tableLayoutPanel2.Controls.Add(btnChinhSua, 2, 7);
			tableLayoutPanel2.Dock = DockStyle.Fill;
			tableLayoutPanel2.Location = new Point(0, 0);
			tableLayoutPanel2.Name = "tableLayoutPanel2";
			tableLayoutPanel2.RowCount = 9;
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
			tableLayoutPanel2.RowStyles.Add(new RowStyle());
			tableLayoutPanel2.RowStyles.Add(new RowStyle());
			tableLayoutPanel2.RowStyles.Add(new RowStyle());
			tableLayoutPanel2.RowStyles.Add(new RowStyle());
			tableLayoutPanel2.RowStyles.Add(new RowStyle());
			tableLayoutPanel2.RowStyles.Add(new RowStyle());
			tableLayoutPanel2.RowStyles.Add(new RowStyle());
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
			tableLayoutPanel2.Size = new Size(1208, 610);
			tableLayoutPanel2.TabIndex = 2;
			// 
			// GUI_CapNhatThongTinDoanhNghiep
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(tableLayoutPanel2);
			Margin = new Padding(4);
			Name = "GUI_CapNhatThongTinDoanhNghiep";
			Size = new Size(1208, 610);
			tableLayoutPanel2.ResumeLayout(false);
			tableLayoutPanel2.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Label label1;
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
		private TableLayoutPanel tableLayoutPanel2;
	}
}
