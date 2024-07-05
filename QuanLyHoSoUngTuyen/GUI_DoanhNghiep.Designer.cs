namespace GUI
{
    partial class GUI_DoanhNghiep
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
            btnCapNhatTTDN = new Button();
            _contentPanel = new Panel();
            lbThongBao = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            _contentPanel.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnCapNhatTTDN
            // 
            btnCapNhatTTDN.Location = new Point(3, 3);
            btnCapNhatTTDN.Name = "btnCapNhatTTDN";
            btnCapNhatTTDN.Size = new Size(163, 36);
            btnCapNhatTTDN.TabIndex = 7;
            btnCapNhatTTDN.Text = "Cập nhật TT DN";
            btnCapNhatTTDN.UseVisualStyleBackColor = true;
            btnCapNhatTTDN.Click += btnCapNhatTTDN_Click;
            // 
            // _contentPanel
            // 
            _contentPanel.BackColor = SystemColors.ControlLight;
            _contentPanel.Controls.Add(lbThongBao);
            _contentPanel.Location = new Point(0, 41);
            _contentPanel.Margin = new Padding(2);
            _contentPanel.Name = "_contentPanel";
            _contentPanel.Size = new Size(931, 589);
            _contentPanel.TabIndex = 6;
            // 
            // lbThongBao
            // 
            lbThongBao.AutoSize = true;
            lbThongBao.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbThongBao.Location = new Point(147, 91);
            lbThongBao.Name = "lbThongBao";
            lbThongBao.Size = new Size(649, 92);
            lbThongBao.TabIndex = 9;
            lbThongBao.Text = "\r\nBạn cần cập nhật thông tin để xác thực.";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnCapNhatTTDN);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(931, 36);
            flowLayoutPanel1.TabIndex = 8;
            // 
            // GUI_DoanhNghiep
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(931, 589);
            Controls.Add(_contentPanel);
            Controls.Add(flowLayoutPanel1);
            Name = "GUI_DoanhNghiep";
            Text = "GUI_DoanhNghiep";
            Load += GUI_DoanhNghiep_Load;
            _contentPanel.ResumeLayout(false);
            _contentPanel.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnCapNhatTTDN;
        private Panel _contentPanel;
        private Label lbThongBao;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}