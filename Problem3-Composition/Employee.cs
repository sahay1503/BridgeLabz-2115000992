// Employee class (Part of a Department)
class Employee
{
    public string Name { get; set; }
    public string Position { get; set; }

    public Employee(string name, string position)
    {
        Name = name;
        Position = position;
    }

    public void Display()
    {
        Console.WriteLine($"Employee: {Name}, Position: {Position}");
    }
}
