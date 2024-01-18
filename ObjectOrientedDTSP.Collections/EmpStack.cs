namespace ObjectOrientedDTSP.Collections;

public static class EmpStack
{
    public static void EmployeeStack()
    {
        Employee joe = new("Joe Bloggs", "P123", "Plumber", "Engineering", 34500);
        Employee aisha = new("Aisha", "P456", "Marketing Executive", "Marketing", 29000);
        Employee lisa = new("Lisa", "P789", "Accountant", "Sales", 32000);
        Employee ahmed = new("Ahmed", "P678", "Electrician", "Engineering", 37000);
        Employee tom = new("Tom", "P567", "Customer Advisor", "Sales", 26000);
        Employee uche = new("Uche", "P234", "Sales Executive", "Sales", 28000);
        Employee virat = new("Virat", "P345", "Mechanic", "Engineering", 42000);

        Stack<Employee> employees = new([joe, aisha, lisa, ahmed, tom, uche, virat]);
        
        Console.WriteLine($"At the top of the stack: {employees.Peek().EmployeeName}");
        
        Console.WriteLine("");
        
        foreach (string name in employees.Select(employee => employee.EmployeeName))
        {
            Console.WriteLine(name);
        }
        
        Console.WriteLine("");

        Console.WriteLine(employees.Any(employee => employee.EmployeeName == "Tom") ? "True" : "Object Not Found");
        
        Console.WriteLine("");

        employees.Pop();
        employees.Pop();
        
        foreach (string name in employees.Select(employee => employee.EmployeeName))
        {
            Console.WriteLine(name);
        }
    }
}