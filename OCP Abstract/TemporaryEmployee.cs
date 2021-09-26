namespace OCP_Abstract
{
    public class TemporaryEmployee : Employee, ICalculate
    {
        public TemporaryEmployee(int id, string name, int salary) : base(id, name, salary)
        {
        }

        public decimal CalculateBonus(int salary)
        {
            return salary * 0.5M;
        }
    }
}
