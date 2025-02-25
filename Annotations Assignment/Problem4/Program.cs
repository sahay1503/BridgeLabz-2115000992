using System;
using System.Reflection;

//Define the Custom Attribute
[AttributeUsage(AttributeTargets.Method)]  // Restrict usage to methods only
public class TaskInfoAttribute : Attribute
{
    public string AssignedTo { get; }
    public int Priority { get; }

    // Constructor to initialize the attribute
    public TaskInfoAttribute(string assignedTo, int priority)
    {
        AssignedTo = assignedTo;
        Priority = priority;
    }
}

//Apply the Attribute to a Method
public class TaskManager
{
    [TaskInfo("Ankur", 1)]
    public void CompleteTask()
    {
        Console.WriteLine("Task completed!");
    }
}

//Retrieve Attribute Details Using Reflection
public class Program
{
    public static void Main()
    {
        TaskManager taskManager = new TaskManager();
        MethodInfo method = typeof(TaskManager).GetMethod("CompleteTask");

        // Check if the method has the TaskInfo attribute
        if (method.GetCustomAttribute(typeof(TaskInfoAttribute)) is TaskInfoAttribute taskInfo)
        {
            Console.WriteLine($"Task Assigned To: {taskInfo.AssignedTo}");
            Console.WriteLine($"Task Priority: {taskInfo.Priority}");
        }

        // Execute the method
        taskManager.CompleteTask();
    }
}
