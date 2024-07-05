namespace GUI.UC
{
    partial class GUI_DuyetPhDK_DanhSachThongTinDangTuyen
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
            dsThongTinDangTuyen = new DataGridView();
            lb_dsTTDT = new Label();
            _id = new DataGridViewTextBoxColumn();
            _thoiGianDang = new DataGridViewTextBoxColumn();
            _soNgayDang = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dsThongTinDangTuyen).BeginInit();
            SuspendLayout();
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.Red;
            btnHuy.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnHuy.Location = new Point(664, 379);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(94, 29);
            btnHuy.TabIndex = 5;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = false;
            // 
            // dsThongTinDangTuyen
            // 
            dsThongTinDangTuyen.AllowUserToAddRows = false;
            dsThongTinDangTuyen.AllowUserToDeleteRows = false;
            dsThongTinDangTuyen.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dsThongTinDangTuyen.Columns.AddRange(new DataGridViewColumn[] { _id, _thoiGianDang, _soNgayDang });
            dsThongTinDangTuyen.Location = new Point(41, 85);
            dsThongTinDangTuyen.Name = "dsThongTinDangTuyen";
            dsThongTinDangTuyen.ReadOnly = true;
            dsThongTinDangTuyen.RowHeadersWidth = 51;
            dsThongTinDangTuyen.Size = new Size(717, 269);
            dsThongTinDangTuyen.TabIndex = 4;
            dsThongTinDangTuyen.CellContentClick += dsThongTinDangTuyen_CellContentClick;
            // 
            // lb_dsTTDT
            // 
            lb_dsTTDT.AutoSize = true;
            lb_dsTTDT.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lb_dsTTDT.Location = new Point(41, 41);
            lb_dsTTDT.Name = "lb_dsTTDT";
            lb_dsTTDT.Size = new Size(229, 31);
            lb_dsTTDT.TabIndex = 3;
            lb_dsTTDT.Text = "Thông in đăng tuyển";
            // 
            // _id
            // 
            _id.HeaderText = "Ma TTDT";
            _id.MinimumWidth = 6;
            _id.Name = "_id";
            _id.ReadOnly = true;
            _id.Width = 125;
            // 
            // _thoiGianDang
            // 
            _thoiGianDang.HeaderText = "Thời gian đăng";
            _thoiGianDang.MinimumWidth = 6;
            _thoiGianDang.Name = "_thoiGianDang";
            _thoiGianDang.ReadOnly = true;
            _thoiGianDang.Width = 125;
            // 
            // _soNgayDang
            // 
            _soNgayDang.HeaderText = "Số ngày đăng";
            _soNgayDang.MinimumWidth = 6;
            _soNgayDang.Name = "_soNgayDang";
            _soNgayDang.ReadOnly = true;
            _soNgayDang.Width = 125;
            // 
            // GUI_DuyetPhDK_DanhSachThongTinDangTuyen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnHuy);
            Controls.Add(dsThongTinDangTuyen);
            Controls.Add(lb_dsTTDT);
            Name = "GUI_DuyetPhDK_DanhSachThongTinDangTuyen";
            Size = new Size(799, 448);
            ((System.ComponentModel.ISupportInitialize)dsThongTinDangTuyen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnHuy;
        private DataGridView dsThongTinDangTuyen;
        private Label lb_dsTTDT;
        private DataGridViewTextBoxColumn _id;
        private DataGridViewTextBoxColumn _thoiGianDang;
        private DataGridViewTextBoxColumn _soNgayDang;
    }
}
