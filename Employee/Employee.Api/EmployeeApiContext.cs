namespace Employee.Api
{
    public class EmployeeApiContext
    {
        public List<Employees> employeesList { get; set; }

        public EmployeeApiContext()
        {
            employeesList = new List<Employees>()
            {
                new Employees()
                {
                    Id = 1,
                    First_Name = "Veera",
                    Last_Name = "Ashok",
                    Mobile_Number = "9999999999",
                    Email = "test@abc.com",
                    Address = "Gurazala",

                },
                new Employees()
                {
                    Id = 2,
                    First_Name = "Naveen",
                    Last_Name = "Suriya",
                    Mobile_Number = "2222222",
                    Email = "abc@abc.com",
                    Address = "Vizag",

                },
                new Employees()
                {
                    Id = 3,
                    First_Name = "Rakesh",
                    Last_Name = "Rocky",
                    Mobile_Number = "3333333333",
                    Email = "test@abc.com",
                    Address= "Vijyawada",

                }
            };
        }
    }
}
