﻿namespace GUI
{
	partial class GUI_NhanVienThanhToan
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
			panel1 = new Panel();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.Dock = DockStyle.Fill;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(942, 593);
			panel1.TabIndex = 0;
			// 
			// GUI_NhanVienThanhToan
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(942, 593);
			Controls.Add(panel1);
			Name = "GUI_NhanVienThanhToan";
			Text = "GUI_NhanVienThanhToan";
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
	}
}