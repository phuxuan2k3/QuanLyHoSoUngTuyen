namespace GUI
{
    partial class GUI_NhanVienTiepNhan
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
            panel1 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnXetDuyetTTDT = new Button();
            btnXacThucDN = new Button();
            btn_ThemHS = new Button();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Location = new Point(0, 35);
            panel1.Name = "panel1";
            panel1.Size = new Size(1092, 506);
            panel1.TabIndex = 4;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnXetDuyetTTDT);
            flowLayoutPanel1.Controls.Add(btnXacThucDN);
            flowLayoutPanel1.Controls.Add(btn_ThemHS);
            flowLayoutPanel1.Location = new Point(0, -2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1089, 37);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // btnXetDuyetTTDT
            // 
            btnXetDuyetTTDT.AutoSize = true;
            btnXetDuyetTTDT.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnXetDuyetTTDT.Location = new Point(2, 2);
            btnXetDuyetTTDT.Margin = new Padding(2);
            btnXetDuyetTTDT.Name = "btnXetDuyetTTDT";
            btnXetDuyetTTDT.Size = new Size(218, 30);
            btnXetDuyetTTDT.TabIndex = 5;
            btnXetDuyetTTDT.Text = "Xác thực thông tin đăng tuyển";
            btnXetDuyetTTDT.UseVisualStyleBackColor = true;
            btnXetDuyetTTDT.Click += btnXetDuyetTTDT_Click;
            // 
            // btnXacThucDN
            // 
            btnXacThucDN.AutoSize = true;
            btnXacThucDN.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnXacThucDN.Location = new Point(224, 2);
            btnXacThucDN.Margin = new Padding(2);
            btnXacThucDN.Name = "btnXacThucDN";
            btnXacThucDN.Size = new Size(172, 30);
            btnXacThucDN.TabIndex = 4;
            btnXacThucDN.Text = "Xác thực doanh nghiệp";
            btnXacThucDN.UseVisualStyleBackColor = true;
            btnXacThucDN.Click += btnXacThucDN_Click;
            // 
            // btn_ThemHS
            // 
            btn_ThemHS.Location = new Point(401, 3);
            btn_ThemHS.Name = "btn_ThemHS";
            btn_ThemHS.Size = new Size(333, 29);
            btn_ThemHS.TabIndex = 2;
            btn_ThemHS.Text = "Thêm Hồ sơ - Chứng từ - Bằng cấp Ứng viên ";
            btn_ThemHS.UseVisualStyleBackColor = true;
            btn_ThemHS.Click += btn_ThemHS_Click;
            // 
            // GUI_NhanVienTiepNhan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1092, 553);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel1);
            Name = "GUI_NhanVienTiepNhan";
            Text = "UCControl";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btn_ThemHS;
        private Button btnXetDuyetTTDT;
        private Button btnXacThucDN;
    }
}