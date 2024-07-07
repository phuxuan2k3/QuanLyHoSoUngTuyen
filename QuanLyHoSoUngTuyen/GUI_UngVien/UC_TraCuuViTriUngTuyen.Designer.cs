namespace GUI.UC
{
    partial class UC_TraCuuViTriUngTuyen
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
            Txt_TimKiem = new TextBox();
            Btn_TimKiem = new Button();
            panel1 = new Panel();
            dsCacViTriTimDuoc = new DataGridView();
            label2 = new Label();
            Btn_DienPhieu = new Button();
            groupBox1 = new GroupBox();
            txt_CongTy = new TextBox();
            rTxt_YeuCau = new RichTextBox();
            txt_SoLuongTuyen = new TextBox();
            txt_ViTriUngTuyen = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dsCacViTriTimDuoc).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // Txt_TimKiem
            // 
            Txt_TimKiem.Location = new Point(580, 101);
            Txt_TimKiem.Name = "Txt_TimKiem";
            Txt_TimKiem.Size = new Size(226, 31);
            Txt_TimKiem.TabIndex = 0;
            // 
            // Btn_TimKiem
            // 
            Btn_TimKiem.Location = new Point(836, 98);
            Btn_TimKiem.Name = "Btn_TimKiem";
            Btn_TimKiem.Size = new Size(112, 34);
            Btn_TimKiem.TabIndex = 1;
            Btn_TimKiem.Text = "Tìm kiếm";
            Btn_TimKiem.UseVisualStyleBackColor = true;
            Btn_TimKiem.Click += Btn_TimKiem_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(dsCacViTriTimDuoc);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(12, 150);
            panel1.Name = "panel1";
            panel1.Size = new Size(974, 226);
            panel1.TabIndex = 2;
            // 
            // dsCacViTriTimDuoc
            // 
            dsCacViTriTimDuoc.BackgroundColor = Color.FromArgb(224, 224, 224);
            dsCacViTriTimDuoc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dsCacViTriTimDuoc.Location = new Point(12, 46);
            dsCacViTriTimDuoc.Name = "dsCacViTriTimDuoc";
            dsCacViTriTimDuoc.RowHeadersWidth = 62;
            dsCacViTriTimDuoc.Size = new Size(949, 174);
            dsCacViTriTimDuoc.TabIndex = 7;
            dsCacViTriTimDuoc.CellClick += dsCacViTriTimDuoc_CellClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label2.Location = new Point(12, 13);
            label2.Name = "label2";
            label2.Size = new Size(288, 30);
            label2.TabIndex = 6;
            label2.Text = "Danh sách các vị trí tìm được";
            // 
            // Btn_DienPhieu
            // 
            Btn_DienPhieu.BackColor = Color.DodgerBlue;
            Btn_DienPhieu.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            Btn_DienPhieu.ForeColor = Color.Black;
            Btn_DienPhieu.Location = new Point(836, 576);
            Btn_DienPhieu.Name = "Btn_DienPhieu";
            Btn_DienPhieu.Size = new Size(137, 34);
            Btn_DienPhieu.TabIndex = 6;
            Btn_DienPhieu.Text = "Điền phiếu";
            Btn_DienPhieu.UseVisualStyleBackColor = false;
            Btn_DienPhieu.Click += Btn_DienPhieu_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txt_CongTy);
            groupBox1.Controls.Add(rTxt_YeuCau);
            groupBox1.Controls.Add(txt_SoLuongTuyen);
            groupBox1.Controls.Add(txt_ViTriUngTuyen);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(12, 382);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(974, 188);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin chi tiết vị trí đã chọn";
            // 
            // txt_CongTy
            // 
            txt_CongTy.Location = new Point(174, 89);
            txt_CongTy.Name = "txt_CongTy";
            txt_CongTy.Size = new Size(253, 31);
            txt_CongTy.TabIndex = 8;
            // 
            // rTxt_YeuCau
            // 
            rTxt_YeuCau.Location = new Point(683, 86);
            rTxt_YeuCau.Name = "rTxt_YeuCau";
            rTxt_YeuCau.Size = new Size(253, 82);
            rTxt_YeuCau.TabIndex = 7;
            rTxt_YeuCau.Text = "";
            // 
            // txt_SoLuongTuyen
            // 
            txt_SoLuongTuyen.Location = new Point(684, 42);
            txt_SoLuongTuyen.Name = "txt_SoLuongTuyen";
            txt_SoLuongTuyen.Size = new Size(252, 31);
            txt_SoLuongTuyen.TabIndex = 5;
            // 
            // txt_ViTriUngTuyen
            // 
            txt_ViTriUngTuyen.Location = new Point(174, 42);
            txt_ViTriUngTuyen.Name = "txt_ViTriUngTuyen";
            txt_ViTriUngTuyen.Size = new Size(253, 31);
            txt_ViTriUngTuyen.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(540, 89);
            label6.Name = "label6";
            label6.Size = new Size(75, 25);
            label6.TabIndex = 3;
            label6.Text = "Yêu cầu:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(540, 45);
            label5.Name = "label5";
            label5.Size = new Size(138, 25);
            label5.TabIndex = 2;
            label5.Text = "Số lượng tuyển:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 89);
            label4.Name = "label4";
            label4.Size = new Size(79, 25);
            label4.TabIndex = 1;
            label4.Text = "Công ty:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 45);
            label3.Name = "label3";
            label3.Size = new Size(138, 25);
            label3.TabIndex = 0;
            label3.Text = "Vị trí ứng tuyển:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(319, 23);
            label1.Name = "label1";
            label1.Size = new Size(371, 45);
            label1.TabIndex = 8;
            label1.Text = "Tra cứu vị trí ứng tuyển";
            // 
            // UC_TraCuuViTriUngTuyen
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(label1);
            Controls.Add(Btn_DienPhieu);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Controls.Add(Btn_TimKiem);
            Controls.Add(Txt_TimKiem);
            Name = "UC_TraCuuViTriUngTuyen";
            Size = new Size(1004, 630);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dsCacViTriTimDuoc).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Txt_TimKiem;
        private Button Btn_TimKiem;
        private Panel panel1;
        private DataGridView dsCacViTriTimDuoc;
        private Label label2;
        private Button Btn_DienPhieu;
        private GroupBox groupBox1;
        private TextBox txt_CongTy;
        private RichTextBox rTxt_YeuCau;
        private TextBox txt_SoLuongTuyen;
        private TextBox txt_ViTriUngTuyen;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
    }
}
