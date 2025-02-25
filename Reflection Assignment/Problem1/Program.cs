using System;
using System.Reflection;

class ReflectionInfo
{
    static void Main()
    {
        Console.Write("Enter class name: ");
        string className = Console.ReadLine();

        // Get the Type object
        Type type = Type.GetType(className);

        if (type == null)
        {
            Console.WriteLine("Class not found!");
            return;
        }

        Console.WriteLine($"Class Name: {type.Name}\n");

        // Display Methods
        Console.WriteLine("Methods:");
        MethodInfo[] methods = type.GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);
        foreach (var method in methods)
        {
            Console.WriteLine(method.Name);
        }

        // Display Fields
        Console.WriteLine("\nFields:");
        FieldInfo[] fields = type.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);
        foreach (var field in fields)
        {
            Console.WriteLine(field.Name);
        }

        // Display Constructors
        Console.WriteLine("\nConstructors:");
        ConstructorInfo[] constructors = type.GetConstructors(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);
        foreach (var constructor in constructors)
        {
            Console.WriteLine(constructor.ToString());
        }
    }
}
