namespace GUI
{
    partial class GUI_XemThongTinDoanhNghiep
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
            dsDN = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            radChuaXacThuc = new RadioButton();
            radKhongHopLe = new RadioButton();
            radHopLe = new RadioButton();
            radTiemNang = new RadioButton();
            dsUD = new DataGridView();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dsDN).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dsUD).BeginInit();
            SuspendLayout();
            // 
            // dsDN
            // 
            dsDN.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dsDN.Location = new Point(13, 44);
            dsDN.Name = "dsDN";
            dsDN.RowHeadersWidth = 51;
            dsDN.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dsDN.Size = new Size(596, 353);
            dsDN.TabIndex = 0;
            dsDN.CellClick += dsDN_CellClick;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(147, -1);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(279, 31);
            label1.TabIndex = 1;
            label1.Text = "Danh sách doanh nghiệp";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(628, 0);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(81, 31);
            label2.TabIndex = 2;
            label2.Text = "Bộ lọc";
            // 
            // radChuaXacThuc
            // 
            radChuaXacThuc.AutoSize = true;
            radChuaXacThuc.Location = new Point(739, 44);
            radChuaXacThuc.Name = "radChuaXacThuc";
            radChuaXacThuc.Size = new Size(123, 24);
            radChuaXacThuc.TabIndex = 3;
            radChuaXacThuc.TabStop = true;
            radChuaXacThuc.Text = "Chưa xác thực";
            radChuaXacThuc.UseVisualStyleBackColor = true;
            radChuaXacThuc.CheckedChanged += radChuaXacThuc_CheckedChanged;
            // 
            // radKhongHopLe
            // 
            radKhongHopLe.AutoSize = true;
            radKhongHopLe.Location = new Point(739, 74);
            radKhongHopLe.Name = "radKhongHopLe";
            radKhongHopLe.Size = new Size(119, 24);
            radKhongHopLe.TabIndex = 4;
            radKhongHopLe.TabStop = true;
            radKhongHopLe.Text = "Không hợp lệ";
            radKhongHopLe.UseVisualStyleBackColor = true;
            radKhongHopLe.CheckedChanged += radKhongHopLe_CheckedChanged;
            // 
            // radHopLe
            // 
            radHopLe.AutoSize = true;
            radHopLe.Location = new Point(739, 104);
            radHopLe.Name = "radHopLe";
            radHopLe.Size = new Size(75, 24);
            radHopLe.TabIndex = 5;
            radHopLe.TabStop = true;
            radHopLe.Text = "Hợp lệ";
            radHopLe.UseVisualStyleBackColor = true;
            radHopLe.CheckedChanged += radHopLe_CheckedChanged;
            // 
            // radTiemNang
            // 
            radTiemNang.AutoSize = true;
            radTiemNang.Location = new Point(739, 134);
            radTiemNang.Name = "radTiemNang";
            radTiemNang.Size = new Size(100, 24);
            radTiemNang.TabIndex = 6;
            radTiemNang.TabStop = true;
            radTiemNang.Text = "Tiềm năng";
            radTiemNang.UseVisualStyleBackColor = true;
            radTiemNang.CheckedChanged += radTiemNang_CheckedChanged;
            // 
            // dsUD
            // 
            dsUD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dsUD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dsUD.Location = new Point(628, 213);
            dsUD.Name = "dsUD";
            dsUD.RowHeadersWidth = 51;
            dsUD.Size = new Size(452, 184);
            dsUD.TabIndex = 7;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(628, 169);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(316, 31);
            label3.TabIndex = 8;
            label3.Text = "Danh sách chiến lược ưu đãi";
            // 
            // GUI_XemThongTinDoanhNghiep
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label3);
            Controls.Add(dsUD);
            Controls.Add(radTiemNang);
            Controls.Add(radHopLe);
            Controls.Add(radKhongHopLe);
            Controls.Add(radChuaXacThuc);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dsDN);
            Name = "GUI_XemThongTinDoanhNghiep";
            Size = new Size(1094, 412);
            ((System.ComponentModel.ISupportInitialize)dsDN).EndInit();
            ((System.ComponentModel.ISupportInitialize)dsUD).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dsDN;
        private Label label1;
        private Label label2;
        private RadioButton radChuaXacThuc;
        private RadioButton radKhongHopLe;
        private RadioButton radHopLe;
        private RadioButton radTiemNang;
        private DataGridView dsUD;
        private Label label3;
    }
}
