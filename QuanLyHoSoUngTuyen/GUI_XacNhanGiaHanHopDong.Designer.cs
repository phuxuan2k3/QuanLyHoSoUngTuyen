namespace GUI
{
    partial class GUI_XacNhanGiaHanHopDong
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
            dsChienLuocUuDai = new DataGridView();
            dsChienLuocUuDaiHienTai = new DataGridView();
            btnApDung = new Button();
            btnLoaiBo = new Button();
            btnLuuLai = new Button();
            btnKhongGiaHan = new Button();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dsChienLuocUuDai).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dsChienLuocUuDaiHienTai).BeginInit();
            SuspendLayout();
            // 
            // dsChienLuocUuDai
            // 
            dsChienLuocUuDai.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dsChienLuocUuDai.Location = new Point(12, 71);
            dsChienLuocUuDai.Name = "dsChienLuocUuDai";
            dsChienLuocUuDai.RowHeadersWidth = 51;
            dsChienLuocUuDai.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dsChienLuocUuDai.Size = new Size(326, 328);
            dsChienLuocUuDai.TabIndex = 0;
            // 
            // dsChienLuocUuDaiHienTai
            // 
            dsChienLuocUuDaiHienTai.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dsChienLuocUuDaiHienTai.Location = new Point(462, 71);
            dsChienLuocUuDaiHienTai.Name = "dsChienLuocUuDaiHienTai";
            dsChienLuocUuDaiHienTai.RowHeadersWidth = 51;
            dsChienLuocUuDaiHienTai.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dsChienLuocUuDaiHienTai.Size = new Size(326, 328);
            dsChienLuocUuDaiHienTai.TabIndex = 1;
            // 
            // btnApDung
            // 
            btnApDung.BackColor = SystemColors.MenuHighlight;
            btnApDung.ForeColor = Color.White;
            btnApDung.Location = new Point(353, 171);
            btnApDung.Name = "btnApDung";
            btnApDung.Size = new Size(94, 29);
            btnApDung.TabIndex = 2;
            btnApDung.Text = "Áp dụng ->";
            btnApDung.UseVisualStyleBackColor = false;
            btnApDung.Click += btnApDung_Click;
            // 
            // btnLoaiBo
            // 
            btnLoaiBo.BackColor = Color.Red;
            btnLoaiBo.ForeColor = Color.White;
            btnLoaiBo.Location = new Point(353, 227);
            btnLoaiBo.Name = "btnLoaiBo";
            btnLoaiBo.Size = new Size(94, 29);
            btnLoaiBo.TabIndex = 3;
            btnLoaiBo.Text = "Loại bỏ";
            btnLoaiBo.UseVisualStyleBackColor = false;
            btnLoaiBo.Click += btnLoaiBo_Click;
            // 
            // btnLuuLai
            // 
            btnLuuLai.BackColor = SystemColors.MenuHighlight;
            btnLuuLai.ForeColor = Color.White;
            btnLuuLai.Location = new Point(660, 409);
            btnLuuLai.Name = "btnLuuLai";
            btnLuuLai.Size = new Size(94, 29);
            btnLuuLai.TabIndex = 4;
            btnLuuLai.Text = "Lưu lại";
            btnLuuLai.UseVisualStyleBackColor = false;
            btnLuuLai.Click += btnLuuLai_Click;
            // 
            // btnKhongGiaHan
            // 
            btnKhongGiaHan.BackColor = Color.Red;
            btnKhongGiaHan.ForeColor = Color.White;
            btnKhongGiaHan.Location = new Point(500, 409);
            btnKhongGiaHan.Name = "btnKhongGiaHan";
            btnKhongGiaHan.Size = new Size(123, 29);
            btnKhongGiaHan.TabIndex = 5;
            btnKhongGiaHan.Text = "Không gia hạn";
            btnKhongGiaHan.UseVisualStyleBackColor = false;
            btnKhongGiaHan.Click += btnKhongGiaHan_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(462, 48);
            label2.Name = "label2";
            label2.Size = new Size(204, 20);
            label2.TabIndex = 9;
            label2.Text = "Các chiến lược ưu đãi hiện tại";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 48);
            label1.Name = "label1";
            label1.Size = new Size(195, 20);
            label1.TabIndex = 8;
            label1.Text = "Danh sách chiến lược ưu đãi";
            // 
            // GUI_XacNhanGiaHanHopDong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnKhongGiaHan);
            Controls.Add(btnLuuLai);
            Controls.Add(btnLoaiBo);
            Controls.Add(btnApDung);
            Controls.Add(dsChienLuocUuDaiHienTai);
            Controls.Add(dsChienLuocUuDai);
            Name = "GUI_XacNhanGiaHanHopDong";
            Text = "Áp dụng chiến lược ưu đãi";
            ((System.ComponentModel.ISupportInitialize)dsChienLuocUuDai).EndInit();
            ((System.ComponentModel.ISupportInitialize)dsChienLuocUuDaiHienTai).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dsChienLuocUuDai;
        private DataGridView dsChienLuocUuDaiHienTai;
        private Button btnApDung;
        private Button btnLoaiBo;
        private Button btnLuuLai;
        private Button btnKhongGiaHan;
        private Label label2;
        private Label label1;
    }
}