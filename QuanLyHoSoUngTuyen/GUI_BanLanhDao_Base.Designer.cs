namespace GUI
{
    partial class GUI_BanLanhDao_Base
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
            btnChienLuocUuDai.Location = new Point(152, 3);
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
            pnContent.Size = new Size(815, 424);
            pnContent.TabIndex = 3;
            // 
            // GUI_BanLanhDao_Base
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(827, 467);
            Controls.Add(pnContent);
            Controls.Add(btnChienLuocUuDai);
            Controls.Add(btnGiaHanHopDong);
            Name = "GUI_BanLanhDao_Base";
            Text = "GUI_BanLanhDao_Base";
            ResumeLayout(false);
        }

        #endregion

        private Button btnGiaHanHopDong;
        private Button btnChienLuocUuDai;
        private Panel pnContent;
    }
}