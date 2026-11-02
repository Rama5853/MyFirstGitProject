Console.WriteLine("================================");
Console.WriteLine("    Employee Salary Calculator");
Console.WriteLine("================================");

Console.Write("Enter Employee Name: ");
string employeeName = Console.ReadLine();

Console.Write("Enter Basic Salary: ");
decimal basicSalary = Convert.ToDecimal(Console.ReadLine());

Console.Write("Enter Bonus: ");
decimal bonus = Convert.ToDecimal(Console.ReadLine());

decimal totalSalary = basicSalary + bonus;

Console.WriteLine();
Console.WriteLine("--------- Salary Details ---------");
Console.WriteLine("Employee Name: " + employeeName);
Console.WriteLine("Basic Salary: " + basicSalary);
Console.WriteLine("Bonus: " + bonus);
Console.WriteLine("Total Salary: " + totalSalary);
Console.WriteLine("---------------------------------");
