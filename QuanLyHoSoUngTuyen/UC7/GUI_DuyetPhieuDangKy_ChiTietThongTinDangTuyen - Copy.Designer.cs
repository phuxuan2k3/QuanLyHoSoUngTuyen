namespace GUI
{
    partial class GUI_DuyetPhieuDangKy_ChiTietThongTinDangTuyen
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
            lb2 = new Label();
            _SoLuong = new TextBox();
            _ViTri = new TextBox();
            dsPhieuDangKy = new DataGridView();
            _maUV = new DataGridViewTextBoxColumn();
            _trangThai = new DataGridViewTextBoxColumn();
            btnHuy = new Button();
            panel2 = new Panel();
            _YeuCau = new TextBox();
            _MoTa = new TextBox();
            _MaTTDT = new TextBox();
            lb_SoLuong = new Label();
            lb_VTri = new Label();
            lb_MaTTDT = new Label();
            panel1 = new Panel();
            lb_YeuCau = new Label();
            lb_MoTa = new Label();
            lb1 = new Label();
            pageSetupDialog1 = new PageSetupDialog();
            _uuTien = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dsPhieuDangKy).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lb2
            // 
            lb2.AutoSize = true;
            lb2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lb2.Location = new Point(45, 173);
            lb2.Name = "lb2";
            lb2.Size = new Size(203, 23);
            lb2.TabIndex = 9;
            lb2.Text = "Danh sách phiếu đăng ký";
            // 
            // _SoLuong
            // 
            _SoLuong.Location = new Point(623, 9);
            _SoLuong.Name = "_SoLuong";
            _SoLuong.ReadOnly = true;
            _SoLuong.Size = new Size(53, 27);
            _SoLuong.TabIndex = 9;
            // 
            // _ViTri
            // 
            _ViTri.Location = new Point(401, 11);
            _ViTri.Name = "_ViTri";
            _ViTri.ReadOnly = true;
            _ViTri.Size = new Size(121, 27);
            _ViTri.TabIndex = 8;
            // 
            // dsPhieuDangKy
            // 
            dsPhieuDangKy.AllowUserToAddRows = false;
            dsPhieuDangKy.AllowUserToDeleteRows = false;
            dsPhieuDangKy.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dsPhieuDangKy.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dsPhieuDangKy.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dsPhieuDangKy.Columns.AddRange(new DataGridViewColumn[] { _maUV, _trangThai, _uuTien });
            dsPhieuDangKy.Location = new Point(3, 3);
            dsPhieuDangKy.Name = "dsPhieuDangKy";
            dsPhieuDangKy.ReadOnly = true;
            dsPhieuDangKy.RowHeadersWidth = 51;
            dsPhieuDangKy.Size = new Size(693, 130);
            dsPhieuDangKy.TabIndex = 0;
            dsPhieuDangKy.CellContentClick += dsPhieuDangKy_CellContentClick;
            // 
            // _maUV
            // 
            _maUV.HeaderText = "Ma UV";
            _maUV.MinimumWidth = 6;
            _maUV.Name = "_maUV";
            _maUV.ReadOnly = true;
            // 
            // _trangThai
            // 
            _trangThai.HeaderText = "Trạng thái";
            _trangThai.MinimumWidth = 6;
            _trangThai.Name = "_trangThai";
            _trangThai.ReadOnly = true;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.Red;
            btnHuy.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnHuy.Location = new Point(665, 361);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(94, 29);
            btnHuy.TabIndex = 8;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(dsPhieuDangKy);
            panel2.Location = new Point(42, 217);
            panel2.Name = "panel2";
            panel2.Size = new Size(699, 133);
            panel2.TabIndex = 7;
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
            // panel1
            // 
            panel1.Controls.Add(_SoLuong);
            panel1.Controls.Add(_ViTri);
            panel1.Controls.Add(_YeuCau);
            panel1.Controls.Add(_MoTa);
            panel1.Controls.Add(_MaTTDT);
            panel1.Controls.Add(lb_YeuCau);
            panel1.Controls.Add(lb_MoTa);
            panel1.Controls.Add(lb_SoLuong);
            panel1.Controls.Add(lb_VTri);
            panel1.Controls.Add(lb_MaTTDT);
            panel1.Location = new Point(42, 57);
            panel1.Name = "panel1";
            panel1.Size = new Size(699, 113);
            panel1.TabIndex = 6;
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
            // lb1
            // 
            lb1.AutoSize = true;
            lb1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lb1.Location = new Point(42, 23);
            lb1.Name = "lb1";
            lb1.Size = new Size(237, 31);
            lb1.TabIndex = 5;
            lb1.Text = "Thông tin đăng tuyển";
            // 
            // _uuTien
            // 
            _uuTien.HeaderText = "Ưu tiên";
            _uuTien.MinimumWidth = 6;
            _uuTien.Name = "_uuTien";
            _uuTien.ReadOnly = true;
            // 
            // GUI_DuyetPhieuDangKy_ChiTietThongTinDangTuyen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lb2);
            Controls.Add(btnHuy);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(lb1);
            Name = "GUI_DuyetPhieuDangKy_ChiTietThongTinDangTuyen";
            Size = new Size(800, 412);
            ((System.ComponentModel.ISupportInitialize)dsPhieuDangKy).EndInit();
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb2;
        private TextBox _SoLuong;
        private TextBox _ViTri;
        public DataGridView dsPhieuDangKy;
        private Button btnHuy;
        private Panel panel2;
        private TextBox _YeuCau;
        private TextBox _MoTa;
        private TextBox _MaTTDT;
        private Label lb_SoLuong;
        private Label lb_VTri;
        public Label lb_MaTTDT;
        private Panel panel1;
        private Label lb_YeuCau;
        private Label lb_MoTa;
        private Label lb1;
        private PageSetupDialog pageSetupDialog1;
        private DataGridViewTextBoxColumn _maUV;
        private DataGridViewTextBoxColumn _trangThai;
        private DataGridViewTextBoxColumn _uuTien;
    }
}
