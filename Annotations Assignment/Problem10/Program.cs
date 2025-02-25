using System;
using System.Linq;
using System.Reflection;

// Define the RoleAllowed Attribute
[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
public class RoleAllowedAttribute : Attribute
{
    public string[] AllowedRoles { get; }

    public RoleAllowedAttribute(params string[] roles)
    {
        AllowedRoles = roles;
    }
}

// Simulate a User Class with Roles
public class User
{
    public string Username { get; }
    public string Role { get; } // e.g., "ADMIN", "USER", "GUEST"

    public User(string username, string role)
    {
        Username = username;
        Role = role;
    }
}

// Define a Secure Service with Role-Based Methods
public class SecureService
{
    [RoleAllowed("ADMIN", "MANAGER")]
    public void AdminOnlyTask()
    {
        Console.WriteLine("Admin task executed successfully!");
    }

    [RoleAllowed("USER", "ADMIN")]
    public void UserTask()
    {
        Console.WriteLine("User task executed successfully!");
    }
}

// Method to Check Access Before Execution
public class AccessControl
{
    public static void ExecuteMethod(User user, object target, string methodName)
    {
        MethodInfo method = target.GetType().GetMethod(methodName);
        if (method == null)
        {
            Console.WriteLine("Method not found.");
            return;
        }

        RoleAllowedAttribute roleAttribute = method.GetCustomAttribute<RoleAllowedAttribute>();
        if (roleAttribute == null || roleAttribute.AllowedRoles.Contains(user.Role))
        {
            method.Invoke(target, null);
        }
        else
        {
            Console.WriteLine($"Access Denied! {user.Username} ({user.Role}) is not allowed to execute {methodName}.");
        }
    }
}

// Test Role-Based Access Control
public class Program
{
    public static void Main()
    {
        User adminUser = new User("Aneesh", "ADMIN");
        User normalUser = new User("Bhuvnesh", "USER");
        User guestUser = new User("Shashank", "GUEST");

        SecureService service = new SecureService();

        Console.WriteLine("\n✅ Admin tries to execute AdminOnlyTask:");
        AccessControl.ExecuteMethod(adminUser, service, "AdminOnlyTask");

        Console.WriteLine("\n❌ User tries to execute AdminOnlyTask:");
        AccessControl.ExecuteMethod(normalUser, service, "AdminOnlyTask");

        Console.WriteLine("\n✅ User tries to execute UserTask:");
        AccessControl.ExecuteMethod(normalUser, service, "UserTask");

        Console.WriteLine("\n❌ Guest tries to execute UserTask:");
        AccessControl.ExecuteMethod(guestUser, service, "UserTask");
    }
}
