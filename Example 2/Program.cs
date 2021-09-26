using System;

namespace Example_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var employees = new ManageEmployee();
            employees.Add(new PermanetEmployee { Id = 1, Name = "Riad", Salary = 3000 });
            employees.Add(new PermanetEmployee { Id = 2, Name = "Rudra", Salary = 2000 });
            employees.Add(new TemporaryEmployee { Id = 3, Name = "Forkan", Salary = 3000 });

            foreach (var employee in employees.Employees)
            {
                Console.WriteLine($"{employee.Id} {employee.Name} {employee.Salary} {employee.Calculate(employee.Salary)}");
            }
        }
    }
}
