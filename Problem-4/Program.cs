using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
    public double Salary { get; set; }
}

class EmployeeSerialization
{
    static string filePath = "employees.json";

    static void Main()
    {
        List<Employee> employees = new List<Employee>
        {
            new Employee { Id = 101, Name = "Alice Johnson", Department = "HR", Salary = 60000 },
            new Employee { Id = 102, Name = "Bob Smith", Department = "IT", Salary = 75000 },
            new Employee { Id = 103, Name = "Charlie Brown", Department = "Finance", Salary = 70000 }
        };

        try
        {
            SerializeEmployees(employees);
            Console.WriteLine("Employees have been serialized successfully!\n");

            List<Employee> retrievedEmployees = DeserializeEmployees();
            Console.WriteLine("Deserialized Employee List:");
            foreach (var emp in retrievedEmployees)
            {
                Console.WriteLine($"ID: {emp.Id}, Name: {emp.Name}, Dept: {emp.Department}, Salary: {emp.Salary}");
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine($"I/O Error: {ex.Message}");
        }
        catch (JsonException ex)
        {
            Console.WriteLine($"JSON Error: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Unexpected Error: {ex.Message}");
        }
    }

    static void SerializeEmployees(List<Employee> employees)
    {
        string jsonString = JsonSerializer.Serialize(employees, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(filePath, jsonString);
    }

    static List<Employee> DeserializeEmployees()
    {
        if (!File.Exists(filePath))
        {
            Console.WriteLine("No employee data found.");
            return new List<Employee>();
        }

        string jsonString = File.ReadAllText(filePath);
        return JsonSerializer.Deserialize<List<Employee>>(jsonString);
    }
}
