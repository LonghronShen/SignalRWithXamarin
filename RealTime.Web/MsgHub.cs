using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RealTime.Web
{
    public class MsgHub : Hub
    {
        public void Send(string name, string message)
        {
            Clients.All.BroadcastMessage(name, message);
        }
    }
}