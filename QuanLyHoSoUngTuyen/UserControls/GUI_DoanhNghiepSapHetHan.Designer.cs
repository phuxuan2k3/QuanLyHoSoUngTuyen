﻿namespace GUI.UserControls
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
            dsDNHetHan = new DataGridView();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            lbMaDoanhNghiep = new Label();
            label4 = new Label();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dsKetQuaUngTuyen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dsDNHetHan).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnGiaHan
            // 
            btnGiaHan.BackColor = SystemColors.MenuHighlight;
            btnGiaHan.ForeColor = Color.White;
            btnGiaHan.Location = new Point(385, 360);
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
            dsKetQuaUngTuyen.Location = new Point(385, 85);
            dsKetQuaUngTuyen.Name = "dsKetQuaUngTuyen";
            dsKetQuaUngTuyen.RowHeadersWidth = 51;
            dsKetQuaUngTuyen.Size = new Size(362, 267);
            dsKetQuaUngTuyen.TabIndex = 12;
            // 
            // dsDNHetHan
            // 
            dsDNHetHan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dsDNHetHan.Location = new Point(3, 85);
            dsDNHetHan.Name = "dsDNHetHan";
            dsDNHetHan.RowHeadersWidth = 51;
            dsDNHetHan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dsDNHetHan.Size = new Size(362, 267);
            dsDNHetHan.TabIndex = 7;
            dsDNHetHan.CellClick += dsDNHetHan_CellClick;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel1, 1, 0);
            tableLayoutPanel1.Controls.Add(btnGiaHan, 1, 3);
            tableLayoutPanel1.Controls.Add(dsKetQuaUngTuyen, 1, 2);
            tableLayoutPanel1.Controls.Add(dsDNHetHan, 0, 2);
            tableLayoutPanel1.Controls.Add(label1, 0, 1);
            tableLayoutPanel1.Controls.Add(label2, 1, 1);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.2788134F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.2788134F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 68.48259F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.9597826F));
            tableLayoutPanel1.Size = new Size(765, 403);
            tableLayoutPanel1.TabIndex = 14;
            // 
            // panel1
            // 
            panel1.Controls.Add(lbMaDoanhNghiep);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(385, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(277, 35);
            panel1.TabIndex = 15;
            // 
            // lbMaDoanhNghiep
            // 
            lbMaDoanhNghiep.AutoSize = true;
            lbMaDoanhNghiep.Font = new Font("Segoe UI", 7F, FontStyle.Italic);
            lbMaDoanhNghiep.Location = new Point(138, 8);
            lbMaDoanhNghiep.Name = "lbMaDoanhNghiep";
            lbMaDoanhNghiep.Size = new Size(0, 15);
            lbMaDoanhNghiep.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 7F, FontStyle.Italic);
            label4.Location = new Point(4, 9);
            label4.Name = "label4";
            label4.Size = new Size(129, 15);
            label4.TabIndex = 16;
            label4.Text = "Doanh nghiệp hiện tại:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 41);
            label1.Name = "label1";
            label1.Size = new Size(261, 20);
            label1.TabIndex = 16;
            label1.Text = "Doanh nghiệp sắp hết hạn đăng tuyển";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(385, 41);
            label2.Name = "label2";
            label2.Size = new Size(130, 20);
            label2.TabIndex = 17;
            label2.Text = "Kết quả ứng tuyển";
            // 
            // GUI_DoanhNghiepSapHetHan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "GUI_DoanhNghiepSapHetHan";
            Size = new Size(765, 403);
            Load += GUI_DoanhNghiepSapHetHan_Load;
            ((System.ComponentModel.ISupportInitialize)dsKetQuaUngTuyen).EndInit();
            ((System.ComponentModel.ISupportInitialize)dsDNHetHan).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnGiaHan;
        private DataGridView dsKetQuaUngTuyen;
        private DataGridView dsDNHetHan;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Label lbMaDoanhNghiep;
        private Label label4;
        private Label label1;
        private Label label2;
    }
}
