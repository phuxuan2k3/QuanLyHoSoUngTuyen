namespace GUI.UC
{
    partial class GUI_DuyetPhDK_DuyetPhieuDangKy
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
            button1 = new Button();
            cbxTinhTrang = new ComboBox();
            lbUuTien = new Label();
            lbTinhTrang = new Label();
            btnHuy = new Button();
            lb1 = new Label();
            pageSetupDialog1 = new PageSetupDialog();
            panel1 = new Panel();
            _SoLuong = new TextBox();
            _TiTri = new TextBox();
            _YeuCau = new TextBox();
            _MoTa = new TextBox();
            _MaTTDT = new TextBox();
            lb_YeuCau = new Label();
            lb_MoTa = new Label();
            lb_SoLuong = new Label();
            lb_VTri = new Label();
            lb_MaTTDT = new Label();
            _uuTien = new TextBox();
            _ViTri = new TextBox();
            _maPhDK = new TextBox();
            lb2 = new Label();
            lbVtriUV = new Label();
            lb_BangCap = new Label();
            lbMaPhieuDK = new Label();
            panel2 = new Panel();
            _bangCap = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.DodgerBlue;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            button1.Location = new Point(503, 379);
            button1.Name = "button1";
            button1.Size = new Size(119, 29);
            button1.TabIndex = 27;
            button1.Text = "Lưu thay đổi";
            button1.UseVisualStyleBackColor = false;
            // 
            // cbxTinhTrang
            // 
            cbxTinhTrang.DropDownWidth = 135;
            cbxTinhTrang.FormattingEnabled = true;
            cbxTinhTrang.Location = new Point(386, 194);
            cbxTinhTrang.Name = "cbxTinhTrang";
            cbxTinhTrang.Size = new Size(177, 28);
            cbxTinhTrang.TabIndex = 25;
            // 
            // lbUuTien
            // 
            lbUuTien.AutoSize = true;
            lbUuTien.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lbUuTien.Location = new Point(569, 196);
            lbUuTien.Name = "lbUuTien";
            lbUuTien.Size = new Size(73, 25);
            lbUuTien.TabIndex = 24;
            lbUuTien.Text = "Ưu tiên:";
            // 
            // lbTinhTrang
            // 
            lbTinhTrang.AutoSize = true;
            lbTinhTrang.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lbTinhTrang.Location = new Point(284, 194);
            lbTinhTrang.Name = "lbTinhTrang";
            lbTinhTrang.Size = new Size(96, 25);
            lbTinhTrang.TabIndex = 23;
            lbTinhTrang.Text = "Tình trạng:";
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.Red;
            btnHuy.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnHuy.Location = new Point(664, 379);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(94, 29);
            btnHuy.TabIndex = 21;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = false;
            // 
            // lb1
            // 
            lb1.AutoSize = true;
            lb1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lb1.Location = new Point(41, 41);
            lb1.Name = "lb1";
            lb1.Size = new Size(237, 31);
            lb1.TabIndex = 18;
            lb1.Text = "Thông tin đăng tuyển";
            // 
            // panel1
            // 
            panel1.Controls.Add(_SoLuong);
            panel1.Controls.Add(_TiTri);
            panel1.Controls.Add(_YeuCau);
            panel1.Controls.Add(_MoTa);
            panel1.Controls.Add(_MaTTDT);
            panel1.Controls.Add(lb_YeuCau);
            panel1.Controls.Add(lb_MoTa);
            panel1.Controls.Add(lb_SoLuong);
            panel1.Controls.Add(lb_VTri);
            panel1.Controls.Add(lb_MaTTDT);
            panel1.Location = new Point(41, 75);
            panel1.Name = "panel1";
            panel1.Size = new Size(699, 113);
            panel1.TabIndex = 19;
            // 
            // _SoLuong
            // 
            _SoLuong.Location = new Point(623, 9);
            _SoLuong.Name = "_SoLuong";
            _SoLuong.ReadOnly = true;
            _SoLuong.Size = new Size(53, 27);
            _SoLuong.TabIndex = 9;
            // 
            // _TiTri
            // 
            _TiTri.Location = new Point(401, 11);
            _TiTri.Name = "_TiTri";
            _TiTri.ReadOnly = true;
            _TiTri.Size = new Size(121, 27);
            _TiTri.TabIndex = 8;
            // 
            // _YeuCau
            // 
            _YeuCau.Location = new Point(401, 48);
            _YeuCau.Multiline = true;
            _YeuCau.Name = "_YeuCau";
            _YeuCau.ReadOnly = true;
            _YeuCau.Size = new Size(275, 55);
            _YeuCau.TabIndex = 7;
            // 
            // _MoTa
            // 
            _MoTa.Location = new Point(114, 47);
            _MoTa.Multiline = true;
            _MoTa.Name = "_MoTa";
            _MoTa.ReadOnly = true;
            _MoTa.Size = new Size(200, 56);
            _MoTa.TabIndex = 6;
            // 
            // _MaTTDT
            // 
            _MaTTDT.Location = new Point(114, 12);
            _MaTTDT.Name = "_MaTTDT";
            _MaTTDT.ReadOnly = true;
            _MaTTDT.Size = new Size(200, 27);
            _MaTTDT.TabIndex = 5;
            // 
            // lb_YeuCau
            // 
            lb_YeuCau.AutoSize = true;
            lb_YeuCau.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lb_YeuCau.Location = new Point(320, 47);
            lb_YeuCau.Name = "lb_YeuCau";
            lb_YeuCau.Size = new Size(75, 25);
            lb_YeuCau.TabIndex = 4;
            lb_YeuCau.Text = "Yêu cầu:";
            // 
            // lb_MoTa
            // 
            lb_MoTa.AutoSize = true;
            lb_MoTa.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lb_MoTa.Location = new Point(23, 47);
            lb_MoTa.Name = "lb_MoTa";
            lb_MoTa.Size = new Size(63, 25);
            lb_MoTa.TabIndex = 3;
            lb_MoTa.Text = "Mô tả:";
            // 
            // lb_SoLuong
            // 
            lb_SoLuong.AutoSize = true;
            lb_SoLuong.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lb_SoLuong.Location = new Point(528, 11);
            lb_SoLuong.Name = "lb_SoLuong";
            lb_SoLuong.Size = new Size(89, 25);
            lb_SoLuong.TabIndex = 2;
            lb_SoLuong.Text = "Số lượng:";
            // 
            // lb_VTri
            // 
            lb_VTri.AutoSize = true;
            lb_VTri.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lb_VTri.Location = new Point(320, 11);
            lb_VTri.Name = "lb_VTri";
            lb_VTri.Size = new Size(52, 25);
            lb_VTri.TabIndex = 1;
            lb_VTri.Text = "Vị trí:";
            // 
            // lb_MaTTDT
            // 
            lb_MaTTDT.AutoSize = true;
            lb_MaTTDT.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lb_MaTTDT.Location = new Point(23, 11);
            lb_MaTTDT.Name = "lb_MaTTDT";
            lb_MaTTDT.Size = new Size(85, 25);
            lb_MaTTDT.TabIndex = 0;
            lb_MaTTDT.Text = "Mã TTDT:";
            // 
            // _uuTien
            // 
            _uuTien.Location = new Point(648, 194);
            _uuTien.Name = "_uuTien";
            _uuTien.Size = new Size(69, 27);
            _uuTien.TabIndex = 26;
            // 
            // _ViTri
            // 
            _ViTri.Location = new Point(462, 22);
            _ViTri.Name = "_ViTri";
            _ViTri.ReadOnly = true;
            _ViTri.Size = new Size(200, 27);
            _ViTri.TabIndex = 12;
            // 
            // _maPhDK
            // 
            _maPhDK.Location = new Point(187, 22);
            _maPhDK.Name = "_maPhDK";
            _maPhDK.ReadOnly = true;
            _maPhDK.Size = new Size(127, 27);
            _maPhDK.TabIndex = 10;
            // 
            // lb2
            // 
            lb2.AutoSize = true;
            lb2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lb2.Location = new Point(44, 191);
            lb2.Name = "lb2";
            lb2.Size = new Size(203, 23);
            lb2.TabIndex = 22;
            lb2.Text = "Danh sách phiếu đăng ký";
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
            lbMaPhieuDK.Size = new Size(158, 25);
            lbMaPhieuDK.TabIndex = 10;
            lbMaPhieuDK.Text = "Mã Phiếu đăng ký:";
            // 
            // panel2
            // 
            panel2.Controls.Add(_ViTri);
            panel2.Controls.Add(_maPhDK);
            panel2.Controls.Add(_bangCap);
            panel2.Controls.Add(lbVtriUV);
            panel2.Controls.Add(lb_BangCap);
            panel2.Controls.Add(lbMaPhieuDK);
            panel2.Location = new Point(41, 235);
            panel2.Name = "panel2";
            panel2.Size = new Size(699, 133);
            panel2.TabIndex = 20;
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
            // GUI_DuyetPhDK_DuyetPhieuDangKy
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
            Controls.Add(cbxTinhTrang);
            Controls.Add(lbUuTien);
            Controls.Add(lbTinhTrang);
            Controls.Add(btnHuy);
            Controls.Add(lb1);
            Controls.Add(panel1);
            Controls.Add(_uuTien);
            Controls.Add(lb2);
            Controls.Add(panel2);
            Name = "GUI_DuyetPhDK_DuyetPhieuDangKy";
            Size = new Size(799, 448);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ComboBox cbxTinhTrang;
        private Label lbUuTien;
        private Label lbTinhTrang;
        private Button btnHuy;
        private Label lb1;
        private PageSetupDialog pageSetupDialog1;
        private Panel panel1;
        private TextBox _SoLuong;
        private TextBox _TiTri;
        private TextBox _YeuCau;
        private TextBox _MoTa;
        private TextBox _MaTTDT;
        private Label lb_YeuCau;
        private Label lb_MoTa;
        private Label lb_SoLuong;
        private Label lb_VTri;
        private Label lb_MaTTDT;
        private TextBox _uuTien;
        private TextBox _ViTri;
        private TextBox _maPhDK;
        private Label lb2;
        private Label lbVtriUV;
        private Label lb_BangCap;
        private Label lbMaPhieuDK;
        private Panel panel2;
        private TextBox _bangCap;
    }
}
