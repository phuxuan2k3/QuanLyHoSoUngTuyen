namespace GUI.UC
{
    partial class UC_DienPhieuDangKyUngTuyen
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
            panel1 = new Panel();
            Txt_ViTriUngTuyen = new Label();
            Txt_MaViTriUngTuyen = new Label();
            Txt_CCCD = new TextBox();
            Txt_HoVaTenUngVien = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            Btn_DienPhieu = new Button();
            home_button = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)home_button).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(209, 88);
            label1.Name = "label1";
            label1.Size = new Size(550, 45);
            label1.TabIndex = 9;
            label1.Text = "Thông tin phiếu đăng ký ứng tuyển";
            // 
            // panel1
            // 
            panel1.Controls.Add(Txt_ViTriUngTuyen);
            panel1.Controls.Add(Txt_MaViTriUngTuyen);
            panel1.Controls.Add(Txt_CCCD);
            panel1.Controls.Add(Txt_HoVaTenUngVien);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(148, 217);
            panel1.Name = "panel1";
            panel1.Size = new Size(709, 273);
            panel1.TabIndex = 8;
            // 
            // Txt_ViTriUngTuyen
            // 
            Txt_ViTriUngTuyen.AutoSize = true;
            Txt_ViTriUngTuyen.Location = new Point(273, 92);
            Txt_ViTriUngTuyen.Name = "Txt_ViTriUngTuyen";
            Txt_ViTriUngTuyen.Size = new Size(59, 25);
            Txt_ViTriUngTuyen.TabIndex = 9;
            Txt_ViTriUngTuyen.Text = "label6";
            // 
            // Txt_MaViTriUngTuyen
            // 
            Txt_MaViTriUngTuyen.AutoSize = true;
            Txt_MaViTriUngTuyen.Location = new Point(273, 41);
            Txt_MaViTriUngTuyen.Name = "Txt_MaViTriUngTuyen";
            Txt_MaViTriUngTuyen.Size = new Size(59, 25);
            Txt_MaViTriUngTuyen.TabIndex = 8;
            Txt_MaViTriUngTuyen.Text = "label6";
            // 
            // Txt_CCCD
            // 
            Txt_CCCD.Location = new Point(273, 202);
            Txt_CCCD.Name = "Txt_CCCD";
            Txt_CCCD.Size = new Size(363, 31);
            Txt_CCCD.TabIndex = 7;
            // 
            // Txt_HoVaTenUngVien
            // 
            Txt_HoVaTenUngVien.Location = new Point(273, 147);
            Txt_HoVaTenUngVien.Name = "Txt_HoVaTenUngVien";
            Txt_HoVaTenUngVien.Size = new Size(363, 31);
            Txt_HoVaTenUngVien.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(44, 202);
            label5.Name = "label5";
            label5.Size = new Size(122, 25);
            label5.TabIndex = 3;
            label5.Text = "CCCD/CMND:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 147);
            label4.Name = "label4";
            label4.Size = new Size(167, 25);
            label4.TabIndex = 2;
            label4.Text = "Họ và tên ứng viên:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 92);
            label3.Name = "label3";
            label3.Size = new Size(154, 25);
            label3.TabIndex = 1;
            label3.Text = "Vị ứng ứng tuyển:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 41);
            label2.Name = "label2";
            label2.Size = new Size(166, 25);
            label2.TabIndex = 0;
            label2.Text = "Mã vị trí ứng tuyển:";
            // 
            // Btn_DienPhieu
            // 
            Btn_DienPhieu.BackColor = Color.DodgerBlue;
            Btn_DienPhieu.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            Btn_DienPhieu.ForeColor = Color.Black;
            Btn_DienPhieu.Location = new Point(745, 542);
            Btn_DienPhieu.Name = "Btn_DienPhieu";
            Btn_DienPhieu.Size = new Size(112, 34);
            Btn_DienPhieu.TabIndex = 10;
            Btn_DienPhieu.Text = "Tiếp theo";
            Btn_DienPhieu.UseVisualStyleBackColor = false;
            Btn_DienPhieu.Click += Btn_DienPhieu_Click;
            // 
            // home_button
            // 
            home_button.Image = Properties.Resources.home_button_removebg_preview;
            home_button.Location = new Point(29, 43);
            home_button.Name = "home_button";
            home_button.Size = new Size(43, 36);
            home_button.SizeMode = PictureBoxSizeMode.StretchImage;
            home_button.TabIndex = 11;
            home_button.TabStop = false;
            home_button.Click += home_button_Click;
            // 
            // UC_DienPhieuDangKyUngTuyen
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(home_button);
            Controls.Add(Btn_DienPhieu);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "UC_DienPhieuDangKyUngTuyen";
            Size = new Size(1004, 630);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)home_button).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private TextBox Txt_CCCD;
        private TextBox Txt_HoVaTenUngVien;
        
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button Btn_DienPhieu;
        private Label Txt_MaViTriUngTuyen;
        private Label Txt_ViTriUngTuyen;
        private PictureBox home_button;
    }
}
