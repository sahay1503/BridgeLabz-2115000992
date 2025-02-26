using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

class SortCSV
{
    static void Main()
    {
        string filePath = "F:\\Capg- TRAINING\\C# Programmes\\feature-25Feb2025\\CSV- Assignment\\Problem-7\\employees.csv";

        try
        {
            List<string[]> records = new List<string[]>();

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                bool isHeader = true;

                while ((line = reader.ReadLine()) != null)
                {
                    if (isHeader) // Store header separately
                    {
                        isHeader = false;
                        continue;
                    }
                    records.Add(line.Split(','));
                }
            }

            // Sort records by Salary in descending order
            var sortedRecords = records.OrderByDescending(r => decimal.Parse(r[3])).Take(5);

            Console.WriteLine("Top 5 Highest-Paid Employees:");
            Console.WriteLine("ID\tName\t\tDepartment\tSalary");
            foreach (var record in sortedRecords)
            {
                Console.WriteLine($"{record[0]}\t{record[1]}\t{record[2]}\t{record[3]}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
