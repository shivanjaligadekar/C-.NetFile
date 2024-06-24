using SchoolMgtLibrary;
using System.Collections;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello ,World");
        int choice = 3;
        switch (choice)
        {
            case 1:
                phoneBookUsingHashtable p = new phoneBookUsingHashtable();
                p.PopulateEntries();
                Console.WriteLine("Enter the number to find the name");
                int k = Convert.ToInt32(Console.ReadLine());
                string name = p.FindName(k);
                Console.WriteLine(name);
                Console.WriteLine("------------");
                p.AddData(89976, "rita");
                Console.WriteLine("---");
                p.Display();
                break;
            case 2:
                StudentSortedList student = new StudentSortedList();
                student.display();
                Console.WriteLine("====================");
                student.AddStudent(3, "ankita");
                Console.WriteLine("---------");
                student.display();
                break;
            case 3:
                ArrayListDemo demo= new ArrayListDemo();
                ArrayList list = demo.GetTheArrayList();
                foreach(var item in list)
                {
                    Console.WriteLine(item);
                }
                demo.AddElements(2000);
                Console.WriteLine("----");
                list=demo.GetTheArrayList();
                foreach (var item in list)
                {
                    Console.WriteLine(item);
                }

                break;


            default:
                break;
        }
        Console.WriteLine("Hello, World!");
        
    }
}