﻿using DSharpPlus.EventArgs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluginCS.Events
{
    public interface ISocketErrored
    {
       void OnCalled(SocketErrorEventArgs socketErrorEventArgs);
    }
}
