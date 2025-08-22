using HR;

var employee = new Employee();

employee.SetName("Ahmed", "Ali");
employee.SetDateOfBirth(new DateOnly(1990, 5, 15));
employee.Salary = 50000;
employee.TaxPercentage = 20;


Console.WriteLine($"Employee: {employee.FirstName} {employee.LastName}");
Console.WriteLine($"Date of Birth: {employee.DateOfBirth}");
Console.WriteLine($"Salary: {employee.Salary}");
Console.WriteLine($"Tax Percentage: {employee.TaxPercentage}");