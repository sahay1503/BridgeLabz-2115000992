using System;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Collections.Generic;

// Define the Custom Attribute
[AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
public class JsonFieldAttribute : Attribute
{
    public string Name { get; }

    public JsonFieldAttribute(string name)
    {
        Name = name;
    }
}

// Create a Sample User Class with JsonField Attributes
public class User
{
    [JsonField("user_name")]
    public string Name { get; set; }

    [JsonField("user_age")]
    public int Age { get; set; }

    [JsonField("user_email")]
    public string Email { get; set; }
}

//  Implement a Custom Serializer Using Reflection
public class JsonSerializerCustom
{
    public static string SerializeToJson(object obj)
    {
        Type type = obj.GetType();
        var jsonDict = new Dictionary<string, object>();

        foreach (PropertyInfo prop in type.GetProperties())
        {
            object value = prop.GetValue(obj);
            JsonFieldAttribute attr = prop.GetCustomAttribute<JsonFieldAttribute>();

            if (attr != null)
            {
                jsonDict[attr.Name] = value;
            }
            else
            {
                jsonDict[prop.Name] = value; // Use default property name if no attribute
            }
        }

        return JsonSerializer.Serialize(jsonDict, new JsonSerializerOptions { WriteIndented = true });
    }
}

//  Test JSON Serialization
public class Program
{
    public static void Main()
    {
        User user = new User
        {
            Name = "Anushka",
            Age = 21,
            Email = "anuvashistha12@gmail.com"
        };

        string jsonString = JsonSerializerCustom.SerializeToJson(user);
        Console.WriteLine("Serialized JSON:\n" + jsonString);
    }
}
