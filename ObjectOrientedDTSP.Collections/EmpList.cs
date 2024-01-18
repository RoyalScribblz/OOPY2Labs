namespace ObjectOrientedDTSP.Collections;

public static class EmpList
{
    public static void EmpListMethod()
    {
        Employee joe = new("Joe Bloggs", "P123", "Plumber", "Engineering", 34500);
        Employee aisha = new("Aisha", "P456", "Marketing Executive", "Marketing", 29000);
        Employee lisa = new("Lisa", "P789", "Accountant", "Sales", 32000);
        Employee ahmed = new("Ahmed", "P678", "Electrician", "Engineering", 37000);
        Employee tom = new("Tom", "P567", "Customer Advisor", "Sales", 26000);
        Employee uche = new("Uche", "P234", "Sales Executive", "Sales", 28000);
        Employee virat = new("Virat", "P345", "Mechanic", "Engineering", 42000);

        List<Employee> employees = [joe, aisha, lisa, ahmed, tom, uche, virat];

        foreach (Employee employee in employees)
        {
            Console.WriteLine(employee.EmployeeName);
        }

        Console.WriteLine("");

        employees.Remove(joe);
        employees.Remove(tom);

        foreach (Employee employee in employees)
        {
            Console.WriteLine(employee.EmployeeName);
        }

        Console.WriteLine("");

        var employeesWithA = employees
            .Select((employee, index) => new { Index = index, Name = employee.EmployeeName })
            .Where(employee => employee.Name.StartsWith('A'));

        foreach (var employee in employeesWithA)
        {
            Console.WriteLine($"[{employee.Index}] {employee.Name}");
        }
    }
}