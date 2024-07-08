namespace GUI
{
    partial class GUI_DuyetPhieuDangKy_DanhSachThongTinDangTuyen
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
            _maTTDT = new DataGridViewTextBoxColumn();
            _maDN = new DataGridViewTextBoxColumn();
            _soLuong = new DataGridViewTextBoxColumn();
            lb_dsTTDT = new Label();
            ((System.ComponentModel.ISupportInitialize)dsThongTinDangTuyen).BeginInit();
            SuspendLayout();
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
            // dsThongTinDangTuyen
            // 
            dsThongTinDangTuyen.AllowUserToAddRows = false;
            dsThongTinDangTuyen.AllowUserToDeleteRows = false;
            dsThongTinDangTuyen.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dsThongTinDangTuyen.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dsThongTinDangTuyen.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dsThongTinDangTuyen.Columns.AddRange(new DataGridViewColumn[] { _maTTDT, _maDN, _soLuong });
            dsThongTinDangTuyen.Location = new Point(42, 70);
            dsThongTinDangTuyen.Name = "dsThongTinDangTuyen";
            dsThongTinDangTuyen.ReadOnly = true;
            dsThongTinDangTuyen.RowHeadersWidth = 51;
            dsThongTinDangTuyen.Size = new Size(717, 266);
            dsThongTinDangTuyen.TabIndex = 7;
            dsThongTinDangTuyen.CellContentClick += dsThongTinDangTuyen_CellContentClick;
            // 
            // _maTTDT
            // 
            _maTTDT.HeaderText = "Ma TTDT";
            _maTTDT.MinimumWidth = 6;
            _maTTDT.Name = "_maTTDT";
            _maTTDT.ReadOnly = true;
            // 
            // _maDN
            // 
            _maDN.HeaderText = "Ma DN";
            _maDN.MinimumWidth = 6;
            _maDN.Name = "_maDN";
            _maDN.ReadOnly = true;
            // 
            // _soLuong
            // 
            _soLuong.HeaderText = "So Luong";
            _soLuong.MinimumWidth = 6;
            _soLuong.Name = "_soLuong";
            _soLuong.ReadOnly = true;
            // 
            // lb_dsTTDT
            // 
            lb_dsTTDT.AutoSize = true;
            lb_dsTTDT.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lb_dsTTDT.Location = new Point(42, 23);
            lb_dsTTDT.Name = "lb_dsTTDT";
            lb_dsTTDT.Size = new Size(243, 31);
            lb_dsTTDT.TabIndex = 6;
            lb_dsTTDT.Text = " Thông tin đăng tuyển";
            // 
            // GUI_DuyetPhieuDangKy_DanhSachThongTinDangTuyen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnHuy);
            Controls.Add(dsThongTinDangTuyen);
            Controls.Add(lb_dsTTDT);
            Name = "GUI_DuyetPhieuDangKy_DanhSachThongTinDangTuyen";
            Size = new Size(800, 412);
            ((System.ComponentModel.ISupportInitialize)dsThongTinDangTuyen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnHuy;
        private DataGridView dsThongTinDangTuyen;
        private Label lb_dsTTDT;
        private DataGridViewTextBoxColumn _maTTDT;
        private DataGridViewTextBoxColumn _maDN;
        private DataGridViewTextBoxColumn _soLuong;
    }
}
