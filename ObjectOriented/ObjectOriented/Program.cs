using SchoolMgtLibrary;
using System.Collections;
namespace ObjectOrientedDemo;

internal class Program {
    //{
    //    //public void M1(object o2,int i){ }
    //    //public void M2(dynamic o1, int i) { }
    //    private static void Main(string[] args)
    //    {
    //        //non generic stack
    //        Stack s = new Stack();
    //        s.Push(1);
    //        s.Push(3.34f);
    //        s.Push(3456);

    //        foreach (var item in s)
    //        {
    //            Console.WriteLine(item);
    //        }
    //        s.Pop();
    //        s.Peek();
    //        s.Contains(2);
    //        //Array.CreateInstance(typeof(object), 10);
    //        object[] myarr = new object[5];
    //        s.CopyTo(myarr, 0);
    //        int cnt = s.Count;
    //        object[] objArr = new object[cnt];
    //        objArr = s.ToArray();

    //        //Queue queue = new Queue();
    //        //queue.Enqueue(1);
    //        //queue.Enqueue(2);
    //        //queue.Enqueue(3);
    //        //queue.Dequeue();
    //        //queue.Peek();

    //        Hashtable ht = new Hashtable();
    //        ht.Add(1, "A");
    //        ht.Add("1", "A");
    //        ht.Add(2, "B");
    //        ht.Add(3, "C");
    //        ht.Add(4, "D");
    //        ht.Add(5, "E");
    //        IDictionaryEnumerator ie = ht.GetEnumerator();
    //        while (ie.MoveNext())
    //        {
    //            Console.WriteLine(ie.Key + " " + ie.Value);
    //        }
    //        Console.WriteLine("=======================");
    //        string name = (string)ht[5];
    //        Console.WriteLine(name);

    //        //generic stack
    //        Stack<int> s2 = new Stack<int>();
    









    //    //working with arrays()
    private static void Main1(string[] args)
    {

        //Student Operations
        StudentOperation operation = new StudentOperation();
        Console.WriteLine("1.Add Student \n 2.Edit Student \n 3.Get all Student  \n 4.Delete Student \n 5.Exit");
        int userChoise = Convert.ToInt32(Console.ReadLine());
        do
        {
            switch (userChoise)
            {

                case 1:
                    Student s = new Student();
                    Console.WriteLine("Enter roll no");
                    s.RollNo = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Name");
                    s.StudentName = Console.ReadLine();
                    Console.WriteLine("Enter City");
                    s.City = Console.ReadLine();

                    break;
                case 2:
                    break;
                case 3:
                    List<Student> students = new List<Student>();
                    students = operation.Getstudents();
                    foreach (Student student in students)
                    {
                        Console.WriteLine(student.RollNo);
                        Console.WriteLine(student.StudentName);
                        Console.WriteLine(student.City);
                    }
                    break;
                case 4:

                    break;
                case 5:
                    Environment.Exit(0);
                    break;
                default:
                    break;
            }

        } while (userChoise != 0);





        //Dictionary<int, Student> dic = new Dictionary<int, Student>();
        //dic.Add(1, new Student(1, "shivanjali", "nashik"));


        //    private static void Main1(string[] args)
        //{
        //    Console.WriteLine("Hello, World!");
        //    object obj;
        //    //var ol = 13;
        //    //dynamic o2=obj as dynamic;

        //    int i = 10;
        //    obj = i;
        //    Type t = obj.GetType();


        //    float h = (float)obj;
        //    Console.WriteLine(h);
        //    Console.WriteLine(h.GetType());
        //    //object obj = 3.143243422d;
        //    //var o1 = 13;
        //    //dynamic o2 =obj as dynamic;

        //    int[] arr = new int[1, 2, 3, 4, 5];

        //    Console.WriteLine("=========================================");
        //    Array.Sort(arr);
        //    Array.Reverse(arr);
        //    foreach (var item in arr)
        //    {
        //        Console.WriteLine(item);
        //    }


        //    int[] arr2 = new int[5] { 11, 12, 13, 14, 15 };

        //    int[] arr3 = new int[5];
        //    arr[0] = 1;
        //    arr[1] = 2;
        //    arr[2] = 3;
        //    arr[3] = 4;
        //    arr[4] = 5;

        //    Array typedArray=Array.CreateInstance(typeof(int),5);
        //    typedArray.SetValue(101, 0);
        //    typedArray.SetValue(102, 1);
        //    typedArray.SetValue(103, 2);
        //    typedArray.SetValue(104, 3);
        //    typedArray.SetValue(105, 4);

    }

