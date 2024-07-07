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
            button1 = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            btnDuyetPhieuDangKy = new Button();
            btnDuyet_DoanhNghiep = new Button();
            button8 = new Button();
            panel1 = new Panel();
            btnDangTuyenTTDT = new Button();
            _container = new Panel();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(102, 3);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnDangTuyenTTDT);
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Controls.Add(button2);
            flowLayoutPanel1.Controls.Add(button3);
            flowLayoutPanel1.Controls.Add(button4);
            flowLayoutPanel1.Controls.Add(button5);
            flowLayoutPanel1.Controls.Add(btnDuyetPhieuDangKy);
            flowLayoutPanel1.Controls.Add(btnDuyet_DoanhNghiep);
            flowLayoutPanel1.Controls.Add(button8);
            flowLayoutPanel1.Location = new Point(0, -5);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(800, 37);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // button2
            // 
            button2.Location = new Point(202, 3);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(302, 3);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 2;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(402, 3);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 3;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(502, 3);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 4;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // btnDuyetPhieuDangKy
            // 
            btnDuyetPhieuDangKy.Location = new Point(503, 3);
            btnDuyetPhieuDangKy.Name = "btnDuyetPhieuDangKy";
            btnDuyetPhieuDangKy.Size = new Size(94, 29);
            btnDuyetPhieuDangKy.TabIndex = 5;
            btnDuyetPhieuDangKy.Text = "Duyệt hồ sơ";
            btnDuyetPhieuDangKy.UseVisualStyleBackColor = true;
            btnDuyetPhieuDangKy.Click += btnDuyetPhieuDangKy_Click;
            // 
            // btnDuyet_DoanhNghiep
            // 
            btnDuyet_DoanhNghiep.Location = new Point(603, 3);
            btnDuyet_DoanhNghiep.Name = "btnDuyet_DoanhNghiep";
            btnDuyet_DoanhNghiep.Size = new Size(124, 29);
            btnDuyet_DoanhNghiep.TabIndex = 6;
            btnDuyet_DoanhNghiep.Text = "Duyệt của DN";
            btnDuyet_DoanhNghiep.UseVisualStyleBackColor = true;
            btnDuyet_DoanhNghiep.Click += btnDuyet_DoanhNghiep_Click;
            // 
            // button8
            // 
            button8.Location = new Point(3, 38);
            button8.Name = "button8";
            button8.Size = new Size(94, 29);
            button8.TabIndex = 7;
            button8.Text = "button8";
            button8.UseVisualStyleBackColor = true;
            // 
            // _container
            // 
            _container.Location = new Point(0, 38);
            _container.Name = "_container";
            _container.Size = new Size(800, 412);
            _container.TabIndex = 2;
            // 
            // btnDangTuyenTTDT
            // 
            btnDangTuyenTTDT.AutoSize = true;
            btnDangTuyenTTDT.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnDangTuyenTTDT.Location = new Point(2, 2);
            btnDangTuyenTTDT.Margin = new Padding(2);
            btnDangTuyenTTDT.Name = "btnDangTuyenTTDT";
            btnDangTuyenTTDT.Size = new Size(95, 30);
            btnDangTuyenTTDT.TabIndex = 5;
            btnDangTuyenTTDT.Text = "Đăng tuyển";
            btnDangTuyenTTDT.UseVisualStyleBackColor = true;
            btnDangTuyenTTDT.Click += btnDangTuyenTTDT_Click;
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

        private Button button1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button btnDuyetPhieuDangKy;
        private Button btnDuyet_DoanhNghiep;
        private Button button8;
        private Panel _container;
        private Panel panel1;
        private Button btnDangTuyenTTDT;
    }
}