namespace GUI
{
    partial class GUI_BanLanhDao
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnGiaHanHopDong = new Button();
            btnChienLuocUuDai = new Button();
            pnContent = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnGiaHanHopDong
            // 
            btnGiaHanHopDong.Location = new Point(3, 3);
            btnGiaHanHopDong.Name = "btnGiaHanHopDong";
            btnGiaHanHopDong.Size = new Size(143, 29);
            btnGiaHanHopDong.TabIndex = 0;
            btnGiaHanHopDong.Text = "Gia hạn hợp đồng";
            btnGiaHanHopDong.UseVisualStyleBackColor = true;
            btnGiaHanHopDong.Click += btnGiaHanHopDong_Click;
            // 
            // btnChienLuocUuDai
            // 
            btnChienLuocUuDai.Location = new Point(153, 3);
            btnChienLuocUuDai.Name = "btnChienLuocUuDai";
            btnChienLuocUuDai.Size = new Size(143, 29);
            btnChienLuocUuDai.TabIndex = 2;
            btnChienLuocUuDai.Text = "Chiến lược ưu đãi";
            btnChienLuocUuDai.UseVisualStyleBackColor = true;
            btnChienLuocUuDai.Click += btnChienLuocUuDai_Click;
            // 
            // pnContent
            // 
            pnContent.Location = new Point(3, 38);
            pnContent.Name = "pnContent";
            pnContent.Size = new Size(1146, 480);
            pnContent.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(btnGiaHanHopDong, 0, 0);
            tableLayoutPanel1.Controls.Add(btnChienLuocUuDai, 1, 0);
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(301, 38);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // GUI_BanLanhDao
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1150, 522);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(pnContent);
            Name = "GUI_BanLanhDao";
            Text = "GUI_BanLanhDao_Base";
            Load += GUI_BanLanhDao_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnGiaHanHopDong;
        private Button btnChienLuocUuDai;
        private Panel pnContent;
        private TableLayoutPanel tableLayoutPanel1;
    }
}