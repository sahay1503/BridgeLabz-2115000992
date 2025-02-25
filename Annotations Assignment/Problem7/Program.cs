using System;
using System.Reflection;

//  Define the Custom Attribute
[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)] // Allow multiple TODOs per method
public class TodoAttribute : Attribute
{
    public string Task { get; }
    public string AssignedTo { get; }
    public string Priority { get; }

    public TodoAttribute(string task, string assignedTo, string priority = "MEDIUM") // Default priority: MEDIUM
    {
        Task = task;
        AssignedTo = assignedTo;
        Priority = priority;
    }
}

//  Apply the Attribute to Methods
public class FeatureDevelopment
{
    [Todo("Implement user authentication", "Ravi Gupta", "HIGH")]
    [Todo("Add OAuth support", "Anshul Jha", "LOW")]
    public void LoginFeature()
    {
        Console.WriteLine("Login feature is under development...");
    }

    [Todo("Optimize database queries", "Chahat Singh")]
    public void DataProcessing()
    {
        Console.WriteLine("Processing data...");
    }

    public void CompletedFeature()
    {
        Console.WriteLine("This feature is completed.");
    }
}

// Retrieve and Print Todo Tasks Using Reflection
public class Program
{
    public static void Main()
    {
        Type type = typeof(FeatureDevelopment);
        MethodInfo[] methods = type.GetMethods();

        Console.WriteLine("Pending Tasks (TODOs):");
        foreach (MethodInfo method in methods)
        {
            var todos = method.GetCustomAttributes<TodoAttribute>();
            foreach (var todo in todos)
            {
                Console.WriteLine($"- Task: {todo.Task}");
                Console.WriteLine($"  Assigned To: {todo.AssignedTo}");
                Console.WriteLine($"  Priority: {todo.Priority}");
                Console.WriteLine($"  Method: {method.Name}\n");
            }
        }

        // Execute the methods
        FeatureDevelopment dev = new FeatureDevelopment();
        dev.LoginFeature();
        dev.DataProcessing();
        dev.CompletedFeature();
    }
}
