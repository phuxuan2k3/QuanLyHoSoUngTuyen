﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilis
{
    public class EventArgs<T> : EventArgs
    {

        public T Value { get; private set; }

        public EventArgs(T val)
        {
            Value = val;
        }
    }

    public delegate void CustomEventHandler<T>(object sender, EventArgs<T> args);
}
