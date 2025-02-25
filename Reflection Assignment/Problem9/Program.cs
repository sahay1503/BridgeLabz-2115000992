using System;
using System.Reflection;
using System.Text;

class JsonConverter
{
    public static string ToJson(object obj)
    {
        if (obj == null) return "{}";

        Type type = obj.GetType();
        FieldInfo[] fields = type.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);

        StringBuilder json = new StringBuilder();
        json.Append("{ ");

        for (int i = 0; i < fields.Length; i++)
        {
            FieldInfo field = fields[i];
            object value = field.GetValue(obj);
            json.Append($"\"{field.Name}\": \"{value}\"");

            if (i < fields.Length - 1)
                json.Append(", ");
        }

        json.Append(" }");
        return json.ToString();
    }
}

class Person
{
    private string name = "Anish";
    public int age = 30;
}

class ReflectionJsonExample
{
    static void Main()
    {
        Person person = new Person();
        string jsonString = JsonConverter.ToJson(person);
        Console.WriteLine(jsonString);
    }
}
