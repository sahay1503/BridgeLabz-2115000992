using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using CsvHelper;
using Newtonsoft.Json;

class Program
{
    static void Main()
    {
        string jsonFilePath = "students.json";
        string csvFilePath = "students.csv";
        string convertedJsonFilePath = "students_converted.json";

        Console.WriteLine("Choose an option:");
        Console.WriteLine("1. Convert JSON to CSV");
        Console.WriteLine("2. Convert CSV to JSON");
        Console.Write("Enter choice (1/2): ");

        string choice = Console.ReadLine();

        if (choice == "1")
        {
            ConvertJsonToCsv(jsonFilePath, csvFilePath);
        }
        else if (choice == "2")
        {
            ConvertCsvToJson(csvFilePath, convertedJsonFilePath);
        }
        else
        {
            Console.WriteLine("Invalid choice!");
        }
    }

    static void ConvertJsonToCsv(string jsonFilePath, string csvFilePath)
    {
        try
        {
            // Read JSON file
            string jsonData = File.ReadAllText(jsonFilePath);
            List<Student> students = JsonConvert.DeserializeObject<List<Student>>(jsonData);

            // Write to CSV
            using (var writer = new StreamWriter(csvFilePath))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(students);
            }

            Console.WriteLine("✅ JSON successfully converted to CSV!");
        }
        catch (Exception ex)
        {
            Console.WriteLine("❌ Error: " + ex.Message);
        }
    }

    static void ConvertCsvToJson(string csvFilePath, string jsonFilePath)
    {
        try
        {
            using (var reader = new StreamReader(csvFilePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<Student>();
                string jsonData = JsonConvert.SerializeObject(records, Formatting.Indented);

                File.WriteAllText(jsonFilePath, jsonData);
                Console.WriteLine("✅ CSV successfully converted to JSON!");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("❌ Error: " + ex.Message);
        }
    }
}

// Student class
public class Student
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public double Marks { get; set; }
}
