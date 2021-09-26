namespace OCP_Abstract
{
    public class Employee
    {
        public int Id { get; }
        public string Name { get; }
        public int Salary { get; }

        public Employee(int id, string name, int salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public string toString()
        {
            return $"Id: {Id} Name: {Name}";
        }

    }
}
