using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMgtLibrary
{
    public class StudentSortedList
    {
        SortedList list = new SortedList();

        public StudentSortedList()
        {
            list.Add(1, "ruhi");
            list.Add(2, "swati");
            list.Add(13, "mansi");
            list.Add(4, "priya");
            list.Add(5, "queen");

        }

        public void AddStudent(int k, string v)
        {
            list.Add(k, v);
        }
        public void display()
        {
           foreach(DictionaryEntry item in list)
            {
                Console.WriteLine(item.Key+" "+item.Value);
            }
        }
    }
}
