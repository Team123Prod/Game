namespace AuthApi.DTO
{
    public class Auth
    {
        public Auth(dynamic fields)
        {
            Login = fields.Login;
            Password = fields.Password;
        }
        public string Login;
        public string Password;
    }
}