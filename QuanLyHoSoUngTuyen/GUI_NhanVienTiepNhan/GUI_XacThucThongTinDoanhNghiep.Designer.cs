namespace GUI.UserControls
{
    partial class GUI_XacThucThongTinDoanhNghiep
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
            dsDoanhNghiep = new DataGridView();
            ColumnMaDN = new DataGridViewTextBoxColumn();
            ColumnMST = new DataGridViewTextBoxColumn();
            ColumnTenDN = new DataGridViewTextBoxColumn();
            ColumnDaiDienDN = new DataGridViewTextBoxColumn();
            ColumnTrangThai = new DataGridViewTextBoxColumn();
            ColumnNgayConLai = new DataGridViewTextBoxColumn();
            lbDNXT = new Label();
            btnTuChoi = new Button();
            btnXacThuc = new Button();
            MST = new Label();
            Ten = new Label();
            lbMST = new Label();
            lbTenDN = new Label();
            lbNgDaiDien = new Label();
            label2 = new Label();
            lbDiaChi = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dsDoanhNghiep).BeginInit();
            SuspendLayout();
            // 
            // dsDoanhNghiep
            // 
            dsDoanhNghiep.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dsDoanhNghiep.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dsDoanhNghiep.Columns.AddRange(new DataGridViewColumn[] { ColumnMaDN, ColumnMST, ColumnTenDN, ColumnDaiDienDN, ColumnTrangThai, ColumnNgayConLai });
            dsDoanhNghiep.Location = new Point(54, 62);
            dsDoanhNghiep.Name = "dsDoanhNghiep";
            dsDoanhNghiep.RowHeadersWidth = 51;
            dsDoanhNghiep.Size = new Size(761, 382);
            dsDoanhNghiep.TabIndex = 0;
            dsDoanhNghiep.CellContentClick += dsDoanhNghiep_CellContentClick;
            // 
            // ColumnMaDN
            // 
            ColumnMaDN.HeaderText = "Mã Doanh Nghiệp";
            ColumnMaDN.MinimumWidth = 6;
            ColumnMaDN.Name = "ColumnMaDN";
            // 
            // ColumnMST
            // 
            ColumnMST.HeaderText = "Mã số thuế";
            ColumnMST.MinimumWidth = 6;
            ColumnMST.Name = "ColumnMST";
            // 
            // ColumnTenDN
            // 
            ColumnTenDN.HeaderText = "Tên doanh nghiệp";
            ColumnTenDN.MinimumWidth = 6;
            ColumnTenDN.Name = "ColumnTenDN";
            // 
            // ColumnDaiDienDN
            // 
            ColumnDaiDienDN.HeaderText = "Người đại diện";
            ColumnDaiDienDN.MinimumWidth = 6;
            ColumnDaiDienDN.Name = "ColumnDaiDienDN";
            // 
            // ColumnTrangThai
            // 
            ColumnTrangThai.HeaderText = "Trạng thái";
            ColumnTrangThai.MinimumWidth = 6;
            ColumnTrangThai.Name = "ColumnTrangThai";
            // 
            // ColumnNgayConLai
            // 
            ColumnNgayConLai.HeaderText = "Thời hạn xác thực";
            ColumnNgayConLai.MinimumWidth = 6;
            ColumnNgayConLai.Name = "ColumnNgayConLai";
            // 
            // lbDNXT
            // 
            lbDNXT.AutoSize = true;
            lbDNXT.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbDNXT.Location = new Point(54, 0);
            lbDNXT.Name = "lbDNXT";
            lbDNXT.Size = new Size(403, 41);
            lbDNXT.TabIndex = 1;
            lbDNXT.Text = "Doanh nghiệp chờ xác thực";
            // 
            // btnTuChoi
            // 
            btnTuChoi.Location = new Point(716, 463);
            btnTuChoi.Name = "btnTuChoi";
            btnTuChoi.Size = new Size(100, 45);
            btnTuChoi.TabIndex = 5;
            btnTuChoi.Tag = "red";
            btnTuChoi.Text = "Từ chối";
            btnTuChoi.UseVisualStyleBackColor = true;
            btnTuChoi.Click += btnTuChoi_Click;
            // 
            // btnXacThuc
            // 
            btnXacThuc.Location = new Point(591, 463);
            btnXacThuc.Name = "btnXacThuc";
            btnXacThuc.Size = new Size(100, 45);
            btnXacThuc.TabIndex = 6;
            btnXacThuc.Tag = "green";
            btnXacThuc.Text = "Xác thực";
            btnXacThuc.UseVisualStyleBackColor = true;
            btnXacThuc.Click += btnXacThuc_Click_1;
            // 
            // MST
            // 
            MST.AutoSize = true;
            MST.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MST.Location = new Point(843, 62);
            MST.Name = "MST";
            MST.Size = new Size(91, 20);
            MST.TabIndex = 7;
            MST.Text = "Mã số thuế:";
            // 
            // Ten
            // 
            Ten.AutoSize = true;
            Ten.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Ten.Location = new Point(843, 127);
            Ten.Name = "Ten";
            Ten.Size = new Size(138, 20);
            Ten.TabIndex = 8;
            Ten.Text = "Tên doanh nghiệp:";
            // 
            // lbMST
            // 
            lbMST.AutoSize = true;
            lbMST.Location = new Point(843, 82);
            lbMST.Name = "lbMST";
            lbMST.Size = new Size(50, 20);
            lbMST.TabIndex = 9;
            lbMST.Text = "label1";
            // 
            // lbTenDN
            // 
            lbTenDN.AutoSize = true;
            lbTenDN.Location = new Point(843, 147);
            lbTenDN.Name = "lbTenDN";
            lbTenDN.Size = new Size(50, 20);
            lbTenDN.TabIndex = 10;
            lbTenDN.Text = "label1";
            // 
            // lbNgDaiDien
            // 
            lbNgDaiDien.AutoSize = true;
            lbNgDaiDien.Location = new Point(843, 213);
            lbNgDaiDien.Name = "lbNgDaiDien";
            lbNgDaiDien.Size = new Size(50, 20);
            lbNgDaiDien.TabIndex = 12;
            lbNgDaiDien.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(843, 193);
            label2.Name = "label2";
            label2.Size = new Size(116, 20);
            label2.TabIndex = 11;
            label2.Text = "Người đại diện:";
            // 
            // lbDiaChi
            // 
            lbDiaChi.AutoSize = true;
            lbDiaChi.Location = new Point(843, 281);
            lbDiaChi.Name = "lbDiaChi";
            lbDiaChi.Size = new Size(50, 20);
            lbDiaChi.TabIndex = 14;
            lbDiaChi.Text = "label1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(843, 261);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 13;
            label3.Text = "Địa chỉ:";
            // 
            // GUI_XacThucThongTinDoanhNghiep
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lbDiaChi);
            Controls.Add(label3);
            Controls.Add(lbNgDaiDien);
            Controls.Add(label2);
            Controls.Add(lbTenDN);
            Controls.Add(lbMST);
            Controls.Add(Ten);
            Controls.Add(MST);
            Controls.Add(btnXacThuc);
            Controls.Add(btnTuChoi);
            Controls.Add(lbDNXT);
            Controls.Add(dsDoanhNghiep);
            Name = "GUI_XacThucThongTinDoanhNghiep";
            Size = new Size(1110, 624);
            ((System.ComponentModel.ISupportInitialize)dsDoanhNghiep).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dsDoanhNghiep;
        private Label lbDNXT;
        private Button btnTuChoi;
        private Button btnXacThuc;
        private DataGridViewTextBoxColumn ColumnMaDN;
        private DataGridViewTextBoxColumn ColumnMST;
        private DataGridViewTextBoxColumn ColumnTenDN;
        private DataGridViewTextBoxColumn ColumnDaiDienDN;
        private DataGridViewTextBoxColumn ColumnTrangThai;
        private Label MST;
        private Label Ten;
        private Label lbMST;
        private Label lbTenDN;
        private DataGridViewTextBoxColumn ColumnNgayConLai;
        private Label lbNgDaiDien;
        private Label label2;
        private Label lbDiaChi;
        private Label label3;
    }
}
