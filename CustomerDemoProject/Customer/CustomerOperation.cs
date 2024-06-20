using Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerLibrary
{
    public class CustomerOperation
    {
        static List<Customer1> customerList = new List<Customer1>();

        static CustomerOperation()
        {
            customerList.Add(new Customer1(1, "mahi", "pune"));
            customerList.Add(new Customer1(2, "ruhi", "mumbai"));
            customerList.Add(new Customer1(3, "juhi", "nashik"));
        }
        public void AddCustomer(Customer1 customer)
        {
            //Student s=new Student(rno:student.RollNo);
            Customer1 s = new Customer1(Id: customer.ID, custName: customer.custName, city: customer.city);
            //Customer1 s = new Customer1();
            s.ID=customer.Id;
            s.Name = customer.custName;
            s.City = customer.city;
            customerList.Append(s);

        }
        public void UpdateStudent(Customer1 customer)
        {

        }
        public void DeleteStudent(Customer1 customer)
        {

        }
        public List<Customer1> Getstudents()
        {
            return customerList;
        }
    }
}
