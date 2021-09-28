using System;
namespace SpaDay.Models
{
    public class User
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public string VerifyPassword { get; set; }

        public User()
        {
        }

        public User(string username, string email, string password,string verifyPassword)
        {
            Username = username;
            Email = email;
            Password = password;
            VerifyPassword = verifyPassword;
        }

    }
}
