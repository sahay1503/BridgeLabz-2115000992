using System;
using System.IO;

class SearchCSV
{
    static void Main()
    {
        string filePath = "F:\\Capg- TRAINING\\C# Programmes\\feature-25Feb2025\\CSV- Assignment\\Problem-5\\employees.csv";
        Console.Write("Enter employee name to search: ");
        string searchName = Console.ReadLine()?.Trim();

        try
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                bool isHeader = true;
                bool found = false;

                while ((line = reader.ReadLine()) != null)
                {
                    if (isHeader) // Skip header row
                    {
                        isHeader = false;
                        continue;
                    }

                    string[] columns = line.Split(',');

                    if (columns[1].Trim().Equals(searchName, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine($"Employee Found! Department: {columns[2]}, Salary: {columns[3]}");
                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    Console.WriteLine("Employee not found.");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
