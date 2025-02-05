// Department class (Composed within a Company)
class Department
{
    public string Name { get; set; }
    private List<Employee> Employees { get; set; }
    public Department(string name)
    {
        Name = name;
        Employees = new List<Employee>();
    }
    public void AddEmployee(string name, string position)
    {
        Employees.Add(new Employee(name, position));
    }
    public void DisplayEmployees()
    {
        Console.WriteLine($"Department: {Name}");
        foreach (var employee in Employees)
        {
            employee.Display();
        }
    }
}