using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemo
{
    internal class LambdaDemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----function lambda----");
            Func<int,int> square= no => {
                int ans = no * no;
                return ans;
                };
            int sq_ans = square(10);
            Console.WriteLine(sq_ans);

            Console.WriteLine("-----Action lambda----");
            Action<int, int> multiply = (i, j) =>
            {
                int ans = i * j;
                Console.WriteLine(ans);
            };
            multiply(12, 32);

            Console.WriteLine("-----Predicate lambda----");
            Predicate<int> CheckIfNumberIsPositive = i =>
            {
                return i > 0;
            };
            bool ans=CheckIfNumberIsPositive(10);
            Console.WriteLine(ans);



        }
    }
}
