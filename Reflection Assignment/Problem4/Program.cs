using System;
using System.Reflection;

class Student
{
    public string Name { get; set; }

    public Student(string name)
    {
        Name = name;
    }

    public void Display()
    {
        Console.WriteLine("Student Name: " + Name);
    }
}

class ReflectionCreateObjectExample
{
    static void Main()
    {
        Type type = typeof(Student);

        // Get the constructor with a string parameter
        ConstructorInfo constructor = type.GetConstructor(new Type[] { typeof(string) });

        if (constructor != null)
        {
            // Create an instance dynamically
            object obj = constructor.Invoke(new object[] { "Ankur" });

            // Call the Display method
            MethodInfo method = type.GetMethod("Display");
            method.Invoke(obj, null);
        }
        else
        {
            Console.WriteLine("Constructor not found!");
        }
    }
}
