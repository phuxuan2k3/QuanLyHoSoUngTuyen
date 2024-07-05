namespace GUI
{
    partial class GUI_DanhSachPhieuDK_DN
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
            btnHuy = new Button();
            dgv_dsTTDT = new DataGridView();
            lb_dsTTDT = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_dsTTDT).BeginInit();
            SuspendLayout();
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.Red;
            btnHuy.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnHuy.Location = new Point(664, 379);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(94, 29);
            btnHuy.TabIndex = 8;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = false;
            // 
            // dgv_dsTTDT
            // 
            dgv_dsTTDT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_dsTTDT.Location = new Point(41, 85);
            dgv_dsTTDT.Name = "dgv_dsTTDT";
            dgv_dsTTDT.RowHeadersWidth = 51;
            dgv_dsTTDT.Size = new Size(717, 269);
            dgv_dsTTDT.TabIndex = 7;
            // 
            // lb_dsTTDT
            // 
            lb_dsTTDT.AutoSize = true;
            lb_dsTTDT.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lb_dsTTDT.Location = new Point(41, 41);
            lb_dsTTDT.Name = "lb_dsTTDT";
            lb_dsTTDT.Size = new Size(274, 31);
            lb_dsTTDT.TabIndex = 6;
            lb_dsTTDT.Text = "Danh sách phiếu đăng ký";
            // 
            // button1
            // 
            button1.BackColor = Color.DodgerBlue;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            button1.Location = new Point(41, 379);
            button1.Name = "button1";
            button1.Size = new Size(205, 29);
            button1.TabIndex = 9;
            button1.Text = "Thông báo đến Ứng viên";
            button1.UseVisualStyleBackColor = false;
            // 
            // GUI_DanhSachPhieuDK_DN
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
            Controls.Add(btnHuy);
            Controls.Add(dgv_dsTTDT);
            Controls.Add(lb_dsTTDT);
            Name = "GUI_DanhSachPhieuDK_DN";
            Size = new Size(799, 448);
            ((System.ComponentModel.ISupportInitialize)dgv_dsTTDT).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnHuy;
        private DataGridView dgv_dsTTDT;
        private Label lb_dsTTDT;
        private Button button1;
    }
}
