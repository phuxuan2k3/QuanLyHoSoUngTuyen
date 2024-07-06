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
            lb_dsTTDT = new Label();
            button1 = new Button();
            dsPhieuDangKy = new DataGridView();
            _maUV = new DataGridViewTextBoxColumn();
            _trangThai = new DataGridViewTextBoxColumn();
            _uuTien = new DataGridViewTextBoxColumn();
            lbTTDT = new Label();
            ((System.ComponentModel.ISupportInitialize)dsPhieuDangKy).BeginInit();
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
            // dsPhieuDangKy
            // 
            dsPhieuDangKy.AllowUserToAddRows = false;
            dsPhieuDangKy.AllowUserToDeleteRows = false;
            dsPhieuDangKy.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dsPhieuDangKy.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dsPhieuDangKy.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dsPhieuDangKy.Columns.AddRange(new DataGridViewColumn[] { _maUV, _trangThai, _uuTien });
            dsPhieuDangKy.Location = new Point(41, 88);
            dsPhieuDangKy.Name = "dsPhieuDangKy";
            dsPhieuDangKy.ReadOnly = true;
            dsPhieuDangKy.RowHeadersWidth = 51;
            dsPhieuDangKy.Size = new Size(717, 258);
            dsPhieuDangKy.TabIndex = 10;
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
            // _uuTien
            // 
            _uuTien.HeaderText = "Ưu tiên";
            _uuTien.MinimumWidth = 6;
            _uuTien.Name = "_uuTien";
            _uuTien.ReadOnly = true;
            // 
            // lbTTDT
            // 
            lbTTDT.AutoSize = true;
            lbTTDT.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lbTTDT.Location = new Point(619, 41);
            lbTTDT.Name = "lbTTDT";
            lbTTDT.Size = new Size(0, 31);
            lbTTDT.TabIndex = 11;
            // 
            // GUI_DanhSachPhieuDK_DN
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lbTTDT);
            Controls.Add(dsPhieuDangKy);
            Controls.Add(button1);
            Controls.Add(btnHuy);
            Controls.Add(lb_dsTTDT);
            Name = "GUI_DanhSachPhieuDK_DN";
            Size = new Size(799, 448);
            ((System.ComponentModel.ISupportInitialize)dsPhieuDangKy).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnHuy;
        private Label lb_dsTTDT;
        private Button button1;
        public DataGridView dsPhieuDangKy;
        private DataGridViewTextBoxColumn _maUV;
        private DataGridViewTextBoxColumn _trangThai;
        private DataGridViewTextBoxColumn _uuTien;
        private Label lbTTDT;
    }
}
