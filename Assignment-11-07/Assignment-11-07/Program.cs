using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_11_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press 1:Count Even & Odd.Question 1");
            Console.WriteLine("Press 2:Boxing & Unboxing.Question 2");
            Console.WriteLine("Press 3:Largest value.Question 3");
            Console.WriteLine("Press 4:All Odd Numbers.Question 4");
            Console.WriteLine("Press 5:Method Overloading.Question 5");
            Console.WriteLine("Press 6:ArrayList to Sort.Question 6");
            Console.WriteLine("Press 7:Constructor Overloading.Question 7");
            Console.WriteLine("Press 8:Interface.Question 8");
            Console.WriteLine("Press 9:List of Players Using Dictionary.Question 9");
            Console.WriteLine("Press 10:List of students using linq.Question 10");
            int a = Convert.ToInt32(Console.ReadLine());
            switch (a)
            {
                case 1:
                    CountEvenOdd obj = new CountEvenOdd();
                    obj.Count();
                    break;
                    case 3:
                    LargestValue largestValue = new LargestValue();
                    largestValue.Value();
                    break;
                case 4:
                    PrintOddNumbers printOddNumbers = new PrintOddNumbers();
                    printOddNumbers.Print();
                    break;
                case 5:
                    MethodOverloading methodOverloading = new MethodOverloading();
                    methodOverloading.Addition(5, 6);
                    break;
                case 6:
                    Arraylist arraylist = new Arraylist();
                    arraylist.Sort();
                    break;
                case 7:
                    Constructor constructor = new Constructor(4);
                    break;
                case 8:
                    Print_ obj_ = new Print_();
                    obj_.Add(1, 2);
                    obj_.sub(5, 3);
                    break;
                case 9:
                    CricketPlayers cricketPlayers = new CricketPlayers();
                    cricketPlayers.print();
                    break;
                case 10:
                    StudentDetails student = new StudentDetails();
                    student.details();
                    break;
                case 2:
                    BoxingUnboxing unboxing = new BoxingUnboxing();
                    unboxing.print();
                    break;

            }
        }
    }
}
