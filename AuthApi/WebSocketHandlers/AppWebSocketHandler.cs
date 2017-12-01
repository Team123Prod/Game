using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AuthApi.Utils;
using Microsoft.Web.WebSockets;

namespace AuthApi.WebSocketHandlers
{
    public class AppWebSocketHandler : WebSocketHandler
    {
        private static WebSocketCollection _connectedClients = new WebSocketCollection();
        
        public AppWebSocketHandler()
        {
        }

        public override void OnOpen()
        {
            _connectedClients.Add(this);
        }

        public override void OnMessage(string message)
        {
            CommandsBinder.CallCommand(this, message);
        }
    }
}