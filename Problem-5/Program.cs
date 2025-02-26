﻿using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using System;
using System.IO;

class Program
{
    static void Main()
    {
        string schemaText = File.ReadAllText("schema.json");
        string jsonString = File.ReadAllText("student.json");

        JSchema schema = JSchema.Parse(schemaText);

        JObject jsonData = JObject.Parse(jsonString);

        if (jsonData.IsValid(schema, out IList<string> errors))
        {
            Console.WriteLine("JSON is valid!");
        }
        else
        {
            Console.WriteLine("JSON is invalid!");
            foreach (var error in errors)
            {
                Console.WriteLine("Error: " + error);
            }
        }
    }
}
