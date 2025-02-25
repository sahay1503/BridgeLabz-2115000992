using System;
using System.Reflection;

// Define a custom attribute
[AttributeUsage(AttributeTargets.Class)]
class AuthorAttribute : Attribute
{
    public string Name { get; }

    public AuthorAttribute(string name)
    {
        Name = name;
    }
}

// Apply the custom attribute to a class
[Author("Ravi Gupta")]
class SampleClass
{
    public void Display()
    {
        Console.WriteLine("Executing SampleClass method.");
    }
}

class ReflectionAttributeExample
{
    static void Main()
    {
        Type type = typeof(SampleClass);

        // Retrieve the custom attribute
        AuthorAttribute attribute = (AuthorAttribute)Attribute.GetCustomAttribute(type, typeof(AuthorAttribute));

        if (attribute != null)
        {
            Console.WriteLine($"Author: {attribute.Name}");
        }
        else
        {
            Console.WriteLine("No Author attribute found.");
        }
    }
}
