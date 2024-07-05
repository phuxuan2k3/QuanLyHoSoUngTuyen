namespace GUI.UC
{
    partial class GUI_XemDanhSachDoanhNghiep
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
            dsDNHetHan = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dsDNHetHan).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 48);
            label1.Name = "label1";
            label1.Size = new Size(261, 20);
            label1.TabIndex = 10;
            label1.Text = "Doanh nghiệp sắp hết hạn đăng tuyển";
            // 
            // dsDNHetHan
            // 
            dsDNHetHan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dsDNHetHan.Location = new Point(3, 71);
            dsDNHetHan.Name = "dsDNHetHan";
            dsDNHetHan.RowHeadersWidth = 51;
            dsDNHetHan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dsDNHetHan.Size = new Size(362, 298);
            dsDNHetHan.TabIndex = 9;
            // 
            // GUI_XemDanhSachDoanhNghiep
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(dsDNHetHan);
            Name = "GUI_XemDanhSachDoanhNghiep";
            Size = new Size(784, 506);
            ((System.ComponentModel.ISupportInitialize)dsDNHetHan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dsDNHetHan;
    }
}
