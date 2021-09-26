namespace Example_2
{
    public interface IEmployee
    {
        int Id { get; set; }
        string Name { get; set; }
        double Salary { get; set; }

        double Calculate(double salary);
    }
}
