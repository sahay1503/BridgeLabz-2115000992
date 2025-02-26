using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        string jsonString = File.ReadAllText("users.json");

        JArray users = JArray.Parse(jsonString);

        var filteredUsers = users
            .Where(s => s["Age"] != null && int.TryParse(s["Age"].ToString(), out int age) && age > 25)
            .ToList();

        Console.WriteLine(JsonConvert.SerializeObject(filteredUsers, Formatting.Indented));
    }
}
