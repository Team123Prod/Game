using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AuthApi.DTO;
using AuthApi.Models;

namespace AuthApi.Services
{
    public class AuthService
    {
        public string GetAuthToken(Auth authData)
        {
            return "ololo";
        }

        public UserAccount Authorize(string authToken)
        {
            return new UserAccount();
        }
    }
}