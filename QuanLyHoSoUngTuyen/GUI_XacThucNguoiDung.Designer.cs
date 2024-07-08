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
			pnContent.Dock = DockStyle.Fill;
			pnContent.Location = new Point(0, 0);
			pnContent.Margin = new Padding(4, 4, 4, 4);
			pnContent.Name = "pnContent";
			pnContent.Size = new Size(1000, 562);
			pnContent.TabIndex = 0;
			// 
			// GUI_XacThucNguoiDung
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1000, 562);
			Controls.Add(pnContent);
			Margin = new Padding(4, 4, 4, 4);
			Name = "GUI_XacThucNguoiDung";
			Text = "GUI_XacThucNguoiDung";
			ResumeLayout(false);
		}

		#endregion

		private Panel pnContent;
    }
}