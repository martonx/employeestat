namespace EmployeeStat;

public class Calculator : ICalculator
{
    private List<Employee> employees;

    public Calculator(List<Employee> employees)
    {
        this.employees = employees;
    }

    public Employee GetHighestPaidEmployee() =>
        employees.MaxBy(employee => employee.TotalSalary);

    public Employee GetLaziestEmployee() =>
        employees.MinBy(employee => employee.Projects.Count);
}
