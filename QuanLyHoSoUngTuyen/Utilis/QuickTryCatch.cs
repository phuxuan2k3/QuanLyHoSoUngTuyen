using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.Utilis
{
    public class QuickTryCatch
    {
        public static T ExcuteWithTryCatchAndShowMessageBox<T>(Func<T> func, string message)
        {
            try
            {
                return func();
            }
            catch (Exception)
            {
                MessageBoxHelper.ShowException(message);
                return default(T)!;
            }
        }
        public static void ExecuteWithoutResolve<T>(Func<T> func)
        {
            try
            {
                func();
            }
            catch (Exception)
            {

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
