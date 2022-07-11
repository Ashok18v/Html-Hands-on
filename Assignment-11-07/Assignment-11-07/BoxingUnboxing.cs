using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_11_07
{
    internal class BoxingUnboxing
    {
        public void print()
        {
            int a = 100;
            string b = "Ashok";
            object obj = 101;
            object obj1 = "Venkat";
            object c = a;
            object d = b;
            int w = (int)obj; 
            string h = (string)obj1;
            Console.WriteLine("Boxing:"+c);
            Console.WriteLine("Boxing:" + d);
            Console.WriteLine("Unboxing:" + w);
            Console.WriteLine("Unboxing:" + h);
        }
    }
}
