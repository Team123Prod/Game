using AuthApi.DTO;
using AuthApi.Services;
using AuthApi.WebSocketHandlers;

namespace AuthApi.Utils
{
    public static class CommandsBinder
    {
        static readonly AuthService _authService;
        static CommandsBinder()
        {
            _authService = new AuthService();
        }
        public static void CallCommand(AppWebSocketHandler handler, string message)
        {
            dynamic result = null;

            var oMycustomclassname = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(message);

            string command = oMycustomclassname.Command;
            string authToken = oMycustomclassname.AuthToken;

            switch (command)
            {
                case "authorize":
                    {
                        Auth authData = new Auth(oMycustomclassname.Data);
                        result = _authService.GetAuthToken(authData);
                        break;
                    }
            }

            if (result != null)
            {
                dynamic response = new
                {
                    Command = command,
                    Data = result
                };

                var responseJson = Newtonsoft.Json.JsonConvert.SerializeObject(response);

                handler.Send(responseJson);
            }
        }
    }
}