using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.Utilis
{
    public class TryCatchShowMessageBox
    {
        public static T ExcuteWithTryCatch<T>(Func<T> func)
        {
            try
            {
                return func();
            }
            catch (Exception ex)
            {
                MessageBoxHelper.ShowException(ex.Message);
                return default(T)!;
            }
        }

        public static void ExecuteWithTryCatch(Action action)
        {
            try
            {
                action();
            }
            catch (Exception ex)
            {
                MessageBoxHelper.ShowException(ex.Message);
            }
        }
    }
}
