using System;
using System.Reflection;

//  Define the Repeatable Attribute
[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)] // Allow multiple instances
public class BugReportAttribute : Attribute
{
    public string Description { get; }
    public string ReportedBy { get; }
    public string DateReported { get; }

    public BugReportAttribute(string description, string reportedBy, string dateReported)
    {
        Description = description;
        ReportedBy = reportedBy;
        DateReported = dateReported;
    }
}

// Apply the Attribute Multiple Times on a Method
public class SoftwareModule
{
    [BugReport("Null reference exception in edge case", "Amit", "2011-08-19")]
    [BugReport("Memory leak when processing large files", "Rahul", "2009-09-21")]
    public void ProcessData()
    {
        Console.WriteLine("Processing data...");
    }
}

// Retrieve and Print All Bug Reports Using Reflection
public class Program
{
    public static void Main()
    {
        MethodInfo method = typeof(SoftwareModule).GetMethod("ProcessData");

        // Retrieve all BugReport attributes
        var bugReports = method.GetCustomAttributes<BugReportAttribute>();

        Console.WriteLine("Bug Reports for ProcessData():");
        foreach (var report in bugReports)
        {
            Console.WriteLine($"- [{report.DateReported}] {report.ReportedBy}: {report.Description}");
        }

        // Execute the method
        SoftwareModule module = new SoftwareModule();
        module.ProcessData();
    }
}
