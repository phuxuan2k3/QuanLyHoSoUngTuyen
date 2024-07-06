namespace GUI.UC
{
    partial class GUI_DoanhNghiepSapHetHan
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
            btnGiaHan = new Button();
            dsKetQuaUngTuyen = new DataGridView();
            lbMaDoanhNghiep = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dsDNHetHan = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dsKetQuaUngTuyen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dsDNHetHan).BeginInit();
            SuspendLayout();
            // 
            // btnGiaHan
            // 
            btnGiaHan.BackColor = SystemColors.MenuHighlight;
            btnGiaHan.ForeColor = Color.White;
            btnGiaHan.Location = new Point(682, 367);
            btnGiaHan.Name = "btnGiaHan";
            btnGiaHan.Size = new Size(94, 29);
            btnGiaHan.TabIndex = 13;
            btnGiaHan.Text = "Gia hạn";
            btnGiaHan.UseVisualStyleBackColor = false;
            btnGiaHan.Click += btnGiaHan_Click;
            // 
            // dsKetQuaUngTuyen
            // 
            dsKetQuaUngTuyen.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dsKetQuaUngTuyen.Location = new Point(414, 50);
            dsKetQuaUngTuyen.Name = "dsKetQuaUngTuyen";
            dsKetQuaUngTuyen.RowHeadersWidth = 51;
            dsKetQuaUngTuyen.Size = new Size(362, 298);
            dsKetQuaUngTuyen.TabIndex = 12;
            // 
            // lbMaDoanhNghiep
            // 
            lbMaDoanhNghiep.AutoSize = true;
            lbMaDoanhNghiep.Font = new Font("Segoe UI", 7F, FontStyle.Italic);
            lbMaDoanhNghiep.Location = new Point(549, 7);
            lbMaDoanhNghiep.Name = "lbTenDoanhNghiep";
            lbMaDoanhNghiep.Size = new Size(116, 15);
            lbMaDoanhNghiep.TabIndex = 11;
            lbMaDoanhNghiep.Text = "Current Manu Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 7F, FontStyle.Italic);
            label3.Location = new Point(414, 7);
            label3.Name = "label3";
            label3.Size = new Size(129, 15);
            label3.TabIndex = 10;
            label3.Text = "Doanh nghiệp hiện tại:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(414, 27);
            label2.Name = "label2";
            label2.Size = new Size(130, 20);
            label2.TabIndex = 9;
            label2.Text = "Kết quả ứng tuyển";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 27);
            label1.Name = "label1";
            label1.Size = new Size(261, 20);
            label1.TabIndex = 8;
            label1.Text = "Doanh nghiệp sắp hết hạn đăng tuyển";
            // 
            // dsDNHetHan
            // 
            dsDNHetHan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dsDNHetHan.Location = new Point(10, 50);
            dsDNHetHan.Name = "dsDNHetHan";
            dsDNHetHan.RowHeadersWidth = 51;
            dsDNHetHan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dsDNHetHan.Size = new Size(362, 298);
            dsDNHetHan.TabIndex = 7;
            dsDNHetHan.CellClick += dsDNHetHan_CellClick;
            // 
            // GUI_DoanhNghiepSapHetHan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnGiaHan);
            Controls.Add(dsKetQuaUngTuyen);
            Controls.Add(lbMaDoanhNghiep);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dsDNHetHan);
            Name = "GUI_DoanhNghiepSapHetHan";
            Size = new Size(786, 403);
            ((System.ComponentModel.ISupportInitialize)dsKetQuaUngTuyen).EndInit();
            ((System.ComponentModel.ISupportInitialize)dsDNHetHan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGiaHan;
        private DataGridView dsKetQuaUngTuyen;
        private Label lbMaDoanhNghiep;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dsDNHetHan;
    }
}
