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
            button6 = new Button();
            btnDuyetPhieuDangKy = new Button();
            button8 = new Button();
            _contentPanel = new Panel();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Controls.Add(button2);
            flowLayoutPanel1.Controls.Add(button3);
            flowLayoutPanel1.Controls.Add(button4);
            flowLayoutPanel1.Controls.Add(button5);
            flowLayoutPanel1.Controls.Add(button6);
            flowLayoutPanel1.Controls.Add(btnDuyetPhieuDangKy);
            flowLayoutPanel1.Controls.Add(button8);
            flowLayoutPanel1.Location = new Point(0, -5);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(800, 37);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // button2
            // 
            button2.Location = new Point(103, 3);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(203, 3);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 2;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(303, 3);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 3;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(403, 3);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 4;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(503, 3);
            button6.Name = "button6";
            button6.Size = new Size(94, 29);
            button6.TabIndex = 5;
            button6.Text = "button6";
            button6.UseVisualStyleBackColor = true;
            // 
            // btnDuyetPhieuDangKy
            // 
            btnDuyetPhieuDangKy.Location = new Point(603, 3);
            btnDuyetPhieuDangKy.Name = "btnDuyetPhieuDangKy";
            btnDuyetPhieuDangKy.Size = new Size(94, 29);
            btnDuyetPhieuDangKy.TabIndex = 6;
            btnDuyetPhieuDangKy.Text = "Duyệt phiếu";
            btnDuyetPhieuDangKy.UseVisualStyleBackColor = true;
            btnDuyetPhieuDangKy.Click += btnDuyetPhieuDangKy_Click;
            // 
            // button8
            // 
            button8.Location = new Point(703, 3);
            button8.Name = "button8";
            button8.Size = new Size(94, 29);
            button8.TabIndex = 7;
            button8.Text = "button8";
            button8.UseVisualStyleBackColor = true;
            // 
            // _contentPanel
            // 
            _contentPanel.Location = new Point(0, 38);
            _contentPanel.Name = "_contentPanel";
            _contentPanel.Size = new Size(800, 412);
            _contentPanel.TabIndex = 2;
            // 
            // GUI_NhanVienNghiepVu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(_contentPanel);
            Controls.Add(flowLayoutPanel1);
            Name = "GUI_NhanVienNghiepVu";
            Text = "GUI_NhanVienNghiepVu";
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button btnDuyetPhieuDangKy;
        private Button button8;
        public Panel _contentPanel;
    }
}