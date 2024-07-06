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
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
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
            flowLayoutPanel1.Controls.Add(button3);
            flowLayoutPanel1.Controls.Add(button4);
            flowLayoutPanel1.Controls.Add(button5);
            flowLayoutPanel1.Controls.Add(button6);
            flowLayoutPanel1.Controls.Add(button7);
            flowLayoutPanel1.Controls.Add(button8);
            flowLayoutPanel1.Location = new Point(0, -2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(800, 37);
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
            // button3
            // 
            button3.Location = new Point(401, 3);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 2;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(501, 3);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 3;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(601, 3);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 4;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(701, 3);
            button6.Name = "button6";
            button6.Size = new Size(94, 29);
            button6.TabIndex = 5;
            button6.Text = "button6";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(3, 38);
            button7.Name = "button7";
            button7.Size = new Size(94, 29);
            button7.TabIndex = 6;
            button7.Text = "button7";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(103, 38);
            button8.Name = "button8";
            button8.Size = new Size(94, 29);
            button8.TabIndex = 7;
            button8.Text = "button8";
            button8.UseVisualStyleBackColor = true;
            // 
            // GUI_NhanVienTiepNhan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1092, 553);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel1);
            Name = "GUI_NhanVienTiepNhan";
            Text = "GUI_NhanVienTiepNhan";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button btnXetDuyetTTDT;
        private Button btnXacThucDN;
    }
}