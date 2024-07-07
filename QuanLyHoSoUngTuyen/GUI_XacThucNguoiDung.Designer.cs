namespace GUI
{
    partial class GUI_XacThucNguoiDung
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
            pnContent = new Panel();
            SuspendLayout();
            // 
            // pnContent
            // 
            pnContent.Location = new Point(0, 0);
            pnContent.Name = "pnContent";
            pnContent.Size = new Size(801, 451);
            pnContent.TabIndex = 0;
            // 
            // GUI_XacThucNguoiDung
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnContent);
            Name = "GUI_XacThucNguoiDung";
            Text = "GUI_XacThucNguoiDung";
            Load += GUI_XacThucNguoiDung_Load;
            ResumeLayout(false);
        }

        #endregion

        private Panel pnContent;
    }
}