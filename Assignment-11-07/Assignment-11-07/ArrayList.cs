using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_11_07
{
    internal class Arraylist
    {
        public void Sort()
        {
            ArrayList arlist = new ArrayList() {" Delhi"," Mumbai"," Kolkata"," Chennai "};
            Console.Write("Before Sorting:");
            foreach (var item in arlist)
            {
                Console.Write(item);

            }
            Console.WriteLine();
            arlist.Sort();
            Console.Write("Sorted:");
            foreach (var item in arlist)
            {
                Console.Write(item);
            }
            Console.WriteLine();

        }
    }
}
