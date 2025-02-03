namespace DRYPrinciple
{
    public class Payroll
    {
        public decimal CalculateSalary(decimal baseSalary)
        {
            return baseSalary - (baseSalary * 0.18m) + (baseSalary * 0.05m);
        }
    }
}

