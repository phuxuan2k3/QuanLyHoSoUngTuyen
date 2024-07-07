namespace GUI
{
    partial class GUI_DuyetPhieuDangKy_DN
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
            pageSetupDialog1 = new PageSetupDialog();
            lb1 = new Label();
            button1 = new Button();
            cbxTinhTrang = new ComboBox();
            lbTinhTrang = new Label();
            panel2 = new Panel();
            _viTri = new TextBox();
            _MaUV = new TextBox();
            _bangCap = new TextBox();
            lbVtriUV = new Label();
            lb_BangCap = new Label();
            lbMaPhieuDK = new Label();
            btnHuy = new Button();
            lbTTDT = new Label();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // lb1
            // 
            lb1.AutoSize = true;
            lb1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lb1.Location = new Point(41, 41);
            lb1.Name = "lb1";
            lb1.Size = new Size(267, 31);
            lb1.TabIndex = 5;
            lb1.Text = "Thông tin phiếu đăng ký";
            lb1.Click += lb1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Lime;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            button1.Location = new Point(503, 393);
            button1.Name = "button1";
            button1.Size = new Size(119, 29);
            button1.TabIndex = 25;
            button1.Text = "Hoàn tất";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // cbxTinhTrang
            // 
            cbxTinhTrang.DropDownWidth = 135;
            cbxTinhTrang.FormattingEnabled = true;
            cbxTinhTrang.Items.AddRange(new object[] { "Đạt", "Không Đạt" });
            cbxTinhTrang.Location = new Point(523, 79);
            cbxTinhTrang.Name = "cbxTinhTrang";
            cbxTinhTrang.Size = new Size(217, 28);
            cbxTinhTrang.TabIndex = 23;
            // 
            // lbTinhTrang
            // 
            lbTinhTrang.AutoSize = true;
            lbTinhTrang.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lbTinhTrang.Location = new Point(421, 82);
            lbTinhTrang.Name = "lbTinhTrang";
            lbTinhTrang.Size = new Size(96, 25);
            lbTinhTrang.TabIndex = 21;
            lbTinhTrang.Text = "Tình trạng:";
            lbTinhTrang.Click += lbTinhTrang_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(_viTri);
            panel2.Controls.Add(_MaUV);
            panel2.Controls.Add(_bangCap);
            panel2.Controls.Add(lbVtriUV);
            panel2.Controls.Add(lb_BangCap);
            panel2.Controls.Add(lbMaPhieuDK);
            panel2.Location = new Point(41, 126);
            panel2.Name = "panel2";
            panel2.Size = new Size(699, 133);
            panel2.TabIndex = 18;
            // 
            // _viTri
            // 
            _viTri.Location = new Point(462, 22);
            _viTri.Name = "_viTri";
            _viTri.ReadOnly = true;
            _viTri.Size = new Size(200, 27);
            _viTri.TabIndex = 12;
            // 
            // _MaUV
            // 
            _MaUV.Location = new Point(187, 22);
            _MaUV.Name = "_MaUV";
            _MaUV.ReadOnly = true;
            _MaUV.Size = new Size(127, 27);
            _MaUV.TabIndex = 10;
            // 
            // _bangCap
            // 
            _bangCap.Location = new Point(118, 69);
            _bangCap.Multiline = true;
            _bangCap.Name = "_bangCap";
            _bangCap.ReadOnly = true;
            _bangCap.Size = new Size(544, 56);
            _bangCap.TabIndex = 10;
            // 
            // lbVtriUV
            // 
            lbVtriUV.AutoSize = true;
            lbVtriUV.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lbVtriUV.Location = new Point(380, 24);
            lbVtriUV.Name = "lbVtriUV";
            lbVtriUV.Size = new Size(52, 25);
            lbVtriUV.TabIndex = 10;
            lbVtriUV.Text = "Vị trí:";
            // 
            // lb_BangCap
            // 
            lb_BangCap.AutoSize = true;
            lb_BangCap.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lb_BangCap.Location = new Point(23, 69);
            lb_BangCap.Name = "lb_BangCap";
            lb_BangCap.Size = new Size(89, 25);
            lb_BangCap.TabIndex = 11;
            lb_BangCap.Text = "Bằng cấp:";
            // 
            // lbMaPhieuDK
            // 
            lbMaPhieuDK.AutoSize = true;
            lbMaPhieuDK.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lbMaPhieuDK.Location = new Point(23, 24);
            lbMaPhieuDK.Name = "lbMaPhieuDK";
            lbMaPhieuDK.Size = new Size(117, 25);
            lbMaPhieuDK.TabIndex = 10;
            lbMaPhieuDK.Text = "Mã Ứng viên:";
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.Red;
            btnHuy.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnHuy.Location = new Point(646, 393);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(94, 29);
            btnHuy.TabIndex = 19;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            // 
            // lbTTDT
            // 
            lbTTDT.AutoSize = true;
            lbTTDT.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lbTTDT.Location = new Point(608, 41);
            lbTTDT.Name = "lbTTDT";
            lbTTDT.Size = new Size(0, 31);
            lbTTDT.TabIndex = 26;
            // 
            // GUI_DuyetPhieuDangKy_DN
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lbTTDT);
            Controls.Add(button1);
            Controls.Add(cbxTinhTrang);
            Controls.Add(lbTinhTrang);
            Controls.Add(panel2);
            Controls.Add(btnHuy);
            Controls.Add(lb1);
            Name = "GUI_DuyetPhieuDangKy_DN";
            Size = new Size(799, 448);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PageSetupDialog pageSetupDialog1;
        private Label lb1;
        private Button button1;
        private ComboBox cbxTinhTrang;
        private Label lbTinhTrang;
        private Panel panel2;
        private TextBox _viTri;
        private TextBox _MaUV;
        private TextBox _bangCap;
        private Label lbVtriUV;
        private Label lb_BangCap;
        private Label lbMaPhieuDK;
        private Button btnHuy;
        private Label lbTTDT;
    }
}
