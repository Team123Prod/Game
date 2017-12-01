using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using AuthApi.WebSocketHandlers;
using Microsoft.Web.WebSockets;

namespace AuthApi.Controllers
{
    public class AppController : ApiController
    {
        
       public HttpResponseMessage Get()
       {
           HttpContext.Current.AcceptWebSocketRequest(new AppWebSocketHandler());
           return Request.CreateResponse(HttpStatusCode.SwitchingProtocols);
       }
   
    }
}
