using System;
using System.IO;

class FilterCSV
{
    static void Main()
    {
        string filePath = "F:\\Capg- TRAINING\\C# Programmes\\feature-25Feb2025\\CSV- Assignment\\Problem-4\\students.csv";

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

                    if (int.TryParse(columns[3], out int marks) && marks > 80)
                    {
                        Console.WriteLine($"ID: {columns[0]}, Name: {columns[1]}, Age: {columns[2]}, Marks: {columns[3]}");
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
