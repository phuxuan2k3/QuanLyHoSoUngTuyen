using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.Utilis
{
    public class MessageBoxHelper
    {
        public static void ShowException(string message)
        {
            MessageBox.Show(message, "Có lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
