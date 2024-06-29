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
            btnXoaUuDai = new Button();
            btnSuaUuDai = new Button();
            btnThemUuDai = new Button();
            txtMoTaUuDai = new TextBox();
            txtTenUuDai = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            dsChienLuocUuDai = new DataGridView();
            tCtrGiaHanHopDong.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dsKetQuaUngTuyen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dsDNHetHan).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dsChienLuocUuDai).BeginInit();
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
            btnGiaHan.BackColor = SystemColors.MenuHighlight;
            btnGiaHan.ForeColor = Color.White;
            btnGiaHan.Location = new Point(679, 378);
            btnGiaHan.Name = "btnGiaHan";
            btnGiaHan.Size = new Size(94, 29);
            btnGiaHan.TabIndex = 6;
            btnGiaHan.Text = "Gia hạn";
            btnGiaHan.UseVisualStyleBackColor = false;
            btnGiaHan.Click += btnGiaHan_Click;
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
            dsDNHetHan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dsDNHetHan.Size = new Size(362, 298);
            dsDNHetHan.TabIndex = 0;
            dsDNHetHan.CellClick += dsDNHetHan_CellClick;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnXoaUuDai);
            tabPage2.Controls.Add(btnSuaUuDai);
            tabPage2.Controls.Add(btnThemUuDai);
            tabPage2.Controls.Add(txtMoTaUuDai);
            tabPage2.Controls.Add(txtTenUuDai);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(dsChienLuocUuDai);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(791, 415);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Chiến lược ưu đãi";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnXoaUuDai
            // 
            btnXoaUuDai.BackColor = Color.Red;
            btnXoaUuDai.ForeColor = Color.White;
            btnXoaUuDai.Location = new Point(664, 303);
            btnXoaUuDai.Name = "btnXoaUuDai";
            btnXoaUuDai.Size = new Size(94, 29);
            btnXoaUuDai.TabIndex = 10;
            btnXoaUuDai.Text = "Xoá";
            btnXoaUuDai.UseVisualStyleBackColor = false;
            btnXoaUuDai.Click += btnXoaUuDai_Click;
            // 
            // btnSuaUuDai
            // 
            btnSuaUuDai.BackColor = SystemColors.MenuHighlight;
            btnSuaUuDai.ForeColor = Color.White;
            btnSuaUuDai.Location = new Point(564, 303);
            btnSuaUuDai.Name = "btnSuaUuDai";
            btnSuaUuDai.Size = new Size(94, 29);
            btnSuaUuDai.TabIndex = 9;
            btnSuaUuDai.Text = "Chỉnh sửa";
            btnSuaUuDai.UseVisualStyleBackColor = false;
            btnSuaUuDai.Click += btnSuaUuDai_Click;
            // 
            // btnThemUuDai
            // 
            btnThemUuDai.BackColor = Color.Green;
            btnThemUuDai.ForeColor = Color.White;
            btnThemUuDai.Location = new Point(462, 303);
            btnThemUuDai.Name = "btnThemUuDai";
            btnThemUuDai.Size = new Size(94, 29);
            btnThemUuDai.TabIndex = 8;
            btnThemUuDai.Text = "Thêm";
            btnThemUuDai.UseVisualStyleBackColor = false;
            btnThemUuDai.Click += btnThemUuDai_Click;
            // 
            // txtMoTaUuDai
            // 
            txtMoTaUuDai.Location = new Point(462, 158);
            txtMoTaUuDai.Multiline = true;
            txtMoTaUuDai.Name = "txtMoTaUuDai";
            txtMoTaUuDai.Size = new Size(297, 124);
            txtMoTaUuDai.TabIndex = 7;
            // 
            // txtTenUuDai
            // 
            txtTenUuDai.Location = new Point(462, 117);
            txtTenUuDai.Name = "txtTenUuDai";
            txtTenUuDai.Size = new Size(297, 27);
            txtTenUuDai.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(390, 158);
            label6.Name = "label6";
            label6.Size = new Size(51, 20);
            label6.TabIndex = 5;
            label6.Text = "Mô tả:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(406, 117);
            label5.Name = "label5";
            label5.Size = new Size(35, 20);
            label5.TabIndex = 4;
            label5.Text = "Tên:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 43);
            label4.Name = "label4";
            label4.Size = new Size(195, 20);
            label4.TabIndex = 3;
            label4.Text = "Danh sách chiến lược ưu đãi";
            // 
            // dsChienLuocUuDai
            // 
            dsChienLuocUuDai.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dsChienLuocUuDai.Location = new Point(7, 66);
            dsChienLuocUuDai.Name = "dsChienLuocUuDai";
            dsChienLuocUuDai.RowHeadersWidth = 51;
            dsChienLuocUuDai.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dsChienLuocUuDai.Size = new Size(362, 298);
            dsChienLuocUuDai.TabIndex = 2;
            dsChienLuocUuDai.CellClick += dsChienLuocUuDai_CellClick;
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
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dsChienLuocUuDai).EndInit();
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
        private Label label4;
        private DataGridView dsChienLuocUuDai;
        private Label label5;
        private Button btnSuaUuDai;
        private Button btnThemUuDai;
        private TextBox txtMoTaUuDai;
        private TextBox txtTenUuDai;
        private Label label6;
        private Button btnXoaUuDai;
    }
}
