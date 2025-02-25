using System;
using System.Reflection;

class Configuration
{
    private static string API_KEY = "OriginalAPIKey";

    public static void ShowApiKey()
    {
        Console.WriteLine("Current API Key: " + API_KEY);
    }
}

class ReflectionStaticFieldExample
{
    static void Main()
    {
        Type type = typeof(Configuration);

        // Access private static field
        FieldInfo field = type.GetField("API_KEY", BindingFlags.NonPublic | BindingFlags.Static);

        if (field != null)
        {
            // Display original value
            Configuration.ShowApiKey();

            // Modify the static field value
            field.SetValue(null, "NewSecureAPIKey");

            // Display modified value
            Configuration.ShowApiKey();
        }
        else
        {
            Console.WriteLine("Field not found!");
        }
    }
}
