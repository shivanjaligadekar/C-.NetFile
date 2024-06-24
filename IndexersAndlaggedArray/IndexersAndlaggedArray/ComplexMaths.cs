using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexersAndlaggedArray
{
    public class ComplexMaths
    {
        int[] arr=new int[10];

        public int this[int index,bool square]
        {
            get
            {
                if (square)
                {
                    return arr[index] * arr[index];
                }
                else
                {
                    return arr[index];
                }

            }
            set
            {
                if (square)
                {
                    arr[index] = (int)Math.Sqrt(value);
                }
                else
                    arr[index] = value;
            }
        }
    }
}
