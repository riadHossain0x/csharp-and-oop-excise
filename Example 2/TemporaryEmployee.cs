namespace Example_2
{
    public class TemporaryEmployee : IEmployee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public double Calculate(double salary)
        {
            return salary / 100 * 10;
        }
    }
}
