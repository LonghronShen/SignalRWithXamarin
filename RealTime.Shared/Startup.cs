using Microsoft.AspNet.SignalR.Client;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealTime.Shared
{
    public class Startup : IMsgHub
    {
        private IHubProxy msgHubProxy;

        public void Send(string name, string message)
        {
            msgHubProxy.Invoke("Send", name, message);
        }

        public async void Start()
        {
            var hubConnection = new HubConnection("http://192.168.0.129/RealTime.Web");
            msgHubProxy = hubConnection.CreateHubProxy("MsgHub");

            msgHubProxy.On<string, string>("BroadcastMessage", (name, message) =>
              {
                  Debug.WriteLine(name + message);
              });

            await hubConnection.Start();
        }
    }
}
