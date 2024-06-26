namespace QuanLyHoSoUngTuyen
{
    partial class GUI_DoanhNghiepHetHan
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tCtrGiaHanHopDong = new TabControl();
            tabPage1 = new TabPage();
            btnGiaHan = new Button();
            dsKetQuaUngTuyen = new DataGridView();
            lbTenDoanhNghiep = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dsDNHetHan = new DataGridView();
            tabPage2 = new TabPage();
            tCtrGiaHanHopDong.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dsKetQuaUngTuyen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dsDNHetHan).BeginInit();
            SuspendLayout();
            // 
            // tCtrGiaHanHopDong
            // 
            tCtrGiaHanHopDong.Controls.Add(tabPage1);
            tCtrGiaHanHopDong.Controls.Add(tabPage2);
            tCtrGiaHanHopDong.Location = new Point(1, 2);
            tCtrGiaHanHopDong.Name = "tCtrGiaHanHopDong";
            tCtrGiaHanHopDong.SelectedIndex = 0;
            tCtrGiaHanHopDong.Size = new Size(799, 448);
            tCtrGiaHanHopDong.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnGiaHan);
            tabPage1.Controls.Add(dsKetQuaUngTuyen);
            tabPage1.Controls.Add(lbTenDoanhNghiep);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(dsDNHetHan);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(791, 415);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Gia hạn hợp đồng";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnGiaHan
            // 
            btnGiaHan.BackColor = Color.DodgerBlue;
            btnGiaHan.ForeColor = Color.White;
            btnGiaHan.Location = new Point(679, 378);
            btnGiaHan.Name = "btnGiaHan";
            btnGiaHan.Size = new Size(94, 29);
            btnGiaHan.TabIndex = 6;
            btnGiaHan.Text = "Gia hạn";
            btnGiaHan.UseVisualStyleBackColor = false;
            // 
            // dsKetQuaUngTuyen
            // 
            dsKetQuaUngTuyen.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dsKetQuaUngTuyen.Location = new Point(411, 61);
            dsKetQuaUngTuyen.Name = "dsKetQuaUngTuyen";
            dsKetQuaUngTuyen.RowHeadersWidth = 51;
            dsKetQuaUngTuyen.Size = new Size(362, 298);
            dsKetQuaUngTuyen.TabIndex = 5;
            // 
            // lbTenDoanhNghiep
            // 
            lbTenDoanhNghiep.AutoSize = true;
            lbTenDoanhNghiep.Font = new Font("Segoe UI", 7F, FontStyle.Italic);
            lbTenDoanhNghiep.Location = new Point(546, 18);
            lbTenDoanhNghiep.Name = "lbTenDoanhNghiep";
            lbTenDoanhNghiep.Size = new Size(116, 15);
            lbTenDoanhNghiep.TabIndex = 4;
            lbTenDoanhNghiep.Text = "Current Manu Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 7F, FontStyle.Italic);
            label3.Location = new Point(411, 18);
            label3.Name = "label3";
            label3.Size = new Size(129, 15);
            label3.TabIndex = 3;
            label3.Text = "Doanh nghiệp hiện tại:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(411, 38);
            label2.Name = "label2";
            label2.Size = new Size(130, 20);
            label2.TabIndex = 2;
            label2.Text = "Kết quả ứng tuyển";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 38);
            label1.Name = "label1";
            label1.Size = new Size(261, 20);
            label1.TabIndex = 1;
            label1.Text = "Doanh nghiệp sắp hết hạn đăng tuyển";
            // 
            // dsDNHetHan
            // 
            dsDNHetHan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dsDNHetHan.Location = new Point(7, 61);
            dsDNHetHan.Name = "dsDNHetHan";
            dsDNHetHan.RowHeadersWidth = 51;
            dsDNHetHan.Size = new Size(362, 298);
            dsDNHetHan.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(791, 415);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Chiến lược ưu đãi";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // GUI_DoanhNghiepHetHan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tCtrGiaHanHopDong);
            Name = "GUI_DoanhNghiepHetHan";
            Text = "Form 1";
            tCtrGiaHanHopDong.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dsKetQuaUngTuyen).EndInit();
            ((System.ComponentModel.ISupportInitialize)dsDNHetHan).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tCtrGiaHanHopDong;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label2;
        private Label label1;
        private DataGridView dsDNHetHan;
        private Label label3;
        private Button btnGiaHan;
        private DataGridView dsKetQuaUngTuyen;
        private Label lbTenDoanhNghiep;
    }
}
