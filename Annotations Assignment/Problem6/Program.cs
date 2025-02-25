using System;
using System.Reflection;

//Define the Custom Attribute
[AttributeUsage(AttributeTargets.Method)]
public class ImportantMethodAttribute : Attribute
{
    public string Level { get; }

    public ImportantMethodAttribute(string level = "HIGH") // Default level is "HIGH"
    {
        Level = level;
    }
}

// Apply the Attribute to Methods
public class Operations
{
    [ImportantMethod("CRITICAL")]
    public void ProcessData()
    {
        Console.WriteLine("Processing important data...");
    }

    [ImportantMethod] // Defaults to "HIGH"
    public void GenerateReport()
    {
        Console.WriteLine("Generating report...");
    }

    public void RegularMethod()
    {
        Console.WriteLine("This method is not marked as important.");
    }
}

// Retrieve and Print Important Methods Using Reflection
public class Program
{
    public static void Main()
    {
        Type type = typeof(Operations);
        MethodInfo[] methods = type.GetMethods();

        Console.WriteLine("Important Methods:");
        foreach (MethodInfo method in methods)
        {
            if (method.GetCustomAttribute(typeof(ImportantMethodAttribute)) is ImportantMethodAttribute attr)
            {
                Console.WriteLine($"- {method.Name} (Level: {attr.Level})");
            }
        }

        // Execute the methods
        Operations ops = new Operations();
        ops.ProcessData();
        ops.GenerateReport();
        ops.RegularMethod();
    }
}
