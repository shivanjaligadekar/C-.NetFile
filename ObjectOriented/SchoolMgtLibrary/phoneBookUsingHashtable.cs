using System;
using System.Collections;
using System.Collections.Generic;

//using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMgtLibrary
{
    public class phoneBookUsingHashtable
    {
        Hashtable ht = new Hashtable();
        public void PopulateEntries()
        {
           
            ht.Add(123456, "Shivanjali");
            ht.Add(234567, "mansi");
            ht.Add(343456, "Ankita");
            ht.Add(453456, "nikita");
            ht.Add(523456, "Anita");
            ht.Add(623456, "vanita");

            foreach (DictionaryEntry item in ht)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }


        }

        public void AddData(int k, string v)
        {
            ht.Add((int)k, v);
        }

        public void Display() {
            foreach (DictionaryEntry item in ht)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }

        }

        public string FindName(int key)
        {
            string name=(string)ht[key];
            return name;
        }

       
    }

    
}
