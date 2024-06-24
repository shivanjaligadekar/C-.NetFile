using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginLibrary
{
    internal class SingUp
    {
        private string _fname;
        private string _lname;
        private string _pwd;
        private string _password;
        public string firstName {
            get { return _fname; }
            set {  _fname = value; }
        }
        public string lastName {
            get { return _lname; }
            set { _lname = value; }
        }
        public string userName {
            get { return _pwd; }
            set { _pwd = value; } 
        }
        public string password {
            get { return _password; }
            set { _password = value; }
                  
        }
    }
}
