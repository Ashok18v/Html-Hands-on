using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_11_07
{
    internal class CountEvenOdd
    {
        public void Count()
        {
            int Count_Even = 0;
            int Count_Odd = 0;
            List<int> Numbers = new List<int> {50, 65, 56, 71, 81 };
            for(int i = 0; i < Numbers.Count; i++)
            {
                if (Numbers[i] % 2 == 0)
                {
                    Count_Even++;
                }
                else
                {
                    Count_Odd++;
                }
            }
            Console.WriteLine("Even Count-" + Count_Even);
            Console.WriteLine("Odd Count-" + Count_Odd);
        }
    }
}
