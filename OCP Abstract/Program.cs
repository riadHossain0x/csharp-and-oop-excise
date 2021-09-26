using System;
using System.Collections.Generic;

namespace OCP_Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new PermanetEmployee(1, "Riad", 1000));
            employees.Add(new PermanetEmployee(2, "Jihad", 2000));
            employees.Add(new TemporaryEmployee(3, "Arman", 2500));

            foreach (var empl in employees)
            {
                Console.WriteLine($"{empl.toString()} Bonus: {((PermanetEmployee)empl).CalculateBonus(empl.Salary)}");
            }
        }
    }
}
