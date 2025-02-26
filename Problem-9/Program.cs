using Newtonsoft.Json;
using System;
using System.Collections.Generic;

class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Email { get; set; }
}

class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>
        {
            new Student { Name = "Amit", Age = 22, Email = "amit968@gmail.com" },
            new Student { Name = "Babita", Age = 24, Email = "babita253@gmail.com" },
            new Student { Name = "Chahat", Age = 21, Email = "chahaht143@gmail.com" }
        };

        string jsonString = JsonConvert.SerializeObject(students, Formatting.Indented);

        Console.WriteLine(jsonString);
    }
}
