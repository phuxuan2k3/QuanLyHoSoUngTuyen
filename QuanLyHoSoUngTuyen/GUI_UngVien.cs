using GUI.UC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GUI
{
    public partial class GUI_UngVien : Form
    {
        public GUI_UngVien()
        {
            InitializeComponent();
            UC_Home_UngVien uc = new UC_Home_UngVien();
            addUserControl(uc);
        }
        private void addUserControl(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            UserControl.Controls.Clear();
            UserControl.Controls.Add(uc);
            uc.BringToFront();
        }

        private void Btn_TraCuuViTriUngTuyen_Click(object sender, EventArgs e)
        {
            UC_TraCuuViTriUngTuyen uc = new UC_TraCuuViTriUngTuyen();
            addUserControl(uc);
        }
    }
}
