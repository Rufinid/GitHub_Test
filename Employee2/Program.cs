public abstract class Employee
{
    public string? Name { get; set; }
    public int Age { get; set; }

    public abstract double CalculateSalary();
}

public class HourlyEmployee : Employee
{
    public double HourlyRate { get; set; }
    public int HoursWorked { get; set; }

    public override double CalculateSalary()
    {
        return HourlyRate * HoursWorked;
    }
}

public class MonthlyEmployee : Employee
{
    public double MonthlySalary { get; set; }

    public override double CalculateSalary()
    {
        return MonthlySalary;
    }
}

public class ContractEmployee : Employee
{
    public double ContractRate { get; set; }
    public int MonthsWorked { get; set; }

    public override double CalculateSalary()
    {
        return ContractRate * MonthsWorked;
    }
}

class Program
{
    static void Main()
    {
        HourlyEmployee hourlyEmployee = new()
        {
            Name = "Иван Иванов",
            Age = 30,
            HourlyRate = 15.5,
            HoursWorked = 160
        };

        MonthlyEmployee monthlyEmployee = new()
        {
            Name = "Мария Петрова",
            Age = 28,
            MonthlySalary = 30000
        };

        ContractEmployee contractEmployee = new()
        {
            Name = "Сергей Сидоров",
            Age = 35,
            ContractRate = 5000,
            MonthsWorked = 6
        };

        Console.WriteLine($"{hourlyEmployee.Name} получает {hourlyEmployee.CalculateSalary()} за месяц.");
        Console.WriteLine($"{monthlyEmployee.Name} получает {monthlyEmployee.CalculateSalary()} за месяц.");
        Console.WriteLine($"{contractEmployee.Name} получит {contractEmployee.CalculateSalary()} за контракт.");

    }
}