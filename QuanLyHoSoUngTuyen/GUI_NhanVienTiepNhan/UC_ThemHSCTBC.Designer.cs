namespace GUI.GUI_NhanVienTiepNhan
{
    partial class UC_ThemHSCTBC
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
            txt_HSCTBC = new TextBox();
            txt_HoTenUV = new TextBox();
            txt_CCCD = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btn_Them = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(125, 129);
            label1.Name = "label1";
            label1.Size = new Size(737, 45);
            label1.TabIndex = 0;
            label1.Text = "Thêm hồ sơ - bằng cấp - chứng từ cho Ứng viên";
            // 
            // panel1
            // 
            panel1.Controls.Add(txt_HSCTBC);
            panel1.Controls.Add(txt_HoTenUV);
            panel1.Controls.Add(txt_CCCD);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(157, 232);
            panel1.Name = "panel1";
            panel1.Size = new Size(639, 180);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // txt_HSCTBC
            // 
            txt_HSCTBC.Location = new Point(265, 121);
            txt_HSCTBC.Name = "txt_HSCTBC";
            txt_HSCTBC.Size = new Size(345, 31);
            txt_HSCTBC.TabIndex = 5;
            // 
            // txt_HoTenUV
            // 
            txt_HoTenUV.Location = new Point(265, 75);
            txt_HoTenUV.Name = "txt_HoTenUV";
            txt_HoTenUV.Size = new Size(345, 31);
            txt_HoTenUV.TabIndex = 4;
            // 
            // txt_CCCD
            // 
            txt_CCCD.Location = new Point(265, 28);
            txt_CCCD.Name = "txt_CCCD";
            txt_CCCD.Size = new Size(345, 31);
            txt_CCCD.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(58, 121);
            label4.Name = "label4";
            label4.Size = new Size(171, 25);
            label4.TabIndex = 2;
            label4.Text = "Chứng từ thêm vào:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(58, 75);
            label3.Name = "label3";
            label3.Size = new Size(169, 25);
            label3.TabIndex = 1;
            label3.Text = "Họ và tên Ứng viên:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 28);
            label2.Name = "label2";
            label2.Size = new Size(196, 25);
            label2.TabIndex = 0;
            label2.Text = "CCCC/CMND Ứng viên:";
            // 
            // btn_Them
            // 
            btn_Them.BackColor = Color.DodgerBlue;
            btn_Them.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_Them.Location = new Point(670, 461);
            btn_Them.Name = "btn_Them";
            btn_Them.Size = new Size(126, 44);
            btn_Them.TabIndex = 6;
            btn_Them.Text = "Thêm";
            btn_Them.UseVisualStyleBackColor = false;
            btn_Them.Click += btn_Them_Click;
            // 
            // UC_ThemHSCTBC
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btn_Them);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "UC_ThemHSCTBC";
            Size = new Size(1004, 630);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private TextBox txt_HSCTBC;
        private TextBox txt_HoTenUV;
        private TextBox txt_CCCD;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btn_Them;
    }
}
