using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_11_07
{
    internal class PrintOddNumbers
    {
        public void Print()
        {
            Console.WriteLine("Odd Numbers:");
            for (int i = 0; i <= 10; i++)
            {
                if(i% 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
