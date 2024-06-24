using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginLibrary
{
    internal class Login
    {
        private string _username;
        private string _password;
        public string userName {
            get { return _username; }
            set {  _username = value; } 

        }
        public string password {
            get { return _password; }
            set { _password = value; }

        }
    }
}
