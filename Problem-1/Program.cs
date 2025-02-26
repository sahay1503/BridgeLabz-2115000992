using Newtonsoft.Json;
using System;

class Program
{
    static void Main()
    {
        var student = new
        {
            name = "Ravi Gupta",
            age = 20,
            subjects = new string[] { "Math", "Physics", "Computer Science" }
        };

        string jsonString = JsonConvert.SerializeObject(student, Formatting.Indented);
        Console.WriteLine(jsonString);
    }
}
