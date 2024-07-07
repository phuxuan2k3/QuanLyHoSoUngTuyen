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
	public partial class GUI_NhanVienThanhToan : Form
	{
		public GUI_NhanVienThanhToan()
		{
			InitializeComponent();
			_instance = this;
		}

		private static GUI_NhanVienThanhToan? _instance;
		public static GUI_NhanVienThanhToan Instance => _instance ?? new();

		public void SwitchContent(UserControl content)
		{
			panel1.Controls.Clear();
			panel1.Controls.Add(content);
			content.Dock = DockStyle.Fill;
		}
	}
}
