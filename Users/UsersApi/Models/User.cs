using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UsersApi.Models
{
    public class User
    {
        private string _username;
        private List<string> _roles;
        private string _password;

        public User(string username, List<string> roles, string password)
        {
            _username = username;
            _roles = roles;
            _password = password;
        }
    }
}