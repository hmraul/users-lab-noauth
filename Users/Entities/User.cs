using System.Collections.Generic;

namespace Entities
{
    public class User
    {
        private long _id;
        private string _username;
        private List<string> _roles;
        private string _password;

        public long Id { get; }
        public string Username { get; }

        public User(string username, List<string> roles, string password)
        {
            _username = username;
            _roles = roles;
            _password = password;
        }
    }
}
