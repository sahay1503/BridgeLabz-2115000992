using System;
using System.IO;
using System.Collections.Generic;

class Student
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public double Marks { get; set; }

    public override string ToString()
    {
        return $"ID: {ID}, Name: {Name}, Age: {Age}, Marks: {Marks}";
    }
}

class CSVToObjects
{
    static void Main()
    {
        string filePath = "F:\\Capg- TRAINING\\C# Programmes\\feature-25Feb2025\\CSV- Assignment\\Problem-9\\students.csv";
        List<Student> students = new List<Student>();

        try
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                bool isHeader = true;

                while ((line = reader.ReadLine()) != null)
                {
                    if (isHeader) // Skip header row
                    {
                        isHeader = false;
                        continue;
                    }

                    string[] columns = line.Split(',');

                    if (columns.Length < 4) // Ensure correct number of columns
                    {
                        Console.WriteLine($"Invalid row format: {line}");
                        continue;
                    }

                    Student student = new Student
                    {
                        ID = int.Parse(columns[0]),
                        Name = columns[1],
                        Age = int.Parse(columns[2]),
                        Marks = double.Parse(columns[3])
                    };

                    students.Add(student);
                }
            }

            // Print the student list
            Console.WriteLine("Student Records:");
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
