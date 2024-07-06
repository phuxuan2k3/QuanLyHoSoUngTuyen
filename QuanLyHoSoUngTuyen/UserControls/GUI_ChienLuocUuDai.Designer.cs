namespace GUI.UC
{
    partial class GUI_ChienLuocUuDai
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
            btnXoaUuDai = new Button();
            btnSuaUuDai = new Button();
            btnThemUuDai = new Button();
            txtMoTaUuDai = new TextBox();
            txtTenUuDai = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            dsChienLuocUuDai = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dsChienLuocUuDai).BeginInit();
            SuspendLayout();
            // 
            // btnXoaUuDai
            // 
            btnXoaUuDai.BackColor = Color.Red;
            btnXoaUuDai.ForeColor = Color.White;
            btnXoaUuDai.Location = new Point(660, 265);
            btnXoaUuDai.Name = "btnXoaUuDai";
            btnXoaUuDai.Size = new Size(94, 29);
            btnXoaUuDai.TabIndex = 19;
            btnXoaUuDai.Text = "Xoá";
            btnXoaUuDai.UseVisualStyleBackColor = false;
            btnXoaUuDai.Click += btnXoaUuDai_Click;
            // 
            // btnSuaUuDai
            // 
            btnSuaUuDai.BackColor = SystemColors.MenuHighlight;
            btnSuaUuDai.ForeColor = Color.White;
            btnSuaUuDai.Location = new Point(560, 265);
            btnSuaUuDai.Name = "btnSuaUuDai";
            btnSuaUuDai.Size = new Size(94, 29);
            btnSuaUuDai.TabIndex = 18;
            btnSuaUuDai.Text = "Chỉnh sửa";
            btnSuaUuDai.UseVisualStyleBackColor = false;
            btnSuaUuDai.Click += btnSuaUuDai_Click;
            // 
            // btnThemUuDai
            // 
            btnThemUuDai.BackColor = Color.Green;
            btnThemUuDai.ForeColor = Color.White;
            btnThemUuDai.Location = new Point(458, 265);
            btnThemUuDai.Name = "btnThemUuDai";
            btnThemUuDai.Size = new Size(94, 29);
            btnThemUuDai.TabIndex = 17;
            btnThemUuDai.Text = "Thêm";
            btnThemUuDai.UseVisualStyleBackColor = false;
            btnThemUuDai.Click += btnThemUuDai_Click;
            // 
            // txtMoTaUuDai
            // 
            txtMoTaUuDai.Location = new Point(458, 120);
            txtMoTaUuDai.Multiline = true;
            txtMoTaUuDai.Name = "txtMoTaUuDai";
            txtMoTaUuDai.Size = new Size(297, 124);
            txtMoTaUuDai.TabIndex = 16;
            // 
            // txtTenUuDai
            // 
            txtTenUuDai.Location = new Point(458, 79);
            txtTenUuDai.Name = "txtTenUuDai";
            txtTenUuDai.Size = new Size(297, 27);
            txtTenUuDai.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(386, 120);
            label6.Name = "label6";
            label6.Size = new Size(51, 20);
            label6.TabIndex = 14;
            label6.Text = "Mô tả:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(402, 79);
            label5.Name = "label5";
            label5.Size = new Size(35, 20);
            label5.TabIndex = 13;
            label5.Text = "Tên:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 5);
            label4.Name = "label4";
            label4.Size = new Size(195, 20);
            label4.TabIndex = 12;
            label4.Text = "Danh sách chiến lược ưu đãi";
            // 
            // dsChienLuocUuDai
            // 
            dsChienLuocUuDai.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dsChienLuocUuDai.Location = new Point(3, 28);
            dsChienLuocUuDai.Name = "dsChienLuocUuDai";
            dsChienLuocUuDai.RowHeadersWidth = 51;
            dsChienLuocUuDai.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dsChienLuocUuDai.Size = new Size(362, 298);
            dsChienLuocUuDai.TabIndex = 11;
            dsChienLuocUuDai.CellClick += dsChienLuocUuDai_CellClick;
            // 
            // GUI_ChienLuocUuDai
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnXoaUuDai);
            Controls.Add(btnSuaUuDai);
            Controls.Add(btnThemUuDai);
            Controls.Add(txtMoTaUuDai);
            Controls.Add(txtTenUuDai);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dsChienLuocUuDai);
            Name = "GUI_ChienLuocUuDai";
            Size = new Size(764, 337);
            ((System.ComponentModel.ISupportInitialize)dsChienLuocUuDai).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnXoaUuDai;
        private Button btnSuaUuDai;
        private Button btnThemUuDai;
        private TextBox txtMoTaUuDai;
        private TextBox txtTenUuDai;
        private Label label6;
        private Label label5;
        private Label label4;
        private DataGridView dsChienLuocUuDai;
    }
}
