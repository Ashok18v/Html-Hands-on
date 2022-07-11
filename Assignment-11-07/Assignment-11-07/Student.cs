using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_11_07
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
    public class StudentDetails
    {
        public void details()
        {
            List<Student> studentDetails = new List<Student>() {
            new Student { Id = 1022, Name = "Lokesh", Age = 18 },
            new Student { Id = 1933, Name = "Venkat", Age = 19 },
            new Student { Id = 145, Name = "Ravi", Age = 17 },
            new Student { Id = 467, Name = "Rahul", Age = 21 },
            new Student { Id = 478, Name = "Avinash", Age = 15 },
            new Student { Id = 1398, Name = "Sai", Age = 17 },
            new Student { Id = 467, Name = "Vamsi", Age = 20 }
        };
            var result= from s in studentDetails
                        where s.Age>=15 && s.Age<19
                        select s;
            foreach(Student student in result)
            {
               Console.WriteLine("Id:"+student.Id +"Name:"+student.Name+ "Age:"+student.Age);
            }


        }
    }
}
