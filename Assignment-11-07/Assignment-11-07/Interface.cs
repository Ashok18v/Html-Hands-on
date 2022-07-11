using Assignment_11_07;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_11_07
{
    public interface IAddSub
    {
        void Add(int a, int b);
        void sub(int a, int b);

    } }
    class Print_ : IAddSub
{
    public void Add(int a,int b)
    {
        Console.WriteLine("Addition");
        Console.WriteLine(a + b);
    }
    public void sub(int a, int b)
    {
        Console.WriteLine("Subtraction");
        Console.WriteLine(a - b);
    }
}

