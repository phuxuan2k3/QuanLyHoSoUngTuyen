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

        public static void ShowInformation(string message)
        {
            MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static DialogResult ShowQuestion(string message)
        {
            return MessageBox.Show(message, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}
