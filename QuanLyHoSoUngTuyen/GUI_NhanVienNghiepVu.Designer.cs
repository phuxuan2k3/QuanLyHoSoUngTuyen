namespace GUI
{
    partial class GUI_NhanVienNghiepVu
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
            btnDoanhNghiep = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnDangTuyenTTDT = new Button();
            btnDuyetPhieuDangKy = new Button();
            panel1 = new Panel();
            _container = new Panel();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnDoanhNghiep
            // 
            btnDoanhNghiep.Location = new Point(3, 3);
            btnDoanhNghiep.Name = "btnDoanhNghiep";
            btnDoanhNghiep.Size = new Size(125, 29);
            btnDoanhNghiep.TabIndex = 0;
            btnDoanhNghiep.Text = "Doanh nghiệp";
            btnDoanhNghiep.UseVisualStyleBackColor = true;
            btnDoanhNghiep.Click += button1_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnDoanhNghiep);
            flowLayoutPanel1.Controls.Add(btnDangTuyenTTDT);
            flowLayoutPanel1.Controls.Add(btnDuyetPhieuDangKy);
            flowLayoutPanel1.Location = new Point(0, -5);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(800, 37);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // btnDangTuyenTTDT
            // 
            btnDangTuyenTTDT.AutoSize = true;
            btnDangTuyenTTDT.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnDangTuyenTTDT.Location = new Point(133, 2);
            btnDangTuyenTTDT.Margin = new Padding(2);
            btnDangTuyenTTDT.Name = "btnDangTuyenTTDT";
            btnDangTuyenTTDT.Size = new Size(95, 30);
            btnDangTuyenTTDT.TabIndex = 5;
            btnDangTuyenTTDT.Text = "Đăng tuyển";
            btnDangTuyenTTDT.UseVisualStyleBackColor = true;
            btnDangTuyenTTDT.Click += btnDangTuyenTTDT_Click;
            // 
            // btnDuyetPhieuDangKy
            // 
            btnDuyetPhieuDangKy.Location = new Point(233, 3);
            btnDuyetPhieuDangKy.Name = "btnDuyetPhieuDangKy";
            btnDuyetPhieuDangKy.Size = new Size(110, 29);
            btnDuyetPhieuDangKy.TabIndex = 5;
            btnDuyetPhieuDangKy.Text = "Duyệt hồ sơ";
            btnDuyetPhieuDangKy.UseVisualStyleBackColor = true;
            btnDuyetPhieuDangKy.Click += btnDuyetPhieuDangKy_Click;
            // 
            // panel1
            // 
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 100);
            panel1.TabIndex = 0;
            // 
            // _container
            // 
            _container.Location = new Point(0, 38);
            _container.Name = "_container";
            _container.Size = new Size(800, 412);
            _container.TabIndex = 2;
            // 
            // GUI_NhanVienNghiepVu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(_container);
            Controls.Add(flowLayoutPanel1);
            Name = "GUI_NhanVienNghiepVu";
            Text = "GUI_NhanVienNghiepVu";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnDoanhNghiep;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnDuyetPhieuDangKy;
        private Panel _container;
        private Panel panel1;
        private Button btnDangTuyenTTDT;
    }
}