namespace EmployeeStat;

public static class Calculator
{
    public static Employee GetHighestPaidEmployee(List<Employee> employees) =>
        employees.MaxBy(employee => employee.TotalSalary);

    public static Employee GetLaziestEmployee(List<Employee> employees) =>
        employees.MinBy(employee => employee.Projects.Count);
}
