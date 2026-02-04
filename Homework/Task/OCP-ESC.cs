public class Employee
{
    public string Name { get; set; }
    public double BaseSalary { get; set; }
    public string EmployeeType { get; set; } // "Permanent", "Contract", "Intern"
}

public interface ISalaryCalculator
{
    double CalculateSalary(Employee employee);
}

public class PermanentSalaryCalculator : ISalaryCalculator
{
    public double CalculateSalary(Employee employee)
    {
        return employee.BaseSalary * 1.2;// Permanent employee gets 20% bonus
    }
}

public class ContractSalaryCalculator : ISalaryCalculator
{
    public double CalculateSalary(Employee employee)
    {
        return employee.BaseSalary * 1.1;// Contract employee gets 10% bonus
    }
}

public class InternSalaryCalculator : ISalaryCalculator
{
    public double CalculateSalary(Employee employee)
    {
        return employee.BaseSalary * 0.8;// Intern gets 80% of the base salary
    }
}