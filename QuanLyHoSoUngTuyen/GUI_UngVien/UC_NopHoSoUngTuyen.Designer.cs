namespace GUI.UC
{
    partial class UC_NopHoSoUngTuyen
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
            Btn_HoanTat = new Button();
            label3 = new Label();
            ckLbx_HSCTBC = new CheckedListBox();
            label2 = new Label();
            label1 = new Label();
            rTxt_yeucau = new Label();
            home_button = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)home_button).BeginInit();
            SuspendLayout();
            // 
            // Btn_HoanTat
            // 
            Btn_HoanTat.BackColor = Color.DodgerBlue;
            Btn_HoanTat.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            Btn_HoanTat.ForeColor = Color.Black;
            Btn_HoanTat.Location = new Point(829, 578);
            Btn_HoanTat.Name = "Btn_HoanTat";
            Btn_HoanTat.Size = new Size(112, 34);
            Btn_HoanTat.TabIndex = 12;
            Btn_HoanTat.Text = "Hoàn tất";
            Btn_HoanTat.UseVisualStyleBackColor = false;
            Btn_HoanTat.Click += Btn_HoanTat_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label3.Location = new Point(282, 99);
            label3.Name = "label3";
            label3.Size = new Size(419, 45);
            label3.TabIndex = 11;
            label3.Text = "Thông tin hồ sơ ứng tuyển";
            // 
            // ckLbx_HSCTBC
            // 
            ckLbx_HSCTBC.FormattingEnabled = true;
            ckLbx_HSCTBC.Location = new Point(207, 332);
            ckLbx_HSCTBC.Name = "ckLbx_HSCTBC";
            ckLbx_HSCTBC.Size = new Size(734, 228);
            ckLbx_HSCTBC.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 332);
            label2.Name = "label2";
            label2.Size = new Size(108, 25);
            label2.TabIndex = 9;
            label2.Text = "Chọn hồ sơ:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 199);
            label1.Name = "label1";
            label1.Size = new Size(75, 25);
            label1.TabIndex = 7;
            label1.Text = "Yêu cầu:";
            // 
            // rTxt_yeucau
            // 
            rTxt_yeucau.AutoSize = true;
            rTxt_yeucau.Location = new Point(207, 199);
            rTxt_yeucau.Name = "rTxt_yeucau";
            rTxt_yeucau.Size = new Size(59, 25);
            rTxt_yeucau.TabIndex = 13;
            rTxt_yeucau.Text = "label4";
            // 
            // home_button
            // 
            home_button.Image = Properties.Resources.home_button_removebg_preview;
            home_button.Location = new Point(29, 43);
            home_button.Name = "home_button";
            home_button.Size = new Size(43, 36);
            home_button.SizeMode = PictureBoxSizeMode.StretchImage;
            home_button.TabIndex = 14;
            home_button.TabStop = false;
            home_button.Click += home_button_Click;
            // 
            // UC_NopHoSoUngTuyen
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(home_button);
            Controls.Add(rTxt_yeucau);
            Controls.Add(Btn_HoanTat);
            Controls.Add(label3);
            Controls.Add(ckLbx_HSCTBC);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UC_NopHoSoUngTuyen";
            Size = new Size(1004, 630);
            ((System.ComponentModel.ISupportInitialize)home_button).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Btn_HoanTat;
        private Label label3;
        private CheckedListBox ckLbx_HSCTBC;
        private Label label2;
        private Label label1;
        private Label rTxt_yeucau;
        private PictureBox home_button;
    }
}
