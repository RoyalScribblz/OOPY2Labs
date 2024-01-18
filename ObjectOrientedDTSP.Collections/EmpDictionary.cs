namespace ObjectOrientedDTSP.Collections;

public static class EmpDictionary
{
    public static void EmpDictionaryMethod()
    {
        Employee joe = new("Joe Bloggs", "P123", "Plumber", "Engineering", 34500);
        Employee aisha = new("Aisha", "P456", "Marketing Executive", "Marketing", 29000);
        Employee lisa = new("Lisa", "P789", "Accountant", "Sales", 32000);
        Employee ahmed = new("Ahmed", "P678", "Electrician", "Engineering", 37000);
        Employee tom = new("Tom", "P567", "Customer Advisor", "Sales", 26000);
        Employee uche = new("Uche", "P234", "Sales Executive", "Sales", 28000);
        Employee virat = new("Virat", "P345", "Mechanic", "Engineering", 42000);

        var employees = new Dictionary<int, Employee>
        {
            { 1, joe },
            { 2, aisha },
            { 3, lisa },
            { 4, ahmed },
            { 5, tom },
            { 6, uche },
            { 7, virat }
        };
        
        foreach (var keypair in employees)
        {
            Console.WriteLine($"{keypair.Key}: {keypair.Value.EmployeeName}");
        }

        employees.Remove(1);
        employees.Remove(5);
        
        Console.WriteLine("");
        
        foreach (var keypair in employees)
        {
            Console.WriteLine($"{keypair.Key}: {keypair.Value.EmployeeName}");
        }
        
        Console.WriteLine("");

        string tryGetResult = employees.TryGetValue(2, out Employee? employee)
            ? employee.EmployeeName
            : "Object Not Found";
        
        Console.WriteLine(tryGetResult);
    }
}