using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_11_07
{
    internal class Constructor
    {
        public Constructor(int a)
        {
            for(int i = 1; i <11; i++)
            {
                Console.WriteLine(a * i);
            }
        }
    }
}
