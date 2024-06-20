//using System.Runtime.Serialization.Json;
//using System.Xml.Serialization;
//using System.Runtime.Serialization.Formatters.Binary;

namespace ExceptionProjectLibrary
{
    public class Customer

    {
        int _custid;
        string _custname;
        string _city;
        public int Custid
        {
            get
            {
                return _custid;
            }
            set
            {
                if (value > 0 && value<2000) 
                {
                    _custid = value;
                }
                else if (value > 2000)
                {
                    throw new CustomerNotFoundException("This  customer is not found");
                }
                else
                {
                    throw new ArgumentNullException("Customer id must be a positive number");
                }

                _custid = value;
            }
        }                                                         
        public string CustName
        {
            get
            {
                return _custname;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {

                    throw new ArgumentNullException("Customer cannot be empty");
                }
                else
                {
                    _custname = value;
                }
                
            }
        }
        public string City
        { 
            get
            { 
                return _city; 
            } 
            set
            {
                if (string.IsNullOrEmpty(value))
                {

                    throw new ArgumentNullException("");
                }

                _city = value;
            } 
        }

    }
}
