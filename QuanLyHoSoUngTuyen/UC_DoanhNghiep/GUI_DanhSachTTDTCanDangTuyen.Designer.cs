namespace GUI.UC
{
    partial class GUI_DanhSachTTDTCanDangTuyen
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
            dsThongTinDangTuyen = new DataGridView();
            _id = new DataGridViewTextBoxColumn();
            _viTri = new DataGridViewTextBoxColumn();
            _soLuong = new DataGridViewTextBoxColumn();
            _thoiGianDang = new DataGridViewTextBoxColumn();
            _soNgayDang = new DataGridViewTextBoxColumn();
            _trangThai = new DataGridViewTextBoxColumn();
            _tinhTrang = new DataGridViewTextBoxColumn();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dsThongTinDangTuyen).BeginInit();
            SuspendLayout();
            // 
            // dsThongTinDangTuyen
            // 
            dsThongTinDangTuyen.AllowUserToAddRows = false;
            dsThongTinDangTuyen.AllowUserToDeleteRows = false;
            dsThongTinDangTuyen.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dsThongTinDangTuyen.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dsThongTinDangTuyen.Columns.AddRange(new DataGridViewColumn[] { _id, _viTri, _soLuong, _thoiGianDang, _soNgayDang, _trangThai, _tinhTrang });
            dsThongTinDangTuyen.Location = new Point(29, 89);
            dsThongTinDangTuyen.Margin = new Padding(24);
            dsThongTinDangTuyen.Name = "dsThongTinDangTuyen";
            dsThongTinDangTuyen.ReadOnly = true;
            dsThongTinDangTuyen.RowHeadersWidth = 51;
            dsThongTinDangTuyen.Size = new Size(915, 417);
            dsThongTinDangTuyen.TabIndex = 4;
            dsThongTinDangTuyen.CellContentClick += dsThongTinDangTuyen_CellClick;
            // 
            // _id
            // 
            _id.HeaderText = "_id";
            _id.MinimumWidth = 6;
            _id.Name = "_id";
            _id.ReadOnly = true;
            _id.Visible = false;
            // 
            // _viTri
            // 
            _viTri.FillWeight = 160.427811F;
            _viTri.HeaderText = "Vị trí";
            _viTri.MinimumWidth = 6;
            _viTri.Name = "_viTri";
            _viTri.ReadOnly = true;
            // 
            // _soLuong
            // 
            _soLuong.FillWeight = 87.91444F;
            _soLuong.HeaderText = "Số lượng";
            _soLuong.MinimumWidth = 6;
            _soLuong.Name = "_soLuong";
            _soLuong.ReadOnly = true;
            // 
            // _thoiGianDang
            // 
            _thoiGianDang.FillWeight = 87.91444F;
            _thoiGianDang.HeaderText = "Thời gian đăng";
            _thoiGianDang.MinimumWidth = 6;
            _thoiGianDang.Name = "_thoiGianDang";
            _thoiGianDang.ReadOnly = true;
            // 
            // _soNgayDang
            // 
            _soNgayDang.FillWeight = 87.91444F;
            _soNgayDang.HeaderText = "Số ngày đăng";
            _soNgayDang.MinimumWidth = 6;
            _soNgayDang.Name = "_soNgayDang";
            _soNgayDang.ReadOnly = true;
            // 
            // _trangThai
            // 
            _trangThai.FillWeight = 87.91444F;
            _trangThai.HeaderText = "Trạng thái";
            _trangThai.MinimumWidth = 6;
            _trangThai.Name = "_trangThai";
            _trangThai.ReadOnly = true;
            // 
            // _tinhTrang
            // 
            _tinhTrang.FillWeight = 87.91444F;
            _tinhTrang.HeaderText = "Tình trạng";
            _tinhTrang.MinimumWidth = 6;
            _tinhTrang.Name = "_tinhTrang";
            _tinhTrang.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(29, 27);
            label1.Name = "label1";
            label1.Size = new Size(178, 38);
            label1.TabIndex = 3;
            label1.Text = "Đăng tuyển ";
            // 
            // GUI_DanhSachTTDTCanDangTuyen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dsThongTinDangTuyen);
            Controls.Add(label1);
            Name = "GUI_DanhSachTTDTCanDangTuyen";
            Size = new Size(1013, 538);
            ((System.ComponentModel.ISupportInitialize)dsThongTinDangTuyen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dsThongTinDangTuyen;
        private DataGridViewTextBoxColumn _id;
        private DataGridViewTextBoxColumn _viTri;
        private DataGridViewTextBoxColumn _soLuong;
        private DataGridViewTextBoxColumn _thoiGianDang;
        private DataGridViewTextBoxColumn _soNgayDang;
        private DataGridViewTextBoxColumn _trangThai;
        private DataGridViewTextBoxColumn _tinhTrang;
        private Label label1;
    }
}
