namespace GUI.UserControls
{
    partial class GUI_XacNhanGiaHanHopDongUC
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
            label2 = new Label();
            label1 = new Label();
            btnKhongGiaHan = new Button();
            btnLuuLai = new Button();
            btnLoaiBo = new Button();
            btnApDung = new Button();
            dsChienLuocUuDaiHienTai = new DataGridView();
            dsChienLuocUuDai = new DataGridView();
            lbMaDoanhNghiep = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dsChienLuocUuDaiHienTai).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dsChienLuocUuDai).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(453, 38);
            label2.Name = "label2";
            label2.Size = new Size(204, 20);
            label2.TabIndex = 17;
            label2.Text = "Các chiến lược ưu đãi hiện tại";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 38);
            label1.Name = "label1";
            label1.Size = new Size(195, 20);
            label1.TabIndex = 16;
            label1.Text = "Danh sách chiến lược ưu đãi";
            // 
            // btnKhongGiaHan
            // 
            btnKhongGiaHan.BackColor = Color.Red;
            btnKhongGiaHan.ForeColor = Color.White;
            btnKhongGiaHan.Location = new Point(491, 399);
            btnKhongGiaHan.Name = "btnKhongGiaHan";
            btnKhongGiaHan.Size = new Size(123, 29);
            btnKhongGiaHan.TabIndex = 15;
            btnKhongGiaHan.Text = "Không gia hạn";
            btnKhongGiaHan.UseVisualStyleBackColor = false;
            btnKhongGiaHan.Click += btnKhongGiaHan_Click;
            // 
            // btnLuuLai
            // 
            btnLuuLai.BackColor = SystemColors.MenuHighlight;
            btnLuuLai.ForeColor = Color.White;
            btnLuuLai.Location = new Point(651, 399);
            btnLuuLai.Name = "btnLuuLai";
            btnLuuLai.Size = new Size(94, 29);
            btnLuuLai.TabIndex = 14;
            btnLuuLai.Text = "Lưu lại";
            btnLuuLai.UseVisualStyleBackColor = false;
            btnLuuLai.Click += btnLuuLai_Click;
            // 
            // btnLoaiBo
            // 
            btnLoaiBo.BackColor = Color.Red;
            btnLoaiBo.ForeColor = Color.White;
            btnLoaiBo.Location = new Point(344, 217);
            btnLoaiBo.Name = "btnLoaiBo";
            btnLoaiBo.Size = new Size(94, 29);
            btnLoaiBo.TabIndex = 13;
            btnLoaiBo.Text = "Loại bỏ";
            btnLoaiBo.UseVisualStyleBackColor = false;
            btnLoaiBo.Click += btnLoaiBo_Click;
            // 
            // btnApDung
            // 
            btnApDung.BackColor = SystemColors.MenuHighlight;
            btnApDung.ForeColor = Color.White;
            btnApDung.Location = new Point(344, 161);
            btnApDung.Name = "btnApDung";
            btnApDung.Size = new Size(94, 29);
            btnApDung.TabIndex = 12;
            btnApDung.Text = "Áp dụng ->";
            btnApDung.UseVisualStyleBackColor = false;
            btnApDung.Click += btnApDung_Click;
            // 
            // dsChienLuocUuDaiHienTai
            // 
            dsChienLuocUuDaiHienTai.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dsChienLuocUuDaiHienTai.Location = new Point(453, 61);
            dsChienLuocUuDaiHienTai.Name = "dsChienLuocUuDaiHienTai";
            dsChienLuocUuDaiHienTai.RowHeadersWidth = 51;
            dsChienLuocUuDaiHienTai.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dsChienLuocUuDaiHienTai.Size = new Size(326, 328);
            dsChienLuocUuDaiHienTai.TabIndex = 11;
            // 
            // dsChienLuocUuDai
            // 
            dsChienLuocUuDai.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dsChienLuocUuDai.Location = new Point(3, 61);
            dsChienLuocUuDai.Name = "dsChienLuocUuDai";
            dsChienLuocUuDai.RowHeadersWidth = 51;
            dsChienLuocUuDai.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dsChienLuocUuDai.Size = new Size(326, 328);
            dsChienLuocUuDai.TabIndex = 10;
            // 
            // lbMaDoanhNghiep
            // 
            lbMaDoanhNghiep.AutoSize = true;
            lbMaDoanhNghiep.Font = new Font("Segoe UI", 7F, FontStyle.Italic);
            lbMaDoanhNghiep.Location = new Point(591, 19);
            lbMaDoanhNghiep.Name = "lbMaDoanhNghiep";
            lbMaDoanhNghiep.Size = new Size(116, 15);
            lbMaDoanhNghiep.TabIndex = 19;
            lbMaDoanhNghiep.Text = "Current Manu Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 7F, FontStyle.Italic);
            label3.Location = new Point(456, 19);
            label3.Name = "label3";
            label3.Size = new Size(129, 15);
            label3.TabIndex = 18;
            label3.Text = "Doanh nghiệp hiện tại:";
            // 
            // GUI_XacNhanGiaHanHopDongUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lbMaDoanhNghiep);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnKhongGiaHan);
            Controls.Add(btnLuuLai);
            Controls.Add(btnLoaiBo);
            Controls.Add(btnApDung);
            Controls.Add(dsChienLuocUuDaiHienTai);
            Controls.Add(dsChienLuocUuDai);
            Name = "GUI_XacNhanGiaHanHopDongUC";
            Size = new Size(791, 438);
            ((System.ComponentModel.ISupportInitialize)dsChienLuocUuDaiHienTai).EndInit();
            ((System.ComponentModel.ISupportInitialize)dsChienLuocUuDai).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Button btnKhongGiaHan;
        private Button btnLuuLai;
        private Button btnLoaiBo;
        private Button btnApDung;
        private DataGridView dsChienLuocUuDaiHienTai;
        private DataGridView dsChienLuocUuDai;
        private Label lbMaDoanhNghiep;
        private Label label3;
    }
}
