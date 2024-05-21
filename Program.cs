using EmployeeStat;

var employees = await new FileService().GetEmployeesAsync();

foreach (var employee in employees)
    Console.WriteLine(employee);

var highestPaidEmployee = Calculator.GetHighestPaidEmployee(employees);
Console.WriteLine($"Legmagsabb fizetése: {highestPaidEmployee}");

var laziestEmployee = Calculator.GetLaziestEmployee(employees);
Console.WriteLine($"Legkevesebb projekje: {laziestEmployee}");