using EmployeeStat;

var fileService = new FileService("employees.xml");
var employees = await fileService.GetEmployeesAsync();

foreach (var employee in employees)
    Console.WriteLine(employee);

var calculator = new Calculator(employees);

var highestPaidEmployee = calculator.GetHighestPaidEmployee();
Console.WriteLine($"Legmagsabb fizetése: {highestPaidEmployee}");

var laziestEmployee = calculator.GetLaziestEmployee();
Console.WriteLine($"Legkevesebb projekje: {laziestEmployee}");