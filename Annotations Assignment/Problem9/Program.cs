using System;
using System.Reflection;

// Define the Custom MaxLength Attribute
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
public class MaxLengthAttribute : Attribute
{
    public int Length { get; }

    public MaxLengthAttribute(int length)
    {
        Length = length;
    }
}

// Apply the Attribute to the User Class
public class User
{
    [MaxLength(10)]
    public string Username { get; }

    public User(string username)
    {
        ValidateMaxLength(this, username, nameof(Username));
        Username = username;
    }

    //Validate Field Length Using Reflection
    private void ValidateMaxLength(object obj, string value, string propertyName)
    {
        PropertyInfo property = obj.GetType().GetProperty(propertyName);
        if (property == null) return;

        MaxLengthAttribute attribute = property.GetCustomAttribute<MaxLengthAttribute>();
        if (attribute != null && value.Length > attribute.Length)
        {
            throw new ArgumentException($"{propertyName} cannot exceed {attribute.Length} characters.");
        }
    }
}

// Test the Validation
public class Program
{
    public static void Main()
    {
        try
        {
            User validUser = new User("Siddhant");
            Console.WriteLine($"User created: {validUser.Username}");

            User invalidUser = new User("VeryLongUsername"); // This should throw an exception
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
