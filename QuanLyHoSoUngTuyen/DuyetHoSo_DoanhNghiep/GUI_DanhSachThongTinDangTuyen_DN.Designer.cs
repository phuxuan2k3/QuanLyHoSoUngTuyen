namespace GUI
{
    partial class GUI_DanhSachThongTinDangTuyen_DN
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
            dsThongTinDangTuyen = new DataGridView();
            _maTTDT = new DataGridViewTextBoxColumn();
            _maDN = new DataGridViewTextBoxColumn();
            _soLuong = new DataGridViewTextBoxColumn();
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
            // dsThongTinDangTuyen
            // 
            dsThongTinDangTuyen.AllowUserToAddRows = false;
            dsThongTinDangTuyen.AllowUserToDeleteRows = false;
            dsThongTinDangTuyen.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dsThongTinDangTuyen.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dsThongTinDangTuyen.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dsThongTinDangTuyen.Columns.AddRange(new DataGridViewColumn[] { _maTTDT, _maDN, _soLuong });
            dsThongTinDangTuyen.Location = new Point(41, 91);
            dsThongTinDangTuyen.Name = "dsThongTinDangTuyen";
            dsThongTinDangTuyen.ReadOnly = true;
            dsThongTinDangTuyen.RowHeadersWidth = 51;
            dsThongTinDangTuyen.Size = new Size(717, 266);
            dsThongTinDangTuyen.TabIndex = 8;
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
            // GUI_DanhSachThongTinDangTuyen_DN
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dsThongTinDangTuyen);
            Controls.Add(btnHuy);
            Controls.Add(lb_dsTTDT);
            Name = "GUI_DanhSachThongTinDangTuyen_DN";
            Size = new Size(799, 448);
            ((System.ComponentModel.ISupportInitialize)dsThongTinDangTuyen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnHuy;
        private Label lb_dsTTDT;
        public DataGridView dsThongTinDangTuyen;
        private DataGridViewTextBoxColumn _maTTDT;
        private DataGridViewTextBoxColumn _maDN;
        private DataGridViewTextBoxColumn _soLuong;
    }
}
