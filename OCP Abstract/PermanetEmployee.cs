namespace OCP_Abstract
{
    public class PermanetEmployee : Employee, ICalculate
    {
        public PermanetEmployee(int id, string name, int salary) : base(id, name, salary)
        {
        }

        public decimal CalculateBonus(int salary)
        {
            return salary * 1M;
        }
    }
}
