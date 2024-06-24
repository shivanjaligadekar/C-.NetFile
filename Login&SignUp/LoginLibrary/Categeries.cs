using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginLibrary
{
    internal class Categeries
    {
        private int _cateId;
        private string _cateName;

        public int CategeryId {
            get { return _cateId; }
            set { _cateId = value; } 
        }

        public string CategeryName {
            get { return _cateName; } 
            set { _cateName = value; } 

        }
    }
}
