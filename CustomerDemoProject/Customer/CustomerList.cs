using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerLibrary
{
    public class CustomerList
    {
        SortedList list = new SortedList();
        public CustomerList()
        {
            list.Add(1, "ruhi","pune");
            list.Add(2, "swati","pune");
            list.Add(13, "mansi","mp");
            list.Add(4, "priya","jalgao");
            list.Add(5, "queen","pune");

        }

        public void AddCustomer(int k, string v,string u)
        {
            list.Add(k, v, u);
        }
        public void display()
        {
            foreach (DictionaryEntry item in list)
            {
                Console.WriteLine(item.Key + " " + item.Value+""+item.Value);
            }
        }

    }
}
