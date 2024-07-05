namespace GUI.UC
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
            dgv_dsTTDT = new DataGridView();
            lb_dsTTDT = new Label();
            _id = new DataGridViewTextBoxColumn();
            _ViTri = new DataGridViewTextBoxColumn();
            _SoLuong = new DataGridViewTextBoxColumn();
            _thoiGianDang = new DataGridViewTextBoxColumn();
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
            btnHuy.TabIndex = 5;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = false;
            // 
            // dgv_dsTTDT
            // 
            dgv_dsTTDT.AllowUserToAddRows = false;
            dgv_dsTTDT.AllowUserToDeleteRows = false;
            dgv_dsTTDT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_dsTTDT.Columns.AddRange(new DataGridViewColumn[] { _id, _ViTri, _SoLuong, _thoiGianDang });
            dgv_dsTTDT.Location = new Point(41, 85);
            dgv_dsTTDT.Name = "dgv_dsTTDT";
            dgv_dsTTDT.ReadOnly = true;
            dgv_dsTTDT.RowHeadersWidth = 51;
            dgv_dsTTDT.Size = new Size(717, 269);
            dgv_dsTTDT.TabIndex = 4;
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
            _id.HeaderText = "MATTDT";
            _id.MinimumWidth = 6;
            _id.Name = "_id";
            _id.ReadOnly = true;
            _id.Width = 125;
            // 
            // _ViTri
            // 
            _ViTri.HeaderText = "Vị trí";
            _ViTri.MinimumWidth = 6;
            _ViTri.Name = "_ViTri";
            _ViTri.ReadOnly = true;
            _ViTri.Width = 125;
            // 
            // _SoLuong
            // 
            _SoLuong.HeaderText = "Số lượng";
            _SoLuong.MinimumWidth = 6;
            _SoLuong.Name = "_SoLuong";
            _SoLuong.ReadOnly = true;
            _SoLuong.Width = 125;
            // 
            // _thoiGianDang
            // 
            _thoiGianDang.HeaderText = "Thời gian đăng";
            _thoiGianDang.MinimumWidth = 6;
            _thoiGianDang.Name = "_thoiGianDang";
            _thoiGianDang.ReadOnly = true;
            _thoiGianDang.Width = 125;
            // 
            // GUI_DanhSachThongTinDangTuyen_DN
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnHuy);
            Controls.Add(dgv_dsTTDT);
            Controls.Add(lb_dsTTDT);
            Name = "GUI_DanhSachThongTinDangTuyen_DN";
            Size = new Size(799, 448);
            ((System.ComponentModel.ISupportInitialize)dgv_dsTTDT).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnHuy;
        private DataGridView dgv_dsTTDT;
        private Label lb_dsTTDT;
        private DataGridViewTextBoxColumn _id;
        private DataGridViewTextBoxColumn _ViTri;
        private DataGridViewTextBoxColumn _SoLuong;
        private DataGridViewTextBoxColumn _thoiGianDang;
    }
}
