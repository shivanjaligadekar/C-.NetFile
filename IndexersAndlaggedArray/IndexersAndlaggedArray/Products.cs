using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexersAndlaggedArray
{
    
    public class Products

    {
        string[] productnames = new string[5] { "Tea", "Cofee", "Biscuits", "water","cofee1" };
        public string this[int index]
        {
            get
            {
                return productnames[index];
            }
            set
            {
                productnames[index] = value;
            }
        }
    }
}
