using DelegateLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemo
{
    internal class EventsDemo

    {
        //keyword       delegete         event name
        static event ProductIdGeneration ev_AutoGenerateProductID;
        static event MathOperations ev_DoAddition;
        static event MathOperations ev_DoSubtraction;
        static void Main(string[] args)
        {
            Console.WriteLine("1.Add  2.Subtract");
            int userChoise=Convert.ToInt32(Console.ReadLine());
            Maths m = new Maths();
            switch (userChoise)
            {
                case 1:
                    MathOperations mo = new MathOperations(m.Add);// Addition
                    ev_DoAddition += mo;
                    Console.WriteLine("Enter 1st no");
                    int fno=Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter 2nd no");
                    int sno = Convert.ToInt32(Console.ReadLine());
                    int addAns = ev_DoAddition(fno,sno);
                    Console.WriteLine(addAns);
                    break;

                case 2:
                    MathOperations mo1 = new MathOperations(m.Subtract);//Subtraction
                    ev_DoSubtraction += mo1;
                    Console.WriteLine("Enter 1st no");
                    int fno1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter 2nd no");
                    int sno1 = Convert.ToInt32(Console.ReadLine());
                    int subAns=ev_DoSubtraction(fno1,sno1);
                    Console.WriteLine(subAns);
                    break;
            }

            //Products p = new Products();
            //ProductIdGeneration delgen = new ProductIdGeneration(p.GenerateId);
            //ev_AutoGenerateProductID += delgen;
            //int prodid = ev_AutoGenerateProductID();
            //Console.WriteLine(prodid);
            //Console.WriteLine("================");

            //prodid= ev_AutoGenerateProductID();
            //Console.WriteLine(prodid);
        }
    }
}
