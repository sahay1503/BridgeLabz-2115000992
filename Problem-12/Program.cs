using System;
using System.IO;
using System.Collections.Generic;

class DetectDuplicateCSV
{
    static void Main()
    {
        string filePath = "F:\\Capg- TRAINING\\C# Programmes\\feature-25Feb2025\\CSV- Assignment\\Problem-12\\students.csv";
        HashSet<int> uniqueIds = new HashSet<int>();
        List<string> duplicates = new List<string>();

        try
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                bool isHeader = true;

                while ((line = reader.ReadLine()) != null)
                {
                    if (isHeader)
                    {
                        isHeader = false;
                        continue;
                    }

                    string[] columns = line.Split(',');

                    if (columns.Length > 0 && int.TryParse(columns[0], out int id))
                    {
                        if (!uniqueIds.Add(id)) // ID already exists
                        {
                            duplicates.Add(line);
                        }
                    }
                }
            }

            // Display duplicate records
            if (duplicates.Count > 0)
            {
                Console.WriteLine("Duplicate Records Found:");
                foreach (var record in duplicates)
                {
                    Console.WriteLine(record);
                }
            }
            else
            {
                Console.WriteLine("No duplicate records found.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
