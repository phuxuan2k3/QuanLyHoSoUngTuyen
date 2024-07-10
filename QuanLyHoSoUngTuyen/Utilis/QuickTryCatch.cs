using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.Utilis
{
    public class QuickTryCatch
    {
        public static void ExcuteWithTryCatchAndShowMessageBox(Action action, string message)
        {
            try
            {
                action();
            }
            catch (Exception)
            {
                MessageBoxHelper.ShowException(message);
            }
        }
        public static void ExecuteWithoutResolve(Action action)
        {
            try
            {
                action();
            }
            catch (Exception)
            {

            }
        }
    }
}
