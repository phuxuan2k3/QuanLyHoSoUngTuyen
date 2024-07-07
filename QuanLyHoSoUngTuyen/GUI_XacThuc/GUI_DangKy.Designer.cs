namespace GUI.GUI_XacThuc
{
    partial class GUI_DangKy
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
            rdbUngVien = new RadioButton();
            rdbDoanhNghiep = new RadioButton();
            pnDangKyContent = new Panel();
            pnTaiKhoanContent = new Panel();
            panel3 = new Panel();
            btnQuayLai = new Button();
            btnDangky = new Button();
            pnTaiKhoanContent.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 10);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 0;
            label1.Text = "Bạn là?";
            // 
            // rdbUngVien
            // 
            rdbUngVien.AutoSize = true;
            rdbUngVien.Location = new Point(168, 34);
            rdbUngVien.Name = "rdbUngVien";
            rdbUngVien.Size = new Size(89, 24);
            rdbUngVien.TabIndex = 1;
            rdbUngVien.TabStop = true;
            rdbUngVien.Text = "Ứng viên";
            rdbUngVien.UseVisualStyleBackColor = true;
            rdbUngVien.CheckedChanged += rdbUngVien_CheckedChanged;
            // 
            // rdbDoanhNghiep
            // 
            rdbDoanhNghiep.AutoSize = true;
            rdbDoanhNghiep.Location = new Point(475, 34);
            rdbDoanhNghiep.Name = "rdbDoanhNghiep";
            rdbDoanhNghiep.Size = new Size(124, 24);
            rdbDoanhNghiep.TabIndex = 2;
            rdbDoanhNghiep.TabStop = true;
            rdbDoanhNghiep.Text = "Doanh nghiệp";
            rdbDoanhNghiep.UseVisualStyleBackColor = true;
            rdbDoanhNghiep.CheckedChanged += rdbDoanhNghiep_CheckedChanged;
            // 
            // pnDangKyContent
            // 
            pnDangKyContent.Location = new Point(59, 64);
            pnDangKyContent.Name = "pnDangKyContent";
            pnDangKyContent.Size = new Size(654, 225);
            pnDangKyContent.TabIndex = 3;
            // 
            // pnTaiKhoanContent
            // 
            pnTaiKhoanContent.Controls.Add(panel3);
            pnTaiKhoanContent.Location = new Point(59, 295);
            pnTaiKhoanContent.Name = "pnTaiKhoanContent";
            pnTaiKhoanContent.Size = new Size(654, 157);
            pnTaiKhoanContent.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.Location = new Point(0, 188);
            panel3.Name = "panel3";
            panel3.Size = new Size(775, 192);
            panel3.TabIndex = 4;
            // 
            // btnQuayLai
            // 
            btnQuayLai.Location = new Point(14, 402);
            btnQuayLai.Name = "btnQuayLai";
            btnQuayLai.Size = new Size(94, 29);
            btnQuayLai.TabIndex = 7;
            btnQuayLai.Text = "Quay lại";
            btnQuayLai.UseVisualStyleBackColor = true;
            btnQuayLai.Click += btnQuayLai_Click;
            // 
            // btnDangky
            // 
            btnDangky.Location = new Point(636, 405);
            btnDangky.Name = "btnDangky";
            btnDangky.Size = new Size(94, 29);
            btnDangky.TabIndex = 6;
            btnDangky.Text = "Đăng ký";
            btnDangky.UseVisualStyleBackColor = true;
            btnDangky.Visible = false;
            btnDangky.Click += btnDangky_Click;
            // 
            // GUI_DangKy
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnQuayLai);
            Controls.Add(btnDangky);
            Controls.Add(pnTaiKhoanContent);
            Controls.Add(pnDangKyContent);
            Controls.Add(rdbDoanhNghiep);
            Controls.Add(rdbUngVien);
            Controls.Add(label1);
            Name = "GUI_DangKy";
            Size = new Size(775, 455);
            pnTaiKhoanContent.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RadioButton rdbUngVien;
        private RadioButton rdbDoanhNghiep;
        private Panel pnDangKyContent;
        private Panel pnTaiKhoanContent;
        private Panel panel3;
        private Button btnDangky;
        private Button btnQuayLai;
    }
}
