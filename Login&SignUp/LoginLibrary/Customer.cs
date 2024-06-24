using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginLibrary
{
    internal class Customer
    {
        private int _custId;
        private string _custname;
        private string _city;
        public int custId {
            get { return _custId; }
            set { _custId = value; }
        }
        public string custName {
            get { return _custname; }
            set { _custname = value; }
        }
        public string City {
            get { return _city; }
            set { _city = value; }
        }
    }
}
