using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class UsersDomain : IUsersDomain
    {
        public string SayHi(string name) => string.Format("Hi {0}", name);
    }
}
