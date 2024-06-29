using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilis
{
    public class StringEventAgrs : EventArgs
    {
        private readonly string message;

        public StringEventAgrs(string msg)
        {
            this.message = msg;
        }

        public string Message
        {
            get { return this.message; }
        }
    }
}
