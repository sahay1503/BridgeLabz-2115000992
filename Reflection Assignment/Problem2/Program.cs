using System;
using System.Reflection;

class Person
{
    private int age = 25; // Private field
}

class ReflectionPrivateFieldExample
{
    static void Main()
    {
        Person person = new Person();
        Type type = typeof(Person);

        // Access private field
        FieldInfo field = type.GetField("age", BindingFlags.NonPublic | BindingFlags.Instance);

        if (field != null)
        {
            // Get field value
            Console.WriteLine("Old Age: " + field.GetValue(person));

            // Modify field value
            field.SetValue(person, 30);
            Console.WriteLine("New Age: " + field.GetValue(person));
        }
        else
        {
            Console.WriteLine("Field not found!");
        }
    }
}
