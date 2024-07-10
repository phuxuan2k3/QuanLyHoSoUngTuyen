namespace GUI
{
    partial class GUI_UngVien
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            Btn_TraCuuViTriUngTuyen = new Button();
            UserControl = new Panel();
            label1 = new Label();
            flowLayoutPanel1.SuspendLayout();
            UserControl.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(Btn_TraCuuViTriUngTuyen);
            flowLayoutPanel1.Location = new Point(2, 2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(684, 37);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // Btn_TraCuuViTriUngTuyen
            // 
            Btn_TraCuuViTriUngTuyen.BackColor = Color.Transparent;
            Btn_TraCuuViTriUngTuyen.Location = new Point(3, 3);
            Btn_TraCuuViTriUngTuyen.Name = "Btn_TraCuuViTriUngTuyen";
            Btn_TraCuuViTriUngTuyen.Size = new Size(334, 29);
            Btn_TraCuuViTriUngTuyen.TabIndex = 0;
            Btn_TraCuuViTriUngTuyen.Text = "Tra cứu vị trí ứng tuyển";
            Btn_TraCuuViTriUngTuyen.UseVisualStyleBackColor = false;
            Btn_TraCuuViTriUngTuyen.Click += Btn_TraCuuViTriUngTuyen_Click;
            // 
            // UserControl
            // 
            UserControl.Controls.Add(label1);
            UserControl.Location = new Point(2, 41);
            UserControl.Name = "UserControl";
            UserControl.Size = new Size(803, 504);
            UserControl.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(173, 225);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(512, 32);
            label1.TabIndex = 0;
            label1.Text = "CÔNG TY ABC QUẢN LÝ HỒ SƠ ỨNG TUYỂN";
            // 
            // GUI_UngVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(810, 547);
            Controls.Add(UserControl);
            Controls.Add(flowLayoutPanel1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "GUI_UngVien";
            Text = "GUI_UngVien";
            flowLayoutPanel1.ResumeLayout(false);
            UserControl.ResumeLayout(false);
            UserControl.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Button Btn_TraCuuViTriUngTuyen;
        private Panel UserControl;
        private Label label1;
    }
}