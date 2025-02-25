using System;
using System.Collections.Generic;
using System.Reflection;

class ObjectMapper
{
    public static T ToObject<T>(Dictionary<string, object> properties) where T : new()
    {
        T obj = new T();
        Type type = typeof(T);

        foreach (var property in properties)
        {
            FieldInfo field = type.GetField(property.Key, BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);

            if (field != null)
            {
                field.SetValue(obj, Convert.ChangeType(property.Value, field.FieldType));
            }
        }

        return obj;
    }
}

class Person
{
    private string name;
    public int age;

    public void Display()
    {
        Console.WriteLine($"Name: {name}, Age: {age}");
    }
}

class ReflectionObjectMapperExample
{
    static void Main()
    {
        Dictionary<string, object> properties = new Dictionary<string, object>
        {
            { "name", "Amit" },
            { "age", 30 }
        };

        Person person = ObjectMapper.ToObject<Person>(properties);
        person.Display();
    }
}
