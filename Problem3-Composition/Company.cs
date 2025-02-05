// Company class (Composes Departments and Employees)
class Company
{
    public string Name { get; set; }
    private List<Department> Departments { get; set; }
    public Company(string name)
    {
        Name = name;
        Departments = new List<Department>();
    }

    public void AddDepartment(string departmentName)
    {
        Departments.Add(new Department(departmentName));
    }
    public void AddEmployeeToDepartment(string departmentName, string employeeName, string position)
    {
        var department = Departments.Find(d => d.Name == departmentName);
        if (department != null)
        {
            department.AddEmployee(employeeName, position);
        }
        else
        {
            Console.WriteLine("Department not found.");
        }
    }
    public void DisplayCompanyStructure()
    {
        Console.WriteLine($"Company: {Name}");
        foreach (var department in Departments)
        {
            department.DisplayEmployees();
        }
    }
}
