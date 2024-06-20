﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateLibrary
{
    public delegate int MathOperations(int x,int y);
    public class Maths
    {
        public  int Add(int x, int y)
        {
            return x + y;
        }
        public  int Subtract(int x, int y) 
        {  if(x!=0 && y!=0)
                return x - y;
           else
                return -1;

        }
    }
}
